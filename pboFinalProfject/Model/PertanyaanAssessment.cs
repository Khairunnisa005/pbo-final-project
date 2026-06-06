using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Models
{
    public class PertanyaanAssessment 
    {
        public int PertanyaanId { get; set; }
        public string PertanyaanText { get; set; }
        public int BobotA { get; set; } = 1; // ringan
        public int BobotB { get; set; } = 2; // sedang
        public int BobotC { get; set; } = 3; // berat
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
