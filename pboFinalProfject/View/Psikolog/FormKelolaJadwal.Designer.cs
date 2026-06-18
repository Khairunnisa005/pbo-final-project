namespace pboFinalProfject.View
{
    partial class FormKelolaJadwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaJadwal));
            cmbHari = new ComboBox();
            dtpJamMulai = new DateTimePicker();
            dtpJamSelesai = new DateTimePicker();
            cmbMetode = new ComboBox();
            tbKuota = new TextBox();
            chkIsActive = new CheckBox();
            dgvSlotJadwal = new DataGridView();
            btnTambah = new Button();
            btnBersihkan = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnDashboard = new Button();
            btnKelolaJadwal = new Button();
            btnKeluar = new Button();
            btnKelolaProfil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).BeginInit();
            SuspendLayout();
            // 
            // cmbHari
            // 
            cmbHari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHari.Items.AddRange(new object[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            cmbHari.Location = new Point(1268, 246);
            cmbHari.Name = "cmbHari";
            cmbHari.Size = new Size(235, 28);
            cmbHari.TabIndex = 1;
            // 
            // dtpJamMulai
            // 
            dtpJamMulai.CustomFormat = "HH:mm";
            dtpJamMulai.Format = DateTimePickerFormat.Custom;
            dtpJamMulai.Location = new Point(1268, 335);
            dtpJamMulai.Name = "dtpJamMulai";
            dtpJamMulai.ShowUpDown = true;
            dtpJamMulai.Size = new Size(235, 27);
            dtpJamMulai.TabIndex = 2;
            // 
            // dtpJamSelesai
            // 
            dtpJamSelesai.CustomFormat = "HH:mm";
            dtpJamSelesai.Format = DateTimePickerFormat.Custom;
            dtpJamSelesai.Location = new Point(1268, 426);
            dtpJamSelesai.Name = "dtpJamSelesai";
            dtpJamSelesai.ShowUpDown = true;
            dtpJamSelesai.Size = new Size(235, 27);
            dtpJamSelesai.TabIndex = 3;
            // 
            // cmbMetode
            // 
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Items.AddRange(new object[] { "Online", "Offline" });
            cmbMetode.Location = new Point(1268, 518);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(235, 28);
            cmbMetode.TabIndex = 4;
            // 
            // tbKuota
            // 
            tbKuota.Location = new Point(1268, 609);
            tbKuota.Name = "tbKuota";
            tbKuota.Size = new Size(235, 27);
            tbKuota.TabIndex = 5;
            // 
            // chkIsActive
            // 
            chkIsActive.BackColor = Color.White;
            chkIsActive.FlatStyle = FlatStyle.Flat;
            chkIsActive.ForeColor = Color.Black;
            chkIsActive.Location = new Point(1257, 687);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(246, 31);
            chkIsActive.TabIndex = 6;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = false;
            // 
            // dgvSlotJadwal
            // 
            dgvSlotJadwal.AllowUserToAddRows = false;
            dgvSlotJadwal.BackgroundColor = Color.FromArgb(74, 222, 222);
            dgvSlotJadwal.ColumnHeadersHeight = 34;
            dgvSlotJadwal.Location = new Point(303, 144);
            dgvSlotJadwal.Name = "dgvSlotJadwal";
            dgvSlotJadwal.ReadOnly = true;
            dgvSlotJadwal.RowHeadersWidth = 62;
            dgvSlotJadwal.Size = new Size(852, 577);
            dgvSlotJadwal.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(28, 167, 236);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(1198, 754);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(315, 56);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click_1;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.Gray;
            btnBersihkan.ForeColor = Color.White;
            btnBersihkan.Location = new Point(848, 749);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(95, 56);
            btnBersihkan.TabIndex = 9;
            btnBersihkan.Text = "Clear";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(28, 167, 236);
            btnUbah.ForeColor = Color.White;
            btnUbah.Location = new Point(1045, 749);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(90, 56);
            btnUbah.TabIndex = 6;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(28, 167, 236);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(949, 749);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(90, 56);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri Light", 11.5F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(75, 162);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 23;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnKelolaJadwal
            // 
            btnKelolaJadwal.BackColor = Color.FromArgb(31, 81, 199);
            btnKelolaJadwal.FlatAppearance.BorderSize = 0;
            btnKelolaJadwal.FlatStyle = FlatStyle.Flat;
            btnKelolaJadwal.Font = new Font("Calibri Light", 11, FontStyle.Bold);
            btnKelolaJadwal.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaJadwal.Location = new Point(77, 231);
            btnKelolaJadwal.Name = "btnKelolaJadwal";
            btnKelolaJadwal.RightToLeft = RightToLeft.No;
            btnKelolaJadwal.Size = new Size(195, 45);
            btnKelolaJadwal.TabIndex = 20;
            btnKelolaJadwal.Text = "Jadwal Konsultasi";
            btnKelolaJadwal.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaJadwal.UseVisualStyleBackColor = false;
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
            btnKeluar.TabIndex = 22;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnKelolaProfil
            // 
            btnKelolaProfil.BackColor = Color.Transparent;
            btnKelolaProfil.FlatAppearance.BorderSize = 0;
            btnKelolaProfil.FlatStyle = FlatStyle.Flat;
            btnKelolaProfil.Font = new Font("Calibri", 10.9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaProfil.ForeColor = SystemColors.ButtonHighlight;
            btnKelolaProfil.Location = new Point(77, 294);
            btnKelolaProfil.Margin = new Padding(3, 4, 3, 4);
            btnKelolaProfil.Name = "btnKelolaProfil";
            btnKelolaProfil.Size = new Size(165, 38);
            btnKelolaProfil.TabIndex = 21;
            btnKelolaProfil.Text = "Profil";
            btnKelolaProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaProfil.UseVisualStyleBackColor = false;
            // 
            // FormKelolaJadwal
            // 
            BackColor = Color.FromArgb(31, 47, 152);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnDashboard);
            Controls.Add(btnKelolaJadwal);
            Controls.Add(btnKeluar);
            Controls.Add(btnKelolaProfil);
            Controls.Add(cmbHari);
            Controls.Add(dtpJamMulai);
            Controls.Add(dtpJamSelesai);
            Controls.Add(cmbMetode);
            Controls.Add(tbKuota);
            Controls.Add(chkIsActive);
            Controls.Add(dgvSlotJadwal);
            Controls.Add(btnTambah);
            Controls.Add(btnBersihkan);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKelolaJadwal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Jadwal - UniMind";
            WindowState = FormWindowState.Maximized;
            Load += FormKelolaJadwal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.DateTimePicker dtpJamMulai;
        private System.Windows.Forms.DateTimePicker dtpJamSelesai;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.TextBox tbKuota;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.DataGridView dgvSlotJadwal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private Button btnDashboard;
        private Button btnKelolaJadwal;
        private Button btnKeluar;
        private Button btnKelolaProfil;
    }
}