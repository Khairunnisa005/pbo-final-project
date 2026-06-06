namespace pboFinalProfject
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            panelForm = new Panel();
            btnBersihkan = new Button();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            chkIsActive = new CheckBox();
            lblIsActive = new Label();
            tbKuota = new TextBox();
            lblKuota = new Label();
            cmbMetode = new ComboBox();
            lblMetode = new Label();
            dtpJamSelesai = new DateTimePicker();
            lblJamSelesai = new Label();
            dtpJamMulai = new DateTimePicker();
            lblJamMulai = new Label();
            cmbHari = new ComboBox();
            lblHari = new Label();
            dgvSlotJadwal = new DataGridView();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Manajemen Jadwal Konseling";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(240, 242, 245);
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(btnBersihkan);
            panelForm.Controls.Add(btnTambah);
            panelForm.Controls.Add(btnUbah);
            panelForm.Controls.Add(btnHapus);
            panelForm.Controls.Add(chkIsActive);
            panelForm.Controls.Add(lblIsActive);
            panelForm.Controls.Add(tbKuota);
            panelForm.Controls.Add(lblKuota);
            panelForm.Controls.Add(cmbMetode);
            panelForm.Controls.Add(lblMetode);
            panelForm.Controls.Add(dtpJamSelesai);
            panelForm.Controls.Add(lblJamSelesai);
            panelForm.Controls.Add(dtpJamMulai);
            panelForm.Controls.Add(lblJamMulai);
            panelForm.Controls.Add(cmbHari);
            panelForm.Controls.Add(lblHari);
            panelForm.Location = new Point(20, 70);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(380, 661);
            panelForm.TabIndex = 1;
            panelForm.Paint += panelForm_Paint;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.Gray;
            btnBersihkan.FlatStyle = FlatStyle.Flat;
            btnBersihkan.Font = new Font("Segoe UI", 9F);
            btnBersihkan.ForeColor = Color.White;
            btnBersihkan.Location = new Point(20, 520);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(340, 35);
            btnBersihkan.TabIndex = 10;
            btnBersihkan.Text = "Bersihkan Form";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(28, 167, 236);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(20, 470);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(110, 40);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(120, 127, 246);
            btnUbah.FlatStyle = FlatStyle.Flat;
            btnUbah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUbah.ForeColor = Color.White;
            btnUbah.Location = new Point(135, 470);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(110, 40);
            btnUbah.TabIndex = 8;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(250, 470);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 40);
            btnHapus.TabIndex = 9;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.BackColor = Color.White;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.FlatStyle = FlatStyle.Flat;
            chkIsActive.Font = new Font("Segoe UI", 10F);
            chkIsActive.Location = new Point(20, 423);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(62, 27);
            chkIsActive.TabIndex = 11;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = false;
            // 
            // lblIsActive
            // 
            lblIsActive.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIsActive.ForeColor = Color.FromArgb(31, 47, 152);
            lblIsActive.Location = new Point(20, 395);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(100, 25);
            lblIsActive.TabIndex = 12;
            lblIsActive.Text = "Status";
            lblIsActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbKuota
            // 
            tbKuota.Font = new Font("Segoe UI", 10F);
            tbKuota.Location = new Point(20, 348);
            tbKuota.Name = "tbKuota";
            tbKuota.Size = new Size(340, 30);
            tbKuota.TabIndex = 5;
            tbKuota.Text = "1";
            // 
            // lblKuota
            // 
            lblKuota.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKuota.ForeColor = Color.FromArgb(31, 47, 152);
            lblKuota.Location = new Point(20, 320);
            lblKuota.Name = "lblKuota";
            lblKuota.Size = new Size(100, 25);
            lblKuota.TabIndex = 13;
            lblKuota.Text = "Kuota";
            lblKuota.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbMetode
            // 
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Font = new Font("Segoe UI", 10F);
            cmbMetode.Items.AddRange(new object[] { "Online", "Luring" });
            cmbMetode.Location = new Point(20, 273);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(340, 31);
            cmbMetode.TabIndex = 4;
            // 
            // lblMetode
            // 
            lblMetode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMetode.ForeColor = Color.FromArgb(31, 47, 152);
            lblMetode.Location = new Point(20, 245);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(100, 25);
            lblMetode.TabIndex = 14;
            lblMetode.Text = "Metode";
            lblMetode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpJamSelesai
            // 
            dtpJamSelesai.CustomFormat = "HH:mm";
            dtpJamSelesai.Font = new Font("Segoe UI", 10F);
            dtpJamSelesai.Format = DateTimePickerFormat.Custom;
            dtpJamSelesai.Location = new Point(20, 198);
            dtpJamSelesai.Name = "dtpJamSelesai";
            dtpJamSelesai.ShowUpDown = true;
            dtpJamSelesai.Size = new Size(340, 30);
            dtpJamSelesai.TabIndex = 3;
            // 
            // lblJamSelesai
            // 
            lblJamSelesai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJamSelesai.ForeColor = Color.FromArgb(31, 47, 152);
            lblJamSelesai.Location = new Point(20, 170);
            lblJamSelesai.Name = "lblJamSelesai";
            lblJamSelesai.Size = new Size(100, 25);
            lblJamSelesai.TabIndex = 15;
            lblJamSelesai.Text = "Jam Selesai";
            lblJamSelesai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpJamMulai
            // 
            dtpJamMulai.CustomFormat = "HH:mm";
            dtpJamMulai.Font = new Font("Segoe UI", 10F);
            dtpJamMulai.Format = DateTimePickerFormat.Custom;
            dtpJamMulai.Location = new Point(20, 123);
            dtpJamMulai.Name = "dtpJamMulai";
            dtpJamMulai.ShowUpDown = true;
            dtpJamMulai.Size = new Size(340, 30);
            dtpJamMulai.TabIndex = 2;
            // 
            // lblJamMulai
            // 
            lblJamMulai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJamMulai.ForeColor = Color.FromArgb(31, 47, 152);
            lblJamMulai.Location = new Point(20, 95);
            lblJamMulai.Name = "lblJamMulai";
            lblJamMulai.Size = new Size(100, 25);
            lblJamMulai.TabIndex = 16;
            lblJamMulai.Text = "Jam Mulai";
            lblJamMulai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbHari
            // 
            cmbHari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHari.Font = new Font("Segoe UI", 10F);
            cmbHari.Items.AddRange(new object[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            cmbHari.Location = new Point(20, 48);
            cmbHari.Name = "cmbHari";
            cmbHari.Size = new Size(340, 31);
            cmbHari.TabIndex = 1;
            // 
            // lblHari
            // 
            lblHari.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHari.ForeColor = Color.FromArgb(31, 47, 152);
            lblHari.Location = new Point(20, 20);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(100, 25);
            lblHari.TabIndex = 17;
            lblHari.Text = "Hari";
            lblHari.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvSlotJadwal
            // 
            dgvSlotJadwal.AllowUserToAddRows = false;
            dgvSlotJadwal.AllowUserToDeleteRows = false;
            dgvSlotJadwal.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 47, 152);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSlotJadwal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSlotJadwal.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 167, 236);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSlotJadwal.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSlotJadwal.EnableHeadersVisualStyles = false;
            dgvSlotJadwal.Location = new Point(420, 70);
            dgvSlotJadwal.Name = "dgvSlotJadwal";
            dgvSlotJadwal.ReadOnly = true;
            dgvSlotJadwal.RowHeadersVisible = false;
            dgvSlotJadwal.RowHeadersWidth = 51;
            dgvSlotJadwal.RowTemplate.Height = 30;
            dgvSlotJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlotJadwal.Size = new Size(1020, 661);
            dgvSlotJadwal.TabIndex = 6;
            // 
            // FormKelolaJadwal
            // 
            BackColor = Color.FromArgb(31, 47, 152);
            ClientSize = new Size(1517, 817);
            Controls.Add(dgvSlotJadwal);
            Controls.Add(panelForm);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKelolaJadwal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Jadwal - UniMind";
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSlotJadwal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Panel dan Label Title
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;

        // Input Components
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

        // Buttons
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersihkan;

        // DataGridView
        private System.Windows.Forms.DataGridView dgvSlotJadwal;
    }
}