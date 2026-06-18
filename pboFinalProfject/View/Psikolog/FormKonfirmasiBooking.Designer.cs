namespace pboFinalProfject.View
{
    partial class FormKonfirmasiBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKonfirmasiBooking));
            lblValID = new Label();
            lblValNama = new Label();
            lblValJadwal = new Label();
            btnSetuju = new Button();
            btnBatal = new Button();
            txtValCatatanMhs = new TextBox();
            btnKembali = new Button();
            btnDashboard = new Button();
            btnKelolaJadwal = new Button();
            btnKeluar = new Button();
            btnKelolaProfil = new Button();
            SuspendLayout();
            // 
            // lblValID
            // 
            lblValID.Font = new Font("Segoe UI", 9.5F);
            lblValID.Location = new Point(573, 247);
            lblValID.Name = "lblValID";
            lblValID.Size = new Size(424, 27);
            lblValID.TabIndex = 6;
            lblValID.Text = "-";
            // 
            // lblValNama
            // 
            lblValNama.Font = new Font("Segoe UI", 9.5F);
            lblValNama.Location = new Point(573, 297);
            lblValNama.Name = "lblValNama";
            lblValNama.Size = new Size(424, 27);
            lblValNama.TabIndex = 4;
            lblValNama.Text = "-";
            // 
            // lblValJadwal
            // 
            lblValJadwal.Font = new Font("Segoe UI", 9.5F);
            lblValJadwal.Location = new Point(573, 350);
            lblValJadwal.Name = "lblValJadwal";
            lblValJadwal.Size = new Size(424, 27);
            lblValJadwal.TabIndex = 2;
            lblValJadwal.Text = "-";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.FromArgb(46, 125, 50);
            btnSetuju.FlatStyle = FlatStyle.Flat;
            btnSetuju.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(1300, 723);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(169, 57);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setujui & Konfirmasi";
            btnSetuju.UseVisualStyleBackColor = false;
            btnSetuju.Click += btnSetuju_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(245, 245, 245);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9.5F);
            btnBatal.ForeColor = Color.FromArgb(100, 100, 100);
            btnBatal.Location = new Point(1076, 724);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(218, 56);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Tolak / Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtValCatatanMhs
            // 
            txtValCatatanMhs.BackColor = Color.White;
            txtValCatatanMhs.BorderStyle = BorderStyle.None;
            txtValCatatanMhs.Font = new Font("Segoe UI", 9.5F);
            txtValCatatanMhs.Location = new Point(573, 399);
            txtValCatatanMhs.Multiline = true;
            txtValCatatanMhs.Name = "txtValCatatanMhs";
            txtValCatatanMhs.ReadOnly = true;
            txtValCatatanMhs.ScrollBars = ScrollBars.Vertical;
            txtValCatatanMhs.Size = new Size(424, 87);
            txtValCatatanMhs.TabIndex = 4;
            txtValCatatanMhs.Text = "-";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Calibri", 10.8F);
            btnKembali.ForeColor = SystemColors.ButtonHighlight;
            btnKembali.Location = new Point(1412, 51);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(128, 51);
            btnKembali.TabIndex = 11;
            btnKembali.Text = "Kembali";
            btnKembali.TextAlign = ContentAlignment.MiddleLeft;
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri", 10.8F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(76, 162);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 15;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnKelolaJadwal
            // 
            btnKelolaJadwal.BackColor = Color.Transparent;
            btnKelolaJadwal.FlatAppearance.BorderSize = 0;
            btnKelolaJadwal.FlatStyle = FlatStyle.Flat;
            btnKelolaJadwal.Font = new Font("Calibri", 10.9F);
            btnKelolaJadwal.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaJadwal.Location = new Point(75, 228);
            btnKelolaJadwal.Name = "btnKelolaJadwal";
            btnKelolaJadwal.Size = new Size(181, 45);
            btnKelolaJadwal.TabIndex = 12;
            btnKelolaJadwal.Text = "Jadwal Konsultasi";
            btnKelolaJadwal.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaJadwal.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(83, 775);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(179, 41);
            btnKeluar.TabIndex = 14;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnKelolaProfil
            // 
            btnKelolaProfil.BackColor = Color.Transparent;
            btnKelolaProfil.FlatAppearance.BorderSize = 0;
            btnKelolaProfil.FlatStyle = FlatStyle.Flat;
            btnKelolaProfil.Font = new Font("Calibri", 10.9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaProfil.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaProfil.Location = new Point(76, 294);
            btnKelolaProfil.Margin = new Padding(3, 4, 3, 4);
            btnKelolaProfil.Name = "btnKelolaProfil";
            btnKelolaProfil.Size = new Size(165, 38);
            btnKelolaProfil.TabIndex = 13;
            btnKelolaProfil.Text = "Profil";
            btnKelolaProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaProfil.UseVisualStyleBackColor = false;
            // 
            // FormKonfirmasiBooking
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnDashboard);
            Controls.Add(btnKelolaJadwal);
            Controls.Add(btnKeluar);
            Controls.Add(btnKelolaProfil);
            Controls.Add(btnKembali);
            Controls.Add(btnBatal);
            Controls.Add(btnSetuju);
            Controls.Add(lblValJadwal);
            Controls.Add(lblValNama);
            Controls.Add(lblValID);
            Controls.Add(txtValCatatanMhs);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKonfirmasiBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem UniMind - Konfirmasi";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblValID;
        private System.Windows.Forms.Label lblValNama;
        private System.Windows.Forms.Label lblValJadwal;
        private System.Windows.Forms.Button btnSetuju;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtValCatatanMhs;
        private System.Windows.Forms.Label lblID;
        private Button btnKembali;
        private Button btnDashboard;
        private Button btnKelolaJadwal;
        private Button btnKeluar;
        private Button btnKelolaProfil;
    }
}