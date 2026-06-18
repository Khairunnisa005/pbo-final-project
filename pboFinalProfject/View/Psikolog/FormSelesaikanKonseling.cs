using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pboFinalProfject.Services;
using pboFinalProfject.Session;

namespace pboFinalProfject.View
{
    public partial class FormSelesaikanKonseling : Form
    {
        private int _bookingId;
        private int _psikologId;
        private IBookingService _bookingService;

        public FormSelesaikanKonseling(int bookingId, int psikologId)
        {
            InitializeComponent();
            _bookingId = bookingId;
            _psikologId = psikologId;
            _bookingService = new BookingService();

            this.Load += FormSelesaikanKonseling_Load;
            btnSelesaikan.Click += BtnSelesaikan_Click;
            btnBatal.Click += BtnBatal_Click;
        }

        private void FormSelesaikanKonseling_Load(object sender, EventArgs e)
        {
            // Cek akses (hanya psikolog yang bisa menyelesaikan konseling)
            if (!UserSession.IsPsikolog)
            {
                MessageBox.Show("Akses ditolak! Hanya psikolog yang dapat menyelesaikan sesi konseling.",
                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            LoadDataBooking();
        }

        private void LoadDataBooking()
        {
            try
            {
                DataTable dt = _bookingService.GetDetailBookingById(_bookingId, _psikologId);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Isi data booking
                    lblValID.Text = row["booking_id"]?.ToString() ?? "-";
                    lblValNama.Text = row["mahasiswa"]?.ToString() ?? "-";

                    // Format jadwal
                    DateTime tanggal = Convert.ToDateTime(row["created_at"]);
                    object jamMulaiObj = row["jam_mulai"];
                    object jamSelesaiObj = row["jam_selesai"];
                    string metode = row["metode"]?.ToString() ?? "-";

                    string jamMulaiStr = "", jamSelesaiStr = "";

                    // Cek tipe dan konversi
                    if (jamMulaiObj is TimeOnly timeOnly)
                        jamMulaiStr = timeOnly.ToString("HH:mm");
                    else if (jamMulaiObj is TimeSpan timeSpan)
                        jamMulaiStr = timeSpan.ToString(@"hh\:mm");
                    else if (jamMulaiObj != null)
                        jamMulaiStr = jamMulaiObj.ToString()?.Length >= 5 ? jamMulaiObj.ToString().Substring(0, 5) : "??:??";

                    if (jamSelesaiObj is TimeOnly timeOnly2)
                        jamSelesaiStr = timeOnly2.ToString("HH:mm");
                    else if (jamSelesaiObj is TimeSpan timeSpan2)
                        jamSelesaiStr = timeSpan2.ToString(@"hh\:mm");
                    else if (jamSelesaiObj != null)
                        jamSelesaiStr = jamSelesaiObj.ToString()?.Length >= 5 ? jamSelesaiObj.ToString().Substring(0, 5) : "??:??";

                    lblValJadwal.Text = $"{tanggal:dd MMMM yyyy}, {jamMulaiStr} - {jamSelesaiStr} WIB ({metode})";

                    lblValMetode.Text = row["metode"]?.ToString() ?? "-";

                    lblValJamMulai.Text = jamMulaiStr;

                    lblValJamSelesai.Text = jamSelesaiStr;
                    // Isi catatan dari mahasiswa (read-only)
                    txtCatatanUser.Text = row["catatan_user"]?.ToString() ?? "-";

                    // Jika sudah pernah ada catatan psikolog, tampilkan
                    if (row["catatan_psikolog"] != DBNull.Value && !string.IsNullOrEmpty(row["catatan_psikolog"]?.ToString()))
                    {
                        txtCatatanPsikolog.Text = row["catatan_psikolog"]?.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data booking tidak ditemukan.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data booking: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnSelesaikan_Click(object sender, EventArgs e)
        {
            string catatanPsikolog = txtCatatanPsikolog.Text.Trim();

            // Validasi catatan psikolog wajib diisi
            if (string.IsNullOrEmpty(catatanPsikolog))
            {
                MessageBox.Show(
                    "Catatan sesi konseling wajib diisi!\n\n" +
                    "Silakan isi ringkasan sesi konseling, diagnosis, dan rekomendasi untuk mahasiswa.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatatanPsikolog.Focus();
                return;
            }

            // Konfirmasi sebelum menyelesaikan
            DialogResult confirm = MessageBox.Show(
                "Apakah Anda yakin ingin menyelesaikan sesi konseling ini?\n\n" +
                "Setelah diselesaikan, status akan berubah menjadi 'Selesai' dan tidak dapat diubah kembali.\n\n" +
                $"📝 Catatan yang akan disimpan:\n{catatanPsikolog}",
                "Konfirmasi Selesaikan Konseling",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = _bookingService.SelesaikanBooking(_bookingId, catatanPsikolog);

                    if (berhasil)
                    {
                        MessageBox.Show(
                            "✅ Sesi konseling berhasil diselesaikan!\n\n" +
                            "Catatan sesi telah disimpan dan mahasiswa dapat melihat ringkasannya.",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyelesaikan sesi konseling. Silakan coba lagi.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menyelesaikan sesi konseling: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin membatalkan?\n\n" +
                "Catatan yang sudah diisi tidak akan disimpan.",
                "Konfirmasi Batal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSelesaikanKonseling_Load_1(object sender, EventArgs e)
        {

        }
        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            // Buka form kelola jadwal untuk psikolog ini
            // 1. Ambil ID psikolog aktif
            int psikologId = UserSession.GetCurrentUserId();

            // 2. Oper ID ke form tujuan
            FormKelolaJadwal formJadwal = new FormKelolaJadwal(psikologId);

            // 3. Sembunyikan Dashboard (bukan ditutup/dihancurkan)
            this.Close();

            // 4. Tampilkan form jadwal
            formJadwal.Show();
        }
        private void btnKelolaProfil_Click(object sender, EventArgs e)
        {
            // 1. Ambil ID psikolog aktif
            int psikologId = UserSession.GetCurrentUserId();

            // 2. Oper ID ke form tujuan
            FormKelolaProfil formProfil = new FormKelolaProfil(psikologId);

            // 3. Sembunyikan Dashboard (bukan ditutup/dihancurkan)
            this.Close();

            // 4. Tampilkan form profil
            formProfil.Show();
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Konfirmasi keluar
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 1. Tampilkan form login baru
                FormLogin login = new FormLogin();
                login.Show();

                // 2. Clear session data jika diperlukan
                UserSession.Clear();

                // 3. Tutup Form Dashboard saat ini tanpa memicu loop penutupan otomatis
                this.Dispose();
            }
        }
    }
}