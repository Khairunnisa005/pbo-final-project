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
            btnKelolaUser = new Button();
            btnLaporan = new Button();
            pnlStatMahasiswa.SuspendLayout();
            pnlStatKonselor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanKonseling).BeginInit();
            SuspendLayout();
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(220, 53, 69);
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(1382, 87);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(110, 45);
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
            btnLogout.Location = new Point(1249, 87);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 45);
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
            btnRefresh.Location = new Point(1118, 87);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 45);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlStatMahasiswa
            // 
            pnlStatMahasiswa.BackColor = Color.FromArgb(120, 127, 246);
            pnlStatMahasiswa.Controls.Add(lblTotalMahasiswa);
            pnlStatMahasiswa.Controls.Add(lblTitleMhs);
            pnlStatMahasiswa.Location = new Point(334, 183);
            pnlStatMahasiswa.Margin = new Padding(4, 5, 4, 5);
            pnlStatMahasiswa.Name = "pnlStatMahasiswa";
            pnlStatMahasiswa.Size = new Size(300, 156);
            pnlStatMahasiswa.TabIndex = 1;
            // 
            // lblTotalMahasiswa
            // 
            lblTotalMahasiswa.AutoSize = true;
            lblTotalMahasiswa.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalMahasiswa.ForeColor = Color.White;
            lblTotalMahasiswa.Location = new Point(19, 55);
            lblTotalMahasiswa.Margin = new Padding(4, 0, 4, 0);
            lblTotalMahasiswa.Name = "lblTotalMahasiswa";
            lblTotalMahasiswa.Size = new Size(50, 60);
            lblTotalMahasiswa.TabIndex = 0;
            lblTotalMahasiswa.Text = "0";
            // 
            // lblTitleMhs
            // 
            lblTitleMhs.AutoSize = true;
            lblTitleMhs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleMhs.ForeColor = Color.FromArgb(31, 47, 152);
            lblTitleMhs.Location = new Point(19, 19);
            lblTitleMhs.Margin = new Padding(4, 0, 4, 0);
            lblTitleMhs.Name = "lblTitleMhs";
            lblTitleMhs.Size = new Size(169, 28);
            lblTitleMhs.TabIndex = 1;
            lblTitleMhs.Text = "Total Mahasiswa";
            // 
            // pnlStatKonselor
            // 
            pnlStatKonselor.BackColor = Color.FromArgb(123, 213, 245);
            pnlStatKonselor.Controls.Add(lblTotalKonselor);
            pnlStatKonselor.Controls.Add(lblTitleKonselor);
            pnlStatKonselor.Location = new Point(652, 183);
            pnlStatKonselor.Margin = new Padding(4, 5, 4, 5);
            pnlStatKonselor.Name = "pnlStatKonselor";
            pnlStatKonselor.Size = new Size(298, 156);
            pnlStatKonselor.TabIndex = 2;
            // 
            // lblTotalKonselor
            // 
            lblTotalKonselor.AutoSize = true;
            lblTotalKonselor.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalKonselor.ForeColor = Color.FromArgb(31, 47, 152);
            lblTotalKonselor.Location = new Point(19, 55);
            lblTotalKonselor.Margin = new Padding(4, 0, 4, 0);
            lblTotalKonselor.Name = "lblTotalKonselor";
            lblTotalKonselor.Size = new Size(50, 60);
            lblTotalKonselor.TabIndex = 0;
            lblTotalKonselor.Text = "0";
            // 
            // lblTitleKonselor
            // 
            lblTitleKonselor.AutoSize = true;
            lblTitleKonselor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleKonselor.ForeColor = Color.FromArgb(31, 47, 152);
            lblTitleKonselor.Location = new Point(19, 19);
            lblTitleKonselor.Margin = new Padding(4, 0, 4, 0);
            lblTitleKonselor.Name = "lblTitleKonselor";
            lblTitleKonselor.Size = new Size(237, 28);
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
            dgvAntreanKonseling.Location = new Point(334, 407);
            dgvAntreanKonseling.Margin = new Padding(4, 5, 4, 5);
            dgvAntreanKonseling.Name = "dgvAntreanKonseling";
            dgvAntreanKonseling.ReadOnly = true;
            dgvAntreanKonseling.RowHeadersWidth = 51;
            dgvAntreanKonseling.RowTemplate.Height = 30;
            dgvAntreanKonseling.Size = new Size(1158, 406);
            dgvAntreanKonseling.TabIndex = 3;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.FromArgb(28, 167, 236);
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(994, 257);
            btnKelolaUser.Margin = new Padding(4, 5, 4, 5);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(200, 41);
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
            btnLaporan.Location = new Point(1259, 257);
            btnLaporan.Margin = new Padding(4, 5, 4, 5);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(200, 41);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Lihat Laporan";
            btnLaporan.UseVisualStyleBackColor = false;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1514, 808);
            Controls.Add(btnLaporan);
            Controls.Add(btnKelolaUser);
            Controls.Add(btnKeluar);
            Controls.Add(btnLogout);
            Controls.Add(dgvAntreanKonseling);
            Controls.Add(btnRefresh);
            Controls.Add(pnlStatKonselor);
            Controls.Add(pnlStatMahasiswa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind Admin Dashboard Center";
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
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
    }
}