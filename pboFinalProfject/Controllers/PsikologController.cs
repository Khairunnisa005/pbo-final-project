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
        private Repositories.PsikologRepository _psikologRepo;
        private Repositories.JadwalRepository _jadwalRepo;

        public PsikologController()
        {
            _db = new DatabaseHelper();
            _psikologRepo = new Repositories.PsikologRepository();
            _jadwalRepo = new Repositories.JadwalRepository();
        }

        public DataTable GetDistinctKeahlian()
        {
            return _psikologRepo.GetDistinctKeahlian();
        }

        public DataTable GetPsikologByKeahlian(string keahlian)
        {
            return _psikologRepo.GetByKeahlian(keahlian);
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

        public DataTable GetAllPsikolog()
        {
            return _psikologRepo.GetAll();
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
                    b.created_at,
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
            return _jadwalRepo.GetByPsikologId(psikologId);
        }

        public bool TambahJadwal(int psikologId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            return _jadwalRepo.TambahJadwal(psikologId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
        }

        public bool UpdateJadwal(int jadwalId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            return _jadwalRepo.UpdateJadwal(jadwalId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
        }

        public bool HapusJadwal(int jadwalId)
        {
            return _jadwalRepo.HapusJadwal(jadwalId);
        }

    }
}
