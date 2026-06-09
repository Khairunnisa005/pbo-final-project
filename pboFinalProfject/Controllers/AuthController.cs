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
        internal static int CurrentUserId;

        public AuthController()
        {
            _service = new AuthService();
        }

        
        public bool Login(string email, string password)
        {
            try
            {
                User user = _service.LoginByEmail(email, password);

                if (user != null)
                {
                    // Simpan ke session
                    UserSession.CurrentUser = user;

                    // Tampilkan pesan sukses sesuai role
                    string roleName = user.Role;
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

        /// Registrasi mahasiswa baru
        public bool RegisterMahasiswa(string username, string email, string noTelepon, string password, string nama)
        {
            try
            {

                bool result = _service.RegisterMahasiswa(username, email, noTelepon, password, nama);

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

        /// Logout dari sistem
        public void Logout(Form currentForm)
        {
            UserSession.Clear();
            MessageBox.Show("Logout Berhasil!", "Logout",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentForm.Close();
        }

        /// Cek apakah user sudah login
        public bool IsLoggedIn()
        {
            return UserSession.IsLoggedIn;
        }

        /// Dapatkan user yang sedang login
        public User GetCurrentUser()
        {
            return UserSession.CurrentUser;
        }
    }
}