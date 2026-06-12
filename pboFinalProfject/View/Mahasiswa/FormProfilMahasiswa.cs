using System;
using System.Windows.Forms;
using pboFinalProfject.Repositories;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormProfilMahasiswa : Form
    {
        private UserRepository _userRepo;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label lblNama;
        private TextBox tbNama;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblTelepon;
        private TextBox tbTelepon;
        private Button btnSave;

        public FormProfilMahasiswa()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                _userRepo = new UserRepository();
                LoadProfile();

                // sidebar navigation
            btnKuisioner.Click += (s, e) => { new FormKuesioner().ShowDialog(this); };
            btnKonselor.Click += (s, e) => { new FormDaftarKonselor().ShowDialog(this); };
            btnKonsultasi.Click += (s, e) => { new FormBuatBooking().ShowDialog(this); };
                btnBeranda.Click += (s, e) => { pboFinalProfject.Utils.Navigation.GoToDashboard(this); };
                btnKeluar.Click += (s, e) => { var auth = new pboFinalProfject.Controllers.AuthController(); auth.LogoutAndRedirect(this); };
            this.Shown += (s, e) => { this.Activate(); };

                btnSave.Click += BtnSave_Click;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void LoadProfile()
        //{
        //    try
        //    {
        //        int id = UserSession.GetCurrentUserId();
        //        var user = _userRepo.GetById(id);
        //        if (user != null)
        //        {
        //            tbUsername.Text = user.Username;
        //            tbNama.Text = user.NamaLengkap;
        //            tbEmail.Text = user.Email;
        //            tbTelepon.Text = user.NoTelepon;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal memuat profil: " + ex.Message);
        //    }
        //}

        private void LoadProfile()
        {
            try
            {
                int id = UserSession.GetCurrentUserId();
                var user = _userRepo.GetById(id);
                if (user != null)
                {
                    tbUsername.Text = user.Username;
                    tbNama.Text = user.NamaLengkap;
                    tbEmail.Text = user.Email;
                    tbTelepon.Text = user.NoTelepon;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat profil: " + ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = UserSession.GetCurrentUserId();
                var user = _userRepo.GetById(id);
                if (user == null)
                {
                    MessageBox.Show("User tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.Username = tbUsername.Text.Trim();
                user.NamaLengkap = tbNama.Text.Trim();
                user.Email = tbEmail.Text.Trim();
                user.NoTelepon = tbTelepon.Text.Trim();

                bool ok = _userRepo.Update(user);
                if (ok) MessageBox.Show("Profil berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Gagal menyimpan profil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan profil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = UserSession.GetCurrentUserId();
                var confirm = MessageBox.Show("Hapus akun Anda? Semua data akan hilang.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;
                bool ok = _userRepo.Delete(id);
                if (ok)
                {
                    MessageBox.Show("Akun dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else MessageBox.Show("Gagal menghapus akun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus akun: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
