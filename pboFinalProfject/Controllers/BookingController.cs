using System;
using System.Data;
using pboFinalProfject.Model;
using pboFinalProfject.Services;
using pboFinalProfject.Session;

namespace pboFinalProfject
{
    public class BookingController
    {
        private readonly IBookingService _bookingService;

        public BookingController()
        {
            _bookingService = new BookingService();
        }

        public DataTable GetJadwalTersediaByPsikolog(int psikologId)
        {
            return _bookingService.GetJadwalTersediaByPsikolog(psikologId);
        }

        public bool BuatBooking(int mahasiswaId, int jadwalId, string catatanUser, int? hasilAssessmentId = null)
        {
            try
            {
                return _bookingService.BuatBooking(mahasiswaId, jadwalId, catatanUser, hasilAssessmentId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal membuat booking: {ex.Message}");
            }
        }

        public DataTable GetRiwayatBookingByMahasiswa(int mahasiswaId)
        {
            return _bookingService.GetRiwayatBookingByMahasiswa(mahasiswaId);
        }

        public DataTable GetBookingByPsikolog(int psikologId)
        {
            return _bookingService.GetBookingByPsikolog(psikologId);
        }

        public DataTable GetDetailBookingById(int bookingId, int psikologId)
        {
            return _bookingService.GetDetailBookingById(bookingId, psikologId);
        }

        public bool SetujuiBooking(int bookingId, string catatanPsikolog = null)
        {
            try
            {
                return _bookingService.SetujuiBooking(bookingId, catatanPsikolog);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menyetujui booking: {ex.Message}");
            }
        }

        public bool TolakBooking(int bookingId, string alasanPenolakan)
        {
            try
            {
                return _bookingService.TolakBooking(bookingId, alasanPenolakan);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menolak booking: {ex.Message}");
            }
        }

        public bool SelesaikanBooking(int bookingId, string catatanPsikolog)
        {
            try
            {
                return _bookingService.SelesaikanBooking(bookingId, catatanPsikolog);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menyelesaikan booking: {ex.Message}");
            }
        }

        public bool BatalkanBooking(int bookingId)
        {
            try
            {
                int mahasiswaId = UserSession.GetCurrentUserId();
                return _bookingService.BatalkanBooking(bookingId, mahasiswaId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal membatalkan booking: {ex.Message}");
            }
        }
    }
}