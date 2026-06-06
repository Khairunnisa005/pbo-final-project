using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Models
{
    public class HasilAssessment
    {
        public int HasilId { get; set; }
        public int UserId { get; set; }
        public DateTime TanggalAssessment { get; set; } = DateTime.Now;
        public int SkorTotal { get; set; }
        public string TingkatStres { get; set; }
        public string Rekomendasi { get; set; }

    }
}
