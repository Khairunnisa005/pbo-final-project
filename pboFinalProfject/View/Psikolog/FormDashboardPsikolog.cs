using pboFinalProfject.Controllers;
using pboFinalProfject.Model;
using pboFinalProfject.Session;
using pboFinalProfject.Utils;
using pboFinalProfject.View;
using System;
using System.Data;

namespace pboFinalProfject
{
    public partial class FormDashboardPsikolog : Form
    {
        private PsikologController _psikologController;
        private AuthController _authController;
        private int _currentPsikologId;

        // Tweak Konstruktor: Tambahkan parameter string untuk menangkap nama
        public FormDashboardPsikolog()
        {
            InitializeComponent();
            _psikologController = new PsikologController();
            _authController = new AuthController();

            // Hook event handlers
            this.Load += FormDashboardPsikolog_Load;
        }

        private void FormDashboardPsikolog_Load(object sender, EventArgs e)
        {
            // Cek apakah user yang login adalah Psikolog
            if (!UserSession.IsPsikolog)
            {
                MessageBox.Show("Akses ditolak! Hanya psikolog yang dapat mengakses halaman ini.",
                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            // Load data
            LoadDaftarPasien();
        }

        private void LoadDaftarPasien()
        {
            try
            {
                // Ambil daftar pasien (mahasiswa yang booking dengan psikolog ini)
                DataTable dt = _psikologController.GetDaftarPasienByPsikologId(_currentPsikologId);
                dgvPasien.DataSource = dt;

                // Sembunyikan kolom yang tidak perlu
                if (dgvPasien.Columns.Contains("booking_id"))
                    dgvPasien.Columns["booking_id"].Visible = false;

                if (dgvPasien.Columns.Contains("psikolog_id"))
                    dgvPasien.Columns["psikolog_id"].Visible = false;

                if (dgvPasien.Columns.Contains("user_id"))
                    dgvPasien.Columns["user_id"].Visible = false;

                // Atur header kolom
                if (dgvPasien.Columns.Contains("mahasiswa_anonim"))
                    dgvPasien.Columns["mahasiswa_anonim"].HeaderText = "Nama Mahasiswa";

                if (dgvPasien.Columns.Contains("created_at"))
                    dgvPasien.Columns["created_at"].HeaderText = "Tanggal Konseling";

                if (dgvPasien.Columns.Contains("jam_mulai"))
                    dgvPasien.Columns["jam_mulai"].HeaderText = "Jam Mulai";

                if (dgvPasien.Columns.Contains("jam_selesai"))
                    dgvPasien.Columns["jam_selesai"].HeaderText = "Jam Selesai";

                if (dgvPasien.Columns.Contains("metode"))
                    dgvPasien.Columns["metode"].HeaderText = "Metode";

                if (dgvPasien.Columns.Contains("status"))
                    dgvPasien.Columns["status"].HeaderText = "Status";

                // Tambahkan kolom tombol aksi jika belum ada
                if (dgvPasien.Columns["btnAksi"] == null)
                {
                    DataGridViewButtonColumn btnAksi = new DataGridViewButtonColumn();
                    btnAksi.Name = "btnAksi";
                    btnAksi.HeaderText = "Aksi";
                    btnAksi.Text = "Proses";
                    btnAksi.UseColumnTextForButtonValue = true;
                    dgvPasien.Columns.Add(btnAksi);
                }

                // Warna status
                dgvPasien.CellFormatting += (s, ev) =>
                {
                    if (ev.ColumnIndex == dgvPasien.Columns["status"]?.Index && ev.Value != null)
                    {
                        string status = ev.Value.ToString();
                        switch (status)
                        {
                            case "Disetujui":
                                ev.CellStyle.ForeColor = Color.Green;
                                ev.Value = "✅ Disetujui";
                                break;
                            case "Pending":
                                ev.CellStyle.ForeColor = Color.Orange;
                                ev.Value = "⏳ Pending";
                                break;
                            case "Ditolak":
                                ev.CellStyle.ForeColor = Color.Red;
                                ev.Value = "❌ Ditolak";
                                break;
                            case "Selesai":
                                ev.CellStyle.ForeColor = Color.Blue;
                                ev.Value = "✔️ Selesai";
                                break;
                            case "Batal":
                                ev.CellStyle.ForeColor = Color.Gray;
                                ev.Value = "🚫 Batal";
                                break;
                        }
                    }
                };

                // Event klik untuk tombol aksi
                dgvPasien.CellClick += DgvPasien_CellClick;

                // Atur auto-size columns
                dgvPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar pasien: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Jika klik pada kolom tombol aksi
            if (e.RowIndex >= 0 && dgvPasien.Columns[e.ColumnIndex].Name == "btnAksi")
            {
                int bookingId = Convert.ToInt32(dgvPasien.Rows[e.RowIndex].Cells["booking_id"].Value);
                string status = dgvPasien.Rows[e.RowIndex].Cells["status"].Value.ToString();

                // Hapus simbol emoji jika ada
                status = status.Replace("✅", "").Replace("⏳", "").Replace("❌", "").Replace("✔️", "").Replace("🚫", "").Trim();

                if (status == "Pending")
                {
                    // Buka form konfirmasi booking
                    FormKonfirmasiBooking formKonfirmasi = new FormKonfirmasiBooking(bookingId, _currentPsikologId);
                    formKonfirmasi.ShowDialog();
                    LoadDaftarPasien(); // Refresh setelah konfirmasi
                }
                else if (status == "Disetujui")
                {
                    // Buka form selesaikan konseling
                    FormSelesaikanKonseling formSelesaikan = new FormSelesaikanKonseling(bookingId, _currentPsikologId);
                    formSelesaikan.ShowDialog();
                    LoadDaftarPasien(); // Refresh setelah selesai
                }
                else
                {
                    // Tampilkan detail booking
                    ShowDetailBooking(bookingId);
                }
            }
        }

        private void ShowDetailBooking(int bookingId)
        {
            try
            {
                DataTable dt = _psikologController.GetDetailBookingById(bookingId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string detail = $"Detail Konseling\n\n" +
                                    $"Mahasiswa: {row["mahasiswa_anonim"]}\n" +
                                    $"Tanggal: {Convert.ToDateTime(row["created_at"]):dd MMMM yyyy}\n" +
                                    $"Jam: {row["jam_mulai"]} - {row["jam_selesai"]}\n" +
                                    $"Metode: {row["metode"]}\n" +
                                    $"Status: {row["status"]}\n" +
                                    $"Catatan Mahasiswa: {row["catatan_user"]}\n" +
                                    $"Catatan Psikolog: {row["catatan_psikolog"]}";

                    MessageBox.Show(detail, "Detail Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil detail booking: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            // Buka form kelola jadwal untuk psikolog ini
            FormKelolaJadwal formJadwal = new FormKelolaJadwal(_currentPsikologId);
            formJadwal.ShowDialog();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Optional: Logout atau kembali ke form login
            // _authController.Logout(this);
        }
    }
}