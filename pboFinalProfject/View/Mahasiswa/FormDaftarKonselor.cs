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
                if (dgvPsikolog.Columns.Contains("user_id")) dgvPsikolog.Columns["user_id"].Visible = false;
                if (dgvPsikolog.Columns.Contains("email")) dgvPsikolog.Columns["email"].Visible = false;
                if (dgvPsikolog.Columns.Contains("username")) dgvPsikolog.Columns["username"].Visible = false;
                if (dgvPsikolog.Columns.Contains("nama_lengkap")) dgvPsikolog.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
                //if (dgvPsikolog.Columns.Contains("email")) dgvPsikolog.Columns["email"].HeaderText = "Email";
                if (dgvPsikolog.Columns.Contains("gelar")) dgvPsikolog.Columns["gelar"].HeaderText = "Gelar";
                if (dgvPsikolog.Columns.Contains("pendidikan")) dgvPsikolog.Columns["pendidikan"].HeaderText = "Pendidikan";
                if (dgvPsikolog.Columns.Contains("deskripsi_singkat")) dgvPsikolog.Columns["deskripsi_singkat"].HeaderText = "Deskripsi singkat";
                if (dgvPsikolog.Columns.Contains("layanan")) dgvPsikolog.Columns["layanan"].HeaderText = "Layanan";
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
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                _controller = new PsikologController();
                // wire sidebar
                btnKuisioner.Click += BtnKuisioner_Click;
                btnKonselor.Click += BtnKonselor_Click;
                btnKonsultasi.Click += BtnKonsultasi_Click;
                btnProfile.Click += BtnProfile_Click;
                btnBeranda.Click += BtnBeranda_Click;
                try { btnKeluar.Click += (s, e) => { var auth = new Controllers.AuthController(); auth.LogoutAndRedirect(this); }; } catch { }
                //LoadPsikologs();
            }
            this.Shown += (s, e) => { this.Activate(); };
            // Di constructor form atau di InitializeComponent()
            this.AutoScaleMode = AutoScaleMode.None;
        }

        // When embedded, the parent dashboard will manage docking and sizing. Keep form as-is.

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

        private void BtnKuisioner_Click(object? sender, EventArgs e)
        {
            var f = new FormKuesioner();
            f.ShowDialog(this);
        }

        private void BtnKonselor_Click(object? sender, EventArgs e)
        {
            // already here
        }

        private void BtnKonsultasi_Click(object? sender, EventArgs e)
        {
            var f = new FormBuatBooking();
            f.ShowDialog(this);
        }

        private void BtnProfile_Click(object? sender, EventArgs e)
        {
            var f = new FormProfilMahasiswa();
            f.ShowDialog(this);
        }

        private void BtnBeranda_Click(object? sender, EventArgs e)
        {
            pboFinalProfject.Utils.Navigation.GoToDashboard(this);
        }

        private void FormDaftarKonselor_Load(object sender, EventArgs e)
        {

        }

        private void dgvPsikolog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
