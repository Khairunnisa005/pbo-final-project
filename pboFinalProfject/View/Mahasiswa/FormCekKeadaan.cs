using System;
using System.Windows.Forms;
using pboFinalProfject.Controllers;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormCekKeadaan : Form
    {
        private MahasiswaController _controller;

        public FormCekKeadaan()
        {
            InitializeComponent();
            _controller = new MahasiswaController();
            LoadLatest();
        }

        private void btnRetake_Click(object sender, EventArgs e)
        {
            var form = new FormKuesioner();
            form.ShowDialog(this);
            // refresh after retake
            LoadLatest();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLatest()
        {
            try
            {
                var hasil = _controller.GetLatestHasil(UserSession.GetCurrentUserId());
                if (hasil == null)
                {
                    lblInfo.Text = "Belum ada hasil kuisioner. Silakan isi kuisioner terlebih dahulu.";
                    btnRetake.Visible = true;
                }
                else
                {
                    lblInfo.Text = $"Terakhir: {hasil.TanggalAssessment:dd MMM yyyy}\r\nSkor: {hasil.SkorTotal}\r\nTingkat: {hasil.TingkatStres}\r\nRekomendasi: {hasil.Rekomendasi}";
                    btnRetake.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
