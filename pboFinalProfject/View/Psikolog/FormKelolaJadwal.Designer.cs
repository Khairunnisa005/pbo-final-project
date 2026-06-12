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
            btnKembali = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).BeginInit();
            SuspendLayout();
            // 
            // cmbHari
            // 
            cmbHari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHari.Items.AddRange(new object[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            cmbHari.Location = new Point(1251, 246);
            cmbHari.Name = "cmbHari";
            cmbHari.Size = new Size(235, 28);
            cmbHari.TabIndex = 1;
            // 
            // dtpJamMulai
            // 
            dtpJamMulai.CustomFormat = "HH:mm";
            dtpJamMulai.Format = DateTimePickerFormat.Custom;
            dtpJamMulai.Location = new Point(1251, 332);
            dtpJamMulai.Name = "dtpJamMulai";
            dtpJamMulai.ShowUpDown = true;
            dtpJamMulai.Size = new Size(235, 27);
            dtpJamMulai.TabIndex = 2;
            // 
            // dtpJamSelesai
            // 
            dtpJamSelesai.CustomFormat = "HH:mm";
            dtpJamSelesai.Format = DateTimePickerFormat.Custom;
            dtpJamSelesai.Location = new Point(1251, 423);
            dtpJamSelesai.Name = "dtpJamSelesai";
            dtpJamSelesai.ShowUpDown = true;
            dtpJamSelesai.Size = new Size(235, 27);
            dtpJamSelesai.TabIndex = 3;
            // 
            // cmbMetode
            // 
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Items.AddRange(new object[] { "Online", "Offline" });
            cmbMetode.Location = new Point(1251, 515);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(235, 28);
            cmbMetode.TabIndex = 4;
            // 
            // tbKuota
            // 
            tbKuota.Location = new Point(1251, 604);
            tbKuota.Name = "tbKuota";
            tbKuota.Size = new Size(235, 27);
            tbKuota.TabIndex = 5;
            // 
            // chkIsActive
            // 
            chkIsActive.BackColor = Color.White;
            chkIsActive.FlatStyle = FlatStyle.Flat;
            chkIsActive.ForeColor = Color.Black;
            chkIsActive.Location = new Point(1245, 679);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(241, 31);
            chkIsActive.TabIndex = 6;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = false;
            // 
            // dgvSlotJadwal
            // 
            dgvSlotJadwal.AllowUserToAddRows = false;
            dgvSlotJadwal.BackgroundColor = Color.FromArgb(74, 222, 222);
            dgvSlotJadwal.ColumnHeadersHeight = 34;
            dgvSlotJadwal.Location = new Point(303, 155);
            dgvSlotJadwal.Name = "dgvSlotJadwal";
            dgvSlotJadwal.ReadOnly = true;
            dgvSlotJadwal.RowHeadersWidth = 62;
            dgvSlotJadwal.Size = new Size(832, 577);
            dgvSlotJadwal.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(28, 167, 236);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(1179, 746);
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
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(1383, 22);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(108, 56);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += BtnKembali_Click;
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
            // FormKelolaJadwal
            // 
            BackColor = Color.FromArgb(31, 47, 152);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1518, 860);
            Controls.Add(cmbHari);
            Controls.Add(dtpJamMulai);
            Controls.Add(dtpJamSelesai);
            Controls.Add(cmbMetode);
            Controls.Add(tbKuota);
            Controls.Add(chkIsActive);
            Controls.Add(dgvSlotJadwal);
            Controls.Add(btnTambah);
            Controls.Add(btnBersihkan);
            Controls.Add(btnKembali);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKelolaJadwal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Jadwal - UniMind";
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
        // duplicate fields removed
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
    }
}