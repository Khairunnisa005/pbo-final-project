namespace pboFinalProfject.view
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
            lblTitle = new Label();
            lblPrompt = new Label();
            panelGaris = new Panel();
            lblID = new Label();
            lblValID = new Label();
            lblNama = new Label();
            lblValNama = new Label();
            lblJadwal = new Label();
            lblValJadwal = new Label();
            btnSetuju = new Button();
            btnBatal = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(16, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 41);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Konfirmasi Reservasi Sesi";
            // 
            // lblPrompt
            // 
            lblPrompt.Font = new Font("Segoe UI", 9F);
            lblPrompt.ForeColor = Color.FromArgb(127, 140, 141);
            lblPrompt.Location = new Point(16, 56);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(322, 58);
            lblPrompt.TabIndex = 9;
            lblPrompt.Text = "Apakah Anda yakin ingin menyetujui permintaan jadwal konseling berikut?";
            lblPrompt.Click += lblPrompt_Click;
            // 
            // panelGaris
            // 
            panelGaris.BackColor = Color.FromArgb(230, 233, 237);
            panelGaris.Location = new Point(20, 112);
            panelGaris.Name = "panelGaris";
            panelGaris.Size = new Size(310, 2);
            panelGaris.TabIndex = 8;
            // 
            // lblID
            // 
            lblID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(52, 73, 94);
            lblID.Location = new Point(20, 114);
            lblID.Name = "lblID";
            lblID.Size = new Size(100, 20);
            lblID.TabIndex = 7;
            lblID.Text = "ID Registrasi";
            lblID.Click += lblID_Click;
            // 
            // lblValID
            // 
            lblValID.Font = new Font("Segoe UI", 9.5F);
            lblValID.Location = new Point(130, 114);
            lblValID.Name = "lblValID";
            lblValID.Size = new Size(200, 20);
            lblValID.TabIndex = 6;
            lblValID.Text = "-";
            // 
            // lblNama
            // 
            lblNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(52, 73, 94);
            lblNama.Location = new Point(16, 146);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(100, 20);
            lblNama.TabIndex = 5;
            lblNama.Text = "Nama Konseli";
            // 
            // lblValNama
            // 
            lblValNama.Font = new Font("Segoe UI", 9.5F);
            lblValNama.Location = new Point(130, 146);
            lblValNama.Name = "lblValNama";
            lblValNama.Size = new Size(200, 20);
            lblValNama.TabIndex = 4;
            lblValNama.Text = "-";
            // 
            // lblJadwal
            // 
            lblJadwal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblJadwal.ForeColor = Color.FromArgb(52, 73, 94);
            lblJadwal.Location = new Point(16, 175);
            lblJadwal.Name = "lblJadwal";
            lblJadwal.Size = new Size(100, 20);
            lblJadwal.TabIndex = 3;
            lblJadwal.Text = "Rencana Sesi";
            // 
            // lblValJadwal
            // 
            lblValJadwal.Font = new Font("Segoe UI", 9.5F);
            lblValJadwal.Location = new Point(130, 175);
            lblValJadwal.Name = "lblValJadwal";
            lblValJadwal.Size = new Size(200, 20);
            lblValJadwal.TabIndex = 2;
            lblValJadwal.Text = "-";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.FromArgb(46, 125, 50);
            btnSetuju.FlatStyle = FlatStyle.Flat;
            btnSetuju.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(180, 225);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(150, 35);
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
            btnBatal.Location = new Point(20, 225);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(145, 35);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Tolak / Kembali";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(20, 306);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(145, 45);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormKonfirmasiBooking
            // 
            BackColor = Color.White;
            ClientSize = new Size(350, 363);
            Controls.Add(btnKembali);
            Controls.Add(btnBatal);
            Controls.Add(btnSetuju);
            Controls.Add(lblValJadwal);
            Controls.Add(lblJadwal);
            Controls.Add(lblValNama);
            Controls.Add(lblNama);
            Controls.Add(lblValID);
            Controls.Add(lblID);
            Controls.Add(panelGaris);
            Controls.Add(lblPrompt);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKonfirmasiBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Unimind - Konfirmasi";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Panel panelGaris;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblValID;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblValNama;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label lblValJadwal;
        private System.Windows.Forms.Button btnSetuju;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKembali;
    }
}