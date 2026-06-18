using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;
using pboFinalProfject.View;

namespace pboFinalProfject.View
{
    public partial class FormDashboardAdmin : Form, IFormLoadable
    {
        private AdminController _adminController;
        private AuthController _authController;

        public FormDashboardAdmin()
        {
            InitializeComponent();
            _adminController = new AdminController();
            _authController = new AuthController();

            // hook event handler
            this.Load += (s, e) => LoadData();
            btnKelolaUser.Click += btnKelolaUser_Click;
            btnLaporan.Click += btnLaporan_Click;
            btnKeluar.Click += btnKeluar_Click;
            btnRefresh.Click += btnRefresh_Click;

        }
        public void LoadData()
        {
            LoadDataDashboard();
            LoadDaftarAntreanKonseling();

        }
        public void RefreshData()
        {
            LoadData();
            MessageBox.Show("Data dashboard berhasil di-refresh!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ResetForm()
        {
            // reset semua label ke default
        }

        public void SetupUIByRole()
        {
            // pastikan hanya admin yang bisa akses
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Akses ditolak! Hanya admin yang dapat mengakses halaman ini.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }


        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            // cek apakah user yang login adalah admin
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Akses ditolak! Hanya admin yang dapat mengakses halaman ini.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            // Load data dashboard
            LoadData();
        }

        private void LoadDataDashboard()
        {
            try
            {
                // ambil data statistik dari database via AdminController
                DataTable dtStatistik = _adminController.GetStatistikDashboard();
                if (dtStatistik.Rows.Count > 0)
                {
                    DataRow row = dtStatistik.Rows[0];

                    // total pasien = total mahasiswa
                    int totalMahasiswa = Convert.ToInt32(row["total_mahasiswa"]);
                    lblTotalMahasiswa.Text = totalMahasiswa.ToString();

                    // total psikolog/konselor aktif
                    int totalPsikolog = Convert.ToInt32(row["total_psikolog"]);
                    lblTotalKonselor.Text = totalPsikolog.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat informasi dashboard: " + ex.Message,
                                "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // set default value jika error
                lblTotalMahasiswa.Text = "0";
                lblTotalKonselor.Text = "0";
            }
        }

        private void LoadDaftarAntreanKonseling()
        {
            try
            {
                // Simulasi struktur datatable untuk Grid View (Daftar Booking Masuk)
                DataTable dt = _adminController.GetDaftarBookingTerbaru(20);
                dgvAntreanKonseling.DataSource = dt;

                // sembunyikan bookinng id
                if (dgvAntreanKonseling.Columns.Contains("booking_id"))
                    dgvAntreanKonseling.Columns["booking_id"].Visible = false;

                // atur header kolom sesuai dengan data yang diterima
                if (dgvAntreanKonseling.Columns.Contains("tanggal"))
                    dgvAntreanKonseling.Columns["tanggal"].HeaderText = "Tanggal";
                if (dgvAntreanKonseling.Columns.Contains("mahasiswa"))
                    dgvAntreanKonseling.Columns["mahasiswa"].HeaderText = "Mahasiswa";
                if (dgvAntreanKonseling.Columns.Contains("psikolog"))
                    dgvAntreanKonseling.Columns["psikolog"].HeaderText = "Psikolog";
                if (dgvAntreanKonseling.Columns.Contains("metode"))
                    dgvAntreanKonseling.Columns["metode"].HeaderText = "Metode";
                if (dgvAntreanKonseling.Columns.Contains("status"))
                    dgvAntreanKonseling.Columns["status"].HeaderText = "Status";

                // Warna status berdasarkan nilai
                dgvAntreanKonseling.CellFormatting += (s, e) =>
                {
                    if (e.ColumnIndex == dgvAntreanKonseling.Columns["status"]?.Index && e.Value != null)
                    {
                        string status = e.Value.ToString();
                        switch (status)
                        {
                            case "Disetujui":
                                e.CellStyle.ForeColor = Color.Green;
                                e.Value = "✅ Disetujui";
                                break;
                            case "Pending":
                                e.CellStyle.ForeColor = Color.Orange;
                                e.Value = "⏳ Pending";
                                break;
                            case "Ditolak":
                                e.CellStyle.ForeColor = Color.Red;
                                e.Value = "❌ Ditolak";
                                break;
                            case "Selesai":
                                e.CellStyle.ForeColor = Color.Blue;
                                e.Value = "✔️ Selesai";
                                break;
                            case "Batal":
                                e.CellStyle.ForeColor = Color.Gray;
                                e.Value = "🚫 Batal";
                                break;
                        }
                    }
                };
                // Atur auto-size columns
                dgvAntreanKonseling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar booking: " + ex.Message,
                                "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Tampilkan DataGridView kosong jika error
                DataTable dtEmpty = new DataTable();
                dtEmpty.Columns.Add("Tanggal Booking", typeof(string));
                dtEmpty.Columns.Add("Mahasiswa", typeof(string));
                dtEmpty.Columns.Add("Psikolog", typeof(string));
                dtEmpty.Columns.Add("Status", typeof(string));
                dgvAntreanKonseling.DataSource = dtEmpty;
            }
        }

        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            //// Buka form kelola jadwal untuk psikolog ini
            //// 1. Ambil ID admin aktif
            //int adminId = UserSession.GetCurrentUserId();

            // 2. Oper ID ke form tujuan
            FormManageUser formKelolaUser = new FormManageUser();

            // 3. Sembunyikan Dashboard (bukan ditutup/dihancurkan)
            this.Hide();

            // 4. Tampilkan form kelola user
            formKelolaUser.Show();
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
        private void FormDashboardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Memastikan jika form ini dicolose murni lewat tombol X Windows, 
            // seluruh aplikasi dan form yang tersembunyi ikut mati total.
            Application.Exit();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh data dashboard
            LoadDataDashboard();
            LoadDaftarAntreanKonseling();
            MessageBox.Show("Data dashboard berhasil di-refresh!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void dgvAntreanKonseling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

       
    }
}