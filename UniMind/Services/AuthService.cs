using System;
using UniMind.Models;
using UniMind.Repositories;

namespace UniMind.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        public User Login(string Username, string password)
        {
            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(Username))
                throw new ArgumentException("Email/Username tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password tidak boleh kosong!");

            // Cari user berdasarkan email atau username
            User user = _userRepository.GetByEmail(Username);
            if (user == null)
                user = _userRepository.GetByUsername(Username);

            // Jika user tidak ditemukan
            if (user == null)
                throw new Exception("Username atau password salah!");

            // Verifikasi password (sementara pakai string langsung, nanti pakai hash)
            if (user.PasswordHash != password)
                throw new Exception("Username atau password salah!");

            return user;
        }

        public bool RegisterMahasiswa(string username, string email, string noTelepon, string password, string namaLengkap = null)
        {
            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(noTelepon))
                throw new ArgumentException("Nomor telepon tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password tidak boleh kosong!");

            // Validasi format email sederhana
            if (!email.Contains("@") || !email.Contains("."))
                throw new ArgumentException("Format email tidak valid!");

            // Cek duplikasi
            if (IsUsernameExist(username))
                throw new Exception("Username sudah terdaftar! Silakan pilih username lain.");

            if (IsEmailExist(email))
                throw new Exception("Email sudah terdaftar! Silakan gunakan email lain.");

            if (IsNoTeleponExist(noTelepon))
                throw new Exception("Nomor telepon sudah terdaftar! Silakan gunakan nomor lain.");

            // Buat user baru
            User newUser = new User
            {
                Username = username,
                Email = email,
                NoTelepon = noTelepon,
                PasswordHash = password, // TODO: nanti di-hash pakai PasswordHelper
                NamaLengkap = namaLengkap,
                Role = "Mahasiswa",
                PreferensiWaktu = null,
                CreatedAt = DateTime.Now
            };

            return _userRepository.Insert(newUser);
        }

        public bool RegisterPsikolog(User user)
        {
            // Validasi input
            if (user == null)
                throw new ArgumentException("Data user tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(user.Username))
                throw new ArgumentException("Username tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(user.Email))
                throw new ArgumentException("Email tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(user.NoTelepon))
                throw new ArgumentException("Nomor telepon tidak boleh kosong!");

            if (string.IsNullOrWhiteSpace(user.PasswordHash))
                throw new ArgumentException("Password tidak boleh kosong!");

            // Cek duplikasi
            if (IsUsernameExist(user.Username))
                throw new Exception("Username sudah terdaftar!");

            if (IsEmailExist(user.Email))
                throw new Exception("Email sudah terdaftar!");

            if (IsNoTeleponExist(user.NoTelepon))
                throw new Exception("Nomor telepon sudah terdaftar!");

            // Set role dan created_at
            user.Role = "Psikolog";
            user.CreatedAt = DateTime.Now;

            return _userRepository.Insert(user);
        }

        public bool IsEmailExist(string email)
        {
            return _userRepository.IsEmailExists(email);
        }

        public bool IsUsernameExist(string username)
        {
            return _userRepository.IsUsernameExists(username);
        }

        public bool IsNoTeleponExist(string noTelepon)
        {
            return _userRepository.GetByNoTelepon(noTelepon) != null;
        }
    }
}