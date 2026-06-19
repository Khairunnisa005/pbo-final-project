using Npgsql; // Pastikan library Npgsql sudah terinstall via NuGet
using pboFinalProfject.Session;
using System;
using System.Data;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormKelolaProfil : Form
    {
        private PsikologController _psikologController;  // ← pakai PsikologController
        // ID User psikolog yang sedang login (seharusnya dilempar dari session FormLogin)
        private int currentUserId;
        private int currentPsikologId;

        public FormKelolaProfil(int userId, int psikologId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.currentPsikologId = psikologId;
            _psikologController = new PsikologController(); // Inisialisasi controller
        }

        private void FormKelolaProfil_Load(object sender, EventArgs e)
        {
            if (this.currentUserId <= 0)
            {
                MessageBox.Show("Sesi login tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

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
        // Tombol "Dashboard" di Sidebar Profil
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Cari Form Dashboard yang sudah ada atau buat baru jika diperlukan
            // Agar kembali ke form utama aplikasi
            FormDashboardPsikolog dashboard = new FormDashboardPsikolog();

            this.Hide();         // Sembunyikan Form Profil
            dashboard.Show();    // Tampilkan Dashboard
        }

        // Tombol "Kelola Jadwal" di Sidebar Profil
        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            int userId = UserSession.GetCurrentUserId();
            FormKelolaJadwal formJadwal = new FormKelolaJadwal(userId);

            this.Hide();         // Sembunyikan Form Profil
            formJadwal.Show();   // Tampilkan Form Jadwal
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Konfirmasi keluar
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 1. Tampilkan form login baru
                FormLogin login = new FormLogin();
                login.Show();

                // 2. Clear session data jika diperlukan
                UserSession.Clear();

                // 3. Tutup Form Dashboard saat ini tanpa memicu loop penutupan otomatis
                this.Dispose();
            }
        }
        private void FormKelolaProfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Memastikan jika form ini dicolose murni lewat tombol X Windows, 
            // seluruh aplikasi dan form yang tersembunyi ikut mati total.
            Application.Exit();
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Kembali ke Dashboard Psikolog
            FormDashboardPsikolog dashboard = new FormDashboardPsikolog();
            this.Hide();
            dashboard.Show();
        }
}}