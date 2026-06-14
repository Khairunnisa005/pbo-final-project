using System;
using System.Collections.Generic;
using System.Data;
using pboFinalProfject.Model;
using pboFinalProfject.Services;
using pboFinalProfject.Session;

namespace pboFinalProfject.Controllers
{
    public class ScreeningController
    {
        private readonly IScreeningService _screeningService;

        public ScreeningController()
        {
            _screeningService = new ScreeningService();
        }

        /// <summary>
        /// Mendapatkan semua pertanyaan kuesioner
        /// </summary>
        public List<PertanyaanAssessment> GetPertanyaan()
        {
            try
            {
                return _screeningService.GetPertanyaan();
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil daftar pertanyaan: {ex.Message}");
            }
        }

        /// <summary>
        /// Mendapatkan pertanyaan dalam bentuk DataTable (untuk DataGridView)
        /// </summary>
        public DataTable GetPertanyaanAsDataTable()
        {
            try
            {
                var pertanyaanList = _screeningService.GetPertanyaan();
                DataTable dt = new DataTable();

                dt.Columns.Add("pertanyaan_id", typeof(int));
                dt.Columns.Add("pertanyaan_text", typeof(string));
                dt.Columns.Add("bobot_a", typeof(int));
                dt.Columns.Add("bobot_b", typeof(int));
                dt.Columns.Add("bobot_c", typeof(int));

                foreach (var p in pertanyaanList)
                {
                    dt.Rows.Add(p.PertanyaanId, p.PertanyaanText, p.BobotA, p.BobotB, p.BobotC);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil daftar pertanyaan: {ex.Message}");
            }
        }

        /// <summary>
        /// Menghitung skor dari jawaban yang diberikan
        /// </summary>
        public HasilAssessment HitungSkor(List<JawabanAssessment> jawabanList)
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                return _screeningService.HitungSkor(jawabanList, userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghitung skor: {ex.Message}");
            }
        }

        /// <summary>
        /// Menghitung skor untuk user tertentu (alternatif)
        /// </summary>
        public HasilAssessment HitungSkor(List<JawabanAssessment> jawabanList, int userId)
        {
            try
            {
                return _screeningService.HitungSkor(jawabanList, userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghitung skor: {ex.Message}");
            }
        }

        /// <summary>
        /// Menyimpan hasil assessment ke database
        /// </summary>
        public bool SimpanHasilAssessment(HasilAssessment hasil, List<JawabanAssessment> jawabanList)
        {
            try
            {
                if (hasil == null)
                    throw new Exception("Hasil assessment tidak boleh kosong!");

                if (jawabanList == null || jawabanList.Count == 0)
                    throw new Exception("Jawaban tidak boleh kosong!");

                return _screeningService.SimpanHasilAssessment(hasil, jawabanList);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menyimpan hasil assessment: {ex.Message}");
            }
        }

        /// <summary>
        /// Mendapatkan hasil screening terakhir untuk user yang sedang login
        /// </summary>
        public HasilAssessment GetHasilScreeningTerakhir()
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                return _screeningService.GetHasilScreeningTerakhir(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil hasil screening terakhir: {ex.Message}");
            }
        }

        /// <summary>
        /// Mendapatkan hasil screening terakhir untuk user tertentu
        /// </summary>
        public HasilAssessment GetHasilScreeningTerakhir(int userId)
        {
            try
            {
                return _screeningService.GetHasilScreeningTerakhir(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil hasil screening terakhir: {ex.Message}");
            }
        }

        /// <summary>
        /// Mendapatkan hasil screening terakhir dalam bentuk DataTable
        /// </summary>
        public DataTable GetHasilScreeningTerakhirAsDataTable()
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                var hasil = _screeningService.GetHasilScreeningTerakhir(userId);

                DataTable dt = new DataTable();
                dt.Columns.Add("hasil_id", typeof(int));
                dt.Columns.Add("skor_total", typeof(int));
                dt.Columns.Add("tingkat_stres", typeof(string));
                dt.Columns.Add("rekomendasi", typeof(string));
                dt.Columns.Add("tanggal_assessment", typeof(DateTime));

                if (hasil != null)
                {
                    dt.Rows.Add(hasil.HasilId, hasil.SkorTotal, hasil.TingkatStres, hasil.Rekomendasi, hasil.TanggalAssessment);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil hasil screening terakhir: {ex.Message}");
            }
        }

        /// <summary>
        /// Cek apakah user sudah mengisi kuesioner hari ini
        /// </summary>
        public bool CekSudahIsiHariIni()
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                return _screeningService.CekSudahIsiHariIni(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengecek status kuesioner: {ex.Message}");
            }
        }

        /// <summary>
        /// Cek apakah user sudah mengisi kuesioner hari ini (untuk user tertentu)
        /// </summary>
        public bool CekSudahIsiHariIni(int userId)
        {
            try
            {
                return _screeningService.CekSudahIsiHariIni(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengecek status kuesioner: {ex.Message}");
            }
        }

        /// <summary>
        /// Mendapatkan riwayat screening user (semua hasil)
        /// </summary>
        public DataTable GetRiwayatScreening(int userId)
        {
            try
            {
                string query = @"
                    SELECT hasil_id, tanggal_assessment, skor_total, tingkat_stres, rekomendasi, created_at
                    FROM hasil_assessment
                    WHERE user_id = @user_id
                    ORDER BY created_at DESC";

                var parameters = new[] { new Npgsql.NpgsqlParameter("@user_id", userId) };
                return _screeningService.GetRiwayatScreening(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil riwayat screening: {ex.Message}");
            }
        }

        /// <summary>
        /// Mendapatkan riwayat screening untuk user yang sedang login
        /// </summary>
        public DataTable GetRiwayatScreening()
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                return GetRiwayatScreening(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil riwayat screening: {ex.Message}");
            }
        }
    }
}