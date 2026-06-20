using Npgsql;
using pboFinalProfject.Model;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace pboFinalProfject.Repositories
{
    public class HasilAssessmentRepository
    {
        private readonly DatabaseHelper _db;

        public HasilAssessmentRepository()
        {
            _db = new DatabaseHelper();
        }

        public int Insert(HasilAssessment entity)
        {
            // Use RETURNING to reliably obtain the inserted primary key
            string query = @"INSERT INTO hasil_assessment (user_id, tanggal_assessment, skor_total, tingkat_stres, rekomendasi, created_at) 
        VALUES (@user_id, @tanggal_assessment, @skor_total, @tingkat_stres, @rekomendasi, @created_at)
        RETURNING hasil_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@user_id", entity.UserId),
                new NpgsqlParameter("@tanggal_assessment", entity.TanggalAssessment),
                new NpgsqlParameter("@skor_total", entity.SkorTotal),
                new NpgsqlParameter("@tingkat_stres", entity.TingkatStres ?? string.Empty),
                new NpgsqlParameter("@rekomendasi", entity.Rekomendasi ?? string.Empty),
                new NpgsqlParameter("@created_at", entity.CreatedAt)
            };

            object result = _db.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public List<HasilAssessment> GetByUserId(int userId)
        {
            var list = new List<HasilAssessment>();
            string query = "SELECT * FROM hasil_assessment WHERE user_id = @user_id ORDER BY tanggal_assessment DESC";
            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HasilAssessment
                {
                    HasilId = Convert.ToInt32(row["hasil_id"]),
                    UserId = Convert.ToInt32(row["user_id"]),
                    TanggalAssessment = ParseDateValue(row["tanggal_assessment"]),
                    SkorTotal = Convert.ToInt32(row["skor_total"]),
                    TingkatStres = row["tingkat_stres"].ToString(),
                    Rekomendasi = row["rekomendasi"].ToString(),
                });
            }

            return list;
        }

        public HasilAssessment GetLatestByUserId(int userId)
        {
            string query = "SELECT * FROM hasil_assessment WHERE user_id = @user_id ORDER BY tanggal_assessment DESC LIMIT 1";
            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;
            var row = dt.Rows[0];
            return new HasilAssessment
            {
                HasilId = Convert.ToInt32(row["hasil_id"]),
                UserId = Convert.ToInt32(row["user_id"]),
                TanggalAssessment = ParseDateValue(row["tanggal_assessment"]),
                SkorTotal = Convert.ToInt32(row["skor_total"]),
                TingkatStres = row["tingkat_stres"].ToString(),
                Rekomendasi = row["rekomendasi"].ToString(),
            };
        }

        private DateTime ParseDateValue(object value)
        {
            if (value == null || value == DBNull.Value)
                return DateTime.MinValue;

            // Handle different provider return types: DateTime, DateOnly, string
            if (value is DateTime dt) return dt;
            // DateOnly may be returned by newer Npgsql/provider mappings
            var t = value.GetType();
            if (t.FullName == "System.DateOnly")
            {
                // Use reflection to convert DateOnly to DateTime to avoid compile-time dependency
                var toDateTime = t.GetMethod("ToDateTime", new Type[] { Type.GetType("System.TimeOnly") ?? typeof(object) });
                if (toDateTime != null)
                {
                    // create a TimeOnly.MinValue via TimeSpan 00:00
                    var timeOnlyType = Type.GetType("System.TimeOnly");
                    object timeArg = null;
                    if (timeOnlyType != null)
                    {
                        // try TimeOnly.MinValue
                        var minProp = timeOnlyType.GetProperty("MinValue");
                        if (minProp != null) timeArg = minProp.GetValue(null);
                    }
                    try
                    {
                        var dtObj = toDateTime.Invoke(value, new[] { timeArg });
                        if (dtObj is DateTime dt2) return dt2;
                    }
                    catch { }
                }
            }

            // fallback: try parse string
            if (DateTime.TryParse(value.ToString(), out var parsed)) return parsed;

            return DateTime.MinValue;
        }
    }
}
