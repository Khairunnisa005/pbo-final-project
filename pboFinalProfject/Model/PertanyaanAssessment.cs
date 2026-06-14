using pboFinalProfject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Model
{
    public class PertanyaanAssessment : BaseEntity
    {
        public int PertanyaanId { get; set; }
        public string PertanyaanText { get; set; }
        public int BobotA { get; set; } = 1; // ringan
        public int BobotB { get; set; } = 2; // sedang
        public int BobotC { get; set; } = 3; // berat

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            string preview = PertanyaanText?.Length > 50 ? PertanyaanText.Substring(0, 50) + "..." : PertanyaanText;
            return $"Pertanyaan: {preview}";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            return $"Bobot: A={BobotA}, B={BobotB}, C={BobotC} | Dibuat: {CreatedAt:dd MMM yyyy}";
        }
    }
}
