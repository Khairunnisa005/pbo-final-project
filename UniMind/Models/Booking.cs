using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int PsikologId { get; set; }
        public int JadwalId { get; set; }
        public string Status { get; set; } = "Pending";//Pending, Disetujui, Ditolak, Selesai, Batal
        public string CatatanUser { get; set; }
        public string CatatanPsikolog { get; set; }
        public int? HasilAssessment { get; set; } //Nullable, opsional
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Navigation properties 
        public User User { get; set; }
        public Psikolog Psikolog { get; set; }
        public JadwalPsikolog JadwalPsikolog { get; set; }
        //public HasilAssessment HasilAssessment { get; set; }

    }
}
