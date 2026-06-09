namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormProfilMahasiswa
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

        private void InitializeComponent()
        {
            btnKuisioner = new Button();
            btnKonselor = new Button();
            btnKonsultasi = new Button();
            btnProfile = new Button();
            btnBeranda = new Button();
            btnSubmit = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.Font = new Font("Calibri", 12F);
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(63, 213);
            btnKuisioner.Name = "btnKuisioner";
            btnKuisioner.Size = new Size(165, 38);
            btnKuisioner.TabIndex = 18;
            btnKuisioner.Text = "Kuisioner";
            btnKuisioner.TextAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.UseVisualStyleBackColor = false;
            // 
            // btnKonselor
            // 
            btnKonselor.BackColor = Color.Transparent;
            btnKonselor.Font = new Font("Calibri", 12F);
            btnKonselor.Location = new Point(63, 281);
            btnKonselor.Name = "btnKonselor";
            btnKonselor.Size = new Size(165, 38);
            btnKonselor.TabIndex = 17;
            btnKonselor.Text = "Konselor";
            btnKonselor.TextAlign = ContentAlignment.MiddleLeft;
            btnKonselor.UseVisualStyleBackColor = false;
            // 
            // btnKonsultasi
            // 
            btnKonsultasi.BackColor = Color.Transparent;
            btnKonsultasi.Font = new Font("Calibri", 12F);
            btnKonsultasi.Location = new Point(63, 338);
            btnKonsultasi.Name = "btnKonsultasi";
            btnKonsultasi.Size = new Size(167, 38);
            btnKonsultasi.TabIndex = 16;
            btnKonsultasi.Text = "Jadwal Konsultasi";
            btnKonsultasi.TextAlign = ContentAlignment.MiddleLeft;
            btnKonsultasi.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Font = new Font("Calibri", 12F);
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(65, 419);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 38);
            btnProfile.TabIndex = 15;
            btnProfile.Text = "Profil";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.Font = new Font("Calibri", 12F);
            btnBeranda.Location = new Point(63, 144);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 14;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ControlLightLight;
            btnSubmit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnSubmit.Location = new Point(1253, 752);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(215, 45);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Kirim Kuisioner";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.ControlLightLight;
            btnKembali.Font = new Font("Calibri", 10F);
            btnKembali.Location = new Point(1034, 753);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(193, 45);
            btnKembali.TabIndex = 20;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Visible = false;
            // 
            // FormProfilMahasiswa
            // 
            BackgroundImage = Properties.Resources.profil__2_;
            ClientSize = new Size(1518, 817);
            // profile fields
            lblUsername = new Label();
            lblUsername.Location = new Point(320, 200);
            lblUsername.Size = new Size(100, 24);
            lblUsername.Text = "Username:";
            Controls.Add(lblUsername);

            tbUsername = new TextBox();
            tbUsername.Location = new Point(430, 200);
            tbUsername.Size = new Size(300, 30);
            Controls.Add(tbUsername);

            lblNama = new Label();
            lblNama.Location = new Point(320, 250);
            lblNama.Size = new Size(100, 24);
            lblNama.Text = "Nama Lengkap:";
            Controls.Add(lblNama);

            tbNama = new TextBox();
            tbNama.Location = new Point(430, 250);
            tbNama.Size = new Size(600, 30);
            Controls.Add(tbNama);

            lblEmail = new Label();
            lblEmail.Location = new Point(320, 300);
            lblEmail.Size = new Size(100, 24);
            lblEmail.Text = "Email:";
            Controls.Add(lblEmail);

            tbEmail = new TextBox();
            tbEmail.Location = new Point(430, 300);
            tbEmail.Size = new Size(400, 30);
            Controls.Add(tbEmail);

            lblTelepon = new Label();
            lblTelepon.Location = new Point(320, 350);
            lblTelepon.Size = new Size(100, 24);
            lblTelepon.Text = "No. Telepon:";
            Controls.Add(lblTelepon);

            tbTelepon = new TextBox();
            tbTelepon.Location = new Point(430, 350);
            tbTelepon.Size = new Size(300, 30);
            Controls.Add(tbTelepon);

            // action buttons
            btnSave = new Button();
            btnSave.Location = new Point(1180, 750);
            btnSave.Size = new Size(150, 45);
            btnSave.Text = "Simpan";
            Controls.Add(btnSave);

            btnDelete = new Button();
            btnDelete.Location = new Point(980, 750);
            btnDelete.Size = new Size(150, 45);
            btnDelete.Text = "Hapus Akun";
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.ForeColor = Color.White;
            Controls.Add(btnDelete);

            Controls.Add(btnSubmit);
            Controls.Add(btnKembali);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Name = "FormProfilMahasiswa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Profil";
            ResumeLayout(false);
        }

        private Button btnKuisioner;
        private Button btnKonselor;
        private Button btnKonsultasi;
        private Button btnProfile;
        private Button btnBeranda;
        private Button btnSubmit;
        private Button btnKembali;
    }
}
