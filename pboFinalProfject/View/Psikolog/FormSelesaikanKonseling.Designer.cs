namespace pboFinalProfject.View
{
    partial class FormSelesaikanKonseling
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelesaikanKonseling));
            lblValID = new Label();
            lblValNama = new Label();
            lblValJadwal = new Label();
            lblValMetode = new Label();
            txtCatatanUser = new TextBox();
            txtCatatanPsikolog = new TextBox();
            btnSelesaikan = new Button();
            btnBatal = new Button();
            lblValJamMulai = new Label();
            lblValJamSelesai = new Label();
            lblJam = new Label();
            btnDashboard = new Button();
            btnKelolaJadwal = new Button();
            btnKeluar = new Button();
            btnKelolaProfil = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // lblValID
            // 
            lblValID.Font = new Font("Segoe UI", 9.5F);
            lblValID.ForeColor = Color.FromArgb(52, 73, 94);
            lblValID.Location = new Point(554, 176);
            lblValID.Name = "lblValID";
            lblValID.Size = new Size(403, 25);
            lblValID.TabIndex = 4;
            lblValID.Text = "-";
            // 
            // lblValNama
            // 
            lblValNama.Font = new Font("Segoe UI", 9.5F);
            lblValNama.ForeColor = Color.FromArgb(52, 73, 94);
            lblValNama.Location = new Point(554, 223);
            lblValNama.Name = "lblValNama";
            lblValNama.Size = new Size(403, 25);
            lblValNama.TabIndex = 6;
            lblValNama.Text = "-";
            // 
            // lblValJadwal
            // 
            lblValJadwal.Font = new Font("Segoe UI", 9.5F);
            lblValJadwal.ForeColor = Color.FromArgb(52, 73, 94);
            lblValJadwal.Location = new Point(554, 262);
            lblValJadwal.Name = "lblValJadwal";
            lblValJadwal.Size = new Size(403, 25);
            lblValJadwal.TabIndex = 8;
            lblValJadwal.Text = "-";
            // 
            // lblValMetode
            // 
            lblValMetode.Font = new Font("Segoe UI", 9.5F);
            lblValMetode.ForeColor = Color.FromArgb(52, 73, 94);
            lblValMetode.Location = new Point(554, 347);
            lblValMetode.Name = "lblValMetode";
            lblValMetode.Size = new Size(403, 25);
            lblValMetode.TabIndex = 10;
            lblValMetode.Text = "-";
            // 
            // txtCatatanUser
            // 
            txtCatatanUser.BackColor = Color.FromArgb(245, 245, 250);
            txtCatatanUser.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanUser.Font = new Font("Segoe UI", 9F);
            txtCatatanUser.Location = new Point(362, 441);
            txtCatatanUser.Multiline = true;
            txtCatatanUser.Name = "txtCatatanUser";
            txtCatatanUser.ReadOnly = true;
            txtCatatanUser.ScrollBars = ScrollBars.Vertical;
            txtCatatanUser.Size = new Size(587, 98);
            txtCatatanUser.TabIndex = 12;
            // 
            // txtCatatanPsikolog
            // 
            txtCatatanPsikolog.Font = new Font("Segoe UI", 9.5F);
            txtCatatanPsikolog.Location = new Point(362, 602);
            txtCatatanPsikolog.Multiline = true;
            txtCatatanPsikolog.Name = "txtCatatanPsikolog";
            txtCatatanPsikolog.PlaceholderText = "Contoh: Klien mengalami kecemasan akademik ringan. Diberikan terapi relaksasi. Disarankan booking lanjutan 2 minggu lagi.";
            txtCatatanPsikolog.ScrollBars = ScrollBars.Vertical;
            txtCatatanPsikolog.Size = new Size(587, 185);
            txtCatatanPsikolog.TabIndex = 15;
            // 
            // btnSelesaikan
            // 
            btnSelesaikan.BackColor = Color.FromArgb(46, 125, 50);
            btnSelesaikan.FlatStyle = FlatStyle.Flat;
            btnSelesaikan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelesaikan.ForeColor = Color.White;
            btnSelesaikan.Location = new Point(1274, 722);
            btnSelesaikan.Name = "btnSelesaikan";
            btnSelesaikan.Size = new Size(191, 48);
            btnSelesaikan.TabIndex = 16;
            btnSelesaikan.Text = "✔️ Selesaikan";
            btnSelesaikan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(100, 100, 100);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 10F);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(1117, 723);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(143, 48);
            btnBatal.TabIndex = 17;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // lblValJamMulai
            // 
            lblValJamMulai.Font = new Font("Segoe UI", 9.5F);
            lblValJamMulai.Location = new Point(554, 305);
            lblValJamMulai.Name = "lblValJamMulai";
            lblValJamMulai.Size = new Size(167, 28);
            lblValJamMulai.TabIndex = 0;
            lblValJamMulai.Text = "-";
            // 
            // lblValJamSelesai
            // 
            lblValJamSelesai.Font = new Font("Segoe UI", 9.5F);
            lblValJamSelesai.Location = new Point(771, 305);
            lblValJamSelesai.Name = "lblValJamSelesai";
            lblValJamSelesai.Size = new Size(186, 28);
            lblValJamSelesai.TabIndex = 0;
            lblValJamSelesai.Text = "-";
            // 
            // lblJam
            // 
            lblJam.Location = new Point(727, 305);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(38, 28);
            lblJam.TabIndex = 0;
            lblJam.Text = "s/d";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(76, 162);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 21;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnKelolaJadwal
            // 
            btnKelolaJadwal.BackColor = Color.Transparent;
            btnKelolaJadwal.FlatAppearance.BorderSize = 0;
            btnKelolaJadwal.FlatStyle = FlatStyle.Flat;
            btnKelolaJadwal.Font = new Font("Calibri", 10.9F, FontStyle.Bold);
            btnKelolaJadwal.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaJadwal.Location = new Point(75, 228);
            btnKelolaJadwal.Name = "btnKelolaJadwal";
            btnKelolaJadwal.Size = new Size(181, 45);
            btnKelolaJadwal.TabIndex = 18;
            btnKelolaJadwal.Text = "Jadwal Konsultasi";
            btnKelolaJadwal.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaJadwal.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(83, 775);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(179, 41);
            btnKeluar.TabIndex = 20;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnKelolaProfil
            // 
            btnKelolaProfil.BackColor = Color.Transparent;
            btnKelolaProfil.FlatAppearance.BorderSize = 0;
            btnKelolaProfil.FlatStyle = FlatStyle.Flat;
            btnKelolaProfil.Font = new Font("Calibri", 10.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaProfil.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaProfil.Location = new Point(76, 294);
            btnKelolaProfil.Margin = new Padding(3, 4, 3, 4);
            btnKelolaProfil.Name = "btnKelolaProfil";
            btnKelolaProfil.Size = new Size(165, 38);
            btnKelolaProfil.TabIndex = 19;
            btnKelolaProfil.Text = "Profil";
            btnKelolaProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaProfil.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Calibri", 9.7F);
            btnKembali.ForeColor = SystemColors.ButtonHighlight;
            btnKembali.Location = new Point(1413, 48);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(81, 51);
            btnKembali.TabIndex = 22;
            btnKembali.Text = "Kembali";
            btnKembali.TextAlign = ContentAlignment.MiddleLeft;
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // FormSelesaikanKonseling
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKembali);
            Controls.Add(btnDashboard);
            Controls.Add(btnKelolaJadwal);
            Controls.Add(btnKeluar);
            Controls.Add(btnKelolaProfil);
            Controls.Add(btnBatal);
            Controls.Add(btnSelesaikan);
            Controls.Add(txtCatatanPsikolog);
            Controls.Add(txtCatatanUser);
            Controls.Add(lblValMetode);
            Controls.Add(lblValJadwal);
            Controls.Add(lblValNama);
            Controls.Add(lblValID);
            Controls.Add(lblValJamMulai);
            Controls.Add(lblValJamSelesai);
            Controls.Add(lblJam);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSelesaikanKonseling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unimind - Selesaikan Konseling";
            WindowState = FormWindowState.Maximized;
            Load += FormSelesaikanKonseling_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblValID;
        private System.Windows.Forms.Label lblValNama;
        private System.Windows.Forms.Label lblValJadwal;
        private System.Windows.Forms.Label lblValMetode;
        private System.Windows.Forms.TextBox txtCatatanUser;
        private System.Windows.Forms.TextBox txtCatatanPsikolog;
        private System.Windows.Forms.Button btnSelesaikan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblValJamMulai;
        private System.Windows.Forms.Label lblValJamSelesai;
        private System.Windows.Forms.Label lblJam;
        private Button btnDashboard;
        private Button btnKelolaJadwal;
        private Button btnKeluar;
        private Button btnKelolaProfil;
        private Button btnKembali;
    }
}