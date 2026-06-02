using System;
using System.Windows.Forms;
using pboFinalProfject.Model;

namespace pboFinalProfject.View
{
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
            btnDaftar.Click += BtnDaftar_Click;
            lblMasuk.LinkClicked += LblMasuk_LinkClicked;
        }

        private void BtnDaftar_Click(object? sender, EventArgs e)
        {
            var nama = tbNamaLengkap.Text?.Trim() ?? string.Empty;
            var email = tbEmail.Text?.Trim() ?? string.Empty;
            var telepon = tbTelepon.Text?.Trim() ?? string.Empty;
            var sandi = tbSandi.Text ?? string.Empty;
            var username = tbUsername.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sandi))
            {
                MessageBox.Show("Nama, email, dan kata sandi wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserStore.GetByEmail(email) != null)
            {
                MessageBox.Show("Email sudah terdaftar.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new User
            {
                NamaLengkap = nama,
                Email = email,
                NoTelepon = telepon,
                PasswordHash = sandi,
                Username = string.IsNullOrWhiteSpace(username) ? email : username,
            };

            UserStore.Add(user);
            MessageBox.Show("Pendaftaran berhasil. Silakan masuk.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void LblMasuk_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
