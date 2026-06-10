namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormKuesioner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            panelQuestions = new Panel();
            btnSubmit = new Button();
            btnMulaiLagi = new Button();
            btnKembali = new Button();
            btnKuisioner = new Button();
            btnKonselor = new Button();
            btnKonsultasi = new Button();
            btnProfile = new Button();
            btnBeranda = new Button();
            SuspendLayout();
            // 
            // panelQuestions
            // 
            panelQuestions.AutoScroll = true;
            panelQuestions.BackColor = Color.WhiteSmoke;
            panelQuestions.BorderStyle = BorderStyle.FixedSingle;
            panelQuestions.Location = new Point(311, 220);
            panelQuestions.Name = "panelQuestions";
            panelQuestions.Size = new Size(1159, 509);
            panelQuestions.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ControlLight;
            btnSubmit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnSubmit.Location = new Point(1255, 753);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(215, 45);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Kirim Kuisioner";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnMulaiLagi
            // 
            btnMulaiLagi.BackColor = SystemColors.ControlLight;
            btnMulaiLagi.Font = new Font("Calibri", 10F);
            btnMulaiLagi.Location = new Point(1032, 751);
            btnMulaiLagi.Name = "btnMulaiLagi";
            btnMulaiLagi.Size = new Size(199, 47);
            btnMulaiLagi.TabIndex = 2;
            btnMulaiLagi.Text = "Mulai Lagi";
            btnMulaiLagi.UseVisualStyleBackColor = false;
            btnMulaiLagi.Visible = false;
            btnMulaiLagi.Click += btnMulaiLagi_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.ControlLight;
            btnKembali.Font = new Font("Calibri", 10F);
            btnKembali.Location = new Point(839, 751);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(172, 45);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Visible = true;
            btnKembali.Click -= btnKembali_Click;
            btnKembali.Click += btnKembali_Click;
            btnKembali.DialogResult = DialogResult.Cancel;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.FlatStyle = FlatStyle.Flat;
            btnKuisioner.FlatAppearance.BorderSize = 0;
            btnKuisioner.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKuisioner.Font = new Font("Calibri", 12F);
            btnKuisioner.UseVisualStyleBackColor = false;
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(62, 212);
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
            btnKonselor.FlatStyle = FlatStyle.Flat;
            btnKonselor.FlatAppearance.BorderSize = 0;
            btnKonselor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKonselor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKonselor.Font = new Font("Calibri", 12F);
            btnKonselor.UseVisualStyleBackColor = false;
            btnKonselor.Location = new Point(62, 282);
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
            btnKonsultasi.FlatStyle = FlatStyle.Flat;
            btnKonsultasi.FlatAppearance.BorderSize = 0;
            btnKonsultasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKonsultasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKonsultasi.Font = new Font("Calibri", 12F);
            btnKonsultasi.UseVisualStyleBackColor = false;
            btnKonsultasi.Location = new Point(62, 349);
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
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfile.Font = new Font("Calibri", 12F);
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(64, 418);
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
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBeranda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBeranda.Font = new Font("Calibri", 12F);
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Location = new Point(62, 143);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 14;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            btnKeluar = new Button();
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.Font = new Font("Calibri", 12F);
            btnKeluar.Location = new Point(62, 750);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(165, 38);
            btnKeluar.TabIndex = 19;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            Controls.Add(btnKeluar);

            // last score label
            lblLastScore = new Label();
            lblLastScore.Location = new Point(311, 180);
            lblLastScore.Size = new Size(600, 24);
            lblLastScore.Text = string.Empty;
            lblLastScore.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            Controls.Add(lblLastScore);
            // 
            // FormKuesioner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Kuisioner__1_;
            ClientSize = new Size(1518, 817);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(btnSubmit);
            Controls.Add(btnMulaiLagi);
            Controls.Add(btnKembali);
            Controls.Add(panelQuestions);
            FormBorderStyle = FormBorderStyle.FixedDialog;

            Name = "FormKuesioner";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kuisioner Kesehatan Mental";
            Load += FormKuesioner_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMulaiLagi;
        private System.Windows.Forms.Button btnKembali;
        private Button btnKuisioner;
        private Button btnKonselor;
        private Button btnKonsultasi;
        private Button btnProfile;
        private Button btnBeranda;
        private Button btnKeluar;
        private Label lblLastScore;
    }
}
