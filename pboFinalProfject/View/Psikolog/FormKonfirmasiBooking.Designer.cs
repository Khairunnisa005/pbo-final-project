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
            btnKembali = new Button();
            txtValCatatanMhs = new TextBox();
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
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(1371, 52);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(126, 49);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += BtnKembali_Click;
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
            // btnKelolaJadwal
            // 
            btnKelolaJadwal.BackColor = Color.FromArgb(28, 167, 236);
            btnKelolaJadwal.FlatStyle = FlatStyle.Flat;
            btnKelolaJadwal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKelolaJadwal.ForeColor = Color.White;
            btnKelolaJadwal.Location = new Point(74, 227);
            btnKelolaJadwal.Margin = new Padding(3, 4, 3, 4);
            btnKelolaJadwal.Name = "btnKelolaJadwal";
            btnKelolaJadwal.Size = new Size(163, 45);
            btnKelolaJadwal.TabIndex = 2;
            btnKelolaJadwal.Text = "Kelola Jadwal";
            btnKelolaJadwal.UseVisualStyleBackColor = false;
            btnKelolaJadwal.Click += btnKelolaJadwal_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(28, 167, 236);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(37, 775);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(218, 41);
            btnKeluar.TabIndex = 10;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // btnKelolaProfil
            // 
            btnKelolaProfil.BackColor = Color.FromArgb(28, 167, 236);
            btnKelolaProfil.FlatStyle = FlatStyle.Flat;
            btnKelolaProfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKelolaProfil.ForeColor = Color.White;
            btnKelolaProfil.Location = new Point(74, 290);
            btnKelolaProfil.Margin = new Padding(3, 4, 3, 4);
            btnKelolaProfil.Name = "btnKelolaProfil";
            btnKelolaProfil.Size = new Size(163, 45);
            btnKelolaProfil.TabIndex = 2;
            btnKelolaProfil.Text = "Kelola Profil";
            btnKelolaProfil.UseVisualStyleBackColor = false;
            btnKelolaProfil.Click += btnKelolaProfil_Click;
            // 
            // FormKonfirmasiBooking
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKeluar);
            Controls.Add(btnKembali);
            Controls.Add(btnBatal);
            Controls.Add(btnSetuju);
            Controls.Add(lblValJadwal);
            Controls.Add(lblValNama);
            Controls.Add(lblValID);
            Controls.Add(txtValCatatanMhs);
            Controls.Add(btnKelolaProfil);
            Controls.Add(btnKelolaJadwal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKonfirmasiBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem UniMind - Konfirmasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblValID;
        private System.Windows.Forms.Label lblValNama;
        private System.Windows.Forms.Label lblValJadwal;
        private System.Windows.Forms.Button btnSetuju;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtValCatatanMhs;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnKelolaJadwal;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnKelolaProfil;
    }
}