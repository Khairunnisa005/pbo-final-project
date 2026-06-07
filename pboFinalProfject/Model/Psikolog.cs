using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Model
{
    public class Psikolog 
    {
        public int PsikologId { get; set; }
        public int UserId { get; set; }
        public string Gelar { get; set; }
        public string Pendidikan { get; set; }
        public string NoIzinPraktek { get; set; }
        public string DeskripsiSingkat { get; set; }
        public bool MelayaniOnline { get; set; }
        public bool MelayaniOffline { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public User User { get; set; }

    }
}
