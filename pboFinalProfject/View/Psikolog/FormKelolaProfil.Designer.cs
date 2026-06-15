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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaProfil));
            btnKembali = new Button();
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
            grpDataAkun.SuspendLayout();
            grpDataKlinis.SuspendLayout();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(1362, 54);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(129, 45);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
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
            grpDataAkun.Location = new Point(362, 170);
            grpDataAkun.Margin = new Padding(3, 4, 3, 4);
            grpDataAkun.Name = "grpDataAkun";
            grpDataAkun.Padding = new Padding(3, 4, 3, 4);
            grpDataAkun.Size = new Size(492, 503);
            grpDataAkun.TabIndex = 1;
            grpDataAkun.TabStop = false;
            grpDataAkun.Text = "Informasi Dasar Akun";
            // 
            // txtTelepon
            // 
            txtTelepon.Location = new Point(23, 354);
            txtTelepon.Margin = new Padding(3, 4, 3, 4);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(388, 34);
            txtTelepon.TabIndex = 0;
            // 
            // lblTelepon
            // 
            lblTelepon.Location = new Point(23, 320);
            lblTelepon.Name = "lblTelepon";
            lblTelepon.Size = new Size(282, 30);
            lblTelepon.TabIndex = 1;
            lblTelepon.Text = "Nomor Telepon / WhatsApp";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 255);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(388, 34);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(23, 221);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(163, 30);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Alamat Email";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(23, 158);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(388, 34);
            txtNama.TabIndex = 4;
            // 
            // lblNama
            // 
            lblNama.Location = new Point(23, 123);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(163, 30);
            lblNama.TabIndex = 5;
            lblNama.Text = "Nama Lengkap";
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(23, 74);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(388, 34);
            txtUsername.TabIndex = 6;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(23, 42);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 30);
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
            grpDataKlinis.Location = new Point(917, 170);
            grpDataKlinis.Margin = new Padding(3, 4, 3, 4);
            grpDataKlinis.Name = "grpDataKlinis";
            grpDataKlinis.Padding = new Padding(3, 4, 3, 4);
            grpDataKlinis.Size = new Size(504, 503);
            grpDataKlinis.TabIndex = 2;
            grpDataKlinis.TabStop = false;
            grpDataKlinis.Text = "Kompetensi dan Detail Klinis";
            // 
            // chkOffline
            // 
            chkOffline.Location = new Point(229, 373);
            chkOffline.Margin = new Padding(3, 4, 3, 4);
            chkOffline.Name = "chkOffline";
            chkOffline.Size = new Size(119, 32);
            chkOffline.TabIndex = 0;
            chkOffline.Text = "Offline";
            // 
            // chkOnline
            // 
            chkOnline.Location = new Point(23, 373);
            chkOnline.Margin = new Padding(3, 4, 3, 4);
            chkOnline.Name = "chkOnline";
            chkOnline.Size = new Size(119, 32);
            chkOnline.TabIndex = 1;
            chkOnline.Text = "Online";
            // 
            // lblLayanan
            // 
            lblLayanan.Location = new Point(23, 339);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(114, 30);
            lblLayanan.TabIndex = 2;
            lblLayanan.Text = "Metode Layanan Konseling";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(23, 255);
            txtDeskripsi.Margin = new Padding(3, 4, 3, 4);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(399, 62);
            txtDeskripsi.TabIndex = 3;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Location = new Point(23, 221);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(308, 30);
            lblDeskripsi.TabIndex = 4;
            lblDeskripsi.Text = "Deskripsi Singkat Pengalaman";
            // 
            // txtIzinPraktek
            // 
            txtIzinPraktek.Location = new Point(229, 74);
            txtIzinPraktek.Margin = new Padding(3, 4, 3, 4);
            txtIzinPraktek.Name = "txtIzinPraktek";
            txtIzinPraktek.Size = new Size(194, 34);
            txtIzinPraktek.TabIndex = 5;
            // 
            // lblIzinPraktek
            // 
            lblIzinPraktek.Location = new Point(229, 42);
            lblIzinPraktek.Name = "lblIzinPraktek";
            lblIzinPraktek.Size = new Size(178, 30);
            lblIzinPraktek.TabIndex = 6;
            lblIzinPraktek.Text = "No. Izin Praktek (SIPP)";
            // 
            // txtPendidikan
            // 
            txtPendidikan.Location = new Point(23, 158);
            txtPendidikan.Margin = new Padding(3, 4, 3, 4);
            txtPendidikan.Name = "txtPendidikan";
            txtPendidikan.Size = new Size(399, 34);
            txtPendidikan.TabIndex = 7;
            // 
            // lblPendidikan
            // 
            lblPendidikan.Location = new Point(23, 123);
            lblPendidikan.Name = "lblPendidikan";
            lblPendidikan.Size = new Size(259, 30);
            lblPendidikan.TabIndex = 8;
            lblPendidikan.Text = "Riwayat Pendidikan Terakhir";
            // 
            // txtGelar
            // 
            txtGelar.Location = new Point(23, 74);
            txtGelar.Margin = new Padding(3, 4, 3, 4);
            txtGelar.Name = "txtGelar";
            txtGelar.Size = new Size(182, 34);
            txtGelar.TabIndex = 9;
            // 
            // lblGelar
            // 
            lblGelar.Location = new Point(23, 42);
            lblGelar.Name = "lblGelar";
            lblGelar.Size = new Size(182, 30);
            lblGelar.TabIndex = 10;
            lblGelar.Text = "Gelar Akademik";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(26, 54, 141);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(1203, 710);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(218, 54);
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
            btnBatal.Location = new Point(960, 710);
            btnBatal.Margin = new Padding(3, 4, 3, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(218, 54);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "BATALKAN";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormKelolaProfil
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKembali);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(grpDataKlinis);
            Controls.Add(grpDataAkun);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormKelolaProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind - Kelola Profil";
            Load += FormKelolaProfil_Load;
            grpDataAkun.ResumeLayout(false);
            grpDataAkun.PerformLayout();
            grpDataKlinis.ResumeLayout(false);
            grpDataKlinis.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
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