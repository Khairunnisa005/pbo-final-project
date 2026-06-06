//using System;
//using System.Windows.Forms;
//using pboFinalProfject.Controllers;
//using pboFinalProfject.Session;
//using pboFinalProfject.Model;
//using pboFinalProfject.View;

//namespace pboFinalProfject
//{
//    public partial class FormLogin : Form
//    {
//        private AuthController _authController;
//        public FormLogin()
//        {
//            InitializeComponent();
//            _authController = new AuthController(); // Insialisasi Controller

//            btnMasuk.Click += BtnMasuk_Click;
//            lblDaftar.LinkClicked += LblDaftar_LinkClicked;
//        }

//        private void BtnMasuk_Click(object? sender, EventArgs e)
//        {
//            var email = tbEmail.Text?.Trim() ?? string.Empty;
//            var password = tbSandi.Text ?? string.Empty;

//            var user = UserStore.ValidateCredentials(email, password);
//            if (user != null)
//            {
//                MessageBox.Show($"Selamat datang, {user.Username}!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                // Open dashboard with the same size as the current form so the runtime size matches
//                var dashboard = new Dashboard();
//                dashboard.StartPosition = FormStartPosition.Manual;
//                dashboard.Size = this.Size; // keep same size as login form
//                dashboard.Show();
//                this.Hide();
//                dashboard.FormClosed += (s, ev) => this.Close();
//            }
//            else
//            {
//                MessageBox.Show("Email atau kata sandi salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }

//        private void LblDaftar_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
//        {
//            var reg = new View.Registrasi();
//            // open registration as a replacement page: hide this login form and show registration
//            reg.StartPosition = FormStartPosition.Manual;
//            reg.Size = this.Size;
//            reg.Show();
//            this.Hide();
//            // when registration closes, show the login form again
//            reg.FormClosed += (s, ev) => this.Show();
//        }

//        private void btnMasuk_Click_1(object sender, EventArgs e)
//        {

//        }

//        private void FormLogin_Load(object sender, EventArgs e)
//        {
//            this.ClientSize = new System.Drawing.Size(1535, 864);
//        }
//    }
//}

using System;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;
using pboFinalProfject.Model;
using pboFinalProfject.View;

namespace pboFinalProfject
{
    public partial class FormLogin : Form
    {
        private AuthController _authController;
        public FormLogin()
        {
            InitializeComponent();
            _authController = new AuthController(); // Insialisasi Controller

            btnMasuk.Click += BtnMasuk_Click;
            lblDaftar.LinkClicked += LblDaftar_LinkClicked;
        }

        private void BtnMasuk_Click(object? sender, EventArgs e)
        {
            string email = tbEmail.Text?.Trim() ?? string.Empty;
            string password = tbSandi.Text ?? string.Empty;

            // Validasi input kosong
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil AuthController untuk Login 
            bool loginBerhasil = _authController.Login(email, password);
            if (loginBerhasil)
            {
                Form dashboard = null;

                if (UserSession.IsAdmin)
                {
                    dashboard = new FormDashboardAdmin();
                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Size = this.Size; // keep same size as login form
                    dashboard.Show();
                    this.Hide();
                    dashboard.FormClosed += (s, ev) => this.Close();
                }

                else if (UserSession.IsPsikolog)
                {
                    dashboard = new FormDashboardPsikolog();
                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Size = this.Size; // keep same size as login form
                    dashboard.Show();
                    this.Hide();
                    dashboard.FormClosed += (s, ev) => this.Close();
                }
                else if (UserSession.IsMahasiswa)
                {
                    dashboard = new FormDashboardMahasiswa();
                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Size = this.Size; // keep same size as login form
                    dashboard.Show();
                    this.Hide();
                    dashboard.FormClosed += (s, ev) => this.Close();
                }

                if (dashboard != null)
                {
                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Size = this.Size;
                    dashboard.Show();
                    this.Hide();
                    dashboard.FormClosed += (s, ev) => this.Close();
                }
            }
        }
        private void LblDaftar_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new FormRegistrasi();
            reg.StartPosition = FormStartPosition.Manual;
            reg.Size = this.Size;
            reg.Show();
            this.Hide();
            reg.FormClosed += (s, ev) => this.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1535, 864);
        }
    }
}
