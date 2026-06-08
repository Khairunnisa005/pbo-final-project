using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormBuatBooking : Form
    {
        private BookingController _bookingController;
        private PsikologController _psikologController;

        public FormBuatBooking()
        {
            InitializeComponent();
            _bookingController = new BookingController();
            _psikologController = new PsikologController();

            // wire events
            comboKategori.SelectedIndexChanged += ComboKategori_SelectedIndexChanged;
            comboPsikolog.SelectedIndexChanged += ComboPsikolog_SelectedIndexChanged;
            dgvJadwal.CellDoubleClick += DgvJadwal_CellDoubleClick;
            btnSubmit.Click += BtnSubmit_Click;

            LoadCategories();
        }

        private void LoadCategories()
        {
            // first, try distinct keahlian (skill) table
            var dt = _psikologController.GetDistinctKeahlian();
            comboKategori.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                comboKategori.Items.Add("-- Pilih Kategori --");
                foreach (DataRow r in dt.Rows) comboKategori.Items.Add(r["nama_keahlian"].ToString());
                comboKategori.SelectedIndex = 0;
                comboPsikolog.DataSource = null;
                comboPsikolog.Items.Clear();
                dgvJadwal.DataSource = null;
                return;
            }

            // fallback: use layanan grouping
            dt = _psikologController.GetAllPsikolog();
            if (dt.Columns.Contains("layanan"))
            {
                var cats = dt.AsEnumerable().Select(r => r.Field<string>("layanan") ?? string.Empty).Distinct().Where(s => !string.IsNullOrEmpty(s)).ToList();
                comboKategori.Items.Add("-- Pilih Kategori --");
                comboKategori.Items.AddRange(cats.ToArray());
                comboKategori.SelectedIndex = 0;
                comboPsikolog.DataSource = null;
                comboPsikolog.Items.Clear();
                dgvJadwal.DataSource = null;
            }
            else
            {
                comboKategori.Items.Add("-- Pilih Kategori --");
                comboKategori.Items.Add("Semua");
                comboKategori.SelectedIndex = 0;
            }
        }

        private void ComboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboKategori.SelectedItem?.ToString() ?? string.Empty;
            if (selected == "-- Pilih Kategori --")
            {
                comboPsikolog.DataSource = null;
                comboPsikolog.Items.Clear();
                dgvJadwal.DataSource = null;
                return;
            }
            // Determine whether selected is a keahlian (skill) or a layanan value
            try
            {
                var skills = _psikologController.GetDistinctKeahlian();
                bool isSkill = skills != null && skills.Rows.Cast<DataRow>().Any(r => string.Equals(r["nama_keahlian"].ToString(), selected, StringComparison.OrdinalIgnoreCase));

                DataTable psykTable = null;
                if (isSkill)
                {
                    // load psikologs by keahlian
                    psykTable = _psikologController.GetPsikologByKeahlian(selected);
                }
                else
                {
                    // fallback: filter by layanan or show all
                    var dt = _psikologController.GetAllPsikolog();
                    if (selected == "Semua" || string.IsNullOrEmpty(selected)) psykTable = dt;
                    else
                    {
                        var rows = dt.AsEnumerable().Where(r => (r.Field<string>("layanan") ?? string.Empty) == selected).ToList();
                        if (rows.Count == 0)
                        {
                            comboPsikolog.DataSource = null;
                            comboPsikolog.Items.Clear();
                            return;
                        }
                        psykTable = rows.CopyToDataTable();
                    }
                }

                if (psykTable == null || psykTable.Rows.Count == 0)
                {
                    comboPsikolog.DataSource = null;
                    comboPsikolog.Items.Clear();
                    dgvJadwal.DataSource = null;
                    return;
                }

                comboPsikolog.DisplayMember = psykTable.Columns.Contains("nama_lengkap") ? "nama_lengkap" : "username";
                comboPsikolog.ValueMember = "psikolog_id";
                comboPsikolog.DataSource = psykTable;
                if (comboPsikolog.Items.Count > 0) comboPsikolog.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat psikolog untuk kategori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboPsikolog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPsikolog.SelectedItem == null) return;
            int psikologId = Convert.ToInt32(((DataRowView)comboPsikolog.SelectedItem)["psikolog_id"]);
            var dt = _bookingController.GetJadwalTersediaByPsikolog(psikologId);
            dgvJadwal.DataSource = dt;
            if (dgvJadwal.Columns.Contains("jadwal_id")) dgvJadwal.Columns["jadwal_id"].Visible = false;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // ensure availability column exists
            if (!dgvJadwal.Columns.Contains("sisa_kuota") && !dgvJadwal.Columns.Contains("status_ketersediaan"))
            {
                // nothing to validate, leave as is
            }
        }

        private void DgvJadwal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvJadwal.Rows[e.RowIndex];
            if (!dgvJadwal.Columns.Contains("jadwal_id")) return;
            // validate availability
            if (dgvJadwal.Columns.Contains("sisa_kuota"))
            {
                var sisaObj = row.Cells["sisa_kuota"].Value;
                int sisa = sisaObj == DBNull.Value ? 0 : Convert.ToInt32(sisaObj);
                if (sisa <= 0)
                {
                    MessageBox.Show("Slot ini sudah penuh.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (dgvJadwal.Columns.Contains("status_ketersediaan"))
            {
                var status = (row.Cells["status_ketersediaan"].Value ?? string.Empty).ToString();
                if (!status.Equals("Tersedia", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Slot ini tidak tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            int jadwalId = Convert.ToInt32(row.Cells["jadwal_id"].Value);
            SubmitBooking(jadwalId);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih jadwal terlebih dahulu (klik baris atau double-click).", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvJadwal.SelectedRows[0];
            if (!dgvJadwal.Columns.Contains("jadwal_id")) return;
            int jadwalId = Convert.ToInt32(row.Cells["jadwal_id"].Value);
            SubmitBooking(jadwalId);
        }

        private void SubmitBooking(int jadwalId)
        {
            var confirm = MessageBox.Show("Kirim permintaan booking untuk jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int userId = UserSession.GetCurrentUserId();
                int? hasilId = null;

                // sanitize and limit catatan length
                var catatan = (txtCatatan.Text ?? string.Empty).Trim();
                if (catatan.Length > 1000) catatan = catatan.Substring(0, 1000);

                if (chkAttachAssessment.Checked)
                {
                    var ctrl = new MahasiswaController();
                    var hasil = ctrl.GetLatestHasil(userId);
                    if (hasil == null)
                    {
                        var ask = MessageBox.Show("Tidak ditemukan hasil kuisioner terbaru. Lanjutkan tanpa melampirkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.No) return;
                        // continue without attachment
                    }
                    else
                    {
                        hasilId = hasil.HasilId;
                    }
                }

                bool ok = _bookingController.BuatBooking(userId, jadwalId, catatan, hasilId);
                if (ok)
                {
                    MessageBox.Show("Permintaan booking berhasil dikirim.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal mengirim permintaan booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // show full exception to help debugging in development
                MessageBox.Show("Gagal membuat booking: " + ex.Message + "\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
