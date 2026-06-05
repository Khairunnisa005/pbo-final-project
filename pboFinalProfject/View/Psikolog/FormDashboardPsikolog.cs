using System;
using System.Drawing;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormDashboardPsikolog : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        // Variabel untuk menyimpan nama psikolog yang login
        private string namaPsikologLogin;

        // Tweak Konstruktor: Tambahkan parameter string untuk menangkap nama
        public FormDashboardPsikolog(string namaPsikolog)
        {
            InitializeComponent();

            // Simpan nama yang dikirim dari form login
            this.namaPsikologLogin = namaPsikolog;

            this.Load += new System.EventHandler(this.FormDashboardPsikolog_Load);
        }

        private void FormDashboardPsikolog_Load(object sender, EventArgs e)
        {
            TampilkanBooking();
        }

        private void TampilkanBooking()
        {
            string query = "SELECT booking_id AS \"ID Booking\", user_id AS \"ID Mahasiswa\", jadwal_id AS \"ID Jadwal\" " +
                           "FROM bookings";
            try
            {
                DataTable dt = DatabaseHelper.EksekusiSelect(query);
                dgvPasien.DataSource = dt;
                dgvPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            // Membuat objek/instance dari Form Kelola Jadwal
            FormKelolaJadwal formJadwal = new FormKelolaJadwal();
            formJadwal.ShowDialog();
        }
    }
}