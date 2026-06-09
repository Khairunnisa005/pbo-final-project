using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;
using Npgsql;
using System.Data;
using System.Text;

namespace pboFinalProfject.Repositories
{
    public class PertanyaanAssessmentRepository
    {
        private readonly DatabaseHelper _db;

        public PertanyaanAssessmentRepository()
        {
            _db = new DatabaseHelper();
        }

        public List<PertanyaanAssessment> GetAll()
        {
            var list = new List<PertanyaanAssessment>();
            string query = "SELECT * FROM pertanyaan_assessment ORDER BY pertanyaan_id";
            DataTable dt = _db.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new PertanyaanAssessment
                {
                    PertanyaanId = Convert.ToInt32(row["pertanyaan_id"]),
                    PertanyaanText = row["pertanyaan_text"].ToString(),
                    BobotA = row["bobot_a"] != DBNull.Value ? Convert.ToInt32(row["bobot_a"]) : 1,
                    BobotB = row["bobot_b"] != DBNull.Value ? Convert.ToInt32(row["bobot_b"]) : 2,
                    BobotC = row["bobot_c"] != DBNull.Value ? Convert.ToInt32(row["bobot_c"]) : 3,
                });
            }

            return list;
        }
    public class PertanyaanAssessmentRepository
    {
        private readonly DatabaseHelper _db;

        public PertanyaanAssessmentRepository()
        {
            _db = new DatabaseHelper();
        }

        public PertanyaanAssessment GetById(int pertanyaanId)
        {
            string query = "SELECT * FROM pertanyaan_assessment WHERE pertanyaan_id = @pertanyaan_id";
            var parameters = new[] { new NpgsqlParameter("@pertanyaan_id", pertanyaanId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToPertanyaan(dt.Rows[0]);
            return null;
        }

        public List<PertanyaanAssessment> GetAll()
        {
            List<PertanyaanAssessment> list = new List<PertanyaanAssessment>();
            string query = "SELECT * FROM pertanyaan_assessment ORDER BY pertanyaan_id";
            DataTable dt = _db.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToPertanyaan(row));

            return list;
        }

        public DataTable GetDataTable()
        {
            string query = "SELECT pertanyaan_id, pertanyaan_text, bobot_a, bobot_b, bobot_c FROM pertanyaan_assessment ORDER BY pertanyaan_id";
            return _db.ExecuteQuery(query);
        }

        public bool Insert(PertanyaanAssessment entity)
        {
            string query = @"
                INSERT INTO pertanyaan_assessment (pertanyaan_text, bobot_a, bobot_b, bobot_c, created_at) 
                VALUES (@pertanyaan_text, @bobot_a, @bobot_b, @bobot_c, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@pertanyaan_text", entity.PertanyaanText),
                new NpgsqlParameter("@bobot_a", entity.BobotA),
                new NpgsqlParameter("@bobot_b", entity.BobotB),
                new NpgsqlParameter("@bobot_c", entity.BobotC),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(PertanyaanAssessment entity)
        {
            string query = @"
                UPDATE pertanyaan_assessment 
                SET pertanyaan_text = @pertanyaan_text, 
                    bobot_a = @bobot_a, 
                    bobot_b = @bobot_b, 
                    bobot_c = @bobot_c 
                WHERE pertanyaan_id = @pertanyaan_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@pertanyaan_id", entity.PertanyaanId),
                new NpgsqlParameter("@pertanyaan_text", entity.PertanyaanText),
                new NpgsqlParameter("@bobot_a", entity.BobotA),
                new NpgsqlParameter("@bobot_b", entity.BobotB),
                new NpgsqlParameter("@bobot_c", entity.BobotC)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(int pertanyaanId)
        {
            string query = "DELETE FROM pertanyaan_assessment WHERE pertanyaan_id = @pertanyaan_id";
            var parameters = new[] { new NpgsqlParameter("@pertanyaan_id", pertanyaanId) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        private PertanyaanAssessment MapToPertanyaan(DataRow row)
        {
            return new PertanyaanAssessment
            {
                PertanyaanId = Convert.ToInt32(row["pertanyaan_id"]),
                PertanyaanText = row["pertanyaan_text"].ToString(),
                BobotA = Convert.ToInt32(row["bobot_a"]),
                BobotB = Convert.ToInt32(row["bobot_b"]),
                BobotC = Convert.ToInt32(row["bobot_c"]),
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }
    }
}
