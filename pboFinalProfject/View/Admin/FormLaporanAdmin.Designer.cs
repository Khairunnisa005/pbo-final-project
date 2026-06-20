namespace pboFinalProfject.View
{
    partial class FormLaporanAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanAdmin));
            btnFilter = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpSelesai = new DateTimePicker();
            lblSampai = new Label();
            dtpMulai = new DateTimePicker();
            lblPeriode = new Label();
            dgvLaporan = new DataGridView();
            pnlSummary = new Panel();
            lblTotalSesi = new Label();
            lblTotalTitle = new Label();
            btnEkspor = new Button();
            btnCetak = new Button();
            btnKeluar = new Button();
            btnDashboard = new Button();
            btnLaporan = new Button();
            btnKelolaUser = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(41, 128, 185);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(1237, 189);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(138, 47);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Terapkan";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F);
            cmbStatus.Location = new Point(1016, 197);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(184, 28);
            cmbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(925, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(85, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status:";
            // 
            // dtpSelesai
            // 
            dtpSelesai.Font = new Font("Segoe UI", 9F);
            dtpSelesai.Format = DateTimePickerFormat.Short;
            dtpSelesai.Location = new Point(703, 197);
            dtpSelesai.Name = "dtpSelesai";
            dtpSelesai.Size = new Size(202, 27);
            dtpSelesai.TabIndex = 3;
            // 
            // lblSampai
            // 
            lblSampai.Font = new Font("Segoe UI", 9F);
            lblSampai.Location = new Point(649, 202);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(48, 20);
            lblSampai.TabIndex = 4;
            lblSampai.Text = "s/d";
            // 
            // dtpMulai
            // 
            dtpMulai.Font = new Font("Segoe UI", 9F);
            dtpMulai.Format = DateTimePickerFormat.Short;
            dtpMulai.Location = new Point(441, 197);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(191, 27);
            dtpMulai.TabIndex = 5;
            // 
            // lblPeriode
            // 
            lblPeriode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPeriode.Location = new Point(348, 183);
            lblPeriode.Name = "lblPeriode";
            lblPeriode.Size = new Size(87, 60);
            lblPeriode.TabIndex = 6;
            lblPeriode.Text = "Pilih Periode:";
            // 
            // dgvLaporan
            // 
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.AllowUserToDeleteRows = false;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.BackgroundColor = Color.FromArgb(245, 245, 247);
            dgvLaporan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLaporan.ColumnHeadersHeight = 30;
            dgvLaporan.EnableHeadersVisualStyles = false;
            dgvLaporan.Location = new Point(344, 300);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowHeadersWidth = 62;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.Size = new Size(827, 476);
            dgvLaporan.TabIndex = 3;
            dgvLaporan.CellContentClick += dgvLaporan_CellContentClick;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblTotalSesi);
            pnlSummary.Controls.Add(lblTotalTitle);
            pnlSummary.Location = new Point(1195, 300);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(305, 178);
            pnlSummary.TabIndex = 2;
            // 
            // lblTotalSesi
            // 
            lblTotalSesi.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalSesi.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalSesi.Location = new Point(82, 79);
            lblTotalSesi.Name = "lblTotalSesi";
            lblTotalSesi.Size = new Size(145, 40);
            lblTotalSesi.TabIndex = 0;
            lblTotalSesi.Text = "0 Sesi";
            lblTotalSesi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(127, 140, 141);
            lblTotalTitle.Location = new Point(82, 34);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(145, 20);
            lblTotalTitle.TabIndex = 1;
            lblTotalTitle.Text = "Total Terfilter";
            lblTotalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEkspor
            // 
            btnEkspor.Font = new Font("Segoe UI", 9F);
            btnEkspor.Location = new Point(1195, 501);
            btnEkspor.Name = "btnEkspor";
            btnEkspor.Size = new Size(305, 132);
            btnEkspor.TabIndex = 1;
            btnEkspor.Text = "Ekspor ke CSV/Excel";
            btnEkspor.UseVisualStyleBackColor = true;
            btnEkspor.Click += btnEkspor_Click;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(52, 73, 94);
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCetak.ForeColor = Color.White;
            btnCetak.Location = new Point(1195, 658);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(305, 109);
            btnCetak.TabIndex = 0;
            btnCetak.Text = "Cetak Laporan";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 10.9F, FontStyle.Bold);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(84, 755);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(179, 41);
            btnKeluar.TabIndex = 15;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri Light", 11.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(74, 168);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 14;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Calibri Light", 11.5F, FontStyle.Bold);
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(75, 310);
            btnLaporan.Margin = new Padding(3, 4, 3, 4);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(163, 45);
            btnLaporan.TabIndex = 12;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Transparent;
            btnKelolaUser.FlatAppearance.BorderSize = 0;
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.Font = new Font("Corbel", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(74, 237);
            btnKelolaUser.Margin = new Padding(3, 4, 3, 4);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(163, 45);
            btnKelolaUser.TabIndex = 13;
            btnKelolaUser.Text = "Kelola Pengguna";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = false;
            btnKelolaUser.Click += btnKelolaUser_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Calibri", 10.8F);
            btnKembali.ForeColor = SystemColors.ButtonHighlight;
            btnKembali.Location = new Point(1411, 62);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(81, 51);
            btnKembali.TabIndex = 16;
            btnKembali.Text = "Kembali";
            btnKembali.TextAlign = ContentAlignment.MiddleLeft;
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // FormLaporanAdmin
            // 
            BackColor = Color.FromArgb(250, 250, 250);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKembali);
            Controls.Add(btnKeluar);
            Controls.Add(btnDashboard);
            Controls.Add(btnLaporan);
            Controls.Add(btnKelolaUser);
            Controls.Add(lblPeriode);
            Controls.Add(dtpMulai);
            Controls.Add(lblSampai);
            Controls.Add(dtpSelesai);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnFilter);
            Controls.Add(btnCetak);
            Controls.Add(btnEkspor);
            Controls.Add(pnlSummary);
            Controls.Add(dgvLaporan);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormLaporanAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unimind Admin - Panel Laporan";
            WindowState = FormWindowState.Maximized;
            Load += FormLaporanAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            pnlSummary.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.DateTimePicker dtpMulai;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSelesai;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalSesi;
        private System.Windows.Forms.Button btnEkspor;
        private System.Windows.Forms.Button btnCetak;
        private Button btnKeluar;
        private Button btnDashboard;
        private Button btnLaporan;
        private Button btnKelolaUser;
        private Button btnKembali;
    }
}