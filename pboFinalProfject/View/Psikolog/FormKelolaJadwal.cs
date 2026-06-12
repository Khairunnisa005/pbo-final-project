using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using pboFinalProfject.Utils;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;

namespace pboFinalProfject.View
{
    public partial class FormKelolaJadwal : Form
    {
        private PsikologController _psikologController;  // ← pakai PsikologController
        private int _psikologId;
        private int _selectedJadwalId = 0;

        public FormKelolaJadwal(int psikologId)
        {
            InitializeComponent();

            _psikologController = new PsikologController();  // ← Pakai PsikologController
            _psikologId = psikologId;

            btnTambah.Click += BtnTambah_Click;
            btnUbah.Click += BtnUbah_Click;
            btnHapus.Click += BtnHapus_Click;
            btnKembali.Click += BtnKembali_Click;
            btnBersihkan.Click += BtnBersihkan_Click;
            dgvSlotJadwal.SelectionChanged += DgvSlotJadwal_SelectionChanged;

            LoadData();
        }

        private void FormKelolaJadwal_Load(object sender, EventArgs e)
        {
            // Cek apakah user yang login adalah Psikolog
            if (!UserSession.IsPsikolog)
            {
                MessageBox.Show("Akses ditolak! Hanya psikolog yang dapat mengakses halaman ini.",
                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // Set default values
            dtpJamMulai.Value = DateTime.Today.AddHours(9);
            dtpJamSelesai.Value = DateTime.Today.AddHours(10);
            chkIsActive.Checked = true;
            tbKuota.Text = "1";

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _psikologController.GetJadwalByPsikologId(_psikologId);
                dgvSlotJadwal.DataSource = dt;

                // Sembunyikan kolom yang tidak perlu
                if (dgvSlotJadwal.Columns.Contains("jadwal_id"))
                    dgvSlotJadwal.Columns["jadwal_id"].Visible = false;

                // Atur header kolom
                if (dgvSlotJadwal.Columns.Contains("hari"))
                    dgvSlotJadwal.Columns["hari"].HeaderText = "Hari";

                if (dgvSlotJadwal.Columns.Contains("jam_mulai"))
                    dgvSlotJadwal.Columns["jam_mulai"].HeaderText = "Jam Mulai";

                if (dgvSlotJadwal.Columns.Contains("jam_selesai"))
                    dgvSlotJadwal.Columns["jam_selesai"].HeaderText = "Jam Selesai";

                if (dgvSlotJadwal.Columns.Contains("metode"))
                    dgvSlotJadwal.Columns["metode"].HeaderText = "Metode";

                if (dgvSlotJadwal.Columns.Contains("kuota"))
                    dgvSlotJadwal.Columns["kuota"].HeaderText = "Kuota";

                //if (dgvSlotJadwal.Columns.Contains("is_active"))
                //{
                //    dgvSlotJadwal.Columns["is_active"].HeaderText = "Status";

                //    //// Format tampilan status
                //    //dgvSlotJadwal.CellFormatting += (s, ev) =>
                //    //{
                //    //    if (ev.ColumnIndex == dgvSlotJadwal.Columns["is_active"].Index && ev.Value != null)
                //    //    {
                //    //        bool isActive = Convert.ToBoolean(ev.Value);
                //    //        ev.Value = isActive ? "✅ Aktif" : "❌ Tidak Aktif";
                //    //        ev.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                //    //    }
                //    //};
                //}
                if (dgvSlotJadwal.Columns.Contains("is_active"))
                    dgvSlotJadwal.Columns["is_active"].HeaderText = "Status";
                // Auto-size columns
                dgvSlotJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BersihkanForm()
        {
            cmbHari.SelectedIndex = -1;
            dtpJamMulai.Value = DateTime.Today.AddHours(9);
            dtpJamSelesai.Value = DateTime.Today.AddHours(10);
            cmbMetode.SelectedIndex = -1;
            tbKuota.Text = "1";
            chkIsActive.Checked = true;
            _selectedJadwalId = 0;

            btnTambah.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }


        private void DgvSlotJadwal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSlotJadwal.SelectedRows.Count <= 0)
                return;

            DataGridViewRow row = dgvSlotJadwal.SelectedRows[0];

            try
            {
                // Pastikan kolom yang diperlukan ada dan nilai tidak null
                if (dgvSlotJadwal.Columns.Contains("jadwal_id") && row.Cells["jadwal_id"].Value != null)
                    _selectedJadwalId = Convert.ToInt32(row.Cells["jadwal_id"].Value);

                if (dgvSlotJadwal.Columns.Contains("hari") && row.Cells["hari"].Value != null)
                {
                    var hariVal = row.Cells["hari"].Value.ToString();
                    if (cmbHari.Items.Contains(hariVal)) cmbHari.SelectedItem = hariVal; else cmbHari.SelectedIndex = -1;
                }

                // jam_mulai may be TimeSpan, DateTime or string; handle gracefully
                if (dgvSlotJadwal.Columns.Contains("jam_mulai") && row.Cells["jam_mulai"].Value != null)
                {
                    var v = row.Cells["jam_mulai"].Value;
                    TimeSpan ts;
                    if (v is TimeSpan) ts = (TimeSpan)v;
                    else if (v is DateTime) ts = ((DateTime)v).TimeOfDay;
                    else if (!TimeSpan.TryParse(v.ToString(), out ts) && DateTime.TryParse(v.ToString(), out var dt)) ts = dt.TimeOfDay;
                    else if (!TimeSpan.TryParse(v.ToString(), out ts)) ts = TimeSpan.Zero;
                    dtpJamMulai.Value = DateTime.Today.Add(ts);
                }

                if (dgvSlotJadwal.Columns.Contains("jam_selesai") && row.Cells["jam_selesai"].Value != null)
                {
                    var v = row.Cells["jam_selesai"].Value;
                    TimeSpan ts;
                    if (v is TimeSpan) ts = (TimeSpan)v;
                    else if (v is DateTime) ts = ((DateTime)v).TimeOfDay;
                    else if (!TimeSpan.TryParse(v.ToString(), out ts) && DateTime.TryParse(v.ToString(), out var dt)) ts = dt.TimeOfDay;
                    else if (!TimeSpan.TryParse(v.ToString(), out ts)) ts = TimeSpan.Zero;
                    dtpJamSelesai.Value = DateTime.Today.Add(ts);
                }

                if (dgvSlotJadwal.Columns.Contains("metode") && row.Cells["metode"].Value != null)
                {
                    var metodeVal = row.Cells["metode"].Value.ToString();
                    if (cmbMetode.Items.Contains(metodeVal)) cmbMetode.SelectedItem = metodeVal; else cmbMetode.SelectedIndex = -1;
                }

                if (dgvSlotJadwal.Columns.Contains("kuota") && row.Cells["kuota"].Value != null)
                    tbKuota.Text = row.Cells["kuota"].Value.ToString();

                if (dgvSlotJadwal.Columns.Contains("is_active") && row.Cells["is_active"].Value != null)
                    chkIsActive.Checked = Convert.ToBoolean(row.Cells["is_active"].Value);

                btnTambah.Enabled = true;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data baris: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (cmbHari.SelectedItem == null)
                {
                    MessageBox.Show("Pilih hari terlebih dahulu!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbMetode.SelectedItem == null)
                {
                    MessageBox.Show("Pilih metode terlebih dahulu!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbKuota.Text, out int kuota) || kuota < 1)
                {
                    MessageBox.Show("Kuota harus berupa angka positif (minimal 1)!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hari = cmbHari.SelectedItem.ToString();
                TimeSpan jamMulai = dtpJamMulai.Value.TimeOfDay;
                TimeSpan jamSelesai = dtpJamSelesai.Value.TimeOfDay;
                string metode = cmbMetode.SelectedItem.ToString();
                bool isActive = chkIsActive.Checked;

                // DEBUG: Tampilkan parameter yang akan dikirim
                MessageBox.Show($"Debug - Parameter:\n\n" +
                    $"psikologId: {_psikologId}\n" +
                    $"hari: {hari}\n" +
                    $"jamMulai: {jamMulai}\n" +
                    $"jamSelesai: {jamSelesai}\n" +
                    $"metode: {metode}\n" +
                    $"kuota: {kuota}\n" +
                    $"isActive: {isActive}",
                    "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bool berhasil = _psikologController.TambahJadwal(_psikologId, hari, jamMulai, jamSelesai, metode, kuota, isActive);

                if (berhasil)
                {
                    MessageBox.Show("Jadwal berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Gagal menambah jadwal: Method mengembalikan false.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // show full exception details to help debugging (stack trace)
                MessageBox.Show($"Gagal menambah jadwal: {ex}\n", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (_selectedJadwalId == 0)
            {
                MessageBox.Show("Pilih jadwal yang akan diubah terlebih dahulu!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validasi input
                if (cmbHari.SelectedItem == null)
                {
                    MessageBox.Show("Pilih hari terlebih dahulu!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbMetode.SelectedItem == null)
                {
                    MessageBox.Show("Pilih metode terlebih dahulu!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbKuota.Text, out int kuota) || kuota < 1)
                {
                    MessageBox.Show("Kuota harus berupa angka positif (minimal 1)!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hari = cmbHari.SelectedItem.ToString();
                TimeSpan jamMulai = dtpJamMulai.Value.TimeOfDay;
                TimeSpan jamSelesai = dtpJamSelesai.Value.TimeOfDay;
                string metode = cmbMetode.SelectedItem.ToString();
                bool isActive = chkIsActive.Checked;

                bool berhasil = _psikologController.UpdateJadwal(_selectedJadwalId, hari, jamMulai, jamSelesai, metode, kuota, isActive);

                if (berhasil)
                {
                    MessageBox.Show("Jadwal berhasil diubah!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengubah jadwal: {ex}\n", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedJadwalId == 0)
            {
                MessageBox.Show("Pilih jadwal yang akan dihapus terlebih dahulu!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus jadwal ini?\n\nJika jadwal sudah memiliki booking, penghapusan akan ditolak.",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = _psikologController.HapusJadwal(_selectedJadwalId);

                    if (berhasil)
                    {
                        MessageBox.Show("Jadwal berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menghapus jadwal: {ex}\n", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }


        // Mengambil data dari baris grid yang diklik user untuk dimasukkan kembali ke form input
        private void dgvSlotJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnKembali_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {

        }
    }
}