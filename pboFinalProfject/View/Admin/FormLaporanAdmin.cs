using pboFinalProfject.Controllers;
using pboFinalProfject.Session;
using pboFinalProfject.View;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormLaporanAdmin : Form
    {
        private AdminController _adminController;
        public FormLaporanAdmin()
        {
            InitializeComponent();
            _adminController = new AdminController();

            // set default date range (1 bulan terakhir)
            dtpMulai.Value = DateTime.Now.AddDays(-30);
            dtpSelesai.Value = DateTime.Now;

            // isi combobox status
            cmbStatus.Items.Add("Semua");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Disetujui");
            cmbStatus.Items.Add("Ditolak");
            cmbStatus.Items.Add("Selesai");
            cmbStatus.Items.Add("Batal");
            cmbStatus.SelectedIndex = 0; // default semua

            btnKembali.Click += btnKembali_Click;
        }

        // Event saat form pertama kali dimuat
        private void FormLaporanAdmin_Load(object sender, EventArgs e)
        {
            // Cek apakah user yang login adalah Admin
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Akses ditolak! Hanya admin yang dapat mengakses laporan.",
                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // load data awal
            LoadLaporan();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadLaporan();
        }



        //private void LoadLaporan()
        private void LoadLaporan()
        {
            try
            {
                DateTime startDate = dtpMulai.Value.Date;
                DateTime endDate = dtpSelesai.Value.Date;

                // Ambil status dari combobox
                string status = cmbStatus.SelectedItem?.ToString();

                // Handle status "Semua"
                if (status == "Semua")
                {
                    status = null;
                }

                DataTable dt = _adminController.GetLaporanBooking(startDate, endDate, status);

                dgvLaporan.DataSource = dt;

                // Sembunyikan kolom booking_id jika ada
                if (dgvLaporan.Columns.Contains("booking_id"))
                    dgvLaporan.Columns["booking_id"].Visible = false;

                // Atur header kolom
                if (dgvLaporan.Columns.Contains("tanggal_booking"))
                    dgvLaporan.Columns["tanggal_booking"].HeaderText = "Tanggal Booking";
                if (dgvLaporan.Columns.Contains("mahasiswa"))
                    dgvLaporan.Columns["mahasiswa"].HeaderText = "Mahasiswa";
                if (dgvLaporan.Columns.Contains("email_mahasiswa"))
                    dgvLaporan.Columns["email_mahasiswa"].HeaderText = "Email Mahasiswa";
                if (dgvLaporan.Columns.Contains("psikolog"))
                    dgvLaporan.Columns["psikolog"].HeaderText = "Psikolog";
                if (dgvLaporan.Columns.Contains("metode"))
                    dgvLaporan.Columns["metode"].HeaderText = "Metode";
                if (dgvLaporan.Columns.Contains("status"))
                    dgvLaporan.Columns["status"].HeaderText = "Status";

                // Update total sesi
                lblTotalSesi.Text = $"{dt.Rows.Count} Sesi";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat laporan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEkspor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLaporan.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data untuk diekspor.", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV File|*.csv|Excel File|*.xlsx";
                saveFileDialog.Title = "Simpan Laporan";
                saveFileDialog.FileName = $"Laporan_Konseling_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (filePath.EndsWith(".csv"))
                    {
                        ExportToCsv(filePath);
                    }
                    else
                    {
                        ExportToExcel(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengekspor laporan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExportToCsv(string filePath)
        {
            DateTime startDate = dtpMulai.Value.Date;
            DateTime endDate = dtpSelesai.Value.Date;
            string status = cmbStatus.SelectedItem?.ToString() == "Semua" ? null : cmbStatus.SelectedItem.ToString();

            string csvContent = _adminController.ExportLaporanToCsv(startDate, endDate, status);

            if (string.IsNullOrEmpty(csvContent))
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.IO.File.WriteAllText(filePath, csvContent);
            MessageBox.Show($"Laporan berhasil diekspor ke:\n{filePath}", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToExcel(string filePath)
        {
            // Untuk Excel, kita ekspor ke CSV dulu (karena lebih sederhana)
            // Atau bisa pakai library EPPlus jika mau format xlsx asli
            string csvPath = System.IO.Path.ChangeExtension(filePath, ".csv");
            ExportToCsv(csvPath);

            MessageBox.Show($"Laporan berhasil diekspor ke:\n{csvPath}\n\n(Catatan: File dalam format CSV, bisa dibuka dengan Excel)",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLaporan.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data untuk dicetak.", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Siapkan konten untuk dicetak
                string printContent = GeneratePrintContent();

                // Tampilkan dialog print preview
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDocument.DocumentName = $"Laporan_Konseling_{DateTime.Now:yyyyMMdd}";

                printDocument.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(printContent, new Font("Courier New", 10), Brushes.Black, 50, 50);
                };

                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    MessageBox.Show("Laporan sedang dicetak.", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencetak laporan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GeneratePrintContent()
        {
            string content = "";
            content += "========================================\n";
            content += "     UNIMIND - LAPORAN KONSELING       \n";
            content += "========================================\n";
            content += $"Periode: {dtpMulai.Value:dd/MM/yyyy} - {dtpSelesai.Value:dd/MM/yyyy}\n";
            content += $"Status: {cmbStatus.SelectedItem}\n";
            content += $"Tanggal Cetak: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n";
            content += "========================================\n\n";
            content += "No | Tanggal | Mahasiswa | Psikolog | Metode | Status\n";
            content += "----------------------------------------\n";

            for (int i = 0; i < dgvLaporan.Rows.Count; i++)
            {
                DataGridViewRow row = dgvLaporan.Rows[i];
                string tanggal = row.Cells["tgl_booking"]?.Value?.ToString() ?? "-";
                string mahasiswa = row.Cells["mahasiswa"]?.Value?.ToString() ?? "-";
                string psikolog = row.Cells["psikolog"]?.Value?.ToString() ?? "-";
                string metode = row.Cells["metode"]?.Value?.ToString() ?? "-";
                string status = row.Cells["status"]?.Value?.ToString() ?? "-";

                content += $"{i + 1,-3} | {tanggal,-10} | {mahasiswa,-15} | {psikolog,-15} | {metode,-6} | {status}\n";
            }

            content += "\n========================================\n";
            content += $"Total Sesi: {dgvLaporan.Rows.Count} Sesi\n";
            content += "========================================\n";

            return content;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Cari Form Dashboard yang sudah ada atau buat baru jika diperlukan
            // Agar kembali ke form utama aplikasi
            FormDashboardAdmin dashboard = new FormDashboardAdmin();
            this.Hide();         // Sembunyikan Form Laporan
            dashboard.Show();    // Tampilkan Dashboard
        }

        private void dgvLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Cari Form Dashboard yang sudah ada atau buat baru jika diperlukan
            // Agar kembali ke form utama aplikasi
            FormDashboardAdmin dashboard = new FormDashboardAdmin();
            this.Hide();         // Sembunyikan Form Laporan
            dashboard.Show();    // Tampilkan Dashboard
        }
}}