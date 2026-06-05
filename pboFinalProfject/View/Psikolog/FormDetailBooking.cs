using System;
using System.Data; // Diperlukan jika Database Helper mengembalikan DataTable
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using pboFinalProfject.View;

namespace pboFinalProfject.View
{
    public partial class FormDetailBooking : Form
    {
        private string _idBooking;

        // Konstruktor sekarang menerima IDBooking, bukan lagi objek data lengkap
        public FormDetailBooking(string idBooking)
        {
            InitializeComponent();
            this._idBooking = idBooking;
        }

        // Event load form untuk memicu pengambilan data saat form pertama kali dibuka
        private void FormDetailBooking_Load(object sender, EventArgs e)
        {
            AmbilDanMuatData();
        }

        private void AmbilDanMuatData()
        {
            try
            {
                // PANGGIL DATABASE HELPER
                // Asumsi: DatabaseHelper memiliki fungsi statis AmbilDetailBooking(string id)
                // Fungsi ini mengembalikan objek 'KonselingData' atau DataRow
                KonselingData data = DatabaseHelper.AmbilDetailBooking(_idBooking);

                if (data != null)
                {
                    // Mengisi label informasi dari properti objek hasil database
                    lblValIDBooking.Text = data.IDBooking;
                    lblValNamaKonseli.Text = data.NamaKonseli;
                    lblValKonselor.Text = data.NamaKonselor;
                    lblValJadwal.Text = data.WaktuSesi.ToString("dd MMMM yyyy, HH:mm") + " WIB";
                    lblValTipe.Text = data.TipeKonseling;
                    txtValKeluhan.Text = data.KeluhanAwal;

                    // Mengatur warna badge status
                    AturKomponenStatus(data.StatusBooking);
                }
                else
                {
                    MessageBox.Show("Data booking tidak ditemukan di database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        

        private void AturKomponenStatus(string status)
        {
            lblValStatus.Text = status.ToUpper();

            if (status.ToLower() == "disetujui" || status.ToLower() == "selesai")
            {
                lblValStatus.ForeColor = Color.FromArgb(46, 125, 50);
                panelStatus.BackColor = Color.FromArgb(232, 245, 233);
            }
            else if (status.ToLower() == "menunggu")
            {
                lblValStatus.ForeColor = Color.FromArgb(216, 111, 0);
                panelStatus.BackColor = Color.FromArgb(255, 243, 224);
            }
            else // Dibatalkan / Ditolak
            {
                lblValStatus.ForeColor = Color.FromArgb(198, 40, 40);
                panelStatus.BackColor = Color.FromArgb(255, 235, 235);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAksiUtama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Membuka detail sesi konseling Unimind...", "Unimind System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}