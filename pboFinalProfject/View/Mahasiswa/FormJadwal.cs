using System;
using System.Data;
using System.Windows.Forms;
using pboFinalProfject.Controllers;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormJadwal : Form
    {
        private MahasiswaController _controller;
        private BookingController _bookingController;

        public FormJadwal()
        {
            InitializeComponent();
            _controller = new MahasiswaController();
            _bookingController = new BookingController();
            LoadJadwal();
            // wire button handlers
            btnBuat.Click += BtnBuat_Click;
            btnKembali.Click += BtnKembali_Click;
        }

        private void LoadJadwal()
        {
            try
            {
                // Untuk mahasiswa, tampilkan jadwal yang sudah dibooking oleh mahasiswa (riwayat booking)
                int userId = pboFinalProfject.Session.UserSession.GetCurrentUserId();
                DataTable dt = _bookingController.GetRiwayatBookingByMahasiswa(userId);
                dgvJadwal.DataSource = dt;
                if (dgvJadwal.Columns.Contains("booking_id")) dgvJadwal.Columns["booking_id"].Visible = false;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // ensure we don't attach the handler multiple times
                dgvJadwal.CellDoubleClick -= DgvJadwal_CellDoubleClick;
                dgvJadwal.CellDoubleClick += DgvJadwal_CellDoubleClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jadwal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvJadwal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvJadwal.Rows[e.RowIndex];
            if (!dgvJadwal.Columns.Contains("booking_id")) return;
            int bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);

            // try to open a detail form named FormDetailBookingMahasiswa if it exists
            try
            {
                var type = Type.GetType("pboFinalProfject.View.Mahasiswa.FormDetailBookingMahasiswa");
                if (type != null)
                {
                    var detail = (Form)Activator.CreateInstance(type, bookingId)!;
                    detail.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Detail booking tidak tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka detail booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void DgvJadwal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;
        //    var row = dgvJadwal.Rows[e.RowIndex];
        //    if (!dgvJadwal.Columns.Contains("booking_id")) return;
        //    int bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);

        //    // buka form detail booking mahasiswa
        //    var detail = new FormDetailBookingMahasiswa(bookingId);
        //    detail.ShowDialog(this);
        //}

        private void BtnBuat_Click(object sender, EventArgs e)
        {
            var form = new FormBuatBooking();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadJadwal();
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Designer-generated event handlers (matching names wired in Designer)
        private void btnBuat_Click(object sender, EventArgs e) => BtnBuat_Click(sender, e);
        private void btnKembali_Click(object sender, EventArgs e) => BtnKembali_Click(sender, e);
    }
}
