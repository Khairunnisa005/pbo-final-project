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
            pnlFilter = new Panel();
            btnFilter = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpSelesai = new DateTimePicker();
            lblSampai = new Label();
            dtpMulai = new DateTimePicker();
            lblPeriode = new Label();
            btnKembali = new Button();
            dgvLaporan = new DataGridView();
            pnlSummary = new Panel();
            lblTotalSesi = new Label();
            lblTotalTitle = new Label();
            btnEkspor = new Button();
            btnCetak = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(btnFilter);
            pnlFilter.Controls.Add(cmbStatus);
            pnlFilter.Controls.Add(lblStatus);
            pnlFilter.Controls.Add(dtpSelesai);
            pnlFilter.Controls.Add(lblSampai);
            pnlFilter.Controls.Add(dtpMulai);
            pnlFilter.Controls.Add(lblPeriode);
            pnlFilter.Location = new Point(20, 65);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(801, 65);
            pnlFilter.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(41, 128, 185);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(669, 14);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(109, 35);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Terapkan";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F);
            cmbStatus.Location = new Point(510, 16);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(140, 33);
            cmbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(441, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(85, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status:";
            // 
            // dtpSelesai
            // 
            dtpSelesai.Font = new Font("Segoe UI", 9F);
            dtpSelesai.Format = DateTimePickerFormat.Short;
            dtpSelesai.Location = new Point(279, 16);
            dtpSelesai.Name = "dtpSelesai";
            dtpSelesai.Size = new Size(144, 31);
            dtpSelesai.TabIndex = 3;
            // 
            // lblSampai
            // 
            lblSampai.Font = new Font("Segoe UI", 9F);
            lblSampai.Location = new Point(235, 19);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(48, 20);
            lblSampai.TabIndex = 4;
            lblSampai.Text = "s/d";
            // 
            // dtpMulai
            // 
            dtpMulai.Font = new Font("Segoe UI", 9F);
            dtpMulai.Format = DateTimePickerFormat.Short;
            dtpMulai.Location = new Point(96, 16);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(134, 31);
            dtpMulai.TabIndex = 5;
            // 
            // lblPeriode
            // 
            lblPeriode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPeriode.Location = new Point(15, 19);
            lblPeriode.Name = "lblPeriode";
            lblPeriode.Size = new Size(90, 20);
            lblPeriode.TabIndex = 6;
            lblPeriode.Text = "Pilih Periode:";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(697, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(124, 45);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
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
            dgvLaporan.Location = new Point(20, 136);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowHeadersWidth = 62;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.Size = new Size(626, 354);
            dgvLaporan.TabIndex = 3;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblTotalSesi);
            pnlSummary.Controls.Add(lblTotalTitle);
            pnlSummary.Location = new Point(652, 136);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(169, 100);
            pnlSummary.TabIndex = 2;
            // 
            // lblTotalSesi
            // 
            lblTotalSesi.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalSesi.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalSesi.Location = new Point(10, 40);
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
            lblTotalTitle.Location = new Point(10, 15);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(145, 20);
            lblTotalTitle.TabIndex = 1;
            lblTotalTitle.Text = "Total Terfilter";
            lblTotalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEkspor
            // 
            btnEkspor.Font = new Font("Segoe UI", 9F);
            btnEkspor.Location = new Point(652, 413);
            btnEkspor.Name = "btnEkspor";
            btnEkspor.Size = new Size(169, 32);
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
            btnCetak.Location = new Point(652, 458);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(169, 32);
            btnCetak.TabIndex = 0;
            btnCetak.Text = "Cetak Laporan";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(16, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 35);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "LAPORAN AKTIVITAS ADMIN";
            // 
            // FormLaporanAdmin
            // 
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(839, 545);
            Controls.Add(btnCetak);
            Controls.Add(btnEkspor);
            Controls.Add(pnlSummary);
            Controls.Add(dgvLaporan);
            Controls.Add(pnlFilter);
            Controls.Add(lblTitle);
            Controls.Add(btnKembali);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLaporanAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unimind Admin - Panel Laporan";
            Load += FormLaporanAdmin_Load;
            pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            pnlSummary.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFilter;
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnKembali;
    }
}