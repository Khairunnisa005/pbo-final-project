using Npgsql; // Library Connector PostgreSQL
using pboFinalProfject.Controllers;
using pboFinalProfject.Model;
using pboFinalProfject.Session;
using System;
using System.Data;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormManageUser : Form
    {
        private AdminController _adminController;
        private int _selectedPsikologId = 0;
        private int _selectedMahasiswaId = 0;

        public FormManageUser()
        {
            InitializeComponent();
            _adminController = new AdminController();

        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {
            // Cek akses (hanya admin)
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Akses ditolak! Hanya admin yang dapat mengakses halaman ini.",
                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }


            LoadDataPsikolog();
            LoadDataMahasiswa();
            btnSimpanMhs.Visible = false;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LOGIKA MANAJEMEN PSIKOLOG (KARYAWAN)

        private void LoadDataPsikolog()
        {
            try
            {
                DataTable dt = _adminController.GetDaftarPsikolog();
                dgvPsikolog.DataSource = dt;

                // Sembunyikan kolom ID
                if (dgvPsikolog.Columns.Contains("psikolog_id"))
                    dgvPsikolog.Columns["psikolog_id"].Visible = false;
                if (dgvPsikolog.Columns.Contains("user_id"))
                    dgvPsikolog.Columns["user_id"].Visible = false;

                // Atur header
                if (dgvPsikolog.Columns.Contains("username"))
                    dgvPsikolog.Columns["username"].HeaderText = "Username";
                if (dgvPsikolog.Columns.Contains("nama_lengkap"))
                    dgvPsikolog.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
                if (dgvPsikolog.Columns.Contains("email"))
                    dgvPsikolog.Columns["email"].HeaderText = "Email";
                if (dgvPsikolog.Columns.Contains("no_telepon"))
                    dgvPsikolog.Columns["no_telepon"].HeaderText = "No. Telepon";
                if (dgvPsikolog.Columns.Contains("gelar"))
                    dgvPsikolog.Columns["gelar"].HeaderText = "Gelar";
                if (dgvPsikolog.Columns.Contains("pendidikan"))
                    dgvPsikolog.Columns["pendidikan"].HeaderText = "Pendidikan";
                if (dgvPsikolog.Columns.Contains("no_izin_praktek"))
                    dgvPsikolog.Columns["no_izin_praktek"].HeaderText = "No. Izin Praktek";
                if (dgvPsikolog.Columns.Contains("keahlian"))
                    dgvPsikolog.Columns["keahlian"].HeaderText = "Keahlian";
                if (dgvPsikolog.Columns.Contains("deskripsi_singkat"))
                    dgvPsikolog.Columns["deskripsi_singkat"].HeaderText = "Deskripsi Singkat";

                dgvPsikolog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data psikolog: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanPsikolog_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserPsi.Text.Trim();
                string namaLengkap = txtNamaPsi.Text.Trim();
                string email = txtEmailPsi.Text.Trim();
                string noTelepon = txtTelpPsi.Text.Trim();
                string keahlian = txtKeahlian.Text.Trim();
                string gelar = txtGelar.Text.Trim();
                string pendidikan = txtPendidikan.Text.Trim();
                string no_izin = txtIzinPraktek.Text.Trim();
                string deskripsiSingkat = txtDeskPsi.Text.Trim();
                // Validasi dasar
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(namaLengkap) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Username, Nama, dan Email wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Membuat objek model yang membawa data inputan
                User userModel = new User
                {
                    Username = username,
                    Email = email,
                    NoTelepon = noTelepon,
                    NamaLengkap = namaLengkap,
                    Role = "Psikolog"
                };

                Psikolog psikologModel = new Psikolog
                {
                    Gelar = gelar,
                    Pendidikan = pendidikan,
                    NoIzinPraktek = no_izin,
                    Keahlian = keahlian, // Pastikan properti ini ada di class Psikolog Anda
                    MelayaniOnline = true,
                    MelayaniOffline = true,
                    DeskripsiSingkat = deskripsiSingkat
                };

                if (_selectedPsikologId == 0)
                {
                    // --- TAMBAH PSIKOLOG BARU ---
                    userModel.PasswordHash = "psikolog123"; // Default password
                    userModel.CreatedAt = DateTime.Now;
                    psikologModel.CreatedAt = DateTime.Now;

                    bool berhasil = _adminController.TambahPsikolog(userModel, psikologModel);
                    if (berhasil)
                    {
                        MessageBox.Show("Psikolog berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFieldsPsikolog();
                        LoadDataPsikolog();
                    }
                }
                else
                {
                    // --- UPDATE PSIKOLOG (SOLUSI MASALAH 1) ---
                    // Set ID psikolog yang dipilih ke objek model agar controller tahu record mana yang di-update
                    psikologModel.PsikologId = _selectedPsikologId;

                    bool berhasil = _adminController.UpdatePsikolog(userModel, psikologModel);
                    if (berhasil)
                    {
                        MessageBox.Show("Data psikolog berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFieldsPsikolog();
                        LoadDataPsikolog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusPsi_Click(object sender, EventArgs e)
        {
            if (_selectedPsikologId == 0)
            {
                MessageBox.Show("Pilih psikolog yang akan dihapus terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Hapus psikolog {txtNamaPsi.Text}?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = _adminController.HapusPsikolog(_selectedPsikologId);
                    if (berhasil)
                    {
                        MessageBox.Show("Psikolog berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFieldsPsikolog();
                        LoadDataPsikolog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menghapus psikolog: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPsikolog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPsikolog.Rows[e.RowIndex];

                _selectedPsikologId = Convert.ToInt32(row.Cells["psikolog_id"].Value);
                txtUserPsi.Text = row.Cells["username"].Value?.ToString();
                txtNamaPsi.Text = row.Cells["nama_lengkap"].Value?.ToString();
                txtEmailPsi.Text = row.Cells["email"].Value?.ToString();
                txtTelpPsi.Text = row.Cells["no_telepon"].Value?.ToString();
                txtKeahlian.Text = row.Cells["keahlian"].Value?.ToString();
                txtGelar.Text = row.Cells["gelar"].Value?.ToString();
                txtPendidikan.Text = row.Cells["pendidikan"].Value?.ToString();
                txtIzinPraktek.Text = row.Cells["no_izin_praktek"].Value?.ToString();
                txtDeskPsi.Text = row.Cells["deskripsi_singkat"].Value?.ToString();

                // Ubah tombol simpan menjadi "UPDATE"
                btnSimpanPsikolog.Text = "UPDATE PSIKOLOG";
                btnSimpanPsikolog.BackColor = Color.FromArgb(52, 152, 219);
            }
        }

        private void ClearFieldsPsikolog()
        {
            txtUserPsi.Clear();
            txtNamaPsi.Clear();
            txtEmailPsi.Clear();
            txtTelpPsi.Clear();
            txtKeahlian.Clear();
            txtGelar.Clear();
            txtPendidikan.Clear();
            txtIzinPraktek.Clear();
            txtDeskPsi.Clear();
            _selectedPsikologId = 0;
            btnSimpanPsikolog.Text = "TAMBAH PSIKOLOG";
            btnSimpanPsikolog.BackColor = Color.FromArgb(26, 54, 141);
        }

        #endregion

        #region LOGIKA MANAJEMEN MAHASISWA (CUSTOMER)

        private void LoadDataMahasiswa()
        {
            try
            {
                DataTable dt = _adminController.GetDaftarMahasiswa();
                dgvMahasiswa.DataSource = dt;

                // Sembunyikan kolom ID
                if (dgvMahasiswa.Columns.Contains("user_id"))
                    dgvMahasiswa.Columns["user_id"].Visible = false;

                // Atur header
                if (dgvMahasiswa.Columns.Contains("username"))
                    dgvMahasiswa.Columns["username"].HeaderText = "Username (NIM)";
                if (dgvMahasiswa.Columns.Contains("nama_lengkap"))
                    dgvMahasiswa.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
                if (dgvMahasiswa.Columns.Contains("email"))
                    dgvMahasiswa.Columns["email"].HeaderText = "Email";
                if (dgvMahasiswa.Columns.Contains("no_telepon"))
                    dgvMahasiswa.Columns["no_telepon"].HeaderText = "No. Telepon";
                if (dgvMahasiswa.Columns.Contains("tgl_daftar"))
                    dgvMahasiswa.Columns["tgl_daftar"].HeaderText = "Tanggal Daftar";
                if (dgvMahasiswa.Columns.Contains("preferensi_waktu")) dgvMahasiswa.Columns["preferensi_waktu"].Visible = false;


                dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data mahasiswa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanMhs_Click(object sender, EventArgs e)
        {
            if (_selectedMahasiswaId == 0)
            {
                MessageBox.Show("Pilih data mahasiswa dari tabel terlebih dahulu untuk di-update!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buat objek model membawa perubahan data dari UI
                User mhsUpdate = new User
                {
                    UserId = _selectedMahasiswaId,
                    Username = txtUserMhs.Text.Trim(),
                    NamaLengkap = txtNamaMhs.Text.Trim(),
                    Email = txtEmailMhs.Text.Trim(),
                    NoTelepon = txtTelpMhs.Text.Trim()
                };

                // Panggil controller untuk update ke database
                bool berhasil = _adminController.UpdateMahasiswa(mhsUpdate);

                if (berhasil)
                {
                    MessageBox.Show("Data mahasiswa berhasil di-update!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFieldsMahasiswa();
                    LoadDataMahasiswa();
                }
                else
                {
                    MessageBox.Show("Gagal mengupdate data mahasiswa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusMhs_Click(object sender, EventArgs e)
        {
            if (_selectedMahasiswaId == 0)
            {
                MessageBox.Show("Pilih mahasiswa yang akan dihapus terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Hapus mahasiswa {txtNamaMhs.Text}?\n\n" +
                "Data booking dan riwayat konseling juga akan dihapus!",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = _adminController.HapusMahasiswa(_selectedMahasiswaId);
                    if (berhasil)
                    {
                        MessageBox.Show("Mahasiswa berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFieldsMahasiswa();
                        LoadDataMahasiswa();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menghapus mahasiswa: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];

                _selectedMahasiswaId = Convert.ToInt32(row.Cells["user_id"].Value);
                txtUserMhs.Text = row.Cells["username"].Value?.ToString();
                txtNamaMhs.Text = row.Cells["nama_lengkap"].Value?.ToString();
                txtEmailMhs.Text = row.Cells["email"].Value?.ToString();
                txtTelpMhs.Text = row.Cells["no_telepon"].Value?.ToString();

                // Munculkan tombol dan ubah teksnya hanya untuk update (Solusi Masalah 1 & 2)
                btnSimpanMhs.Text = "UPDATE MAHASISWA";
                btnSimpanMhs.BackColor = Color.FromArgb(52, 152, 219);
                btnSimpanMhs.Visible = true;
            }
        }

        private void ClearFieldsMahasiswa()
        {
            txtUserMhs.Clear();
            txtNamaMhs.Clear();
            txtEmailMhs.Clear();
            txtTelpMhs.Clear();
            _selectedMahasiswaId = 0;

            // Sembunyikan kembali tombol karena proses edit sudah selesai / dibersihkan
            btnSimpanMhs.Visible = false;
        }



        #endregion

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
        private void btnLaporan_Click(object sender, EventArgs e)
        {
            //// 1. Ambil ID admin aktif
            //int adminId = UserSession.GetCurrentUserId();

            // 2. Oper ID ke form tujuan
            FormLaporanAdmin formLaporan = new FormLaporanAdmin();

            // 3. Sembunyikan Dashboard (bukan ditutup/dihancurkan)
            this.Hide();

            // 4. Tampilkan form laporan
            formLaporan.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboardAdmin dashboard = new FormDashboardAdmin();
            this.Hide();
            dashboard.Show();
        }
        private void FormManageUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Memastikan jika form ini dicolose murni lewat tombol X Windows, 
            // seluruh aplikasi dan form yang tersembunyi ikut mati total.
            Application.Exit();
        }
    }
}