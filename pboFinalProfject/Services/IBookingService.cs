using System;
using System.Data;
using pboFinalProfject.Model;

namespace pboFinalProfject
{
    public interface IBookingService
    {
        /// <summary>
        /// Mendapatkan daftar jadwal yang tersedia untuk psikolog tertentu
        /// </summary>
        DataTable GetJadwalTersediaByPsikolog(int psikologId);

        /// <summary>
        /// Membuat booking baru oleh mahasiswa
        /// </summary>
        bool BuatBooking(int mahasiswaId, int jadwalId, string catatanUser, int? hasilAssessmentId = null);

        /// <summary>
        /// Mendapatkan riwayat booking berdasarkan mahasiswa ID
        /// </summary>
        DataTable GetRiwayatBookingByMahasiswa(int mahasiswaId);

        /// <summary>
        /// Mendapatkan daftar booking untuk psikolog tertentu
        /// </summary>
        DataTable GetBookingByPsikolog(int psikologId);

        /// <summary>
        /// Mendapatkan detail booking berdasarkan ID
        /// </summary>
        DataTable GetDetailBookingById(int bookingId, int psikologId);

        /// <summary>
        /// Mengupdate status booking (untuk psikolog)
        /// </summary>
        bool UpdateStatusBooking(int bookingId, string status, string catatanPsikolog = null);

        /// <summary>
        /// Menyetujui booking
        /// </summary>
        bool SetujuiBooking(int bookingId, string catatanPsikolog = null);

        /// <summary>
        /// Menolak booking
        /// </summary>
        bool TolakBooking(int bookingId, string alasanPenolakan);

        /// <summary>
        /// Menyelesaikan konseling (mengubah status menjadi Selesai)
        /// </summary>
        bool SelesaikanBooking(int bookingId, string catatanPsikolog);

        /// <summary>
        /// Membatalkan booking oleh mahasiswa
        /// </summary>
        bool BatalkanBooking(int bookingId, int mahasiswaId);

        /// <summary>
        /// Mengecek apakah slot jadwal masih tersedia
        /// </summary>
        bool CekKetersediaanSlot(int jadwalId);
    }
}