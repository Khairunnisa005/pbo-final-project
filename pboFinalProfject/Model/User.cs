namespace pboFinalProfject.Model
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string NoTelepon { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; set; } // Mahasiswa, Psikolog, Admin
        public string PreferensiWaktu { get; set; } // Pagi, Siang, Malam
        
        // encapsulation email
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email tidak boleh kosong!");
                if (!value.Contains("@") || !value.Contains("."))
                    throw new ArgumentException("Format email tidak valid!");
                _email = value;
            }

        }

        // encapsulation untuk password
        private string _passwordHash;
        public string PasswordHash
        {
            get { return _passwordHash; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Password tidak boleh kosong!");
                if (value.Length < 6)
                    throw new ArgumentException("Password harus minimal 6 karakter!");
                _passwordHash = value;
            }

        }

        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            if(!string.IsNullOrEmpty(NamaLengkap))
                return $"{NamaLengkap} (@{Username})";
            return $"User: @{Username}";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            return $"{GetDisplayName()} | Role: {Role} | Created At: {CreatedAt}}}";
        }

        // readonly property untuk mengecek apakah user adalah admin, prikolog, atau mahasiswa
        public bool IsAdmin => Role == "Admin";
        public bool IsPsikolog => Role == "Psikolog";
        public bool IsMahasiswa => Role == "Mahasiswa";
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