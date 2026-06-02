using System;
using System.Collections.Generic;
using System.Text;

namespace UniMind.Models
{
    public class JawabanAssessment
    {
        public int JawabanId { get; set; }
        public int HasilId { get; set; }
        public int PertanyaanId { get; set; }
        public char Jawaban { get; set; } // A, B, C
        public int Nilai { get; set; } // 1, 2, 3 

    }
}
