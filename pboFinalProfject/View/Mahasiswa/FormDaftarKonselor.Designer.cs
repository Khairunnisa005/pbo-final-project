namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormDaftarKonselor
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
            dgvPsikolog = new DataGridView();
            btnKembali = new Button();
            btnKuisioner = new Button();
            btnKonselor = new Button();
            btnKonsultasi = new Button();
            btnProfile = new Button();
            btnBeranda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPsikolog).BeginInit();
            SuspendLayout();
            // 
            // dgvPsikolog
            // 
            dgvPsikolog.BackgroundColor = SystemColors.ControlLightLight;
            dgvPsikolog.BorderStyle = BorderStyle.Fixed3D;
            dgvPsikolog.ColumnHeadersHeight = 29;
            dgvPsikolog.Location = new Point(303, 159);
            dgvPsikolog.Name = "dgvPsikolog";
            dgvPsikolog.RowHeadersWidth = 51;
            dgvPsikolog.Size = new Size(1164, 531);
            dgvPsikolog.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.Font = new Font("Segoe UI", 12F);
            btnKembali.Location = new Point(1031, 750);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(436, 55);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.Font = new Font("Calibri", 12F);
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(65, 211);
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
            btnKonselor.Location = new Point(65, 281);
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
            btnKonsultasi.Location = new Point(65, 348);
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
            btnProfile.Location = new Point(67, 417);
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
            btnBeranda.Location = new Point(65, 142);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 14;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            // 
            // FormDaftarKonselor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.daftarKonselor;
            ClientSize = new Size(1518, 817);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(btnKembali);
            Controls.Add(dgvPsikolog);
            Name = "FormDaftarKonselor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Daftar Konselor";
            ((System.ComponentModel.ISupportInitialize)dgvPsikolog).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPsikolog;
        private System.Windows.Forms.Button btnKembali;
        private Button btnKuisioner;
        private Button btnKonselor;
        private Button btnKonsultasi;
        private Button btnProfile;
        private Button btnBeranda;
    }
}
