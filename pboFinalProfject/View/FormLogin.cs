using System;
using System.Windows.Forms;
using pboFinalProfject.Model;
using pboFinalProfject.View;

namespace pboFinalProfject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnMasuk.Click += BtnMasuk_Click;
            lblDaftar.LinkClicked += LblDaftar_LinkClicked;
        }

        private void BtnMasuk_Click(object? sender, EventArgs e)
        {
            var email = tbEmail.Text?.Trim() ?? string.Empty;
            var password = tbSandi.Text ?? string.Empty;

            var user = UserStore.ValidateCredentials(email, password);
            if (user != null)
            {
                MessageBox.Show($"Selamat datang, {user.Username}!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open dashboard with the same size as the current form so the runtime size matches
                var dashboard = new Dashboard();
                dashboard.StartPosition = FormStartPosition.Manual;
                dashboard.Size = this.Size; // keep same size as login form
                dashboard.Show();
                this.Hide();
                dashboard.FormClosed += (s, ev) => this.Close();
            }
            else
            {
                MessageBox.Show("Email atau kata sandi salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LblDaftar_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new View.Registrasi();
            // open registration as a replacement page: hide this login form and show registration
            reg.StartPosition = FormStartPosition.Manual;
            reg.Size = this.Size;
            reg.Show();
            this.Hide();
            // when registration closes, show the login form again
            reg.FormClosed += (s, ev) => this.Show();
        }
    }
}
