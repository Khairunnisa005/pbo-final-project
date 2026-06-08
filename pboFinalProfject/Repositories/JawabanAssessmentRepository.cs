using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;

namespace pboFinalProfject.Repositories
{
    public class JawabanAssessmentRepository
    {
        private readonly DatabaseHelper _db;

        public JawabanAssessmentRepository()
        {
            _db = new DatabaseHelper();
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
    }
}
