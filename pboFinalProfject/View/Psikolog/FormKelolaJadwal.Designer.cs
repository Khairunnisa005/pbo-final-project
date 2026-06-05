namespace UniMind
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
            lblJudul = new Label();
            lblHari = new Label();
            cmbHari = new ComboBox();
            lblJamMulai = new Label();
            dtpJamMulai = new DateTimePicker();
            lblJamSelesai = new Label();
            dtpJamSelesai = new DateTimePicker();
            lblMetode = new Label();
            cmbMetode = new ComboBox();
            lblKuota = new Label();
            tbKuota = new TextBox();
            lblIsActive = new Label();
            chkIsActive = new CheckBox();
            dgvSlotJadwal = new DataGridView();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(20, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(400, 30);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Manajemen Slot Jadwal Konseling";
            // 
            // lblHari
            // 
            lblHari.BackColor = Color.FromArgb(31, 47, 152);
            lblHari.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHari.ForeColor = Color.White;
            lblHari.Location = new Point(874, 70);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(200, 38);
            lblHari.TabIndex = 11;
            lblHari.Text = "Hari";
            // 
            // cmbHari
            // 
            cmbHari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHari.Items.AddRange(new object[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            cmbHari.Location = new Point(874, 111);
            cmbHari.Name = "cmbHari";
            cmbHari.Size = new Size(200, 33);
            cmbHari.TabIndex = 1;
            // 
            // lblJamMulai
            // 
            lblJamMulai.BackColor = Color.FromArgb(31, 47, 152);
            lblJamMulai.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJamMulai.ForeColor = Color.White;
            lblJamMulai.Location = new Point(874, 147);
            lblJamMulai.Name = "lblJamMulai";
            lblJamMulai.Size = new Size(200, 38);
            lblJamMulai.TabIndex = 11;
            lblJamMulai.Text = "Jam Mulai";
            // 
            // dtpJamMulai
            // 
            dtpJamMulai.CustomFormat = "HH:mm";
            dtpJamMulai.Format = DateTimePickerFormat.Custom;
            dtpJamMulai.Location = new Point(874, 188);
            dtpJamMulai.Name = "dtpJamMulai";
            dtpJamMulai.ShowUpDown = true;
            dtpJamMulai.Size = new Size(200, 31);
            dtpJamMulai.TabIndex = 2;
            // 
            // lblJamSelesai
            // 
            lblJamSelesai.BackColor = Color.FromArgb(31, 47, 152);
            lblJamSelesai.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJamSelesai.ForeColor = Color.White;
            lblJamSelesai.Location = new Point(874, 222);
            lblJamSelesai.Name = "lblJamSelesai";
            lblJamSelesai.Size = new Size(200, 38);
            lblJamSelesai.TabIndex = 12;
            lblJamSelesai.Text = "Jam Selesai";
            // 
            // dtpJamSelesai
            // 
            dtpJamSelesai.CustomFormat = "HH:mm";
            dtpJamSelesai.Format = DateTimePickerFormat.Custom;
            dtpJamSelesai.Location = new Point(874, 263);
            dtpJamSelesai.Name = "dtpJamSelesai";
            dtpJamSelesai.ShowUpDown = true;
            dtpJamSelesai.Size = new Size(200, 31);
            dtpJamSelesai.TabIndex = 3;
            // 
            // lblMetode
            // 
            lblMetode.BackColor = Color.FromArgb(31, 47, 152);
            lblMetode.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetode.ForeColor = Color.White;
            lblMetode.Location = new Point(874, 297);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(200, 38);
            lblMetode.TabIndex = 13;
            lblMetode.Text = "Metode";
            // 
            // cmbMetode
            // 
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Items.AddRange(new object[] { "Online", "Offline" });
            cmbMetode.Location = new Point(874, 338);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(200, 33);
            cmbMetode.TabIndex = 4;
            // 
            // lblKuota
            // 
            lblKuota.BackColor = Color.FromArgb(31, 47, 152);
            lblKuota.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKuota.ForeColor = Color.White;
            lblKuota.Location = new Point(874, 374);
            lblKuota.Name = "lblKuota";
            lblKuota.Size = new Size(200, 38);
            lblKuota.TabIndex = 14;
            lblKuota.Text = "Kuota";
            // 
            // tbKuota
            // 
            tbKuota.Location = new Point(874, 415);
            tbKuota.Name = "tbKuota";
            tbKuota.Size = new Size(200, 31);
            tbKuota.TabIndex = 5;
            // 
            // lblIsActive
            // 
            lblIsActive.BackColor = Color.FromArgb(31, 47, 152);
            lblIsActive.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsActive.ForeColor = Color.White;
            lblIsActive.Location = new Point(874, 449);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(200, 38);
            lblIsActive.TabIndex = 15;
            lblIsActive.Text = "Status";
            // 
            // chkIsActive
            // 
            chkIsActive.BackColor = Color.White;
            chkIsActive.FlatStyle = FlatStyle.Flat;
            chkIsActive.ForeColor = Color.Black;
            chkIsActive.Location = new Point(874, 490);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(200, 31);
            chkIsActive.TabIndex = 6;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = false;
            // 
            // dgvSlotJadwal
            // 
            dgvSlotJadwal.AllowUserToAddRows = false;
            dgvSlotJadwal.BackgroundColor = Color.FromArgb(74, 222, 222);
            dgvSlotJadwal.ColumnHeadersHeight = 34;
            dgvSlotJadwal.Location = new Point(20, 70);
            dgvSlotJadwal.Name = "dgvSlotJadwal";
            dgvSlotJadwal.ReadOnly = true;
            dgvSlotJadwal.RowHeadersWidth = 62;
            dgvSlotJadwal.Size = new Size(838, 451);
            dgvSlotJadwal.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(28, 167, 236);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(979, 527);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(95, 30);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(120, 127, 246);
            btnUbah.ForeColor = Color.White;
            btnUbah.Location = new Point(874, 527);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(95, 30);
            btnUbah.TabIndex = 7;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(773, 527);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(95, 30);
            btnHapus.TabIndex = 8;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.Gray;
            btnBersihkan.ForeColor = Color.White;
            btnBersihkan.Location = new Point(672, 527);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(95, 30);
            btnBersihkan.TabIndex = 9;
            btnBersihkan.Text = "Clear";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // FormKelolaJadwal
            // 
            BackColor = Color.FromArgb(31, 47, 152);
            ClientSize = new Size(1109, 640);
            Controls.Add(lblHari);
            Controls.Add(lblJamMulai);
            Controls.Add(lblJamSelesai);
            Controls.Add(lblMetode);
            Controls.Add(lblKuota);
            Controls.Add(lblIsActive);
            Controls.Add(lblJudul);
            Controls.Add(cmbHari);
            Controls.Add(dtpJamMulai);
            Controls.Add(dtpJamSelesai);
            Controls.Add(cmbMetode);
            Controls.Add(tbKuota);
            Controls.Add(chkIsActive);
            Controls.Add(dgvSlotJadwal);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(btnBersihkan);
            Name = "FormKelolaJadwal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kelola Jadwal - UniMind";
            Load += FormKelolaJadwal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.Label lblJamMulai;
        private System.Windows.Forms.DateTimePicker dtpJamMulai;
        private System.Windows.Forms.Label lblJamSelesai;
        private System.Windows.Forms.DateTimePicker dtpJamSelesai;
        private System.Windows.Forms.Label lblMetode;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.Label lblKuota;
        private System.Windows.Forms.TextBox tbKuota;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.DataGridView dgvSlotJadwal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersihkan;
    }
}