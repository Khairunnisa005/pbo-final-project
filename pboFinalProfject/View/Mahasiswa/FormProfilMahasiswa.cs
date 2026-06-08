using System;
using System.Windows.Forms;
using pboFinalProfject.Repositories;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormProfilMahasiswa : Form
    {
        private UserRepository _userRepo;

        public FormProfilMahasiswa()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            LoadProfile();
        }

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
    }
}
