using System;
using System.Data;
using pboFinalProfject.Model;

namespace pboFinalProfject
{
    public interface IBookingService
    {
        /// Mendapatkan daftar jadwal yang tersedia untuk psikolog tertentu
        DataTable GetJadwalTersediaByPsikolog(int psikologId);

        /// </summary>
        bool BuatBooking(int mahasiswaId, int jadwalId, string catatanUser, int? hasilAssessmentId = null);

        /// Mendapatkan riwayat booking berdasarkan mahasiswa ID
        DataTable GetRiwayatBookingByMahasiswa(int mahasiswaId);

        /// Mendapatkan daftar booking untuk psikolog tertentu
        DataTable GetBookingByPsikolog(int psikologId);

        /// Mendapatkan detail booking berdasarkan ID
        DataTable GetDetailBookingById(int bookingId, int psikologId);

        /// Mengupdate status booking (untuk psikolog)
        bool UpdateStatusBooking(int bookingId, string status, string catatanPsikolog = null);

        /// Memperbarui jadwal sebuah booking (reschedule) oleh mahasiswa
        bool UpdateBookingJadwal(int bookingId, int psikologId, int jadwalId, string catatanUser = null);

        /// Mendapatkan detail booking untuk mahasiswa
        DataTable GetDetailBookingForMahasiswa(int bookingId, int mahasiswaId);

        /// Menyetujui booking
        bool SetujuiBooking(int bookingId, string catatanPsikolog = null);

        /// Menolak booking
        bool TolakBooking(int bookingId, string alasanPenolakan);

        /// Menyelesaikan konseling (mengubah status menjadi Selesai)
        bool SelesaikanBooking(int bookingId, string catatanPsikolog);

        /// Membatalkan booking oleh mahasiswa
        bool BatalkanBooking(int bookingId, int mahasiswaId);

        /// Mengecek apakah slot jadwal masih tersedia
        bool CekKetersediaanSlot(int jadwalId);
    }
}