using Npgsql;
using pboFinalProfject.Model;
using pboFinalProfject.Repositories;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject.Services
{
    public class ScreeningService : IScreeningService
    {
        private readonly DatabaseHelper _db;
        private readonly PertanyaanAssessmentRepository _pertanyaanRepo;
        private readonly HasilAssessmentRepository _hasilRepo;
        private readonly JawabanAssessmentRepository _jawabanRepo;

        public ScreeningService()
        {
            _db = new DatabaseHelper();
            _pertanyaanRepo = new PertanyaanAssessmentRepository();
            _hasilRepo = new HasilAssessmentRepository();
            _jawabanRepo = new JawabanAssessmentRepository();
        }

        public List<PertanyaanAssessment> GetPertanyaan()
        {
            return _pertanyaanRepo.GetAll();
        }

        public HasilAssessment HitungSkor(List<JawabanAssessment> jawabanList, int userId)
        {
            int totalSkor = 0;
            foreach (var jawaban in jawabanList)
            {
                totalSkor += jawaban.Nilai;
            }

            string tingkatStres;
            string rekomendasi;

            // Aturan penentuan tingkat stres (sesuaikan dengan jumlah soal)
            // Asumsi: 10 soal, skor maksimal 30, minimal 10
            if (totalSkor <= 15)
            {
                tingkatStres = "Rendah";
                rekomendasi = "Stres Anda masih dalam batas normal. Pertahankan pola hidup sehat, istirahat cukup, dan kelola waktu dengan baik.";
            }
            else if (totalSkor <= 25)
            {
                tingkatStres = "Sedang";
                rekomendasi = "Anda mengalami stres sedang. Pertimbangkan untuk berkonsultasi dengan psikolog kampus. Jangan ragu untuk meminta bantuan.";
            }
            else
            {
                tingkatStres = "Tinggi";
                rekomendasi = "Anda mengalami stres tinggi. Sangat disarankan untuk segera berkonsultasi dengan psikolog. Klik tombol 'Daftar Konseling' untuk membuat janji.";
            }

            HasilAssessment hasil = new HasilAssessment
            {
                UserId = userId,
                TanggalAssessment = DateTime.Now,
                SkorTotal = totalSkor,
                TingkatStres = tingkatStres,
                Rekomendasi = rekomendasi,
                CreatedAt = DateTime.Now
            };

            return hasil;
        }

        /// Mendapatkan riwayat screening user
        public DataTable GetRiwayatScreening(int userId)
        {
            string query = @"
        SELECT hasil_id, tanggal_assessment, skor_total, tingkat_stres, rekomendasi, created_at
        FROM hasil_assessment
        WHERE user_id = @user_id
        ORDER BY created_at DESC";

            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public bool SimpanHasilAssessment(HasilAssessment hasil, List<JawabanAssessment> jawabanList)
        {
            int hasilId = _hasilRepo.Insert(hasil);
            if (hasilId <= 0) return false;

            foreach (var jawaban in jawabanList)
            {
                jawaban.HasilId = hasilId;
                bool jawabanSaved = _jawabanRepo.Insert(jawaban);
                if (!jawabanSaved) return false;
            }

            return true;
        }

        public HasilAssessment GetHasilScreeningTerakhir(int userId)
        {
            string query = @"
                SELECT hasil_id, user_id, tanggal_assessment, skor_total, tingkat_stres, rekomendasi, created_at
                FROM hasil_assessment
                WHERE user_id = @user_id
                ORDER BY created_at DESC
                LIMIT 1";

            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // tanggal_assessment may be mapped to DateOnly by Npgsql.
                object rawTanggal = row["tanggal_assessment"];
                DateTime tanggalAssessment;
                if (rawTanggal == DBNull.Value)
                {
                    tanggalAssessment = default;
                }
                else if (rawTanggal is DateTime dtTanggal)
                {
                    tanggalAssessment = dtTanggal;
                }
                else if (rawTanggal is DateOnly dTanggal)
                {
                    // Convert DateOnly to DateTime at midnight
                    tanggalAssessment = dTanggal.ToDateTime(System.TimeOnly.MinValue);
                }
                else if (rawTanggal is string sTanggal && DateTime.TryParse(sTanggal, out var parsedTanggal))
                {
                    tanggalAssessment = parsedTanggal;
                }
                else
                {
                    throw new InvalidCastException($"Cannot convert {rawTanggal?.GetType().FullName} to DateTime");
                }

                // created_at is expected to be DateTime but handle defensively
                object rawCreated = row["created_at"];
                DateTime createdAt;
                if (rawCreated == DBNull.Value)
                {
                    createdAt = default;
                }
                else if (rawCreated is DateTime dtCreated)
                {
                    createdAt = dtCreated;
                }
                else if (rawCreated is DateOnly dCreated)
                {
                    createdAt = dCreated.ToDateTime(System.TimeOnly.MinValue);
                }
                else if (rawCreated is string sCreated && DateTime.TryParse(sCreated, out var parsedCreated))
                {
                    createdAt = parsedCreated;
                }
                else
                {
                    createdAt = Convert.ToDateTime(rawCreated);
                }

                return new HasilAssessment
                {
                    HasilId = Convert.ToInt32(row["hasil_id"]),
                    UserId = Convert.ToInt32(row["user_id"]),
                    TanggalAssessment = tanggalAssessment,
                    SkorTotal = Convert.ToInt32(row["skor_total"]),
                    TingkatStres = row["tingkat_stres"].ToString(),
                    Rekomendasi = row["rekomendasi"].ToString(),
                    CreatedAt = createdAt
                };
            }

            return null;
        }

        public bool CekSudahIsiHariIni(int userId)
        {
            string query = @"
                SELECT COUNT(*) FROM hasil_assessment 
                WHERE user_id = @user_id 
                AND DATE(created_at) = CURRENT_DATE";

            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            int count = Convert.ToInt32(_db.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}
