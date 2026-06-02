using System;
using System.Collections.Generic;
using System.Text;

namespace UniMind.Models
{
    public class Review 
    {
        public int ReviewId { get; set; }
        public int PsikologId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Komentar { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public Psikolog Psikolog { get; set; }
    }
}
