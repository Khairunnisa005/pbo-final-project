using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Repositories;
using pboFinalProfject.Utils;
using pboFinalProfject.Session;
using System;
using System.Data;

namespace pboFinalProfject.Controllers
{
    public class MahasiswaController
    {
        private readonly JadwalRepository _jadwalRepo;
        private readonly HasilAssessmentRepository _hasilRepo;
        private readonly DatabaseHelper _db;

        public MahasiswaController()
        {
            _jadwalRepo = new JadwalRepository();
            _hasilRepo = new HasilAssessmentRepository();
            _db = new DatabaseHelper();
        }

        public bool UpdateBookingJadwal(int bookingId, int psikologId, int jadwalId, string catatanUser = null)
        {
            try
            {
                var bookingCtrl = new BookingController();
                return bookingCtrl.UpdateBookingJadwal(bookingId, psikologId, jadwalId, catatanUser);
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetJadwalAktif(int userId)
        {
            string query = @"
        SELECT 
            b.booking_id,
            j.jadwal_id,
            j.hari,
            j.jam_mulai,
            j.jam_selesai,
            j.metode,
            b.status
        FROM booking b
        JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
        WHERE b.user_id = @uid
        ORDER BY j.hari, j.jam_mulai";

            var param = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@uid", userId)
            };

            return _db.ExecuteQuery(query, param);
        }


        public HasilAssessment GetLatestHasil(int userId)
        {
            return _hasilRepo.GetLatestByUserId(userId);
        }

        public bool HapusBooking(int bookingId, int userId)
        {
            string query = "DELETE FROM booking WHERE booking_id = @bid AND user_id = @uid";
            var param = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@bid", bookingId),
        new NpgsqlParameter("@uid", userId)
            };

            int rows = _db.ExecuteNonQuery(query, param);
            return rows > 0;
        }

        // Convenience overload that returns jadwal for the currently logged in mahasiswa
        public DataTable GetJadwalAktif()
        {
            int userId = UserSession.GetCurrentUserId();
            return GetJadwalAktif(userId);
        }
    }
}
