using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject.Repositories
{
    internal class HasilAssessmentRepository
    {
        private readonly DatabaseHelper _db;

        public HasilAssessmentRepository()
        {
            _db = new DatabaseHelper();
        }

        public HasilAssessment GetById(int hasilId)
        {
            string query = "SELECT * FROM hasil_assessment WHERE hasil_id = @hasil_id";
            var parameters = new[] { new NpgsqlParameter("@hasil_id", hasilId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToHasilAssessment(dt.Rows[0]);
            return null;
        }

        public DataTable GetByUserId(int userId)
        {
            string query = "SELECT * FROM hasil_assessment WHERE user_id = @user_id ORDER BY created_at DESC";
            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public HasilAssessment GetLastByUserId(int userId)
        {
            string query = @"
                SELECT * FROM hasil_assessment 
                WHERE user_id = @user_id 
                ORDER BY created_at DESC 
                LIMIT 1";

            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToHasilAssessment(dt.Rows[0]);
            return null;
        }

        public bool Insert(HasilAssessment entity)
        {
            string query = @"
                INSERT INTO hasil_assessment (user_id, tanggal_assessment, skor_total, tingkat_stres, rekomendasi, created_at) 
                VALUES (@user_id, @tanggal_assessment, @skor_total, @tingkat_stres, @rekomendasi, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@user_id", entity.UserId),
                new NpgsqlParameter("@tanggal_assessment", entity.TanggalAssessment),
                new NpgsqlParameter("@skor_total", entity.SkorTotal),
                new NpgsqlParameter("@tingkat_stres", entity.TingkatStres),
                new NpgsqlParameter("@rekomendasi", string.IsNullOrEmpty(entity.Rekomendasi) ? DBNull.Value : (object)entity.Rekomendasi),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public int GetLastInsertedId()
        {
            string query = "SELECT lastval()";
            return Convert.ToInt32(_db.ExecuteScalar(query));
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

        private HasilAssessment MapToHasilAssessment(DataRow row)
        {
            return new HasilAssessment
            {
                HasilId = Convert.ToInt32(row["hasil_id"]),
                UserId = Convert.ToInt32(row["user_id"]),
                TanggalAssessment = Convert.ToDateTime(row["tanggal_assessment"]),
                SkorTotal = Convert.ToInt32(row["skor_total"]),
                TingkatStres = row["tingkat_stres"].ToString(),
                Rekomendasi = row["rekomendasi"] != DBNull.Value ? row["rekomendasi"].ToString() : null,
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }
    }
}
