using pboFinalProfject.Controllers;
using pboFinalProfject.Model;
using pboFinalProfject.Session;
using pboFinalProfject.Utils;
using pboFinalProfject.View;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormDashboardPsikolog : Form, IFormLoadable
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
            _currentPsikologId = _psikologController.GetPsikologIdByUserId(UserSession.GetCurrentUserId());

            // Hook event handlers
            this.Load += FormDashboardPsikolog_Load;
            btnKelolaJadwal.Click += btnKelolaJadwal_Click;
            dgvPasien.CellClick += DgvPasien_CellClick;

        }

        public void LoadData()
        {  // Load data saat form dibuka
            LoadDaftarPasien();
        }
        public void RefreshData()
        {
            LoadDaftarPasien();
        }
        public void ResetForm()
        {
            // Reset form jika diperlukan (misal setelah update data)
            LoadDaftarPasien();
        }
        public void SetupUIByRole()
        {
            // Atur UI berdasarkan role (jika ada elemen khusus untuk psikolog)
            // Misal: sembunyikan tombol tertentu jika bukan psikolog
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

                if (dgvPasien.Columns.Contains("catatan_user"))
                    dgvPasien.Columns["catatan_user"].Visible = false;

                if (dgvPasien.Columns.Contains("catatan_psikolog"))
                    dgvPasien.Columns["catatan_psikolog"].Visible = false;

                // Atur header kolom
                if (dgvPasien.Columns.Contains("mahasiswa"))
                    dgvPasien.Columns["mahasiswa"].HeaderText = "Nama Mahasiswa";

                if (dgvPasien.Columns.Contains("tgl_booking"))
                    dgvPasien.Columns["tgl_booking"].HeaderText = "Tanggal Booking";

                if (dgvPasien.Columns.Contains("jam_mulai"))
                    dgvPasien.Columns["jam_mulai"].HeaderText = "Jam Mulai";

                if (dgvPasien.Columns.Contains("jam_selesai"))
                    dgvPasien.Columns["jam_selesai"].HeaderText = "Jam Selesai";

                if (dgvPasien.Columns.Contains("metode"))
                    dgvPasien.Columns["metode"].HeaderText = "Metode";

                if (dgvPasien.Columns.Contains("status"))
                    dgvPasien.Columns["status"].HeaderText = "Status";

                // Hapus kolom tombol aksi yang lama jika ada (untuk menghindari duplikasi)
                if (dgvPasien.Columns["btnAksi"] != null)
                    dgvPasien.Columns.Remove("btnAksi");

                // Tambah kolom tombol aksi
                DataGridViewButtonColumn btnAksi = new DataGridViewButtonColumn();
                btnAksi.Name = "btnAksi";
                btnAksi.HeaderText = "Aksi";
                btnAksi.Text = "Proses";
                btnAksi.UseColumnTextForButtonValue = true;
                dgvPasien.Columns.Add(btnAksi);

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

                };
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
            // Validasi dasar
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvPasien.Columns[e.ColumnIndex].Name != "btnAksi") return;

            // Ambil baris yang diklik
            DataGridViewRow row = dgvPasien.Rows[e.RowIndex];

            // Validasi kolom booking_id
            if (!dgvPasien.Columns.Contains("booking_id"))
            {
                MessageBox.Show("Error: Kolom 'booking_id' tidak ditemukan.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object bookingIdObj = row.Cells["booking_id"].Value;
            if (bookingIdObj == null || bookingIdObj == DBNull.Value)
            {
                MessageBox.Show("Error: Data booking tidak valid (ID booking kosong).", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bookingId = Convert.ToInt32(bookingIdObj);

            // Validasi kolom status
            if (!dgvPasien.Columns.Contains("status"))
            {
                MessageBox.Show("Error: Kolom 'status' tidak ditemukan.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string status = row.Cells["status"].Value?.ToString() ?? "";
            status = status.Replace("✅", "").Replace("⏳", "").Replace("❌", "").Replace("✔️", "").Replace("🚫", "").Trim();

            try
            {
                //if (status == "Pending")
                //{
                //    FormDetailBooking form = new FormDetailBooking(bookingId, _currentPsikologId);
                //    form.ShowDialog();
                //    LoadDaftarPasien();
                //}
                //else if (status == "Disetujui")
                //{
                //    FormSelesaikanKonseling form = new FormSelesaikanKonseling(bookingId, _currentPsikologId);
                //    form.ShowDialog();
                //    LoadDaftarPasien();
                //}
                //else
                //{
                //    FormDetailBooking form = new FormDetailBooking(bookingId, _currentPsikologId);
                //    form.ShowDialog();
                //}
                FormDetailBooking form = new FormDetailBooking(bookingId, _currentPsikologId);
                form.ShowDialog();
                LoadDaftarPasien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memproses aksi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Modified: allow optional bookingId. If no id provided (<=0), do nothing.
        //private void ShowDetailBooking(int bookingId = 0)
        //{
        //    // If no booking specified, skip showing details (called from LoadData for initialization)
        //    if (bookingId <= 0) return;

        //    try
        //    {
        //        DataTable dt = _psikologController.GetDetailBookingById(bookingId, _currentPsikologId);
        //        if (dt.Rows.Count > 0)
        //        {
        //            DataRow row = dt.Rows[0];
        //            string detail = $"Detail Konseling\n\n" +
        //                            $"Mahasiswa: {row["mahasiswa"]}\n" +
        //                            $"Tanggal: {Convert.ToDateTime(row["tgl_booking"]):dd MMMM yyyy}\n" +
        //                            $"Jam: {row["jam_mulai"]} - {row["jam_selesai"]}\n" +
        //                            $"Metode: {row["metode"]}\n" +
        //                            $"Status: {row["status"]}\n" +
        //                            $"Catatan Mahasiswa: {row["catatan_user"]}\n" +
        //                            $"Catatan Psikolog: {row["catatan_psikolog"]}\n";

        //            MessageBox.Show(detail, "Detail Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal mengambil detail booking: " + ex.Message,
        //            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            // Buka form kelola jadwal untuk psikolog ini
            FormKelolaJadwal formJadwal = new FormKelolaJadwal(_currentPsikologId);
            formJadwal.ShowDialog();
        }
        private void btnKelolaProfil_Click(object sender, EventArgs e)
        {
            // Buka form kelola profil untuk psikolog ini
            FormKelolaProfil formProfil = new FormKelolaProfil(UserSession.GetCurrentUserId());
            formProfil.ShowDialog();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Tampilkan form login lagi
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Konfirmasi keluar
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}