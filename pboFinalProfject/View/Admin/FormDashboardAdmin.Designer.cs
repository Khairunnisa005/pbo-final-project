using pboFinalProfject.View;
using pboFinalProfject.Session;
using pboFinalProfject.Controllers;
namespace pboFinalProfject.View
{
    partial class FormDashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubJudul = new Label();
            lblJudulApp = new Label();
            btnKeluar = new Button();
            btnLogout = new Button();
            btnRefresh = new Button();
            pnlStatMahasiswa = new Panel();
            lblTotalMahasiswa = new Label();
            lblTitleMhs = new Label();
            pnlStatKonselor = new Panel();
            lblTotalKonselor = new Label();
            lblTitleKonselor = new Label();
            dgvAntreanKonseling = new DataGridView();
            lblTabelTitle = new Label();
            btnKelolaUser = new Button();
            btnLaporan = new Button();
            pnlHeader.SuspendLayout();
            pnlStatMahasiswa.SuspendLayout();
            pnlStatKonselor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanKonseling).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 47, 152);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudulApp);
            pnlHeader.Controls.Add(btnKeluar);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 10F);
            lblSubJudul.ForeColor = Color.FromArgb(74, 222, 222);
            lblSubJudul.Location = new Point(22, 54);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(277, 23);
            lblSubJudul.TabIndex = 0;
            lblSubJudul.Text = "Panel Kontrol Utama Administrator";
            // 
            // lblJudulApp
            // 
            lblJudulApp.AutoSize = true;
            lblJudulApp.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblJudulApp.ForeColor = Color.White;
            lblJudulApp.Location = new Point(20, 11);
            lblJudulApp.Name = "lblJudulApp";
            lblJudulApp.Size = new Size(128, 37);
            lblJudulApp.TabIndex = 1;
            lblJudulApp.Text = "UniMind";
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(220, 53, 69);
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(817, 15);
            btnKeluar.Margin = new Padding(2, 2, 2, 2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(76, 36);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 193, 7);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(735, 15);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 36);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(40, 167, 69);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(655, 15);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 36);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlStatMahasiswa
            // 
            pnlStatMahasiswa.BackColor = Color.FromArgb(120, 127, 246);
            pnlStatMahasiswa.Controls.Add(lblTotalMahasiswa);
            pnlStatMahasiswa.Controls.Add(lblTitleMhs);
            pnlStatMahasiswa.Location = new Point(27, 131);
            pnlStatMahasiswa.Margin = new Padding(3, 4, 3, 4);
            pnlStatMahasiswa.Name = "pnlStatMahasiswa";
            pnlStatMahasiswa.Size = new Size(240, 125);
            pnlStatMahasiswa.TabIndex = 1;
            // 
            // lblTotalMahasiswa
            // 
            lblTotalMahasiswa.AutoSize = true;
            lblTotalMahasiswa.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalMahasiswa.ForeColor = Color.White;
            lblTotalMahasiswa.Location = new Point(15, 44);
            lblTotalMahasiswa.Name = "lblTotalMahasiswa";
            lblTotalMahasiswa.Size = new Size(43, 50);
            lblTotalMahasiswa.TabIndex = 0;
            lblTotalMahasiswa.Text = "0";
            // 
            // lblTitleMhs
            // 
            lblTitleMhs.AutoSize = true;
            lblTitleMhs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleMhs.ForeColor = Color.FromArgb(31, 47, 152);
            lblTitleMhs.Location = new Point(15, 15);
            lblTitleMhs.Name = "lblTitleMhs";
            lblTitleMhs.Size = new Size(140, 23);
            lblTitleMhs.TabIndex = 1;
            lblTitleMhs.Text = "Total Mahasiswa";
            // 
            // pnlStatKonselor
            // 
            pnlStatKonselor.BackColor = Color.FromArgb(123, 213, 245);
            pnlStatKonselor.Controls.Add(lblTotalKonselor);
            pnlStatKonselor.Controls.Add(lblTitleKonselor);
            pnlStatKonselor.Location = new Point(285, 131);
            pnlStatKonselor.Margin = new Padding(3, 4, 3, 4);
            pnlStatKonselor.Name = "pnlStatKonselor";
            pnlStatKonselor.Size = new Size(240, 125);
            pnlStatKonselor.TabIndex = 2;
            // 
            // lblTotalKonselor
            // 
            lblTotalKonselor.AutoSize = true;
            lblTotalKonselor.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalKonselor.ForeColor = Color.FromArgb(31, 47, 152);
            lblTotalKonselor.Location = new Point(15, 44);
            lblTotalKonselor.Name = "lblTotalKonselor";
            lblTotalKonselor.Size = new Size(43, 50);
            lblTotalKonselor.TabIndex = 0;
            lblTotalKonselor.Text = "0";
            // 
            // lblTitleKonselor
            // 
            lblTitleKonselor.AutoSize = true;
            lblTitleKonselor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleKonselor.ForeColor = Color.FromArgb(31, 47, 152);
            lblTitleKonselor.Location = new Point(15, 15);
            lblTitleKonselor.Name = "lblTitleKonselor";
            lblTitleKonselor.Size = new Size(201, 23);
            lblTitleKonselor.TabIndex = 1;
            lblTitleKonselor.Text = "Konselor/Psikolog Aktif";
            // 
            // dgvAntreanKonseling
            // 
            dgvAntreanKonseling.AllowUserToAddRows = false;
            dgvAntreanKonseling.AllowUserToDeleteRows = false;
            dgvAntreanKonseling.BackgroundColor = Color.White;
            dgvAntreanKonseling.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 47, 152);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAntreanKonseling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAntreanKonseling.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(123, 213, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAntreanKonseling.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAntreanKonseling.EnableHeadersVisualStyles = false;
            dgvAntreanKonseling.Location = new Point(27, 325);
            dgvAntreanKonseling.Margin = new Padding(3, 4, 3, 4);
            dgvAntreanKonseling.Name = "dgvAntreanKonseling";
            dgvAntreanKonseling.ReadOnly = true;
            dgvAntreanKonseling.RowHeadersWidth = 51;
            dgvAntreanKonseling.RowTemplate.Height = 30;
            dgvAntreanKonseling.Size = new Size(846, 325);
            dgvAntreanKonseling.TabIndex = 3;
            // 
            // lblTabelTitle
            // 
            lblTabelTitle.AutoSize = true;
            lblTabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTabelTitle.ForeColor = Color.FromArgb(31, 47, 152);
            lblTabelTitle.Location = new Point(22, 282);
            lblTabelTitle.Name = "lblTabelTitle";
            lblTabelTitle.Size = new Size(268, 28);
            lblTabelTitle.TabIndex = 6;
            lblTabelTitle.Text = "Daftar Aktivitas Booking";
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.FromArgb(28, 167, 236);
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(546, 169);
            btnKelolaUser.Margin = new Padding(3, 4, 3, 4);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(160, 56);
            btnKelolaUser.TabIndex = 4;
            btnKelolaUser.Text = "Kelola Pengguna";
            btnKelolaUser.UseVisualStyleBackColor = false;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.FromArgb(31, 47, 152);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(713, 169);
            btnLaporan.Margin = new Padding(3, 4, 3, 4);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(160, 56);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Lihat Laporan";
            btnLaporan.UseVisualStyleBackColor = false;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(900, 687);
            Controls.Add(btnLaporan);
            Controls.Add(btnKelolaUser);
            Controls.Add(lblTabelTitle);
            Controls.Add(dgvAntreanKonseling);
            Controls.Add(pnlStatKonselor);
            Controls.Add(pnlStatMahasiswa);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind Admin Dashboard Center";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStatMahasiswa.ResumeLayout(false);
            pnlStatMahasiswa.PerformLayout();
            pnlStatKonselor.ResumeLayout(false);
            pnlStatKonselor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanKonseling).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudulApp;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Panel pnlStatMahasiswa;
        private System.Windows.Forms.Label lblTotalMahasiswa;
        private System.Windows.Forms.Label lblTitleMhs;
        private System.Windows.Forms.Panel pnlStatKonselor;
        private System.Windows.Forms.Label lblTotalKonselor;
        private System.Windows.Forms.Label lblTitleKonselor;
        private System.Windows.Forms.DataGridView dgvAntreanKonseling;
        private System.Windows.Forms.Label lblTabelTitle;
        private System.Windows.Forms.Button btnKelolaUser;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;

    }
}