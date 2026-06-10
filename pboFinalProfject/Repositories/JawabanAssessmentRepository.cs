using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace pboFinalProfject.Repositories
{
    public class JawabanAssessmentRepository
    {
        private readonly DatabaseHelper _db;

        public JawabanAssessmentRepository()
        {
            _db = new DatabaseHelper();
        }

        public List<JawabanAssessment> GetByHasilId(int hasilId)
        {
            List<JawabanAssessment> list = new List<JawabanAssessment>();
            string query = "SELECT * FROM jawaban_assessment WHERE hasil_id = @hasil_id";
            var parameters = new[] { new NpgsqlParameter("@hasil_id", hasilId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToJawabanAssessment(row));

            return list;
        }

        public bool Insert(JawabanAssessment entity)
        {
            string query = @"
                INSERT INTO jawaban_assessment (hasil_id, pertanyaan_id, jawaban, nilai, created_at) 
                VALUES (@hasil_id, @pertanyaan_id, @jawaban, @nilai, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@hasil_id", entity.HasilId),
                new NpgsqlParameter("@pertanyaan_id", entity.PertanyaanId),
                new NpgsqlParameter("@jawaban", entity.Jawaban.ToString()),
                new NpgsqlParameter("@nilai", entity.Nilai),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool InsertBulk(List<JawabanAssessment> jawabanList)
        {
            foreach (var jawaban in jawabanList)
            {
                if (!Insert(jawaban))
                    return false;
            }
            return true;
        }

        public bool InsertMany(int hasilId, List<JawabanAssessment> jawabanList)
        {
            string query = @"INSERT INTO jawaban_assessment (hasil_id, pertanyaan_id, jawaban, nilai)
                             VALUES (@hasil_id, @pertanyaan_id, @jawaban, @nilai)";

            int success = 0;
            foreach (var j in jawabanList)
            {
                var parameters = new[]
                {
                    new NpgsqlParameter("@hasil_id", hasilId),
                    new NpgsqlParameter("@pertanyaan_id", j.PertanyaanId),
                    new NpgsqlParameter("@jawaban", j.Jawaban.ToString()),
                    new NpgsqlParameter("@nilai", j.Nilai),
                };

                success += _db.ExecuteNonQuery(query, parameters);
            }

            return success == jawabanList.Count;
        }

        private JawabanAssessment MapToJawabanAssessment(DataRow row)
        {
            return new JawabanAssessment
            {
                JawabanId = Convert.ToInt32(row["jawaban_id"]),
                HasilId = Convert.ToInt32(row["hasil_id"]),
                PertanyaanId = Convert.ToInt32(row["pertanyaan_id"]),
                Jawaban = row["jawaban"].ToString()[0],
                Nilai = Convert.ToInt32(row["nilai"]),
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }
    }
}
