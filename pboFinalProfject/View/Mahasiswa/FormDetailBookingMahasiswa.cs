using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormDetailBookingMahasiswa : Form
    {
        private int _bookingId;
        private BookingController _bookingController;

        public FormDetailBookingMahasiswa(int bookingId)
        {
            InitializeComponent();
            _bookingId = bookingId;
            _bookingController = new BookingController();
            // Defer loading details until the form is actually shown to avoid closing/disposing
            // the form during construction which can cause ObjectDisposedException when
            // the caller then calls ShowDialog on the instance.
            this.Shown -= FormDetailBookingMahasiswa_Shown;
            this.Shown += FormDetailBookingMahasiswa_Shown;
        }

        private void FormDetailBookingMahasiswa_Shown(object? sender, EventArgs e)
        {
            // Unsubscribe to ensure LoadDetail runs only once
            this.Shown -= FormDetailBookingMahasiswa_Shown;
            LoadDetail();
        }

        private void LoadDetail()
        {
            try
            {
                int userId = UserSession.GetCurrentUserId();
                DataTable dt = _bookingController.GetDetailBookingForMahasiswa(_bookingId, userId);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Detail booking tidak ditemukan atau bukan milik Anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                var row = dt.Rows[0];
                lblId.Text = row["booking_id"].ToString();
                lblPsikolog.Text = row["psikolog_nama"].ToString();
                var tanggal = Convert.ToDateTime(row["tanggal_booking"]);
                // jam_mulai / jam_selesai may be TimeOnly, TimeSpan or string; handle all
                string jamMulaiText = "-";
                string jamSelesaiText = "-";
                try
                {
                    if (row["jam_mulai"] is TimeOnly t1) jamMulaiText = t1.ToString("HH:mm");
                    else if (row["jam_mulai"] is TimeSpan ts1) jamMulaiText = ts1.ToString(@"hh\:mm");
                    else if (row["jam_mulai"] != null && TimeOnly.TryParse(row["jam_mulai"].ToString(), out var p1)) jamMulaiText = p1.ToString("HH:mm");
                }
                catch { }

                try
                {
                    if (row["jam_selesai"] is TimeOnly t2) jamSelesaiText = t2.ToString("HH:mm");
                    else if (row["jam_selesai"] is TimeSpan ts2) jamSelesaiText = ts2.ToString(@"hh\:mm");
                    else if (row["jam_selesai"] != null && TimeOnly.TryParse(row["jam_selesai"].ToString(), out var p2)) jamSelesaiText = p2.ToString("HH:mm");
                }
                catch { }

                lblJadwal.Text = $"{tanggal:dd MMM yyyy}, {jamMulaiText} - {jamSelesaiText}";
                lblMetode.Text = row["metode"].ToString();
                lblStatus.Text = row["status"].ToString();
                txtCatatanUser.Text = row["catatan_user"]?.ToString() ?? string.Empty;
                txtCatatanPsikolog.Text = row["catatan_psikolog"]?.ToString() ?? string.Empty;
                lblTingkat.Text = row["tingkat_stres"]?.ToString() ?? "-";
                lblSkor.Text = row["skor_total"]?.ToString() ?? "-";
                txtRekomendasi.Text = row["rekomendasi"]?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat detail booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
