using System;
using System.Collections.Generic;
using System.Data;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;
using Npgsql;

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
    }
}
