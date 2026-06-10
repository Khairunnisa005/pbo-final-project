using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pboFinalProfject.Services;
using pboFinalProfject.Session;

namespace pboFinalProfject.View
{
    public partial class FormKonfirmasiBooking : Form
    {
        private int _bookingId;
        private int _psikologId;
        private IBookingService _bookingService;

        public FormKonfirmasiBooking(int bookingId, int psikologId)
        {
            InitializeComponent();
            _bookingId = bookingId;
            _psikologId = psikologId;
            _bookingService = new BookingService();

            this.Load += FormKonfirmasiBooking_Load;
            btnKembali.Click += BtnKembali_Click;

            lblID.Click += lblID_Click;
        }

        private void FormKonfirmasiBooking_Load(object sender, EventArgs e)
        {
            // Cek akses (hanya psikolog yang bisa konfirmasi)
            if (!UserSession.IsPsikolog)
            {
                MessageBox.Show("Akses ditolak! Hanya psikolog yang dapat mengkonfirmasi booking.",
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

                    // Isi data ke label
                    lblValID.Text = row["booking_id"]?.ToString() ?? "-";
                    lblValNama.Text = row["mahasiswa"]?.ToString() ?? "-";

                    // Format jadwal
                    DateTime tanggal = Convert.ToDateTime(row["created_at"]);
                    TimeSpan jamMulai = (TimeSpan)row["jam_mulai"];
                    TimeSpan jamSelesai = (TimeSpan)row["jam_selesai"];
                    string metode = row["metode"]?.ToString() ?? "-";

                    lblValJadwal.Text = $"{tanggal:dd MMMM yyyy}, {jamMulai:hh\\:mm} - {jamSelesai:hh\\:mm} WIB ({metode})";
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

        private void btnSetuju_Click(object sender, EventArgs e)
        {
            try
            {
                // Konfirmasi sebelum menyetujui
                DialogResult confirm = MessageBox.Show(
                    "Apakah Anda yakin ingin menyetujui permintaan konseling ini?\n\n" +
                    "Setelah disetujui, mahasiswa akan menerima konfirmasi dan sesi konseling akan dijadwalkan.",
                    "Konfirmasi Setujui",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool berhasil = _bookingService.SetujuiBooking(_bookingId);

                    if (berhasil)
                    {
                        MessageBox.Show("Booking berhasil disetujui!\n\n" +
                            "Mahasiswa akan segera mendapat konfirmasi.",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyetujui booking. Silakan coba lagi.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyetujui booking: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Tampilkan opsi: kembali atau tolak
            DialogResult result = MessageBox.Show(
                "Pilih tindakan:\n\n" +
                "• [Ya] - Tolak permintaan (beri alasan)\n" +
                "• [Tidak] - Kembali ke halaman sebelumnya",
                "Konfirmasi",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Tolak booking
                TolakBooking();
            }
            else if (result == DialogResult.No)
            {
                // Kembali (tutup form saja)
                this.Close();
            }
            // Cancel -> tidak melakukan apa-apa
        }

        private void TolakBooking()
        {
            // Form input alasan penolakan
            Form inputForm = new Form();
            inputForm.Text = "Alasan Penolakan";
            inputForm.Size = new Size(450, 200);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;

            Label lblAlasan = new Label();
            lblAlasan.Text = "Alasan penolakan (wajib diisi):";
            lblAlasan.Location = new Point(12, 15);
            lblAlasan.Size = new Size(400, 25);

            TextBox txtAlasan = new TextBox();
            txtAlasan.Location = new Point(12, 45);
            txtAlasan.Size = new Size(410, 80);
            txtAlasan.Multiline = true;
            txtAlasan.ScrollBars = ScrollBars.Vertical;

            Button btnKirim = new Button();
            btnKirim.Text = "Kirim Penolakan";
            btnKirim.Location = new Point(250, 135);
            btnKirim.Size = new Size(170, 30);
            btnKirim.BackColor = Color.FromArgb(198, 40, 40);
            btnKirim.ForeColor = Color.White;
            btnKirim.FlatStyle = FlatStyle.Flat;

            Button btnBatalForm = new Button();
            btnBatalForm.Text = "Batal";
            btnBatalForm.Location = new Point(160, 135);
            btnBatalForm.Size = new Size(80, 30);

            btnKirim.Click += (s, ev) =>
            {
                string alasan = txtAlasan.Text.Trim();
                if (string.IsNullOrEmpty(alasan))
                {
                    MessageBox.Show("Alasan penolakan harus diisi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    bool berhasil = _bookingService.TolakBooking(_bookingId, alasan);
                    if (berhasil)
                    {
                        MessageBox.Show("Booking berhasil ditolak.\n\n" +
                            $"Alasan: {alasan}",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inputForm.DialogResult = DialogResult.OK;
                        inputForm.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menolak booking. Silakan coba lagi.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menolak booking: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnBatalForm.Click += (s, ev) => inputForm.Close();

            inputForm.Controls.Add(lblAlasan);
            inputForm.Controls.Add(txtAlasan);
            inputForm.Controls.Add(btnKirim);
            inputForm.Controls.Add(btnBatalForm);

            inputForm.ShowDialog(this);
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {
            // Event handler kosong (tidak diperlukan, tapi tidak boleh dihapus)
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}