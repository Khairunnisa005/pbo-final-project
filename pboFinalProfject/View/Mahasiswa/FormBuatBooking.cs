using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Repositories;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormBuatBooking : Form
    {
        private BookingController _bookingController;
        private PsikologController _psikologController;
        private JadwalRepository _jadwalRepo;
        private int? _editJadwalId;
        private int? _editBookingId;

        public FormBuatBooking()
        {
            InitializeComponent();
            _bookingController = new BookingController();
            _psikologController = new PsikologController();
            _jadwalRepo = new JadwalRepository();

            // wire events
            comboKategori.SelectedIndexChanged += ComboKategori_SelectedIndexChanged;
            comboPsikolog.SelectedIndexChanged += ComboPsikolog_SelectedIndexChanged;
            dgvJadwal.CellDoubleClick += DgvJadwal_CellDoubleClick;
            btnSubmit.Click += BtnSubmit_Click;

            LoadCategories();
        }

        /// <summary>
        /// Constructor untuk mode edit: prefill dengan jadwal tertentu.
        /// </summary>
        public FormBuatBooking(int jadwalId) : this()
        {
            _editJadwalId = jadwalId;
            this.Text = "Edit Jadwal Konsultasi";
            btnSubmit.Text = "Simpan Perubahan";
            LoadEditJadwal(jadwalId);
        }

        /// <summary>
        /// Constructor untuk edit sebuah booking (reschedule) — pass bookingId and set editing flag
        /// </summary>
        public FormBuatBooking(int bookingId, bool isBookingEdit) : this()
        {
            if (isBookingEdit)
            {
                _editBookingId = bookingId;
                this.Text = "Edit Booking";
                btnSubmit.Text = "Simpan Perubahan";
                LoadEditBooking(bookingId);
            }
        }

        private void LoadEditJadwal(int jadwalId)
        {
            try
            {
                var jadwal = _jadwalRepo.GetById(jadwalId);
                if (jadwal == null)
                {
                    MessageBox.Show("Jadwal tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Load all psikolog and select the matching one
                var psikologTable = _psikologController.GetAllPsikolog();
                if (psikologTable == null || psikologTable.Rows.Count == 0)
                {
                    MessageBox.Show("Data psikolog tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Find matching psikolog row
                DataRow matchRow = null;
                foreach (DataRow row in psikologTable.Rows)
                {
                    int pid = Convert.ToInt32(row["psikolog_id"]);
                    if (pid == jadwal.PsikologId)
                    {
                        matchRow = row;
                        break;
                    }
                }

                if (matchRow != null)
                {
                    comboPsikolog.DisplayMember = psikologTable.Columns.Contains("nama_lengkap") ? "nama_lengkap" : "username";
                    comboPsikolog.ValueMember = "psikolog_id";
                    comboPsikolog.DataSource = psikologTable;
                    comboPsikolog.DisplayMember = psikologTable.Columns.Contains("nama_lengkap")
                        ? "nama_lengkap"
                        : "username";
                    comboPsikolog.ValueMember = "psikolog_id";

                    comboPsikolog.SelectedValue = jadwal.PsikologId;
                }

                // Load jadwal for the psikolog
                var jadwalDt = _bookingController.GetJadwalTersediaByPsikolog(jadwal.PsikologId);
                if (jadwalDt != null && jadwalDt.Rows.Count > 0)
                {
                    dgvJadwal.DataSource = jadwalDt;
                    if (dgvJadwal.Columns.Contains("jadwal_id")) dgvJadwal.Columns["jadwal_id"].Visible = false;
                    dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Select the matching jadwal row
                    foreach (DataGridViewRow row in dgvJadwal.Rows)
                    {
                        var val = row.Cells["jadwal_id"].Value;
                        if (val != null && Convert.ToInt32(val) == jadwalId)
                        {
                            row.Selected = true;
                            dgvJadwal.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jadwal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadEditBooking(int bookingId)
        {
            try
            {
                var repo = new BookingRepository();
                var booking = repo.GetById(bookingId);
                if (booking == null)
                {
                    MessageBox.Show("Booking tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // fill catatan and attachment checkbox
                txtCatatan.Text = booking.CatatanUser ?? string.Empty;
                chkAttachAssessment.Checked = booking.HasilAssessmentId.HasValue;

                // show previous booking info (psikolog name, hari and jam, and catatan)
                try
                {
                    var jadwal = _jadwalRepo.GetById(booking.JadwalId);

                    // try to resolve psikolog display name
                    string psikologName = booking.PsikologId.ToString();
                    var psikologDt = _psikologController.GetAllPsikolog();
                    if (psikologDt != null)
                    {
                        foreach (DataRow r in psikologDt.Rows)
                        {
                            if (Convert.ToInt32(r["psikolog_id"]) == booking.PsikologId)
                            {
                                psikologName = psikologDt.Columns.Contains("nama_lengkap") ? (r["nama_lengkap"]?.ToString() ?? r["username"]?.ToString()) : (r["username"]?.ToString() ?? psikologName);
                                break;
                            }
                        }
                    }

                    string hari = jadwal == null ? "-" : (jadwal.Hari ?? "-");
                    string jamMulai = jadwal == null ? "-" : jadwal.JamMulai.ToString();
                    string jamSelesai = jadwal == null ? "-" : jadwal.JamSelesai.ToString();
                    string prev = $"Sebelumnya: Psikolog={psikologName}, Hari={hari}, Jam={jamMulai} - {jamSelesai}";
                    if (!string.IsNullOrEmpty(booking.CatatanUser)) prev += $" | Catatan: {booking.CatatanUser}";
                    if (lblPrevInfo != null) lblPrevInfo.Text = prev;
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string msg = _editJadwalId.HasValue 
                ? "Simpan perubahan untuk jadwal ini?" 
                : "Kirim permintaan booking untuk jadwal ini?";
            var confirm = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                bool ok;
                if (_editBookingId.HasValue)
                {
                    // update existing booking (reschedule)
                    int bookingId = _editBookingId.Value;
                    int psikologId = 0;
                    if (comboPsikolog.SelectedItem != null) psikologId = Convert.ToInt32(((DataRowView)comboPsikolog.SelectedItem)["psikolog_id"]);
                    ok = _bookingController.UpdateBookingJadwal(bookingId, psikologId, jadwalId, catatan);
                    if (ok)
                    {
                        MessageBox.Show("Booking berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ok = _bookingController.BuatBooking(userId, jadwalId, catatan, hasilId);
                    if (ok)
                    {
                        string successMsg = _editJadwalId.HasValue
                            ? "Jadwal berhasil diperbarui."
                            : "Permintaan booking berhasil dikirim.";
                        MessageBox.Show(successMsg, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string errorMsg = _editJadwalId.HasValue
                            ? "Gagal memperbarui jadwal."
                            : "Gagal mengirim permintaan booking.";
                        MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string errTitle = _editJadwalId.HasValue
                    ? "Gagal memperbarui jadwal: "
                    : "Gagal membuat booking: ";
                MessageBox.Show(errTitle + ex.Message + "\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuatBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
