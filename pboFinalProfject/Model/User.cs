namespace pboFinalProfject.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string NoTelepon { get; set; }
        public string PasswordHash { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; set; } // Mahasiswa, Psikolog, Admin
        public string PreferensiWaktu { get; set; } // Pagi, Siang, Malam
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}


//dari IU
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace UniMind.Models
//{
//    public class User
//    {
//        public int UserId { get; set; }
//        public string Username { get; set; }
//        public string Email { get; set; }
//        public string NoTelepon { get; set; }
//        public string PasswordHash { get; set; }
//        public string NamaLengkap { get; set; }
//        public string Role { get; set; } // Mahasiswa, Psikolog, Admin
//        public string PreferensiWaktu { get; set; } // Pagi, Siang, Malam
//        public DateTime CreatedAt { get; set; } = DateTime.Now;
//    }
//}