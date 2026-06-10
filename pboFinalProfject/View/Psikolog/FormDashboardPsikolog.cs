using pboFinalProfject.Controllers;
using pboFinalProfject.Model;
using pboFinalProfject.Session;
using pboFinalProfject.Utils;
using pboFinalProfject.View;
using System;
using System.Data;

namespace pboFinalProfject.View
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
            btnKelolaJadwal.Click += btnKelolaJadwal_Click;

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

            // Ambil psikolog_id dari user yang login
            int userId = UserSession.GetCurrentUserId();
            _currentPsikologId = _psikologController.GetPsikologIdByUserId(userId);

            if (_currentPsikologId == 0)
            {
                MessageBox.Show("Data psikolog tidak ditemukan. Silakan hubungi admin.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dgvPasien.Columns.Contains("mahasiswa"))
                    dgvPasien.Columns["mahasiswa"].HeaderText = "Nama Mahasiswa";

                if (dgvPasien.Columns.Contains("jam_mulai"))
                    dgvPasien.Columns["jam_mulai"].HeaderText = "Jam Mulai";

                if (dgvPasien.Columns.Contains("jam_selesai"))
                    dgvPasien.Columns["jam_selesai"].HeaderText = "Jam Selesai";

                if (dgvPasien.Columns.Contains("metode"))
                    dgvPasien.Columns["metode"].HeaderText = "Metode";

                if (dgvPasien.Columns.Contains("status"))
                    dgvPasien.Columns["status"].HeaderText = "Status";

                if (dgvPasien.Columns.Contains("tgl_booking"))
                    dgvPasien.Columns["tgl_booking"].HeaderText = "Tanggal Booking";

                // Format tampilan tanggal (created_at)
                dgvPasien.CellFormatting += (s, ev) =>
                {
                    if (ev.ColumnIndex == dgvPasien.Columns["tgl_booking"]?.Index && ev.Value != null)
                    {
                        DateTime tanggal = Convert.ToDateTime(ev.Value);
                        ev.Value = tanggal.ToString("dd MMM yyyy");
                        ev.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    // Warna status
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

                    // Format jam (Berlaku untuk jam_mulai dan jam_selesai)
                    if ((ev.ColumnIndex == dgvPasien.Columns["jam_mulai"]?.Index ||
                         ev.ColumnIndex == dgvPasien.Columns["jam_selesai"]?.Index) && ev.Value != null)
                    {
                        // Cek jika tipenya TimeOnly (bawaan PostgreSQL di .NET baru)
                    // Support both TimeOnly (newer providers) and TimeSpan
                    if (ev.Value is TimeOnly jamOnly)
                    {
                        ev.Value = jamOnly.ToString("HH:mm"); // Format 24 jam
                    }
                    else if (ev.Value is TimeSpan jamSpan)
                    {
                        ev.Value = jamSpan.ToString(@"hh\:mm");
                    }
                    else if (ev.Value is string)
                    {
                        var sval = ev.Value.ToString();
                        if (TimeOnly.TryParse(sval, out var t)) ev.Value = t.ToString("HH:mm");
                        else if (TimeSpan.TryParse(sval, out var ts)) ev.Value = ts.ToString(@"hh\:mm");
                    }

                        // Atur posisi teks di tengah-tengah cell
                        ev.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    //// Format jam
                    //if (ev.ColumnIndex == dgvPasien.Columns["jam_mulai"]?.Index && ev.Value != null)
                    //{
                    //    TimeSpan jam = (TimeSpan)ev.Value;
                    //    ev.Value = jam.ToString(@"hh\:mm");
                    //    ev.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //}

                    //if (ev.ColumnIndex == dgvPasien.Columns["jam_selesai"]?.Index && ev.Value != null)
                    //{
                    //    TimeSpan jam = (TimeSpan)ev.Value;
                    //    ev.Value = jam.ToString(@"hh\:mm");
                    //    ev.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //}
                };

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
                    FormKonfirmasiBooking formKonfirmasi = new FormKonfirmasiBooking(bookingId, _currentPsikologId);
                    formKonfirmasi.ShowDialog();
                    LoadDaftarPasien(); // Refresh
                }
                else if (status == "Disetujui")
                {
                    FormSelesaikanKonseling formSelesaikan = new FormSelesaikanKonseling(bookingId, _currentPsikologId);
                    formSelesaikan.ShowDialog();
                    LoadDaftarPasien(); // Refresh
                }
                else
                {
                    FormDetailBooking formDetail = new FormDetailBooking(bookingId, _currentPsikologId);
                    formDetail.ShowDialog();
                }

                ShowDetailBooking(bookingId);

                //if (status == "Pending")
                //{
                //    // Buka form konfirmasi booking
                //    FormKonfirmasiBooking formKonfirmasi = new FormKonfirmasiBooking(bookingId, _currentPsikologId);
                //    formKonfirmasi.ShowDialog();
                //    LoadDaftarPasien(); // Refresh setelah konfirmasi
                //}
                //else if (status == "Disetujui")
                //{
                //    // Buka form selesaikan konseling
                //    FormSelesaikanKonseling formSelesaikan = new FormSelesaikanKonseling(bookingId, _currentPsikologId);
                //    formSelesaikan.ShowDialog();
                //    LoadDaftarPasien(); // Refresh setelah selesai
                //}
                //else
                //{
                //    // Tampilkan detail booking
                //    ShowDetailBooking(bookingId);
                //}
            }
        }

        private void ShowDetailBooking(int bookingId)
        {
            try
            {
                DataTable dt = _psikologController.GetDetailBookingById(bookingId, _currentPsikologId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string detail = $"Detail Konseling\n\n" +
                                    $"Mahasiswa: {row["mahasiswa"]}\n" +
                                    $"Tanggal: {Convert.ToDateTime(row["tgl_booking"]):dd MMMM yyyy}\n" +
                                    $"Jam: {row["jam_mulai"]} - {row["jam_selesai"]}\n" +
                                    $"Metode: {row["metode"]}\n" +
                                    $"Status: {row["status"]}\n" +
                                    $"Catatan Mahasiswa: {row["catatan_user"]}\n" +
                                    $"Catatan Psikolog: {row["catatan_psikolog"]}\n";

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
            //base.OnFormClosed(e);
            //// Optional: Logout atau kembali ke form login
            //_authController.Logout(this);

            // Mematikan seluruh proses aplikasi secara bersih, termasuk form yang di-hide
            Application.Exit();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {

        }
    }
}