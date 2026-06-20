using System;
using System.Data;
using Npgsql;
using pboFinalProfject.Model;
using pboFinalProfject.Repositories;
using pboFinalProfject.Utils;
using pboFinalProfject.Services;

namespace pboFinalProfject
{
    public class BookingService : IBookingService
    {
        private readonly DatabaseHelper _db;
        //private readonly BookingRepository _bookingRepository;
        private readonly UserRepository _userRepository;
        //private readonly PsikologRepository _psikologRepository;

        public BookingService()
        {
            _db = new DatabaseHelper();
            _userRepository = new UserRepository();
            //_psikologRepository = new PsikologRepository();
        }

        /// Mendapatkan daftar jadwal yang tersedia untuk psikolog tertentu
        public DataTable GetJadwalTersediaByPsikolog(int psikologId)
        {
            string query = @"
                SELECT 
                    j.jadwal_id,
                    j.hari,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    j.kuota,
                    COALESCE(b.jumlah_booking, 0) as sudah_dibooking,
                    (j.kuota - COALESCE(b.jumlah_booking, 0)) as sisa_kuota,
                    CASE 
                        WHEN COALESCE(b.jumlah_booking, 0) >= j.kuota THEN 'Penuh'
                        ELSE 'Tersedia'
                    END as status_ketersediaan
                FROM jadwal_psikolog j
                LEFT JOIN (
                    SELECT jadwal_id, COUNT(*) as jumlah_booking
                    FROM booking
                    WHERE status IN ('Pending', 'Disetujui')
                    GROUP BY jadwal_id
                ) b ON j.jadwal_id = b.jadwal_id
                WHERE j.psikolog_id = @psikolog_id 
                AND j.is_active = true
                ORDER BY 
                    CASE j.hari 
                        WHEN 'Senin' THEN 1
                        WHEN 'Selasa' THEN 2
                        WHEN 'Rabu' THEN 3
                        WHEN 'Kamis' THEN 4
                        WHEN 'Jumat' THEN 5
                        WHEN 'Sabtu' THEN 6
                        WHEN 'Minggu' THEN 7
                    END,
                    j.jam_mulai";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }


        public DataTable GetDetailBookingForMahasiswa(int bookingId, int mahasiswaId)
        {
            // Return the booking detail ensuring the booking belongs to mahasiswa
            string query = @"
                SELECT b.*, u.username as mahasiswa, j.hari, j.jam_mulai, j.jam_selesai, j.metode
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                WHERE b.booking_id = @booking_id AND b.user_id = @user_id";

            var parameters = new[] { new NpgsqlParameter("@booking_id", bookingId), new NpgsqlParameter("@user_id", mahasiswaId) };
            return _db.ExecuteQuery(query, parameters);
        }

        /// Membuat booking baru oleh mahasiswa (dengan transaksi)
        public bool BuatBooking(int mahasiswaId, int jadwalId, string catatanUser, int? hasilAssessmentId = null)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Cek apakah slot masih tersedia (use the same connection)
                        using (var cmdCheck = new NpgsqlCommand(@"
                            SELECT 
                                CASE 
                                    WHEN j.kuota > COALESCE(b.jumlah_booking, 0) AND j.is_active = true THEN true 
                                    ELSE false END as tersedia
                            FROM jadwal_psikolog j
                            LEFT JOIN (
                                SELECT jadwal_id, COUNT(*) as jumlah_booking
                                FROM booking
                                WHERE status IN ('Pending', 'Disetujui')
                                GROUP BY jadwal_id
                            ) b ON j.jadwal_id = b.jadwal_id
                            WHERE j.jadwal_id = @jadwal_id", conn, trans))
                        {
                            cmdCheck.Parameters.AddWithValue("@jadwal_id", jadwalId);
                            var avail = cmdCheck.ExecuteScalar();
                            if (avail == null || !Convert.ToBoolean(avail))
                                throw new Exception("Slot jadwal sudah penuh atau tidak tersedia!");
                        }

                        // 2. Cek apakah mahasiswa sudah booking di slot yang sama (same connection)
                        string cekDoubleQuery = @"
                            SELECT COUNT(*) FROM booking b
                            WHERE b.user_id = @user_id 
                            AND b.jadwal_id = @jadwal_id
                            AND b.status IN ('Pending', 'Disetujui')";

                        using (var cmdDouble = new NpgsqlCommand(cekDoubleQuery, conn, trans))
                        {
                            cmdDouble.Parameters.AddWithValue("@user_id", mahasiswaId);
                            cmdDouble.Parameters.AddWithValue("@jadwal_id", jadwalId);
                            int doubleCount = Convert.ToInt32(cmdDouble.ExecuteScalar());
                            if (doubleCount > 0)
                                throw new Exception("Anda sudah melakukan booking untuk jadwal ini!");
                        }

                        // 3. Ambil data jadwal untuk mendapatkan psikolog_id (same connection)
                        int psikologId;
                        using (var cmdGet = new NpgsqlCommand("SELECT psikolog_id FROM jadwal_psikolog WHERE jadwal_id = @jadwal_id", conn, trans))
                        {
                            cmdGet.Parameters.AddWithValue("@jadwal_id", jadwalId);
                            psikologId = Convert.ToInt32(cmdGet.ExecuteScalar());
                        }

                        // 4. Insert booking (same connection & transaction)
                        string insertQuery = @"
                            INSERT INTO booking (user_id, psikolog_id, jadwal_id, status, catatan_user, hasil_assessment_id, created_at) 
                            VALUES (@user_id, @psikolog_id, @jadwal_id, 'Pending', @catatan_user, @hasil_assessment_id, @created_at)";

                        using (var cmdInsert = new NpgsqlCommand(insertQuery, conn, trans))
                        {
                            cmdInsert.Parameters.AddWithValue("@user_id", mahasiswaId);
                            cmdInsert.Parameters.AddWithValue("@psikolog_id", psikologId);
                            cmdInsert.Parameters.AddWithValue("@jadwal_id", jadwalId);
                            cmdInsert.Parameters.AddWithValue("@catatan_user", string.IsNullOrEmpty(catatanUser) ? (object)DBNull.Value : (object)catatanUser);
                            cmdInsert.Parameters.AddWithValue("@hasil_assessment_id", hasilAssessmentId.HasValue ? (object)hasilAssessmentId.Value : (object)DBNull.Value);
                            cmdInsert.Parameters.AddWithValue("@created_at", DateTime.Now);

                            int result = cmdInsert.ExecuteNonQuery();
                            trans.Commit();
                            return result > 0;
                        }
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// Mendapatkan riwayat booking berdasarkan mahasiswa ID
        public DataTable GetRiwayatBookingByMahasiswa(int mahasiswaId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    b.status,
                    b.catatan_user,
                    b.created_at as tgl_booking,
                    b.hasil_assessment_id,
                    u.nama_lengkap as psikolog_nama,
                    j.hari,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    h.tingkat_stres,
                    h.skor_total
                FROM booking b
                JOIN psikolog p ON b.psikolog_id = p.psikolog_id
                JOIN users u ON p.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                LEFT JOIN hasil_assessment h ON b.hasil_assessment_id = h.hasil_id
                WHERE b.user_id = @user_id
                ORDER BY b.created_at DESC";

            var parameters = new[] { new NpgsqlParameter("@user_id", mahasiswaId) };
            return _db.ExecuteQuery(query, parameters);
        }

        /// Mendapatkan daftar booking untuk psikolog tertentu
        public DataTable GetBookingByPsikolog(int psikologId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog,
                    b.created_at as tgl_booking,
                    u.username as mahasiswa,
                    u.user_id as mahasiswa_id,
                    j.hari,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    h.tingkat_stres,
                    h.skor_total,
                    h.rekomendasi
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                LEFT JOIN hasil_assessment h ON b.hasil_assessment_id = h.hasil_id
                WHERE b.psikolog_id = @psikolog_id
                ORDER BY 
                    CASE b.status
                        WHEN 'Pending' THEN 1
                        WHEN 'Disetujui' THEN 2
                        WHEN 'Selesai' THEN 3
                        WHEN 'Ditolak' THEN 4
                        WHEN 'Batal' THEN 5
                    END,
                    b.created_at DESC";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        /// Mendapatkan detail booking berdasarkan ID
        //public DataTable GetDetailBookingById(int bookingId, int psikologId)
        //{
        //    string query = @"
        //        SELECT 
        //            b.booking_id,
        //            u.username as mahasiswa,
        //            u.email as mahasiswa_email,
        //            u.no_telepon as mahasiswa_telepon,
        //            p2.nama_lengkap as psikolog_nama,
        //            b.created_at as tgl_booking,
        //            j.jam_mulai,
        //            j.jam_selesai,
        //            j.metode,
        //            b.status,
        //            b.catatan_user,
        //            b.catatan_psikolog,
        //            h.tingkat_stres,
        //            h.skor_total,
        //            h.rekomendasi
        //        FROM booking b
        //        JOIN users u ON b.user_id = u.user_id
        //        JOIN psikolog ps ON b.psikolog_id = ps.psikolog_id
        //        JOIN users p2 ON ps.user_id = p2.user_id
        //        JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
        //        LEFT JOIN hasil_assessment h ON b.hasil_assessment_id = h.hasil_id
        //        WHERE b.booking_id = @booking_id 
        //        AND b.psikolog_id = @psikolog_id";

        //    var parameters = new[]
        //    {
        //        new NpgsqlParameter("@booking_id", bookingId),
        //        new NpgsqlParameter("@psikolog_id", psikologId)
        //    };
        //    return _db.ExecuteQuery(query, parameters);
        //}
        public DataTable GetDetailBookingById(int bookingId, int psikologId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    u.username as mahasiswa,
                    u.email,
                    u.no_telepon,
                    b.created_at,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog,
                    h.tingkat_stres,
                    h.rekomendasi
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                JOIN hasil_assessment h ON b.hasil_assessment_id = h.hasil_id
                WHERE b.booking_id = @booking_id 
                AND b.psikolog_id = @psikolog_id";

            var parameters = new[]
            {
            new NpgsqlParameter("@booking_id", bookingId),
            new NpgsqlParameter("@psikolog_id", psikologId)
            };

            return _db.ExecuteQuery(query, parameters);
        }

        /// Mengupdate status booking (untuk psikolog)
        public bool UpdateStatusBooking(int bookingId, string status, string catatanPsikolog = null)
        {
            string query = @"
                UPDATE booking 
                SET status = @status, 
                    catatan_psikolog = @catatan_psikolog
                WHERE booking_id = @booking_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId),
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@catatan_psikolog", string.IsNullOrEmpty(catatanPsikolog) ? DBNull.Value : (object)catatanPsikolog)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        /// Memperbarui jadwal booking (mengganti jadwal yang telah dibooking)
        public bool UpdateBookingJadwal(int bookingId, int psikologId, int jadwalId, string catatanUser = null)
        {
            // basic validation: pastikan jadwal milik psikolog dan slot tersedia
            // When checking availability, exclude the current booking from the count so saving without change is allowed
            string cekJadwalQuery = @"
                SELECT 
                    CASE
                        WHEN j.psikolog_id = @psikolog_id AND j.is_active = true AND j.kuota > COALESCE(b.jumlah_booking,0) THEN true
                        ELSE false
                    END as tersedia
                FROM jadwal_psikolog j
                LEFT JOIN (
                    SELECT jadwal_id, COUNT(*) as jumlah_booking
                    FROM booking
                    WHERE status IN ('Pending','Disetujui') AND booking_id != @booking_id
                    GROUP BY jadwal_id
                ) b ON j.jadwal_id = b.jadwal_id
                WHERE j.jadwal_id = @jadwal_id";

            var cekParams = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@jadwal_id", jadwalId),
                new NpgsqlParameter("@booking_id", bookingId)
            };
            object avail = _db.ExecuteScalar(cekJadwalQuery, cekParams);
            if (avail == null || !Convert.ToBoolean(avail))
                throw new Exception("Jadwal tidak valid atau slot tidak tersedia!");

            // Pastikan booking ada
            string cekBookingQuery = "SELECT COUNT(*) FROM booking WHERE booking_id = @booking_id";
            var cekBookingParams = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId)
            };
            int bookingCount = Convert.ToInt32(_db.ExecuteScalar(cekBookingQuery, cekBookingParams));
            if (bookingCount == 0)
                throw new Exception("Booking tidak ditemukan!");

            // Lakukan update jadwal + psikolog jika perlu
            string updateQuery = @"
                UPDATE booking
                SET psikolog_id = @psikolog_id,
                    jadwal_id = @jadwal_id,
                    catatan_user = @catatan_user
                WHERE booking_id = @booking_id";

            var updateParams = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@jadwal_id", jadwalId),
                new NpgsqlParameter("@catatan_user", string.IsNullOrEmpty(catatanUser) ? (object)DBNull.Value : (object)catatanUser),
                new NpgsqlParameter("@booking_id", bookingId)
            };

            return _db.ExecuteNonQuery(updateQuery, updateParams) > 0;
        }

