using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pboFinalProfject.Services;
using pboFinalProfject.Session;

namespace pboFinalProfject
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
                    lblValNama.Text = row["mahasiswa_anonim"]?.ToString() ?? "-";

                    // Format jadwal
                    DateTime tanggal = Convert.ToDateTime(row["created_at"]);
                    TimeSpan jamMulai = (TimeSpan)row["jam_mulai"];
                    TimeSpan jamSelesai = (TimeSpan)row["jam_selesai"];
                    lblValJadwal.Text = $"{tanggal:dd MMMM yyyy}, {jamMulai:hh\\:mm} - {jamSelesai:hh\\:mm} WIB";

                    lblValMetode.Text = row["metode"]?.ToString() ?? "-";

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
    }
}