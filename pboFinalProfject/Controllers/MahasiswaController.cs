using pboFinalProfject.Models;
using pboFinalProfject.Repositories;
using pboFinalProfject.Session;
using System;
using System.Data;

namespace pboFinalProfject.Controllers
{
    public class MahasiswaController
    {
        private readonly JadwalRepository _jadwalRepo;
        private readonly HasilAssessmentRepository _hasilRepo;
        private readonly BookingRepository _bookingRepo;

        public MahasiswaController()
        {
            _jadwalRepo = new JadwalRepository();
            _hasilRepo = new HasilAssessmentRepository();
            _bookingRepo = new BookingRepository();
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
            return _bookingRepo.GetByUserId(userId);
        }


        public HasilAssessment GetLatestHasil(int userId)
        {
            return _hasilRepo.GetLatestByUserId(userId);
        }

        public bool HapusBooking(int bookingId, int userId)
        {
            // ensure booking belongs to user
            var booking = _bookingRepo.GetById(bookingId);
            if (booking == null || booking.UserId != userId) return false;
            return _bookingRepo.Delete(bookingId);
        }

        // Convenience overload that returns jadwal for the currently logged in mahasiswa
        public DataTable GetJadwalAktif()
        {
            int userId = UserSession.GetCurrentUserId();
            return GetJadwalAktif(userId);
        }
    }
}
