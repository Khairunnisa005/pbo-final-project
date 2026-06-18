namespace pboFinalProfject.View
{
    partial class FormDashboardPsikolog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardPsikolog));
            dgvPasien = new DataGridView();
            btnKelolaJadwal = new Button();
            btnKeluar = new Button();
            btnKelolaProfil = new Button();
            btnKonselor = new Button();
            btnDashboard = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPasien).BeginInit();
            SuspendLayout();
            // 
            // dgvPasien
            // 
            dgvPasien.BackgroundColor = Color.FromArgb(74, 222, 222);
            dgvPasien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(120, 127, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPasien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPasien.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(123, 213, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 47, 152);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 167, 236);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPasien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPasien.EnableHeadersVisualStyles = false;
            dgvPasien.Location = new Point(341, 237);
            dgvPasien.Margin = new Padding(3, 4, 3, 4);
            dgvPasien.Name = "dgvPasien";
            dgvPasien.RowHeadersWidth = 51;
            dgvPasien.RowTemplate.Height = 30;
            dgvPasien.Size = new Size(1176, 468);
            dgvPasien.TabIndex = 1;
            // 
            // btnKelolaJadwal
            // 
            btnKelolaJadwal.BackColor = Color.Transparent;
            btnKelolaJadwal.FlatAppearance.BorderSize = 0;
            btnKelolaJadwal.FlatStyle = FlatStyle.Flat;
            btnKelolaJadwal.Font = new Font("Calibri", 10.9F);
            btnKelolaJadwal.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaJadwal.Location = new Point(75, 228);
            btnKelolaJadwal.Name = "btnKelolaJadwal";
            btnKelolaJadwal.Size = new Size(181, 45);
            btnKelolaJadwal.TabIndex = 2;
            btnKelolaJadwal.Text = "Jadwal Konsultasi";
            btnKelolaJadwal.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaJadwal.UseVisualStyleBackColor = false;
            btnKelolaJadwal.Click += btnKelolaJadwal_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(83, 776);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(179, 41);
            btnKeluar.TabIndex = 10;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // btnKelolaProfil
            // 
            btnKelolaProfil.BackColor = Color.Transparent;
            btnKelolaProfil.FlatAppearance.BorderSize = 0;
            btnKelolaProfil.FlatStyle = FlatStyle.Flat;
            btnKelolaProfil.Font = new Font("Calibri", 10.9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaProfil.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaProfil.Location = new Point(76, 295);
            btnKelolaProfil.Margin = new Padding(3, 4, 3, 4);
            btnKelolaProfil.Name = "btnKelolaProfil";
            btnKelolaProfil.Size = new Size(165, 38);
            btnKelolaProfil.TabIndex = 2;
            btnKelolaProfil.Text = "Profil";
            btnKelolaProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaProfil.UseVisualStyleBackColor = false;
            btnKelolaProfil.Click += btnKelolaProfil_Click;
            // 
            // btnKonselor
            // 
            btnKonselor.Location = new Point(0, 0);
            btnKonselor.Name = "btnKonselor";
            btnKonselor.Size = new Size(75, 23);
            btnKonselor.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri", 10.8F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(76, 163);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 11;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // FormDashboardPsikolog
            // 
            BackColor = Color.FromArgb(31, 47, 152);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnDashboard);
            Controls.Add(btnKelolaJadwal);
            Controls.Add(dgvPasien);
            Controls.Add(btnKeluar);
            Controls.Add(btnKelolaProfil);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDashboardPsikolog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvPasien).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPasien;
        private System.Windows.Forms.Button btnKelolaJadwal;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnKelolaProfil;
        private Button btnKonselor;
        private Button btnDashboard;
    }
}