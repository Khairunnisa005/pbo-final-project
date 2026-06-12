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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKuesioner));
            panelQuestions = new Panel();
            btnSubmit = new Button();
            btnMulaiLagi = new Button();
            btnKembali = new Button();
            btnKuisioner = new Button();
            btnKonselor = new Button();
            btnKonsultasi = new Button();
            btnProfile = new Button();
            btnBeranda = new Button();
            btnKeluar = new Button();
            lblLastScore = new Label();
            SuspendLayout();
            // 
            // panelQuestions
            // 
            panelQuestions.AutoScroll = true;
            panelQuestions.BackColor = Color.WhiteSmoke;
            panelQuestions.BorderStyle = BorderStyle.FixedSingle;
            panelQuestions.Location = new Point(330, 259);
            panelQuestions.Name = "panelQuestions";
            panelQuestions.Size = new Size(1159, 474);
            panelQuestions.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ControlLight;
            btnSubmit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnSubmit.Location = new Point(1274, 753);
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
            btnMulaiLagi.Location = new Point(1051, 752);
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
            btnKembali.DialogResult = DialogResult.Cancel;
            btnKembali.Font = new Font("Calibri", 10F);
            btnKembali.Location = new Point(858, 754);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(172, 45);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.BorderSize = 0;
            btnKuisioner.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKuisioner.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKuisioner.FlatStyle = FlatStyle.Flat;
            btnKuisioner.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKuisioner.ForeColor = SystemColors.ButtonHighlight;
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(75, 219);
            btnKuisioner.Name = "btnKuisioner";
            btnKuisioner.Size = new Size(165, 38);
            btnKuisioner.TabIndex = 18;
            btnKuisioner.Text = "Kuisioner";
            btnKuisioner.TextAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.UseVisualStyleBackColor = false;
            btnKuisioner.Click += btnKuisioner_Click;
            // 
            // btnKonselor
            // 
            btnKonselor.BackColor = Color.Transparent;
            btnKonselor.FlatAppearance.BorderSize = 0;
            btnKonselor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKonselor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKonselor.FlatStyle = FlatStyle.Flat;
            btnKonselor.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKonselor.ForeColor = SystemColors.ButtonHighlight;
            btnKonselor.Location = new Point(75, 285);
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
            btnKonsultasi.FlatAppearance.BorderSize = 0;
            btnKonsultasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKonsultasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKonsultasi.FlatStyle = FlatStyle.Flat;
            btnKonsultasi.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKonsultasi.ForeColor = SystemColors.ButtonHighlight;
            btnKonsultasi.Location = new Point(75, 352);
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
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnProfile.ForeColor = SystemColors.ButtonHighlight;
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(77, 421);
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
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBeranda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnBeranda.ForeColor = SystemColors.ButtonHighlight;
            btnBeranda.Location = new Point(75, 157);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(165, 38);
            btnBeranda.TabIndex = 14;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = SystemColors.ButtonHighlight;
            btnKeluar.Location = new Point(69, 784);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(165, 38);
            btnKeluar.TabIndex = 20;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // lblLastScore
            // 
            lblLastScore.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLastScore.Location = new Point(330, 219);
            lblLastScore.Name = "lblLastScore";
            lblLastScore.Size = new Size(600, 24);
            lblLastScore.TabIndex = 20;
            // 
            // FormKuesioner
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1536, 907);
            Controls.Add(btnKeluar);
            Controls.Add(lblLastScore);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(btnSubmit);
            Controls.Add(btnMulaiLagi);
            Controls.Add(btnKembali);
            Controls.Add(panelQuestions);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormKuesioner";
            StartPosition = FormStartPosition.CenterScreen;
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
