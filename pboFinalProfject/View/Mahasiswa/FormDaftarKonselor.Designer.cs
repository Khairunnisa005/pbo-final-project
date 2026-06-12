namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormDaftarKonselor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarKonselor));
            dgvPsikolog = new DataGridView();
            btnKembali = new Button();
            btnKuisioner = new Button();
            btnKonselor = new Button();
            btnKonsultasi = new Button();
            btnProfile = new Button();
            btnBeranda = new Button();
            btnKeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPsikolog).BeginInit();
            SuspendLayout();
            // 
            // dgvPsikolog
            // 
            dgvPsikolog.BackgroundColor = SystemColors.ControlLightLight;
            dgvPsikolog.BorderStyle = BorderStyle.Fixed3D;
            dgvPsikolog.ColumnHeadersHeight = 29;
            dgvPsikolog.Location = new Point(321, 178);
            dgvPsikolog.Name = "dgvPsikolog";
            dgvPsikolog.RowHeadersWidth = 51;
            dgvPsikolog.Size = new Size(1164, 531);
            dgvPsikolog.TabIndex = 0;
            dgvPsikolog.CellContentClick += dgvPsikolog_CellContentClick;
            // 
            // btnKembali
            // 
            btnKembali.DialogResult = DialogResult.Cancel;
            btnKembali.Font = new Font("Segoe UI", 12F);
            btnKembali.Location = new Point(1049, 753);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(436, 48);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.BorderSize = 0;
            btnKuisioner.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKuisioner.FlatStyle = FlatStyle.Flat;
            btnKuisioner.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKuisioner.ForeColor = SystemColors.ButtonHighlight;
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(80, 220);
            btnKuisioner.Name = "btnKuisioner";
            btnKuisioner.Size = new Size(165, 38);
            btnKuisioner.TabIndex = 18;
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
            btnKonselor.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKonselor.ForeColor = SystemColors.ButtonHighlight;
            btnKonselor.Location = new Point(80, 288);
            btnKonselor.Name = "btnKonselor";
            btnKonselor.Size = new Size(165, 38);
            btnKonselor.TabIndex = 17;
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
            btnKonsultasi.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKonsultasi.ForeColor = SystemColors.ButtonHighlight;
            btnKonsultasi.Location = new Point(80, 355);
            btnKonsultasi.Name = "btnKonsultasi";
            btnKonsultasi.Size = new Size(167, 38);
            btnKonsultasi.TabIndex = 16;
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
            btnProfile.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnProfile.ForeColor = SystemColors.ButtonHighlight;
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(82, 424);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 38);
            btnProfile.TabIndex = 15;
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
            btnBeranda.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnBeranda.ForeColor = SystemColors.ButtonHighlight;
            btnBeranda.Location = new Point(80, 155);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 14;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
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
            btnKeluar.Location = new Point(80, 787);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(165, 38);
            btnKeluar.TabIndex = 19;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // FormDaftarKonselor
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(btnKeluar);
            Controls.Add(btnKembali);
            Controls.Add(dgvPsikolog);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormDaftarKonselor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daftar Konselor";
            Load += FormDaftarKonselor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPsikolog).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPsikolog;
        private System.Windows.Forms.Button btnKembali;
        private Button btnKuisioner;
        private Button btnKonselor;
        private Button btnKonsultasi;
        private Button btnProfile;
        private Button btnBeranda;
        private Button btnKeluar;
    }
}
