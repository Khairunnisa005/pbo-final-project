using System;
using System.Data;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormBuatJanji : Form
    {
        private BookingController _bookingController;

        public FormBuatJanji()
        {
            InitializeComponent();
            _bookingController = new BookingController();
            LoadRiwayat();
            LoadPsikologs();
            // wire selection events
            dgvPsikolog.CellClick -= DgvPsikolog_CellClick;
            dgvPsikolog.CellClick += DgvPsikolog_CellClick;
            dgvAvailableJadwal.CellDoubleClick -= DgvAvailableJadwal_CellDoubleClick;
            dgvAvailableJadwal.CellDoubleClick += DgvAvailableJadwal_CellDoubleClick;
        }

        private void LoadRiwayat()
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                DataTable dt = _bookingController.GetRiwayatBookingByMahasiswa(userId);
                dgvRiwayat.DataSource = dt;
                dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // hook double click to view detail or cancel
                dgvRiwayat.CellDoubleClick -= DgvRiwayat_CellDoubleClick;
                dgvRiwayat.CellDoubleClick += DgvRiwayat_CellDoubleClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat booking: " + ex.Message);
            }
        }

        private void LoadPsikologs()
        {
            try
            {
                var ctrl = new PsikologController();
                var dt = ctrl.GetAllPsikolog();
                dgvPsikolog.DataSource = dt;
                if (dgvPsikolog.Columns.Contains("psikolog_id")) dgvPsikolog.Columns["psikolog_id"].Visible = false;
                dgvPsikolog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar konselor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPsikolog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPsikolog.Rows[e.RowIndex];
            if (!dgvPsikolog.Columns.Contains("psikolog_id")) return;
            int psikologId = Convert.ToInt32(row.Cells["psikolog_id"].Value);
            // load available jadwal for selected psikolog
            try
            {
                var dt = _bookingController.GetJadwalTersediaByPsikolog(psikologId);
                dgvAvailableJadwal.DataSource = dt;
                if (dgvAvailableJadwal.Columns.Contains("jadwal_id")) dgvAvailableJadwal.Columns["jadwal_id"].Visible = false;
                dgvAvailableJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jadwal: " + ex.Message);
            }
        }

        private void DgvAvailableJadwal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAvailableJadwal.Rows[e.RowIndex];
            if (!dgvAvailableJadwal.Columns.Contains("jadwal_id")) return;
            int jadwalId = Convert.ToInt32(row.Cells["jadwal_id"].Value);

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
                        // refresh both available jadwal and riwayat
                        DgvPsikolog_CellClick(this, new DataGridViewCellEventArgs(0, dgvPsikolog.CurrentCell?.RowIndex ?? 0));
                        LoadRiwayat();
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

        private void DgvRiwayat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvRiwayat.Rows[e.RowIndex];
            if (!dgvRiwayat.Columns.Contains("booking_id")) return;
            int bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);
            var detail = new FormDetailBookingMahasiswa(bookingId);
            detail.ShowDialog(this);
            // refresh after possible changes
            LoadRiwayat();
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            // Open the new form-based booking dialog
            var form = new FormBuatBooking();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadRiwayat();
            }
        }

        private void btnBatalkan_Click(object sender, EventArgs e)
        {
            if (dgvRiwayat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih booking yang ingin dibatalkan (klik baris).", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvRiwayat.SelectedRows[0];
            if (!dgvRiwayat.Columns.Contains("booking_id")) return;
            int bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);

            var confirm = MessageBox.Show("Batalkan booking terpilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var ok = _bookingController.BatalkanBooking(bookingId);
                    if (ok)
                    {
                        MessageBox.Show("Booking berhasil dibatalkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRiwayat();
                    }
                    else
                    {
                        MessageBox.Show("Gagal membatalkan booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membatalkan booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
