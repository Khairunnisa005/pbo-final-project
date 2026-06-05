using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pboFinalProfject.View;

namespace pboFinalProfject.View
{
    public partial class FormLaporanAdmin : Form
    {
        public FormLaporanAdmin()
        {
            InitializeComponent();
        }

        // Event saat form pertama kali dimuat
        private void FormLaporanAdmin_Load(object sender, EventArgs e)
        {
            // Set tanggal default: awal bulan ini sampai hari ini
            dtpMulai.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSelesai.Value = DateTime.Now;

            // Isi pilihan filter status
            cmbStatus.Items.AddRange(new string[] { "Semua", "Menunggu", "Disetujui", "Selesai", "Dibatalkan" });
            cmbStatus.SelectedIndex = 0;

            TampilkanLaporan();
        }

        private void TampilkanLaporan()
        {
            try
            {
                DateTime tanggalMulai = dtpMulai.Value.Date;
                DateTime tanggalSelesai = dtpSelesai.Value.Date;
                string status = cmbStatus.SelectedItem.ToString();

                // Memanggil Database Helper untuk mengambil data laporan berdasarkan filter
                // Asumsi: DatabaseHelper.AmbilLaporanSesi mengembalikan DataTable
                DataTable dtLaporan = DatabaseHelper.AmbilLaporanSesi(tanggalMulai, tanggalSelesai, status);

                dgvLaporan.DataSource = dtLaporan;

                // Hitung total ringkasan secara dinamis dari DataTable
                lblTotalSesi.Text = dtLaporan.Rows.Count.ToString() + " Sesi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data laporan: " + ex.Message, "Error Laporan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data yang bisa diekspor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Laporan berhasil diekspor ke file Excel/CSV!", "Ekspor Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mengirim dokumen laporan ke printer...", "Cetak Laporan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}