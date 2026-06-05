using System;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormKonfirmasiBooking : Form
    {
        private string _idBooking;

        // Konstruktor menerima data konfirmasi ringkas
        public FormKonfirmasiBooking(string idBooking, string namaKonseli, string jadwalSesi)
        {
            InitializeComponent();

            this._idBooking = idBooking;

            // Menampilkan data ke komponen teks konfirmasi
            lblValID.Text = idBooking;
            lblValNama.Text = namaKonseli;
            lblValJadwal.Text = jadwalSesi;
        }

        // Event ketika tombol 'Setujui & Konfirmasi' diklik
        private void btnSetuju_Click(object sender, EventArgs e)
        {
            // Mengatur hasil dialog menjadi OK dan menutup form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Event ketika tombol 'Tolak / Batalkan' diklik
        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Mengatur hasil dialog menjadi Cancel dan menutup form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}