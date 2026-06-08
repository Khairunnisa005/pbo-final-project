using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; // Pastikan library Npgsql sudah terinstall via NuGet

namespace pboFinalProfject.View
{
    public partial class FormKelolaProfil : Form
    {
        private PsikologController _psikologController;  // ← pakai PsikologController
        // ID User psikolog yang sedang login (seharusnya dilempar dari session FormLogin)
        private int currentUserId;

        public FormKelolaProfil(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            _psikologController = new PsikologController(); // Inisialisasi controller
        }

        private void FormKelolaProfil_Load(object sender, EventArgs e)
        {
            LoadProfilPsikolog();
        }

        private void LoadProfilPsikolog()
        {
            try
            {
                // Memanggil fungsi dari layer controller
                DataTable dtProfil = _psikologController.GetProfilPsikologByUserId(currentUserId);

                // Memastikan data ditemukan
                if (dtProfil.Rows.Count > 0)
                {
                    DataRow row = dtProfil.Rows[0];

                    // Mengisi data ke komponen UI Form dari DataRow
                    txtUsername.Text = row["username"].ToString();
                    txtNama.Text = row["nama_lengkap"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtTelepon.Text = row["no_telepon"].ToString();
                    txtGelar.Text = row["gelar"].ToString();
                    txtPendidikan.Text = row["pendidikan"].ToString();
                    txtIzinPraktek.Text = row["no_izin_praktek"].ToString();
                    txtDeskripsi.Text = row["deskripsi_singkat"].ToString();
                    chkOnline.Checked = Convert.ToBoolean(row["melayani_online"]);
                    chkOffline.Checked = Convert.ToBoolean(row["melayani_offline"]);
                }
                else
                {
                    MessageBox.Show("Data profil psikolog tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Menangkap pesan error yang dilemparkan oleh controller
                MessageBox.Show($"Gagal memuat profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi Input Dasar di Sisi UI
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nama Lengkap dan Email tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Panggil controller untuk melakukan eksekusi pembaruan data
                bool isSuccess = _psikologController.UpdateProfilPsikolog(
                    currentUserId,
                    txtNama.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtTelepon.Text.Trim(),
                    txtGelar.Text.Trim(),
                    txtPendidikan.Text.Trim(),
                    txtIzinPraktek.Text.Trim(),
                    txtDeskripsi.Text.Trim(),
                    chkOnline.Checked,
                    chkOffline.Checked
                );

                if (isSuccess)
                {
                    MessageBox.Show("Profil Anda berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProfilPsikolog(); // Refresh data tampilan
                }
            }
            catch (Exception ex)
            {
                // Menangkap error transaksi maupun koneksi yang dilemparkan controller & helper
                MessageBox.Show($"Gagal menyimpan perubahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Mengembalikan nilai form ke data awal di database
            LoadProfilPsikolog();
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}