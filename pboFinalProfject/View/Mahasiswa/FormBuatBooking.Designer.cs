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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuatBooking));
            comboKategori = new ComboBox();
            comboPsikolog = new ComboBox();
            dgvJadwal = new DataGridView();
            txtCatatan = new TextBox();
            chkAttachAssessment = new CheckBox();
            btnSubmit = new Button();
            btnKembali = new Button();
            lblPrevKategori = new Label();
            lblPrevPsikolog = new Label();
            lblPrevJadwal = new Label();
            lblPrevInfo = new Label();
            btnKeluar = new Button();
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
            comboKategori.Location = new Point(487, 214);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(456, 36);
            comboKategori.TabIndex = 8;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged_1;
            // 
            // comboPsikolog
            // 
            comboPsikolog.Font = new Font("Segoe UI", 12F);
            comboPsikolog.Location = new Point(487, 272);
            comboPsikolog.Name = "comboPsikolog";
            comboPsikolog.Size = new Size(456, 36);
            comboPsikolog.TabIndex = 6;
            // 
            // dgvJadwal
            // 
            dgvJadwal.BackgroundColor = SystemColors.ControlLightLight;
            dgvJadwal.BorderStyle = BorderStyle.Fixed3D;
            dgvJadwal.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvJadwal.ColumnHeadersHeight = 29;
            dgvJadwal.Location = new Point(321, 371);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1170, 174);
            dgvJadwal.TabIndex = 0;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(487, 580);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(1004, 106);
            txtCatatan.TabIndex = 3;
            // 
            // chkAttachAssessment
            // 
            chkAttachAssessment.BackColor = SystemColors.ControlLightLight;
            chkAttachAssessment.Location = new Point(324, 704);
            chkAttachAssessment.Name = "chkAttachAssessment";
            chkAttachAssessment.Size = new Size(300, 24);
            chkAttachAssessment.TabIndex = 2;
            chkAttachAssessment.Text = "Lampirkan hasil kuisioner terbaru";
            chkAttachAssessment.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1278, 752);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(213, 47);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Kirim Permintaan";
            // 
            // btnKembali
            // 
            btnKembali.DialogResult = DialogResult.Cancel;
            btnKembali.Location = new Point(1053, 752);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(195, 47);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.Click += btnKembali_Click;
            // 
            // lblPrevKategori
            // 
            lblPrevKategori.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPrevKategori.Location = new Point(487, 190);
            lblPrevKategori.Name = "lblPrevKategori";
            lblPrevKategori.Size = new Size(1004, 20);
            lblPrevKategori.TabIndex = 0;
            // 
            // lblPrevPsikolog
            // 
            lblPrevPsikolog.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPrevPsikolog.Location = new Point(487, 252);
            lblPrevPsikolog.Name = "lblPrevPsikolog";
            lblPrevPsikolog.Size = new Size(1004, 20);
            lblPrevPsikolog.TabIndex = 0;
            // 
            // lblPrevJadwal
            // 
            lblPrevJadwal.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPrevJadwal.Location = new Point(487, 340);
            lblPrevJadwal.Name = "lblPrevJadwal";
            lblPrevJadwal.Size = new Size(1004, 20);
            lblPrevJadwal.TabIndex = 0;
            // 
            // lblPrevInfo
            // 
            lblPrevInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPrevInfo.Location = new Point(487, 557);
            lblPrevInfo.Name = "lblPrevInfo";
            lblPrevInfo.Size = new Size(1004, 24);
            lblPrevInfo.TabIndex = 0;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = SystemColors.ButtonHighlight;
            btnKeluar.Location = new Point(69, 784);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(165, 38);
            btnKeluar.TabIndex = 20;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.BorderSize = 0;
            btnKuisioner.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKuisioner.FlatStyle = FlatStyle.Flat;
            btnKuisioner.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKuisioner.ForeColor = SystemColors.ButtonHighlight;
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(69, 217);
            btnKuisioner.Name = "btnKuisioner";
            btnKuisioner.Size = new Size(165, 38);
            btnKuisioner.TabIndex = 19;
            btnKuisioner.Text = "Kuisioner";
            btnKuisioner.TextAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.UseVisualStyleBackColor = false;
            // 
            // btnKonselor
            // 
            btnKonselor.BackColor = Color.Transparent;
            btnKonselor.FlatAppearance.BorderSize = 0;
            btnKonselor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKonselor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKonselor.FlatStyle = FlatStyle.Flat;
            btnKonselor.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonselor.ForeColor = SystemColors.ButtonHighlight;
            btnKonselor.Location = new Point(69, 285);
            btnKonselor.Name = "btnKonselor";
            btnKonselor.Size = new Size(165, 38);
            btnKonselor.TabIndex = 18;
            btnKonselor.Text = "Konselor";
            btnKonselor.TextAlign = ContentAlignment.MiddleLeft;
            btnKonselor.UseVisualStyleBackColor = false;
            // 
            // btnKonsultasi
            // 
            btnKonsultasi.BackColor = Color.Transparent;
            btnKonsultasi.FlatAppearance.BorderSize = 0;
            btnKonsultasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKonsultasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKonsultasi.FlatStyle = FlatStyle.Flat;
            btnKonsultasi.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonsultasi.ForeColor = SystemColors.ButtonHighlight;
            btnKonsultasi.Location = new Point(71, 355);
            btnKonsultasi.Name = "btnKonsultasi";
            btnKonsultasi.Size = new Size(167, 38);
            btnKonsultasi.TabIndex = 17;
            btnKonsultasi.Text = "Jadwal Konsultasi";
            btnKonsultasi.TextAlign = ContentAlignment.MiddleLeft;
            btnKonsultasi.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = SystemColors.ButtonHighlight;
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(71, 421);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 38);
            btnProfile.TabIndex = 16;
            btnProfile.Text = "Profil";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBeranda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeranda.ForeColor = SystemColors.ButtonHighlight;
            btnBeranda.Location = new Point(69, 155);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 15;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click_1;
            // 
            // FormBuatBooking
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKeluar);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(lblPrevInfo);
            Controls.Add(lblPrevKategori);
            Controls.Add(lblPrevPsikolog);
            Controls.Add(lblPrevJadwal);
            Controls.Add(btnKembali);
            Controls.Add(btnSubmit);
            Controls.Add(chkAttachAssessment);
            Controls.Add(txtCatatan);
            Controls.Add(dgvJadwal);
            Controls.Add(comboPsikolog);
            Controls.Add(comboKategori);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBuatBooking";
            StartPosition = FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblPrevKategori;
        private System.Windows.Forms.Label lblPrevPsikolog;
        private System.Windows.Forms.Label lblPrevJadwal;
        private System.Windows.Forms.Label lblPrevInfo;
        private Button btnKeluar;
        private Button btnKuisioner;
        private Button btnKonselor;
        private Button btnKonsultasi;
        private Button btnProfile;
        private Button btnBeranda;
    }
}
