using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Model
{
    public class Review : BaseEntity
    {
        public int ReviewId { get; set; }
        public int PsikologId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Komentar { get; set; }

        // Navigation properties
        public Psikolog Psikolog { get; set; }

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            return $"Review untuk Psikolog #{PsikologId} - Rating: {Rating}/5";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            string komentarPreview = string.IsNullOrEmpty(Komentar) ? "Tidak ada komentar" :
                (Komentar.Length > 50 ? Komentar.Substring(0, 50) + "..." : Komentar);
            return $"{GetDisplayName()} | {komentarPreview} | Dibuat: {CreatedAt:dd MMM yyyy}";
        }
    }
}
