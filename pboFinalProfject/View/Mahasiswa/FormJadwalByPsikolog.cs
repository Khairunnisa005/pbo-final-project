using System;
using System.Data;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormJadwalByPsikolog : Form
    {
        private int _psikologId;
        private BookingController _bookingController;

        public FormJadwalByPsikolog(int psikologId)
        {
            InitializeComponent();
            _psikologId = psikologId;
            _bookingController = new BookingController();
            LoadJadwal();
        }

        private void LoadJadwal()
        {
            try
            {
                var dt = _bookingController.GetJadwalTersediaByPsikolog(_psikologId);
                dgvJadwal.DataSource = dt;
                if (dgvJadwal.Columns.Contains("jadwal_id")) dgvJadwal.Columns["jadwal_id"].Visible = false;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvJadwal.CellDoubleClick -= DgvJadwal_CellDoubleClick;
                dgvJadwal.CellDoubleClick += DgvJadwal_CellDoubleClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jadwal: " + ex.Message);
            }
        }

        private void DgvJadwal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvJadwal.Rows[e.RowIndex];
            if (!dgvJadwal.Columns.Contains("jadwal_id")) return;
            int jadwalId = Convert.ToInt32(row.Cells["jadwal_id"].Value);

            // open prompt to confirm booking
            var confirm = MessageBox.Show("Buat janji pada slot ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int userId = UserSession.GetCurrentUserId();
                    bool ok = _bookingController.BuatBooking(userId, jadwalId, null);
                    if (ok)
                    {
                        MessageBox.Show("Booking berhasil dibuat.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadJadwal();
                    }
                    else
                    {
                        MessageBox.Show("Gagal membuat booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuat booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
