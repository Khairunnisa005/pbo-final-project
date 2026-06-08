using Npgsql;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject
{
    public class PsikologController
    {
        private DatabaseHelper _db;

        public PsikologController()
        {
            _db = new DatabaseHelper();
        }

        /// <summary>
        /// Mendapatkan psikolog_id berdasarkan user_id
        /// </summary>
        public int GetPsikologIdByUserId(int userId)
        {
            string query = "SELECT psikolog_id FROM psikolog WHERE user_id = @user_id";
            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };

            object result = _db.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        /// <summary>
        /// Mendapatkan daftar pasien (mahasiswa) untuk psikolog tertentu
        /// </summary>
        public DataTable GetDaftarPasienByPsikologId(int psikologId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    b.user_id,
                    b.psikolog_id,
                    u.username as mahasiswa,
                    b.created_at as tgl_booking,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog,
                    b.created_at as tgl_booking
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                WHERE b.psikolog_id = @psikolog_id
                ORDER BY b.created_at DESC, j.jam_mulai ASC";

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
        /// Konfirmasi booking (Setujui/Tolak)
        /// </summary>
        public bool KonfirmasiBooking(int bookingId, string status, string catatanPsikolog = null)
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
                new NpgsqlParameter("@catatan_psikolog", (object)catatanPsikolog ?? DBNull.Value)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Selesaikan konseling
        /// </summary>
        public bool SelesaikanKonseling(int bookingId, string catatanPsikolog)
        {
            string query = @"
                UPDATE booking 
                SET status = 'Selesai', 
                    catatan_psikolog = @catatan_psikolog
                WHERE booking_id = @booking_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId),
                new NpgsqlParameter("@catatan_psikolog", catatanPsikolog)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetJadwalByPsikologId(int psikologId)
        {
            string query = @"
                SELECT jadwal_id, hari, jam_mulai, jam_selesai, metode, kuota, is_active 
                FROM jadwal_psikolog 
                WHERE psikolog_id = @psikolog_id 
                ORDER BY 
                    CASE hari 
                        WHEN 'Senin' THEN 1
                        WHEN 'Selasa' THEN 2
                        WHEN 'Rabu' THEN 3
                        WHEN 'Kamis' THEN 4
                        WHEN 'Jumat' THEN 5
                        WHEN 'Sabtu' THEN 6
                        WHEN 'Minggu' THEN 7
                    END, 
                    jam_mulai";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public bool TambahJadwal(int psikologId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            // Validasi jam mulai harus lebih kecil dari jam selesai
            if (jamMulai >= jamSelesai)
            {
                throw new Exception("Jam mulai harus lebih awal dari jam selesai!");
            }

            // Cek apakah sudah ada jadwal yang bentrok
            string cekQuery = @"
                SELECT COUNT(*) FROM jadwal_psikolog 
                WHERE psikolog_id = @psikolog_id 
                AND hari = @hari 
                AND ((jam_mulai <= @jam_mulai AND jam_selesai > @jam_mulai)
                  OR (jam_mulai < @jam_selesai AND jam_selesai >= @jam_selesai)
                  OR (@jam_mulai <= jam_mulai AND @jam_selesai >= jam_selesai))";

            var cekParams = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@hari", hari),
                new NpgsqlParameter("@jam_mulai", jamMulai),
                new NpgsqlParameter("@jam_selesai", jamSelesai)
            };

            int count = Convert.ToInt32(_db.ExecuteScalar(cekQuery, cekParams));
            if (count > 0)
            {
                throw new Exception("Jadwal bentrok dengan jadwal yang sudah ada!");
            }
            // insert jadwaal baru
            string query = @"
                INSERT INTO jadwal_psikolog (psikolog_id, hari, jam_mulai, jam_selesai, metode, kuota, is_active, created_at) 
                VALUES (@psikolog_id, @hari, @jam_mulai, @jam_selesai, @metode, @kuota, @is_active, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@hari", hari),
                new NpgsqlParameter("@jam_mulai", jamMulai),
                new NpgsqlParameter("@jam_selesai", jamSelesai),
                new NpgsqlParameter("@metode", metode),
                new NpgsqlParameter("@kuota", kuota),
                new NpgsqlParameter("@is_active", isActive),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            //return _db.ExecuteNonQuery(query, parameters) > 0;
            int result = _db.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateJadwal(int jadwalId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            if (jamMulai >= jamSelesai)
            {
                throw new Exception("Jam mulai harus lebih awal dari jam selesai!");
            }

            string query = @"
                UPDATE jadwal_psikolog 
                SET hari = @hari, 
                    jam_mulai = @jam_mulai, 
                    jam_selesai = @jam_selesai, 
                    metode = @metode, 
                    kuota = @kuota, 
                    is_active = @is_active 
                WHERE jadwal_id = @jadwal_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@jadwal_id", jadwalId),
                new NpgsqlParameter("@hari", hari),
                new NpgsqlParameter("@jam_mulai", jamMulai),
                new NpgsqlParameter("@jam_selesai", jamSelesai),
                new NpgsqlParameter("@metode", metode),
                new NpgsqlParameter("@kuota", kuota),
                new NpgsqlParameter("@is_active", isActive)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool HapusJadwal(int jadwalId)
        {
            // Cek apakah jadwal sudah memiliki booking
            string cekQuery = "SELECT COUNT(*) FROM booking WHERE jadwal_id = @jadwal_id";
            var cekParams = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            int count = Convert.ToInt32(_db.ExecuteScalar(cekQuery, cekParams));

            if (count > 0)
            {
                throw new Exception("Tidak dapat menghapus jadwal karena sudah ada booking yang terkait!");
            }

            string query = "DELETE FROM jadwal_psikolog WHERE jadwal_id = @jadwal_id";
            var parameters = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetProfilPsikologByUserId(int userId)
        {
            // 1. Definisikan string kueri SQL
            string query = @"SELECT u.username, u.nama_lengkap, u.email, u.no_telepon, 
                                    p.gelar, p.pendidikan, p.no_izin_praktek, p.deskripsi_singkat, 
                                    p.melayani_online, p.melayani_offline 
                             FROM M_User u 
                             JOIN M_Psikolog p ON u.user_id = p.user_id 
                             WHERE u.user_id = @userId";

            // 2. Siapkan parameter yang dibutuhkan kueri
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("userId", userId)
            };

            try
            {
                // 3. Eksekusi kueri langsung melalui perantara DatabaseHelper
                return _db.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan pada Controller saat mengambil profil: {ex.Message}");
            }
        }
        public bool UpdateProfilPsikolog(int userId, string nama, string email, string telepon,
                                         string gelar, string pendidikan, string izin,
                                         string deskripsi, bool online, bool offline)
        {
            // 1. Kumpulkan kueri-kueri yang akan dijalankan
            List<string> queries = new List<string>
            {
                @"UPDATE M_User 
                  SET nama_lengkap = @nama, email = @email, no_telepon = @telepon 
                  WHERE user_id = @userId",

                @"UPDATE M_Psikolog 
                  SET gelar = @gelar, pendidikan = @pendidikan, 
                      no_izin_praktek = @izin, deskripsi_singkat = @deskripsi, 
                      melayani_online = @online, melayani_offline = @offline 
                  WHERE user_id = @userId"
            };

            // 2. Siapkan parameter untuk masing-masing kueri secara berurutan
            NpgsqlParameter[] paramUser = new NpgsqlParameter[]
            {
                new NpgsqlParameter("nama", nama),
                new NpgsqlParameter("email", email),
                new NpgsqlParameter("telepon", telepon),
                new NpgsqlParameter("userId", userId)
            };

            NpgsqlParameter[] paramPsikolog = new NpgsqlParameter[]
            {
                new NpgsqlParameter("gelar", gelar),
                new NpgsqlParameter("pendidikan", pendidikan),
                new NpgsqlParameter("izin", izin),
                new NpgsqlParameter("deskripsi", deskripsi),
                new NpgsqlParameter("online", online),
                new NpgsqlParameter("offline", offline),
                new NpgsqlParameter("userId", userId)
            };

            List<NpgsqlParameter[]> parameterSets = new List<NpgsqlParameter[]> { paramUser, paramPsikolog };

            try
            {
                // 3. Kirim paket transaksi ke DatabaseHelper
                return _db.ExecuteNonQuery(queries, parameterSets) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan pada Controller saat update profil: {ex.Message}");
            }
        }
    }
}
