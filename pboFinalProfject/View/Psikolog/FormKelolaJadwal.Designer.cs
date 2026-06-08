namespace pboFinalProfject.view
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
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).BeginInit();
            SuspendLayout();
            // 
            // cmbHari
            // 
            cmbHari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHari.Items.AddRange(new object[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            cmbHari.Location = new Point(1221, 225);
            cmbHari.Name = "cmbHari";
            cmbHari.Size = new Size(253, 33);
            cmbHari.TabIndex = 1;
            // 
            // dtpJamMulai
            // 
            dtpJamMulai.CustomFormat = "HH:mm";
            dtpJamMulai.Format = DateTimePickerFormat.Custom;
            dtpJamMulai.Location = new Point(1221, 310);
            dtpJamMulai.Name = "dtpJamMulai";
            dtpJamMulai.ShowUpDown = true;
            dtpJamMulai.Size = new Size(253, 31);
            dtpJamMulai.TabIndex = 2;
            // 
            // dtpJamSelesai
            // 
            dtpJamSelesai.CustomFormat = "HH:mm";
            dtpJamSelesai.Format = DateTimePickerFormat.Custom;
            dtpJamSelesai.Location = new Point(1221, 395);
            dtpJamSelesai.Name = "dtpJamSelesai";
            dtpJamSelesai.ShowUpDown = true;
            dtpJamSelesai.Size = new Size(253, 31);
            dtpJamSelesai.TabIndex = 3;
            // 
            // cmbMetode
            // 
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Items.AddRange(new object[] { "Online", "Offline" });
            cmbMetode.Location = new Point(1221, 482);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(253, 33);
            cmbMetode.TabIndex = 4;
            // 
            // tbKuota
            // 
            tbKuota.Location = new Point(1221, 566);
            tbKuota.Name = "tbKuota";
            tbKuota.Size = new Size(253, 31);
            tbKuota.TabIndex = 5;
            // 
            // chkIsActive
            // 
            chkIsActive.BackColor = Color.White;
            chkIsActive.FlatStyle = FlatStyle.Flat;
            chkIsActive.ForeColor = Color.Black;
            chkIsActive.Location = new Point(1221, 641);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(253, 31);
            chkIsActive.TabIndex = 6;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = false;
            // 
            // dgvSlotJadwal
            // 
            dgvSlotJadwal.AllowUserToAddRows = false;
            dgvSlotJadwal.BackgroundColor = Color.FromArgb(74, 222, 222);
            dgvSlotJadwal.ColumnHeadersHeight = 34;
            dgvSlotJadwal.Location = new Point(283, 184);
            dgvSlotJadwal.Name = "dgvSlotJadwal";
            dgvSlotJadwal.ReadOnly = true;
            dgvSlotJadwal.RowHeadersWidth = 62;
            dgvSlotJadwal.Size = new Size(754, 507);
            dgvSlotJadwal.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(28, 167, 236);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(1164, 706);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(310, 56);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.Gray;
            btnBersihkan.ForeColor = Color.White;
            btnBersihkan.Location = new Point(1026, 719);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(95, 30);
            btnBersihkan.TabIndex = 9;
            btnBersihkan.Text = "Clear";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(1164, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(310, 56);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormKelolaJadwal
            // 
            BackColor = Color.FromArgb(31, 47, 152);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1514, 808);
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
            Name = "FormKelolaJadwal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kelola Jadwal - UniMind";
            Load += FormKelolaJadwal_Load_1;
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
        private System.Windows.Forms.Button btnKembali;
    }
}