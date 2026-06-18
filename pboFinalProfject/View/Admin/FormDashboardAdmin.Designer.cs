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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardAdmin));
            btnRefresh = new Button();
            pnlStatMahasiswa = new Panel();
            lblTotalMahasiswa = new Label();
            lblTitleMhs = new Label();
            pnlStatKonselor = new Panel();
            lblTotalKonselor = new Label();
            lblTitleKonselor = new Label();
            dgvAntreanKonseling = new DataGridView();
            btnKelolaUser = new Button();
            btnLaporan = new Button();
            btnKelolaUser2 = new Button();
            btnLaporan2 = new Button();
            btnDashboard = new Button();
            btnKeluar = new Button();
            pnlStatMahasiswa.SuspendLayout();
            pnlStatKonselor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanKonseling).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(247, 249, 253);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(0, 192, 0);
            btnRefresh.Location = new Point(1390, 95);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 47);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh   ";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlStatMahasiswa
            // 
            pnlStatMahasiswa.BackColor = Color.FromArgb(120, 127, 246);
            pnlStatMahasiswa.Controls.Add(lblTotalMahasiswa);
            pnlStatMahasiswa.Controls.Add(lblTitleMhs);
            pnlStatMahasiswa.Location = new Point(352, 200);
            pnlStatMahasiswa.Margin = new Padding(3, 4, 3, 4);
            pnlStatMahasiswa.Name = "pnlStatMahasiswa";
            pnlStatMahasiswa.Size = new Size(264, 125);
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
            pnlStatKonselor.Location = new Point(674, 200);
            pnlStatKonselor.Margin = new Padding(3, 4, 3, 4);
            pnlStatKonselor.Name = "pnlStatKonselor";
            pnlStatKonselor.Size = new Size(261, 125);
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
            dgvAntreanKonseling.Location = new Point(352, 380);
            dgvAntreanKonseling.Margin = new Padding(3, 4, 3, 4);
            dgvAntreanKonseling.Name = "dgvAntreanKonseling";
            dgvAntreanKonseling.ReadOnly = true;
            dgvAntreanKonseling.RowHeadersWidth = 51;
            dgvAntreanKonseling.RowTemplate.Height = 30;
            dgvAntreanKonseling.Size = new Size(1126, 408);
            dgvAntreanKonseling.TabIndex = 3;
            dgvAntreanKonseling.CellContentClick += dgvAntreanKonseling_CellContentClick;
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
            btnKelolaUser.TabIndex = 2;
            btnKelolaUser.Text = "Kelola Pengguna";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = false;
            btnKelolaUser.Click += btnKelolaUser_Click;
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
            btnLaporan.TabIndex = 2;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnKelolaUser2
            // 
            btnKelolaUser2.BackColor = Color.Transparent;
            btnKelolaUser2.FlatAppearance.BorderSize = 0;
            btnKelolaUser2.FlatStyle = FlatStyle.Flat;
            btnKelolaUser2.Font = new Font("Corbel", 9.8F, FontStyle.Bold);
            btnKelolaUser2.ForeColor = Color.DarkBlue;
            btnKelolaUser2.Location = new Point(996, 257);
            btnKelolaUser2.Margin = new Padding(3, 4, 3, 4);
            btnKelolaUser2.Name = "btnKelolaUser2";
            btnKelolaUser2.Size = new Size(238, 45);
            btnKelolaUser2.TabIndex = 2;
            btnKelolaUser2.Text = "Kelola Pengguna";
            btnKelolaUser2.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser2.UseVisualStyleBackColor = false;
            btnKelolaUser2.Click += btnKelolaUser_Click;
            // 
            // btnLaporan2
            // 
            btnLaporan2.BackColor = Color.Transparent;
            btnLaporan2.FlatAppearance.BorderSize = 0;
            btnLaporan2.FlatStyle = FlatStyle.Flat;
            btnLaporan2.Font = new Font("Calibri Light", 10.5F);
            btnLaporan2.ForeColor = Color.DarkBlue;
            btnLaporan2.Location = new Point(1263, 257);
            btnLaporan2.Margin = new Padding(3, 4, 3, 4);
            btnLaporan2.Name = "btnLaporan2";
            btnLaporan2.Size = new Size(233, 45);
            btnLaporan2.TabIndex = 2;
            btnLaporan2.Text = "Lihat Laporan";
            btnLaporan2.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan2.UseVisualStyleBackColor = false;
            btnLaporan2.Click += btnLaporan_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri Light", 11.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(71, 169);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 10.9F);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(83, 755);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(179, 41);
            btnKeluar.TabIndex = 11;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(240, 244, 248);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKeluar);
            Controls.Add(btnDashboard);
            Controls.Add(btnLaporan2);
            Controls.Add(btnKelolaUser2);
            Controls.Add(btnLaporan);
            Controls.Add(btnKelolaUser);
            Controls.Add(dgvAntreanKonseling);
            Controls.Add(btnRefresh);
            Controls.Add(pnlStatKonselor);
            Controls.Add(pnlStatMahasiswa);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind Admin Dashboard Center";
            WindowState = FormWindowState.Maximized;
            pnlStatMahasiswa.ResumeLayout(false);
            pnlStatMahasiswa.PerformLayout();
            pnlStatKonselor.ResumeLayout(false);
            pnlStatKonselor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanKonseling).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlStatMahasiswa;
        private System.Windows.Forms.Label lblTotalMahasiswa;
        private System.Windows.Forms.Label lblTitleMhs;
        private System.Windows.Forms.Panel pnlStatKonselor;
        private System.Windows.Forms.Label lblTotalKonselor;
        private System.Windows.Forms.Label lblTitleKonselor;
        private System.Windows.Forms.DataGridView dgvAntreanKonseling;
        private System.Windows.Forms.Button btnKelolaUser;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLaporan2;
        private System.Windows.Forms.Button btnKelolaUser2;
        private Button btnDashboard;
        private Button btnKeluar;
    }
}