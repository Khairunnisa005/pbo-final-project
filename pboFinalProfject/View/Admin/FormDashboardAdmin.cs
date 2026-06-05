using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ResetStateDashboard();
            MuatDataDashboard();
        }

        private void ResetStateDashboard()
        {
            // State awal bersih sebelum data ditarik
            lblCountBooking.Text = "0 Sesi";
            lblCountPasien.Text = "0 Pasien";
        }

        private void MuatDataDashboard()
        {
            try
            {
                // Bagian integrasi ke DatabaseHelper untuk mengambil jumlah aktual
                // Contoh pengisian data simulasi:
                lblCountBooking.Text = "12 Sesi";
                lblCountPasien.Text = "48 Pasien";

                MuatDaftarBookingMasuk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat informasi dashboard: " + ex.Message,
                                "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MuatDaftarBookingMasuk()
        {
            // Simulasi struktur datatable untuk Grid View (Daftar Booking Masuk)
            DataTable dt = new DataTable();
            dt.Columns.Add("ID Mahasiswa", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Program Studi", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            // Jika database helper Anda belum mengembalikan data, grid akan otomatis menampilkan state kosong yang rapi
            dgvBookingMasuk.DataSource = dt;
        }

        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Membuka halaman Kelola Jadwal Konseling...", "Sistem Unimind", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuJadwal_Click(object sender, EventArgs e)
        {
            // Logika pindah ke panel/form Jadwal Konseling
        }

        private void menuPasien_Click(object sender, EventArgs e)
        {
            // Logika pindah ke panel/form Daftar Pasien
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}