        /// Menyetujui booking
        public bool SetujuiBooking(int bookingId, string catatanPsikolog = null)
        {
            return UpdateStatusBooking(bookingId, "Disetujui", catatanPsikolog);
        }

        /// Menolak booking
        public bool TolakBooking(int bookingId, string alasanPenolakan)
        {
            if (string.IsNullOrEmpty(alasanPenolakan))
                throw new Exception("Alasan penolakan harus diisi!");

            return UpdateStatusBooking(bookingId, "Ditolak", alasanPenolakan);
        }

        /// Menyelesaikan konseling (mengubah status menjadi Selesai)
        public bool SelesaikanBooking(int bookingId, string catatanPsikolog)
        {
            if (string.IsNullOrEmpty(catatanPsikolog))
                throw new Exception("Catatan sesi konseling harus diisi!");

            return UpdateStatusBooking(bookingId, "Selesai", catatanPsikolog);
        }

        /// Membatalkan booking oleh mahasiswa
        public bool BatalkanBooking(int bookingId, int mahasiswaId)
        {
            // Pastikan booking milik mahasiswa tersebut
            string cekQuery = "SELECT COUNT(*) FROM booking WHERE booking_id = @booking_id AND user_id = @user_id AND status = 'Pending'";
            var cekParams = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId),
                new NpgsqlParameter("@user_id", mahasiswaId)
            };

            int count = Convert.ToInt32(_db.ExecuteScalar(cekQuery, cekParams));
            if (count == 0)
                throw new Exception("Booking tidak ditemukan atau tidak dapat dibatalkan!");

            string query = "UPDATE booking SET status = 'Batal' WHERE booking_id = @booking_id";
            var parameters = new[] { new NpgsqlParameter("@booking_id", bookingId) };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        /// Mengecek apakah slot jadwal masih tersedia
        public bool CekKetersediaanSlot(int jadwalId)
        {
            string query = @"
                SELECT 
                    CASE 
                        WHEN j.kuota > COALESCE(b.jumlah_booking, 0) AND j.is_active = true 
                        THEN true 
                        ELSE false 
                    END as tersedia
                FROM jadwal_psikolog j
                LEFT JOIN (
                    SELECT jadwal_id, COUNT(*) as jumlah_booking
                    FROM booking
                    WHERE status IN ('Pending', 'Disetujui')
                    GROUP BY jadwal_id
                ) b ON j.jadwal_id = b.jadwal_id
                WHERE j.jadwal_id = @jadwal_id";

            var parameters = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            object result = _db.ExecuteScalar(query, parameters);
            return result != null && Convert.ToBoolean(result);
        }
    }
}