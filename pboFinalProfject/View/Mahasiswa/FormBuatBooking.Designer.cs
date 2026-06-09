namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormBuatBooking
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboKategori = new ComboBox();
            comboPsikolog = new ComboBox();
            dgvJadwal = new DataGridView();
            txtCatatan = new TextBox();
            chkAttachAssessment = new CheckBox();
            btnSubmit = new Button();
            btnKembali = new Button();
            btnKuisioner = new Button();
            btnKonselor = new Button();
            btnKonsultasi = new Button();
            btnProfile = new Button();
            btnBeranda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            SuspendLayout();
            // 
            // comboKategori
            // 
            comboKategori.Font = new Font("Segoe UI", 12F);
            comboKategori.Location = new Point(487, 210);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(435, 36);
            comboKategori.TabIndex = 8;
            // 
            // comboPsikolog
            // 
            comboPsikolog.Font = new Font("Segoe UI", 12F);
            comboPsikolog.Location = new Point(487, 266);
            comboPsikolog.Name = "comboPsikolog";
            comboPsikolog.Size = new Size(435, 36);
            comboPsikolog.TabIndex = 6;
            // 
            // dgvJadwal
            // 
            dgvJadwal.BackgroundColor = SystemColors.ControlLightLight;
            dgvJadwal.BorderStyle = BorderStyle.Fixed3D;
            dgvJadwal.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvJadwal.ColumnHeadersHeight = 29;
            dgvJadwal.Location = new Point(301, 364);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1169, 174);
            dgvJadwal.TabIndex = 0;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(487, 571);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(983, 106);
            txtCatatan.TabIndex = 3;
            // 
            // chkAttachAssessment
            // 
            chkAttachAssessment.BackColor = SystemColors.ControlLightLight;
            chkAttachAssessment.Location = new Point(298, 701);
            chkAttachAssessment.Name = "chkAttachAssessment";
            chkAttachAssessment.Size = new Size(300, 24);
            chkAttachAssessment.TabIndex = 2;
            chkAttachAssessment.Text = "Lampirkan hasil kuisioner terbaru";
            chkAttachAssessment.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1257, 751);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(213, 47);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Kirim Permintaan";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(1032, 751);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(195, 47);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.Font = new Font("Calibri", 12F);
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(60, 211);
            btnKuisioner.Name = "btnKuisioner";
            btnKuisioner.Size = new Size(165, 38);
            btnKuisioner.TabIndex = 13;
            btnKuisioner.Text = "Kuisioner";
            btnKuisioner.TextAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.UseVisualStyleBackColor = false;
            // 
            // btnKonselor
            // 
            btnKonselor.BackColor = Color.Transparent;
            btnKonselor.Font = new Font("Calibri", 12F);
            btnKonselor.Location = new Point(60, 281);
            btnKonselor.Name = "btnKonselor";
            btnKonselor.Size = new Size(165, 38);
            btnKonselor.TabIndex = 12;
            btnKonselor.Text = "Konselor";
            btnKonselor.TextAlign = ContentAlignment.MiddleLeft;
            btnKonselor.UseVisualStyleBackColor = false;
            // 
            // btnKonsultasi
            // 
            btnKonsultasi.BackColor = Color.Transparent;
            btnKonsultasi.Font = new Font("Calibri", 12F);
            btnKonsultasi.Location = new Point(60, 348);
            btnKonsultasi.Name = "btnKonsultasi";
            btnKonsultasi.Size = new Size(167, 38);
            btnKonsultasi.TabIndex = 11;
            btnKonsultasi.Text = "Jadwal Konsultasi";
            btnKonsultasi.TextAlign = ContentAlignment.MiddleLeft;
            btnKonsultasi.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Font = new Font("Calibri", 12F);
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(62, 417);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 38);
            btnProfile.TabIndex = 10;
            btnProfile.Text = "Profil";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.Font = new Font("Calibri", 12F);
            btnBeranda.Location = new Point(60, 142);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 9;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            // 
            // FormBuatBooking
            // 
            BackgroundImage = Properties.Resources.booking;
            ClientSize = new Size(1518, 817);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(btnKembali);
            Controls.Add(btnSubmit);
            Controls.Add(chkAttachAssessment);
            Controls.Add(txtCatatan);
            Controls.Add(dgvJadwal);
            Controls.Add(comboPsikolog);
            Controls.Add(comboKategori);
            Name = "FormBuatBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buat Booking";
            Load += FormBuatBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboPsikolog;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.CheckBox chkAttachAssessment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnKembali;
        private Button btnKuisioner;
        private Button btnKonselor;
        private Button btnKonsultasi;
        private Button btnProfile;
        private Button btnBeranda;
    }
}
