using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Models
{
    public class JadwalPsikolog
    {
        public int JadwalId { get; set; }
        public int PsikologId { get; set; }
        public string Hari { get; set; }
        public TimeSpan JamMulai { get; set; }
        public TimeSpan JamSelesai { get; set; }
        public string Metode { get; set; } // online / offline
        public int Kuota { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now; 

        // Navigation properties
        public Psikolog Psikolog { get; set; }
    }
}
