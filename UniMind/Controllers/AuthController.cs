using System;
using System.Windows.Forms;
using pboFinalProfject.Model;
using pboFinalProfject.Services;
using pboFinalProfject.Session;

namespace pboFinalProfject.Controllers
{
    public class AuthController
    {
        private readonly IAuthService _service;

        public AuthController()
        {
            _service = new AuthService();
        }

        /// <summary>
        /// Login ke sistem
        /// </summary>
        public bool Login(string emailOrUsername, string password)
        {
            try
            {
                User user = _service.Login(emailOrUsername, password);

                if (user != null)
                {
                    // Simpan ke session
                    UserSession.CurrentUser = user;

                    // Tampilkan pesan sukses sesuai role
                    string roleName = user.Role == "Mahasiswa" ? "Mahasiswa" : (user.Role == "Psikolog" ? "Psikolog" : "Admin");
                    MessageBox.Show($"Login Sukses sebagai {roleName}!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Gagal: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Registrasi mahasiswa baru
        /// </summary>
        public bool RegisterMahasiswa(string username, string email, string noTelepon, string password, string confirmPassword, string namaLengkap = null)
        {
            try
            {
                // Validasi password konfirmasi
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password dan konfirmasi password tidak cocok!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool result = _service.RegisterMahasiswa(username, email, noTelepon, password, namaLengkap);

                if (result)
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registrasi Gagal: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Logout dari sistem
        /// </summary>
        public void Logout(Form currentForm)
        {
            UserSession.Clear();
            MessageBox.Show("Logout Berhasil!", "Logout",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentForm.Close();
        }

        /// <summary>
        /// Cek apakah user sudah login
        /// </summary>
        public bool IsLoggedIn()
        {
            return UserSession.IsLoggedIn;
        }

        /// <summary>
        /// Dapatkan user yang sedang login
        /// </summary>
        public User GetCurrentUser()
        {
            return UserSession.CurrentUser;
        }
    }
}