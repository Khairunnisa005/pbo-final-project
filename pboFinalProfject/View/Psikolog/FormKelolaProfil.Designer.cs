namespace pboFinalProfject.View
{
    partial class FormKelolaProfil
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            grpDataAkun = new GroupBox();
            txtTelepon = new TextBox();
            lblTelepon = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNama = new TextBox();
            lblNama = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            grpDataKlinis = new GroupBox();
            chkOffline = new CheckBox();
            chkOnline = new CheckBox();
            lblLayanan = new Label();
            txtDeskripsi = new TextBox();
            lblDeskripsi = new Label();
            txtIzinPraktek = new TextBox();
            lblIzinPraktek = new Label();
            txtPendidikan = new TextBox();
            lblPendidikan = new Label();
            txtGelar = new TextBox();
            lblGelar = new Label();
            btnSimpan = new Button();
            btnBatal = new Button();
            btnKembali = new Button();
            pnlHeader.SuspendLayout();
            grpDataAkun.SuspendLayout();
            grpDataKlinis.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 54, 141);
            pnlHeader.Controls.Add(btnKembali);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1214, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(29, 25);
            lblHeaderTitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(442, 45);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "PENGATURAN PROFIL SAYA";
            // 
            // grpDataAkun
            // 
            grpDataAkun.Controls.Add(txtTelepon);
            grpDataAkun.Controls.Add(lblTelepon);
            grpDataAkun.Controls.Add(txtEmail);
            grpDataAkun.Controls.Add(lblEmail);
            grpDataAkun.Controls.Add(txtNama);
            grpDataAkun.Controls.Add(lblNama);
            grpDataAkun.Controls.Add(txtUsername);
            grpDataAkun.Controls.Add(lblUsername);
            grpDataAkun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpDataAkun.Location = new Point(36, 142);
            grpDataAkun.Margin = new Padding(4, 5, 4, 5);
            grpDataAkun.Name = "grpDataAkun";
            grpDataAkun.Padding = new Padding(4, 5, 4, 5);
            grpDataAkun.Size = new Size(543, 600);
            grpDataAkun.TabIndex = 1;
            grpDataAkun.TabStop = false;
            grpDataAkun.Text = "Informasi Dasar Akun";
            // 
            // txtTelepon
            // 
            txtTelepon.Location = new Point(29, 492);
            txtTelepon.Margin = new Padding(4, 5, 4, 5);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(484, 34);
            txtTelepon.TabIndex = 0;
            // 
            // lblTelepon
            // 
            lblTelepon.Location = new Point(29, 453);
            lblTelepon.Margin = new Padding(4, 0, 4, 0);
            lblTelepon.Name = "lblTelepon";
            lblTelepon.Size = new Size(143, 38);
            lblTelepon.TabIndex = 1;
            lblTelepon.Text = "Nomor Telepon / WhatsApp";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 358);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(484, 34);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(29, 320);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(143, 38);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Alamat Email";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(29, 225);
            txtNama.Margin = new Padding(4, 5, 4, 5);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(484, 34);
            txtNama.TabIndex = 4;
            // 
            // lblNama
            // 
            lblNama.Location = new Point(29, 187);
            lblNama.Margin = new Padding(4, 0, 4, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(143, 38);
            lblNama.TabIndex = 5;
            lblNama.Text = "Nama Lengkap";
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(29, 92);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(484, 34);
            txtUsername.TabIndex = 6;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(29, 53);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(143, 38);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username (Permanen)";
            // 
            // grpDataKlinis
            // 
            grpDataKlinis.Controls.Add(chkOffline);
            grpDataKlinis.Controls.Add(chkOnline);
            grpDataKlinis.Controls.Add(lblLayanan);
            grpDataKlinis.Controls.Add(txtDeskripsi);
            grpDataKlinis.Controls.Add(lblDeskripsi);
            grpDataKlinis.Controls.Add(txtIzinPraktek);
            grpDataKlinis.Controls.Add(lblIzinPraktek);
            grpDataKlinis.Controls.Add(txtPendidikan);
            grpDataKlinis.Controls.Add(lblPendidikan);
            grpDataKlinis.Controls.Add(txtGelar);
            grpDataKlinis.Controls.Add(lblGelar);
            grpDataKlinis.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpDataKlinis.Location = new Point(621, 142);
            grpDataKlinis.Margin = new Padding(4, 5, 4, 5);
            grpDataKlinis.Name = "grpDataKlinis";
            grpDataKlinis.Padding = new Padding(4, 5, 4, 5);
            grpDataKlinis.Size = new Size(557, 600);
            grpDataKlinis.TabIndex = 2;
            grpDataKlinis.TabStop = false;
            grpDataKlinis.Text = "Kompetensi dan Detail Klinis";
            // 
            // chkOffline
            // 
            chkOffline.Location = new Point(300, 533);
            chkOffline.Margin = new Padding(4, 5, 4, 5);
            chkOffline.Name = "chkOffline";
            chkOffline.Size = new Size(149, 40);
            chkOffline.TabIndex = 0;
            chkOffline.Text = "Offline";
            // 
            // chkOnline
            // 
            chkOnline.Location = new Point(36, 533);
            chkOnline.Margin = new Padding(4, 5, 4, 5);
            chkOnline.Name = "chkOnline";
            chkOnline.Size = new Size(149, 40);
            chkOnline.TabIndex = 1;
            chkOnline.Text = "Online";
            // 
            // lblLayanan
            // 
            lblLayanan.Location = new Point(29, 487);
            lblLayanan.Margin = new Padding(4, 0, 4, 0);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(143, 38);
            lblLayanan.TabIndex = 2;
            lblLayanan.Text = "Metode Layanan Konseling";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(29, 358);
            txtDeskripsi.Margin = new Padding(4, 5, 4, 5);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(498, 97);
            txtDeskripsi.TabIndex = 3;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Location = new Point(29, 320);
            lblDeskripsi.Margin = new Padding(4, 0, 4, 0);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(143, 38);
            lblDeskripsi.TabIndex = 4;
            lblDeskripsi.Text = "Deskripsi Singkat Pengalaman";
            // 
            // txtIzinPraktek
            // 
            txtIzinPraktek.Location = new Point(286, 92);
            txtIzinPraktek.Margin = new Padding(4, 5, 4, 5);
            txtIzinPraktek.Name = "txtIzinPraktek";
            txtIzinPraktek.Size = new Size(241, 34);
            txtIzinPraktek.TabIndex = 5;
            // 
            // lblIzinPraktek
            // 
            lblIzinPraktek.Location = new Point(286, 53);
            lblIzinPraktek.Margin = new Padding(4, 0, 4, 0);
            lblIzinPraktek.Name = "lblIzinPraktek";
            lblIzinPraktek.Size = new Size(143, 38);
            lblIzinPraktek.TabIndex = 6;
            lblIzinPraktek.Text = "No. Izin Praktek (SIPP)";
            // 
            // txtPendidikan
            // 
            txtPendidikan.Location = new Point(29, 225);
            txtPendidikan.Margin = new Padding(4, 5, 4, 5);
            txtPendidikan.Name = "txtPendidikan";
            txtPendidikan.Size = new Size(498, 34);
            txtPendidikan.TabIndex = 7;
            // 
            // lblPendidikan
            // 
            lblPendidikan.Location = new Point(29, 187);
            lblPendidikan.Margin = new Padding(4, 0, 4, 0);
            lblPendidikan.Name = "lblPendidikan";
            lblPendidikan.Size = new Size(198, 38);
            lblPendidikan.TabIndex = 8;
            lblPendidikan.Text = "Riwayat Pendidikan Terakhir";
            // 
            // txtGelar
            // 
            txtGelar.Location = new Point(29, 92);
            txtGelar.Margin = new Padding(4, 5, 4, 5);
            txtGelar.Name = "txtGelar";
            txtGelar.Size = new Size(227, 34);
            txtGelar.TabIndex = 9;
            // 
            // lblGelar
            // 
            lblGelar.Location = new Point(29, 53);
            lblGelar.Margin = new Padding(4, 0, 4, 0);
            lblGelar.Name = "lblGelar";
            lblGelar.Size = new Size(143, 38);
            lblGelar.TabIndex = 10;
            lblGelar.Text = "Gelar Akademik";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(26, 54, 141);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(750, 775);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(200, 67);
            btnSimpan.TabIndex = 1;
            btnSimpan.Text = "SIMPAN PERUBAHAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(220, 220, 220);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBatal.ForeColor = Color.Black;
            btnBatal.Location = new Point(979, 775);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(200, 67);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "BATALKAN";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(220, 220, 220);
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(1061, 25);
            btnKembali.Margin = new Padding(4, 5, 4, 5);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(118, 51);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormKelolaProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1214, 883);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(grpDataKlinis);
            Controls.Add(grpDataAkun);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormKelolaProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind - Kelola Profil";
            Load += FormKelolaProfil_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpDataAkun.ResumeLayout(false);
            grpDataAkun.PerformLayout();
            grpDataKlinis.ResumeLayout(false);
            grpDataKlinis.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.GroupBox grpDataAkun;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox grpDataKlinis;
        private System.Windows.Forms.CheckBox chkOffline;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.Label lblLayanan;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtIzinPraktek;
        private System.Windows.Forms.Label lblIzinPraktek;
        private System.Windows.Forms.TextBox txtPendidikan;
        private System.Windows.Forms.Label lblPendidikan;
        private System.Windows.Forms.TextBox txtGelar;
        private System.Windows.Forms.Label lblGelar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKembali;
    }
}