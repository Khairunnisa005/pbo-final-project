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
            btnKembali = new Button();
            SuspendLayout();
            // 
            // lblValID
            // 
            lblValID.Font = new Font("Segoe UI", 9.5F);
            lblValID.ForeColor = Color.FromArgb(52, 73, 94);
            lblValID.Location = new Point(546, 173);
            lblValID.Name = "lblValID";
            lblValID.Size = new Size(403, 25);
            lblValID.TabIndex = 4;
            lblValID.Text = "-";
            // 
            // lblValNama
            // 
            lblValNama.Font = new Font("Segoe UI", 9.5F);
            lblValNama.ForeColor = Color.FromArgb(52, 73, 94);
            lblValNama.Location = new Point(546, 220);
            lblValNama.Name = "lblValNama";
            lblValNama.Size = new Size(403, 25);
            lblValNama.TabIndex = 6;
            lblValNama.Text = "-";
            // 
            // lblValJadwal
            // 
            lblValJadwal.Font = new Font("Segoe UI", 9.5F);
            lblValJadwal.ForeColor = Color.FromArgb(52, 73, 94);
            lblValJadwal.Location = new Point(546, 259);
            lblValJadwal.Name = "lblValJadwal";
            lblValJadwal.Size = new Size(403, 25);
            lblValJadwal.TabIndex = 8;
            lblValJadwal.Text = "-";
            // 
            // lblValMetode
            // 
            lblValMetode.Font = new Font("Segoe UI", 9.5F);
            lblValMetode.ForeColor = Color.FromArgb(52, 73, 94);
            lblValMetode.Location = new Point(546, 344);
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
            btnSelesaikan.Location = new Point(1276, 723);
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
            lblValJamMulai.Location = new Point(546, 302);
            lblValJamMulai.Name = "lblValJamMulai";
            lblValJamMulai.Size = new Size(167, 28);
            lblValJamMulai.TabIndex = 0;
            lblValJamMulai.Text = "-";
            // 
            // lblValJamSelesai
            // 
            lblValJamSelesai.Font = new Font("Segoe UI", 9.5F);
            lblValJamSelesai.Location = new Point(763, 302);
            lblValJamSelesai.Name = "lblValJamSelesai";
            lblValJamSelesai.Size = new Size(186, 28);
            lblValJamSelesai.TabIndex = 0;
            lblValJamSelesai.Text = "-";
            // 
            // lblJam
            // 
            lblJam.Location = new Point(719, 302);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(38, 28);
            lblJam.TabIndex = 0;
            lblJam.Text = "s/d";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(1375, 49);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(121, 49);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += BtnKembali_Click;
            // 
            // FormSelesaikanKonseling
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1514, 808);
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
            Controls.Add(btnKembali);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSelesaikanKonseling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unimind - Selesaikan Konseling";
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
        private System.Windows.Forms.Button btnKembali;
    }
}