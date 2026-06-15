using pboFinalProfject.Model;
using pboFinalProfject.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject.Services
{
    public interface IScreeningService
    {
        /// Mendapatkan semua pertanyaan kuesioner
        List<PertanyaanAssessment> GetPertanyaan();

        /// Mendapatkan riwayat screening user
        DataTable GetRiwayatScreening(int userId);

        /// Menghitung skor dan menentukan tingkat stres
        HasilAssessment HitungSkor(List<JawabanAssessment> jawabanList, int userId);

        /// Menyimpan hasil assessment
        bool SimpanHasilAssessment(HasilAssessment hasil, List<JawabanAssessment> jawabanList);

        ///Mendapatkan hasil screening terakhir mahasiswa
        HasilAssessment GetHasilScreeningTerakhir(int userId);

        /// Cek apakah sudah mengisi kuesioner hari ini
        bool CekSudahIsiHariIni(int userId);
    }
}
