//using System;
//using System.Windows.Forms;
//using pboFinalProfject.Model;

//namespace pboFinalProfject.View
//{
//    public partial class FormRegistrasi : Form
//    {
//        public FormRegistrasi()
//        {
//            InitializeComponent();
//            btnDaftar.Click += BtnDaftar_Click;
//            lblMasuk.LinkClicked += LblMasuk_LinkClicked;
//        }

//        private void BtnDaftar_Click(object? sender, EventArgs e)
//        {
//            var nama = tbNamaLengkap.Text?.Trim() ?? string.Empty;
//            var email = tbEmail.Text?.Trim() ?? string.Empty;
//            var telepon = tbTelepon.Text?.Trim() ?? string.Empty;
//            var sandi = tbSandi.Text ?? string.Empty;
//            var username = tbUsername.Text?.Trim() ?? string.Empty;

//            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sandi))
//            {
//                MessageBox.Show("Nama, email, dan kata sandi wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (UserStore.GetByEmail(email) != null)
//            {
//                MessageBox.Show("Email sudah terdaftar.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var user = new User
//            {
//                NamaLengkap = nama,
//                Email = email,
//                NoTelepon = telepon,
//                PasswordHash = sandi,
//                Username = string.IsNullOrWhiteSpace(username) ? email : username,
//            };

//            UserStore.Add(user);
//            MessageBox.Show("Pendaftaran berhasil. Silakan masuk.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            this.Close();
//        }

//        private void LblMasuk_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
//        {
//            this.Close();
//        }

//        private void textBox3_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void Registrasi_Load(object sender, EventArgs e)
//        {
//            this.ClientSize = new System.Drawing.Size(1535, 864);
//        }
//    }
//}

using System;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;

namespace pboFinalProfject.View
{
    public partial class FormRegistrasi : Form
    {
        private AuthController _authController;

        public FormRegistrasi()
        {
            InitializeComponent();
            _authController = new AuthController();

            btnDaftar.Click += BtnDaftar_Click;
            lblMasuk.LinkClicked += LblMasuk_LinkClicked;
        }

        private void BtnDaftar_Click(object? sender, EventArgs e)
        {
            // Ambil data dari form
            string username = tbUsername.Text?.Trim() ?? string.Empty;
            string email = tbEmail.Text?.Trim() ?? string.Empty;
            string noTelepon = tbTelepon.Text?.Trim() ?? string.Empty;
            string password = tbSandi.Text ?? string.Empty;
            string nama = tbNamaLengkap.Text?.Trim() ?? string.Empty;

            // Validasi field wajib
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama lengkap tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi format email sederhana
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil AuthController untuk registrasi
            bool registrasiBerhasil = _authController.RegisterMahasiswa(
                username, email, noTelepon, password, nama);

            if (registrasiBerhasil)
            {
                // Registrasi berhasil, tutup form registrasi
                MessageBox.Show("Pendaftaran berhasil! Silakan login.", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // Jika gagal, pesan error sudah ditampilkan oleh AuthController
        }

        private void LblMasuk_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tutup form registrasi, kembali ke form login
            this.Close();
        }

        private void FormRegistrasi_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1535, 864);
        }
    }
}