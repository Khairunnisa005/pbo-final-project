
using pboFinalProfject.Services;
using pboFinalProfject.Session;
using pboFinalProfject.View;
using pboFinalProfject.View;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pboFinalProfject
{
    public partial class FormDetailBooking : Form
    {
        private int _bookingId;
        private int _psikologId;
        private IBookingService _bookingService;
        private string _currentStatus;

        // Konstruktor menerima bookingId dan psikologId
        public FormDetailBooking(int bookingId, int psikologId)
        {
            InitializeComponent();
            _bookingId = bookingId;
            _psikologId = psikologId;
            _bookingService = new BookingService();

            // Hook event
            this.Load += FormDetailBooking_Load;
            btnTutup.Click += BtnTutup_Click;
            btnAksiUtama.Click += BtnAksiUtama_Click;
        }

        private void FormDetailBooking_Load(object sender, EventArgs e)
        {
            // Cek akses (hanya psikolog yang bisa melihat detail booking)
            if (!UserSession.IsPsikolog)
            {
                MessageBox.Show("Akses ditolak! Hanya psikolog yang dapat mengakses halaman ini.",
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

                    // Isi data ke komponen form
                    lblValIDBooking.Text = row["booking_id"]?.ToString() ?? "-";
                    lblValNamaKonseli.Text = row["mahasiswa_anonim"]?.ToString() ?? "-";
                    lblValKonselor.Text = row["psikolog_nama"]?.ToString() ?? "-";

                    // Format tanggal dan jam
                    DateTime tanggal = Convert.ToDateTime(row["tanggal_booking"]);
                    TimeSpan jamMulai = (TimeSpan)row["jam_mulai"];
                    TimeSpan jamSelesai = (TimeSpan)row["jam_selesai"];
                    lblValJadwal.Text = $"{tanggal:dd MMMM yyyy}, {jamMulai:hh\\:mm} - {jamSelesai:hh\\:mm} WIB";

                    lblValTipe.Text = row["metode"]?.ToString() ?? "-";
                    txtValKeluhan.Text = row["catatan_user"]?.ToString() ?? "-";
                    _currentStatus = row["status"]?.ToString() ?? "Pending";

                    //// Tampilkan hasil screening jika ada
                    if (row["tingkat_stres"] != DBNull.Value && !string.IsNullOrEmpty(row["tingkat_stres"]?.ToString()))
                    {
                        lblHasilScreening.Visible = true;
                        panelScreening.Visible = true;
                        lblValTingkatStres.Text = row["tingkat_stres"]?.ToString() ?? "-";
                        lblValSkorTotal.Text = row["skor_total"]?.ToString() ?? "-";
                        txtValRekomendasi.Text = row["rekomendasi"]?.ToString() ?? "-";
                    }
                    else
                    {
                        lblHasilScreening.Visible = false;
                        panelScreening.Visible = false;
                    }

                    // Atur warna status
                    AturKomponenStatus(_currentStatus);

                    // Atur tombol aksi berdasarkan status
                    AturTombolAksi(_currentStatus);
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
                MessageBox.Show("Gagal mengambil data booking: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AturKomponenStatus(string status)
        {
            string statusLower = status.ToLower();

            if (statusLower == "disetujui")
            {
                lblValStatus.ForeColor = Color.FromArgb(46, 125, 50);
                panelStatus.BackColor = Color.FromArgb(232, 245, 233);
                lblValStatus.Text = "✓ DISETUJUI";
            }
            else if (statusLower == "selesai")
            {
                lblValStatus.ForeColor = Color.FromArgb(46, 125, 50);
                panelStatus.BackColor = Color.FromArgb(232, 245, 233);
                lblValStatus.Text = "✔️ SELESAI";
            }
            else if (statusLower == "pending")
            {
                lblValStatus.ForeColor = Color.FromArgb(216, 111, 0);
                panelStatus.BackColor = Color.FromArgb(255, 243, 224);
                lblValStatus.Text = "⏳ PENDING";
            }
            else if (statusLower == "ditolak")
            {
                lblValStatus.ForeColor = Color.FromArgb(198, 40, 40);
                panelStatus.BackColor = Color.FromArgb(255, 235, 235);
                lblValStatus.Text = "✗ DITOLAK";
            }
            else if (statusLower == "batal")
            {
                lblValStatus.ForeColor = Color.FromArgb(198, 40, 40);
                panelStatus.BackColor = Color.FromArgb(255, 235, 235);
                lblValStatus.Text = "✗ DIBATALKAN";
            }
            else
            {
                lblValStatus.Text = status.ToUpper();
            }
        }

        private void AturTombolAksi(string status)
        {
            switch (status.ToLower())
            {
                case "pending":
                    btnAksiUtama.Text = "✓ Setujui Konseling";
                    btnAksiUtama.BackColor = Color.FromArgb(46, 125, 50);
                    btnAksiUtama.Enabled = true;
                    break;
                case "disetujui":
                    btnAksiUtama.Text = "✔️ Selesaikan Konseling";
                    btnAksiUtama.BackColor = Color.FromArgb(41, 128, 185);
                    btnAksiUtama.Enabled = true;
                    break;
                case "selesai":
                    btnAksiUtama.Text = "📋 Lihat Ringkasan";
                    btnAksiUtama.BackColor = Color.FromArgb(52, 73, 94);
                    btnAksiUtama.Enabled = true;
                    break;
                default:
                    btnAksiUtama.Text = "Tidak Ada Aksi";
                    btnAksiUtama.BackColor = Color.Gray;
                    btnAksiUtama.Enabled = false;
                    break;
            }
        }

        private void BtnAksiUtama_Click(object sender, EventArgs e)
        {
            string status = _currentStatus.ToLower();

            if (status == "pending")
            {
                // Buka form konfirmasi booking
                FormKonfirmasiBooking formKonfirmasi = new FormKonfirmasiBooking(_bookingId, _psikologId);
                formKonfirmasi.ShowDialog();
                this.Close(); // Tutup form detail setelah konfirmasi
            }
            else if (status == "disetujui")
            {
                // Buka form selesaikan konseling
                FormSelesaikanKonseling formSelesaikan = new FormSelesaikanKonseling(_bookingId, _psikologId);
                formSelesaikan.ShowDialog();
                this.Close(); // Tutup form detail setelah selesai
            }
            else if (status == "selesai")
            {
                // Tampilkan ringkasan konseling
                TampilkanRingkasanKonseling();
            }
        }

        private void TampilkanRingkasanKonseling()
        {
            try
            {
                DataTable dt = _bookingService.GetDetailBookingById(_bookingId, _psikologId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string catatanPsikolog = row["catatan_psikolog"]?.ToString() ?? "-";
                    string tingkatStres = row["tingkat_stres"]?.ToString() ?? "-";
                    string rekomendasi = row["rekomendasi"]?.ToString() ?? "-";

                    string pesan = $"📋 RINGKASAN KONSELING\n\n" +
                                   $"ID Booking: {_bookingId}\n" +
                                   $"Status: SELESAI\n\n" +
                                   $"📊 Hasil Screening:\n" +
                                   $"   Tingkat Stres: {tingkatStres}\n" +
                                   $"   Rekomendasi: {rekomendasi}\n\n" +
                                   $"📝 Catatan Psikolog:\n{catatanPsikolog}\n\n" +
                                   $"Terima kasih telah menyelesaikan sesi konseling.";

                    MessageBox.Show(pesan, "Ringkasan Konseling",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil ringkasan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//using Npgsql;
//using pboFinalProfject.Controllers;
//using pboFinalProfject.Model;
//using pboFinalProfject.Session;
//using pboFinalProfject.Utils;
//using pboFinalProfject.View;
//using System;
//using System.Data; // Diperlukan jika Database Helper mengembalikan DataTable
//using System.Drawing;
//using System.Windows.Forms;

//namespace pboFinalProfject
//{
//    public partial class FormDetailBooking : Form
//    {
//        private int _bookingId;
//        private int _psikologId;
//        private BookingController _bookingController;
//        private string _currentStatus;

//        // Konstruktor menerima bookingId dan psikologId
//        public FormDetailBooking(int bookingId, int psikologId)
//        {
//            InitializeComponent();
//            _bookingId = bookingId;
//            _psikologId = psikologId;
//            _bookingController = new BookingController();

//            // Hook event
//            this.Load += FormDetailBooking_Load;
//            btnTutup.Click += BtnTutup_Click;
//            btnAksiUtama.Click += BtnAksiUtama_Click;
//        }

//        // Event load form untuk memicu pengambilan data saat form pertama kali dibuka
//        private void FormDetailBooking_Load(object sender, EventArgs e)
//        {
//            // Cek akses (hanya psikolog yang bisa melihat detail booking)
//            if (!UserSession.IsPsikolog)
//            {
//                MessageBox.Show("Akses ditolak! Hanya psikolog yang dapat mengakses halaman ini.",
//                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                this.Close();
//                return;
//            }

//            LoadDataBooking();
//        }

//        private void LoadDataBooking()
//        {
//            try
//            {
//                DataTable dt = _bookingController.GetDetailBookingById(_bookingId, _psikologId);

//                if (dt.Rows.Count > 0)
//                {
//                    DataRow row = dt.Rows[0];

//                    // Isi data ke komponen form
//                    lblValIDBooking.Text = row["booking_id"]?.ToString() ?? "-";
//                    lblValNamaKonseli.Text = row["mahasiswa_anonim"]?.ToString() ?? "-";
//                    lblValKonselor.Text = row["psikolog_nama"]?.ToString() ?? "-";

//                    // Format tanggal dan jam
//                    DateTime tanggal = Convert.ToDateTime(row["tanggal_booking"]);
//                    TimeSpan jamMulai = (TimeSpan)row["jam_mulai"];
//                    TimeSpan jamSelesai = (TimeSpan)row["jam_selesai"];
//                    lblValJadwal.Text = $"{tanggal:dd MMMM yyyy}, {jamMulai:hh\\:mm} - {jamSelesai:hh\\:mm} WIB";

//                    lblValTipe.Text = row["metode"]?.ToString() ?? "-";
//                    txtValKeluhan.Text = row["catatan_user"]?.ToString() ?? "-";
//                    _currentStatus = row["status"]?.ToString() ?? "Pending";

//                    // Atur warna status
//                    AturKomponenStatus(_currentStatus);

//                    // Atur tombol aksi berdasarkan status
//                    AturTombolAksi(_currentStatus);
//                }
//                else
//                {
//                    MessageBox.Show("Data booking tidak ditemukan.", "Error",
//                        MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    this.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Gagal mengambil data booking: " + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                this.Close();
//            }
//        }


//        private void AturKomponenStatus(string status)
//        {
//            string statusText = status.ToUpper();
//            lblValStatus.Text = statusText;

//            if (status.ToLower() == "disetujui")
//            {
//                lblValStatus.ForeColor = Color.FromArgb(46, 125, 50);
//                panelStatus.BackColor = Color.FromArgb(232, 245, 233);
//                lblValStatus.Text = "✓ DISETUJUI";
//            }
//            else if (status.ToLower() == "selesai")
//            {
//                lblValStatus.ForeColor = Color.FromArgb(46, 125, 50);
//                panelStatus.BackColor = Color.FromArgb(232, 245, 233);
//                lblValStatus.Text = "✔️ SELESAI";
//            }
//            else if (status.ToLower() == "pending")
//            {
//                lblValStatus.ForeColor = Color.FromArgb(216, 111, 0);
//                panelStatus.BackColor = Color.FromArgb(255, 243, 224);
//                lblValStatus.Text = "⏳ PENDING";
//            }
//            else if (status.ToLower() == "ditolak")
//            {
//                lblValStatus.ForeColor = Color.FromArgb(198, 40, 40);
//                panelStatus.BackColor = Color.FromArgb(255, 235, 235);
//                lblValStatus.Text = "✗ DITOLAK";
//            }
//            else if (status.ToLower() == "batal")
//            {
//                lblValStatus.ForeColor = Color.FromArgb(198, 40, 40);
//                panelStatus.BackColor = Color.FromArgb(255, 235, 235);
//                lblValStatus.Text = "✗ DIBATALKAN";
//            }
//        }

//        private void AturTombolAksi(string status)
//        {
//            switch (status.ToLower())
//            {
//                case "pending":
//                    btnAksiUtama.Text = "✓ Setujui Konseling";
//                    btnAksiUtama.BackColor = Color.FromArgb(46, 125, 50);
//                    btnAksiUtama.Enabled = true;
//                    break;
//                case "disetujui":
//                    btnAksiUtama.Text = "✔️ Selesaikan Konseling";
//                    btnAksiUtama.BackColor = Color.FromArgb(41, 128, 185);
//                    btnAksiUtama.Enabled = true;
//                    break;
//                case "selesai":
//                    btnAksiUtama.Text = "📋 Lihat Ringkasan";
//                    btnAksiUtama.BackColor = Color.FromArgb(52, 73, 94);
//                    btnAksiUtama.Enabled = true;
//                    break;
//                default:
//                    btnAksiUtama.Text = "Tidak Ada Aksi";
//                    btnAksiUtama.BackColor = Color.Gray;
//                    btnAksiUtama.Enabled = false;
//                    break;
//            }
//        }


//        private void BtnAksiUtama_Click(object sender, EventArgs e)
//        {
//            string status = _currentStatus.ToLower();

//            if (status == "pending")
//            {
//                // Buka form konfirmasi booking
//                FormKonfirmasiBooking formKonfirmasi = new FormKonfirmasiBooking(_bookingId, _psikologId);
//                formKonfirmasi.ShowDialog();
//                this.Close(); // Tutup form detail setelah konfirmasi
//            }
//            else if (status == "disetujui")
//            {
//                // Buka form selesaikan konseling
//                FormSelesaikanKonseling formSelesaikan = new FormSelesaikanKonseling(_bookingId, _psikologId);
//                formSelesaikan.ShowDialog();
//                this.Close(); // Tutup form detail setelah selesai
//            }
//            else if (status == "selesai")
//            {
//                // Tampilkan ringkasan konseling
//                TampilkanRingkasanKonseling();
//            }
//        }

//        private void TampilkanRingkasanKonseling()
//        {
//            try
//            {
//                DataTable dt = _bookingController.GetDetailBookingById(_bookingId, _psikologId);
//                if (dt.Rows.Count > 0)
//                {
//                    DataRow row = dt.Rows[0];
//                    string catatanPsikolog = row["catatan_psikolog"]?.ToString() ?? "-";

//                    MessageBox.Show($"📋 RINGKASAN KONSELING\n\n" +
//                        $"ID Booking: {_bookingId}\n" +
//                        $"Status: SELESAI\n" +
//                        $"\n📝 Catatan Psikolog:\n{catatanPsikolog}\n\n" +
//                        $"Terima kasih telah menyelesaikan sesi konseling.",
//                        "Ringkasan Konseling", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Gagal mengambil ringkasan: " + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void BtnTutup_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}

