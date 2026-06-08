using System;
using System.Data;
using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Repositories;
using pboFinalProfject.Utils;

namespace pboFinalProfject
{
    public class BookingService : IBookingService
    {
        private readonly DatabaseHelper _db;
        private readonly UserRepository _userRepository;
        //private readonly PsikologRepository _psikologRepository;

        public BookingService()
        {
            _db = new DatabaseHelper();
            _userRepository = new UserRepository();
            //_psikologRepository = new PsikologRepository();
        }

        /// <summary>
        /// Mendapatkan detail booking untuk mahasiswa (tanpa membutuhkan psikolog_id)
        /// </summary>
        public DataTable GetDetailBookingForMahasiswa(int bookingId, int mahasiswaId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    u.username as mahasiswa,
                    u.email as mahasiswa_email,
                    u.no_telepon as mahasiswa_telepon,
                    p2.nama_lengkap as psikolog_nama,
                    b.created_at as tanggal_booking,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog,
                    h.tingkat_stres,
                    h.skor_total,
                    h.rekomendasi
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN psikolog ps ON b.psikolog_id = ps.psikolog_id
                JOIN users p2 ON ps.user_id = p2.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                LEFT JOIN hasil_assessment h ON b.hasil_assessment_id = h.hasil_id
                WHERE b.booking_id = @booking_id 
                AND b.user_id = @user_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId),
                new NpgsqlParameter("@user_id", mahasiswaId)
            };

            return _db.ExecuteQuery(query, parameters);
        }

        /// <summary>
        /// Mendapatkan daftar jadwal yang tersedia untuk psikolog tertentu
        /// </summary>
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

        /// <summary>
        /// Membuat booking baru oleh mahasiswa (dengan transaksi)
        /// </summary>
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

        /// <summary>
        /// Mendapatkan riwayat booking berdasarkan mahasiswa ID
        /// </summary>
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

        /// <summary>
        /// Mendapatkan daftar booking untuk psikolog tertentu
        /// </summary>
        public DataTable GetBookingByPsikolog(int psikologId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog,
                    b.created_at as tgl_booking,
                    u.username as mahasiswa_anonim,
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

        /// <summary>
        /// Mendapatkan detail booking berdasarkan ID
        /// </summary>
        public DataTable GetDetailBookingById(int bookingId, int psikologId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    u.username as mahasiswa,
                    u.email as mahasiswa_email,
                    u.no_telepon as mahasiswa_telepon,
                    p2.nama_lengkap as psikolog_nama,
                    b.created_at as tanggal_booking,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog,
                    h.tingkat_stres,
                    h.skor_total,
                    h.rekomendasi
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN psikolog ps ON b.psikolog_id = ps.psikolog_id
                JOIN users p2 ON ps.user_id = p2.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                LEFT JOIN hasil_assessment h ON b.hasil_assessment_id = h.hasil_id
                WHERE b.booking_id = @booking_id 
                AND b.psikolog_id = @psikolog_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId),
                new NpgsqlParameter("@psikolog_id", psikologId)
            };
            return _db.ExecuteQuery(query, parameters);
        }

        /// <summary>
        /// Mengupdate status booking (untuk psikolog)
        /// </summary>
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

        /// <summary>
        /// Menyetujui booking
        /// </summary>
        public bool SetujuiBooking(int bookingId, string catatanPsikolog = null)
        {
            return UpdateStatusBooking(bookingId, "Disetujui", catatanPsikolog);
        }

        /// <summary>
        /// Menolak booking
        /// </summary>
        public bool TolakBooking(int bookingId, string alasanPenolakan)
        {
            if (string.IsNullOrEmpty(alasanPenolakan))
                throw new Exception("Alasan penolakan harus diisi!");

            return UpdateStatusBooking(bookingId, "Ditolak", alasanPenolakan);
        }

        /// <summary>
        /// Menyelesaikan konseling (mengubah status menjadi Selesai)
        /// </summary>
        public bool SelesaikanBooking(int bookingId, string catatanPsikolog)
        {
            if (string.IsNullOrEmpty(catatanPsikolog))
                throw new Exception("Catatan sesi konseling harus diisi!");

            return UpdateStatusBooking(bookingId, "Selesai", catatanPsikolog);
        }

        /// <summary>
        /// Membatalkan booking oleh mahasiswa
        /// </summary>
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

        /// <summary>
        /// Mengecek apakah slot jadwal masih tersedia
        /// </summary>
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