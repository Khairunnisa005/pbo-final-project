using pboFinalProfject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Model
{
    public class HasilAssessment : BaseEntity
    {
        public int HasilId { get; set; }
        public int UserId { get; set; }
        public DateTime TanggalAssessment { get; set; } = DateTime.Now;
        public int SkorTotal { get; set; }
        public string TingkatStres { get; set; }
        public string Rekomendasi { get; set; }

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            return $"Assessment #{HasilId} - {TingkatStres} (Skor: {SkorTotal})";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            return $"{GetDisplayName()} | Tanggal: {TanggalAssessment:dd MMM yyyy} | Direkam: {CreatedAt:dd MMM yyyy}";
        }

        // readonly property untuk mengecek apakah hasil assessment menunjukkan tingkat stres tinggi
        public bool PerluKonseling => TingkatStres == "Sedang" || TingkatStres == "Tinggi";
    }
}
