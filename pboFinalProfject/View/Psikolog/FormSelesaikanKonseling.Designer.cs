namespace pboFinalProfject
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelGaris = new System.Windows.Forms.Panel();

            // Informasi Booking
            this.lblID = new System.Windows.Forms.Label();
            this.lblValID = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblValNama = new System.Windows.Forms.Label();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.lblValJadwal = new System.Windows.Forms.Label();
            this.lblMetode = new System.Windows.Forms.Label();
            this.lblValMetode = new System.Windows.Forms.Label();

            // Catatan User (dari mahasiswa)
            this.lblCatatanUser = new System.Windows.Forms.Label();
            this.txtCatatanUser = new System.Windows.Forms.TextBox();

            // Catatan Psikolog (wajib diisi)
            this.lblCatatanPsikolog = new System.Windows.Forms.Label();
            this.lblCatatanPsikologRequired = new System.Windows.Forms.Label();
            this.txtCatatanPsikolog = new System.Windows.Forms.TextBox();

            // Tombol
            this.btnSelesaikan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ==================== lblTitle ====================
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new System.Drawing.Point(16, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Selesaikan Sesi Konseling";

            // ==================== lblSubtitle ====================
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblSubtitle.Location = new System.Drawing.Point(16, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Isi catatan sesi konseling sebelum menyelesaikan.";

            // ==================== panelGaris ====================
            this.panelGaris.BackColor = System.Drawing.Color.FromArgb(230, 233, 237);
            this.panelGaris.Location = new System.Drawing.Point(16, 80);
            this.panelGaris.Name = "panelGaris";
            this.panelGaris.Size = new System.Drawing.Size(460, 2);
            this.panelGaris.TabIndex = 2;

            // ==================== lblID ====================
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblID.Location = new System.Drawing.Point(16, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(120, 25);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Booking";

            // ==================== lblValID ====================
            this.lblValID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValID.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblValID.Location = new System.Drawing.Point(140, 95);
            this.lblValID.Name = "lblValID";
            this.lblValID.Size = new System.Drawing.Size(200, 25);
            this.lblValID.TabIndex = 4;
            this.lblValID.Text = "-";

            // ==================== lblNama ====================
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblNama.Location = new System.Drawing.Point(16, 125);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(120, 25);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "Mahasiswa";

            // ==================== lblValNama ====================
            this.lblValNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValNama.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblValNama.Location = new System.Drawing.Point(140, 125);
            this.lblValNama.Name = "lblValNama";
            this.lblValNama.Size = new System.Drawing.Size(200, 25);
            this.lblValNama.TabIndex = 6;
            this.lblValNama.Text = "-";

            // ==================== lblJadwal ====================
            this.lblJadwal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblJadwal.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblJadwal.Location = new System.Drawing.Point(16, 155);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(120, 25);
            this.lblJadwal.TabIndex = 7;
            this.lblJadwal.Text = "Jadwal Sesi";

            // ==================== lblValJadwal ====================
            this.lblValJadwal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValJadwal.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblValJadwal.Location = new System.Drawing.Point(140, 155);
            this.lblValJadwal.Name = "lblValJadwal";
            this.lblValJadwal.Size = new System.Drawing.Size(200, 25);
            this.lblValJadwal.TabIndex = 8;
            this.lblValJadwal.Text = "-";

            // ==================== lblMetode ====================
            this.lblMetode.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMetode.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblMetode.Location = new System.Drawing.Point(16, 185);
            this.lblMetode.Name = "lblMetode";
            this.lblMetode.Size = new System.Drawing.Size(120, 25);
            this.lblMetode.TabIndex = 9;
            this.lblMetode.Text = "Metode";

            // ==================== lblValMetode ====================
            this.lblValMetode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValMetode.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblValMetode.Location = new System.Drawing.Point(140, 185);
            this.lblValMetode.Name = "lblValMetode";
            this.lblValMetode.Size = new System.Drawing.Size(200, 25);
            this.lblValMetode.TabIndex = 10;
            this.lblValMetode.Text = "-";

            // ==================== lblCatatanUser ====================
            this.lblCatatanUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCatatanUser.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblCatatanUser.Location = new System.Drawing.Point(16, 220);
            this.lblCatatanUser.Name = "lblCatatanUser";
            this.lblCatatanUser.Size = new System.Drawing.Size(200, 25);
            this.lblCatatanUser.TabIndex = 11;
            this.lblCatatanUser.Text = "📝 Catatan dari Mahasiswa:";

            // ==================== txtCatatanUser ====================
            this.txtCatatanUser.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.txtCatatanUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatatanUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCatatanUser.Location = new System.Drawing.Point(16, 248);
            this.txtCatatanUser.Multiline = true;
            this.txtCatatanUser.Name = "txtCatatanUser";
            this.txtCatatanUser.ReadOnly = true;
            this.txtCatatanUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatatanUser.Size = new System.Drawing.Size(460, 60);
            this.txtCatatanUser.TabIndex = 12;

            // ==================== lblCatatanPsikolog ====================
            this.lblCatatanPsikolog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatatanPsikolog.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblCatatanPsikolog.Location = new System.Drawing.Point(16, 320);
            this.lblCatatanPsikolog.Name = "lblCatatanPsikolog";
            this.lblCatatanPsikolog.Size = new System.Drawing.Size(180, 25);
            this.lblCatatanPsikolog.TabIndex = 13;
            this.lblCatatanPsikolog.Text = "📋 Catatan Psikolog";

            // ==================== lblCatatanPsikologRequired ====================
            this.lblCatatanPsikologRequired.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCatatanPsikologRequired.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblCatatanPsikologRequired.Location = new System.Drawing.Point(200, 325);
            this.lblCatatanPsikologRequired.Name = "lblCatatanPsikologRequired";
            this.lblCatatanPsikologRequired.Size = new System.Drawing.Size(100, 20);
            this.lblCatatanPsikologRequired.TabIndex = 14;
            this.lblCatatanPsikologRequired.Text = "(wajib diisi)";

            // ==================== txtCatatanPsikolog ====================
            this.txtCatatanPsikolog.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatatanPsikolog.Location = new System.Drawing.Point(16, 355);
            this.txtCatatanPsikolog.Multiline = true;
            this.txtCatatanPsikolog.Name = "txtCatatanPsikolog";
            this.txtCatatanPsikolog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatatanPsikolog.Size = new System.Drawing.Size(460, 120);
            this.txtCatatanPsikolog.TabIndex = 15;
            this.txtCatatanPsikolog.PlaceholderText = "Contoh: Klien mengalami kecemasan akademik ringan. Diberikan terapi relaksasi. D" +
                "isarankan booking lanjutan 2 minggu lagi.";

            // ==================== btnSelesaikan ====================
            this.btnSelesaikan.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSelesaikan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesaikan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelesaikan.ForeColor = System.Drawing.Color.White;
            this.btnSelesaikan.Location = new System.Drawing.Point(250, 490);
            this.btnSelesaikan.Name = "btnSelesaikan";
            this.btnSelesaikan.Size = new System.Drawing.Size(150, 40);
            this.btnSelesaikan.TabIndex = 16;
            this.btnSelesaikan.Text = "✔️ Selesaikan";
            this.btnSelesaikan.UseVisualStyleBackColor = false;

            // ==================== btnBatal ====================
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(90, 490);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 40);
            this.btnBatal.TabIndex = 17;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;

            // ==================== Form ====================
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSelesaikan);
            this.Controls.Add(this.txtCatatanPsikolog);
            this.Controls.Add(this.lblCatatanPsikologRequired);
            this.Controls.Add(this.lblCatatanPsikolog);
            this.Controls.Add(this.txtCatatanUser);
            this.Controls.Add(this.lblCatatanUser);
            this.Controls.Add(this.lblValMetode);
            this.Controls.Add(this.lblMetode);
            this.Controls.Add(this.lblValJadwal);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.lblValNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblValID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panelGaris);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelesaikanKonseling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unimind - Selesaikan Konseling";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelGaris;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblValID;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblValNama;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label lblValJadwal;
        private System.Windows.Forms.Label lblMetode;
        private System.Windows.Forms.Label lblValMetode;
        private System.Windows.Forms.Label lblCatatanUser;
        private System.Windows.Forms.TextBox txtCatatanUser;
        private System.Windows.Forms.Label lblCatatanPsikolog;
        private System.Windows.Forms.Label lblCatatanPsikologRequired;
        private System.Windows.Forms.TextBox txtCatatanPsikolog;
        private System.Windows.Forms.Button btnSelesaikan;
        private System.Windows.Forms.Button btnBatal;
    }
}