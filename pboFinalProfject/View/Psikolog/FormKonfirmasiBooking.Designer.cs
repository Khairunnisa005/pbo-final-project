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
            txtValCatatanPsi = new TextBox();
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
            btnSetuju.Location = new Point(1312, 726);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(153, 47);
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
            btnBatal.Location = new Point(1092, 726);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(202, 47);
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
            // txtValCatatanPsi
            // 
            txtValCatatanPsi.BackColor = Color.White;
            txtValCatatanPsi.BorderStyle = BorderStyle.None;
            txtValCatatanPsi.Font = new Font("Segoe UI", 9.5F);
            txtValCatatanPsi.Location = new Point(573, 398);
            txtValCatatanPsi.Multiline = true;
            txtValCatatanPsi.Name = "txtValCatatanPsi";
            txtValCatatanPsi.ReadOnly = true;
            txtValCatatanPsi.ScrollBars = ScrollBars.Vertical;
            txtValCatatanPsi.Size = new Size(424, 101);
            txtValCatatanPsi.TabIndex = 4;
            txtValCatatanPsi.Text = "-";
            // 
            // FormKonfirmasiBooking
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1514, 808);
            Controls.Add(btnKembali);
            Controls.Add(btnBatal);
            Controls.Add(btnSetuju);
            Controls.Add(lblValJadwal);
            Controls.Add(lblValNama);
            Controls.Add(lblValID);
            Controls.Add(txtValCatatanPsi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.TextBox txtValCatatanPsi;
        private System.Windows.Forms.Label lblID;
    }
}