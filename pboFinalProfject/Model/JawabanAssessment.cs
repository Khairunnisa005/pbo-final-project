using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Model
{
    public class JawabanAssessment : BaseEntity
    {
        public int JawabanId { get; set; }
        public int HasilId { get; set; }
        public int PertanyaanId { get; set; }
        public char Jawaban { get; set; } // A, B, C
        public int Nilai { get; set; } // 1, 2, 3 

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            return $"Jawaban untuk Pertanyaan #{PertanyaanId}: {Jawaban} (Nilai: {Nilai})";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            return $"{GetDisplayName()} | Hasil ID: {HasilId} | Direkam: {CreatedAt:dd MMM yyyy}";
        }

    }
}