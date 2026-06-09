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
