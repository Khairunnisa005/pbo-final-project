using System;
using System.Data;
using System.Windows.Forms;
using pboFinalProfject.Controllers;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormDaftarKonselor : Form
    {
        private PsikologController _controller;

        public void LoadPsikologs()
        {
            try
            {
                DataTable dt = _controller.GetAllPsikolog();
                dgvPsikolog.DataSource = dt;
                if (dgvPsikolog.Columns.Contains("psikolog_id")) dgvPsikolog.Columns["psikolog_id"].Visible = false;
                dgvPsikolog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPsikolog.CellDoubleClick -= DgvPsikolog_CellDoubleClick;
                dgvPsikolog.CellDoubleClick += DgvPsikolog_CellDoubleClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar konselor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormDaftarKonselor()
        {
            InitializeComponent();
            _controller = new PsikologController();
            //LoadPsikologs();
        }

        // ini dihapus juga kagak apa apa

        //private void LoadPsikologs()
        //{
        //    try
        //    {
        //        DataTable dt = _controller.GetAllPsikolog();
        //        dgvPsikolog.DataSource = dt;
        //        if (dgvPsikolog.Columns.Contains("psikolog_id")) dgvPsikolog.Columns["psikolog_id"].Visible = false;
        //        dgvPsikolog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //        dgvPsikolog.CellDoubleClick -= DgvPsikolog_CellDoubleClick;
        //        dgvPsikolog.CellDoubleClick += DgvPsikolog_CellDoubleClick;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal memuat daftar konselor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private void DgvPsikolog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPsikolog.Rows[e.RowIndex];
            if (!dgvPsikolog.Columns.Contains("psikolog_id")) return;
            int psikologId = Convert.ToInt32(row.Cells["psikolog_id"].Value);
            // open jadwal psikolog for booking - if a form exists try to instantiate it
            try
            {
                var type = Type.GetType("pboFinalProfject.View.Mahasiswa.FormJadwalByPsikolog");
                if (type != null)
                {
                    var form = (Form)Activator.CreateInstance(type, psikologId)!;
                    form.ShowDialog(this);
                }
                else
                {
                    // fallback: open FormBuatBooking and preselect psikolog
                    var booking = new FormBuatBooking();
                    booking.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka jadwal konselor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadPsikologs();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
