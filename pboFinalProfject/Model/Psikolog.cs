using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Model
{
    public class Psikolog : BaseEntity
    {
        public int PsikologId { get; set; }
        public int UserId { get; set; }
        public string Gelar { get; set; }
        public string Pendidikan { get; set; }
        public string NoIzinPraktek { get; set; }
        public string DeskripsiSingkat { get; set; }
        public bool MelayaniOnline { get; set; }
        public bool MelayaniOffline { get; set; }
        public User User { get; set; }

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            string gelar = string.IsNullOrEmpty(Gelar) ? "" : $"{Gelar} ";
            return $"Psikolog: {UserId}{gelar}";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            string layanan = "";
            if (MelayaniOnline && MelayaniOffline)
                layanan = "Online & Luring";
            else if (MelayaniOnline)
                layanan = "Online";
            else if (MelayaniOffline)
                layanan = "Luring";
            else
                layanan = "Belum tersedia";

            return $"{GetDisplayName()} | Layanan: {layanan} | Bergabung: {CreatedAt:dd MMM yyyy}";
        }

        // readonly property untuk mengecek apakah psikolog melayani online, offline, atau keduanya
        public bool MelayaniKeduanya => MelayaniOnline && MelayaniOffline;
    }
}
