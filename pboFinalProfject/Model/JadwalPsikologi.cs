using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Model
{
    public class JadwalPsikolog : BaseEntity
    {
        public int JadwalId { get; set; }
        public int PsikologId { get; set; }
        public string Hari { get; set; }
        public TimeSpan JamMulai { get; set; }
        public TimeSpan JamSelesai { get; set; }
        public string Metode { get; set; } // online / offline
        public int Kuota { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public Psikolog Psikolog { get; set; }

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            return $"Jadwal: {Hari} {JamMulai:hh\\:mm} - {JamSelesai:hh\\:mm} ({Metode})";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            string status = IsActive ? "Aktif" : "Tidak Aktif";
            int sisaKuota = Kuota;

            return $"{GetDisplayName()} | Psikolog: {Psikolog?.GetDisplayName() ?? "N/A"} | Kuota: {sisaKuota} | Status: {status} | Dibuat: {CreatedAt:dd MMM yyyy}";
        }
    }
}
