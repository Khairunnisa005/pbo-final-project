namespace pboFinalProfject.View
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dataGridView1 = new DataGridView();
            lblJadwal = new Label();
            btnBeranda = new Button();
            btnProfile = new Button();
            btnKonsultasi = new Button();
            btnKonselor = new Button();
            btnKuisioner = new Button();
            btnDaftar = new Button();
            btnJadwal = new Button();
            btnKuis = new Button();
            btnKeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(681, 223);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblJadwal
            // 
            lblJadwal.AutoSize = true;
            lblJadwal.BackColor = SystemColors.ControlLightLight;
            lblJadwal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJadwal.Location = new Point(208, 279);
            lblJadwal.Name = "lblJadwal";
            lblJadwal.Size = new Size(134, 20);
            lblJadwal.TabIndex = 1;
            lblJadwal.Text = "Jadwal Konsultasi";
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(37, 76);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(70, 29);
            btnBeranda.TabIndex = 2;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += button1_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.ImageAlign = ContentAlignment.TopRight;
            btnProfile.Location = new Point(37, 224);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(70, 29);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Profil";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += button1_Click_1;
            // 
            // btnKonsultasi
            // 
            btnKonsultasi.BackColor = Color.Transparent;
            btnKonsultasi.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKonsultasi.Location = new Point(37, 184);
            btnKonsultasi.Name = "btnKonsultasi";
            btnKonsultasi.Size = new Size(119, 29);
            btnKonsultasi.TabIndex = 4;
            btnKonsultasi.Text = "Jadwal Konsultasi";
            btnKonsultasi.TextAlign = ContentAlignment.MiddleLeft;
            btnKonsultasi.UseVisualStyleBackColor = false;
            // 
            // btnKonselor
            // 
            btnKonselor.BackColor = Color.Transparent;
            btnKonselor.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKonselor.Location = new Point(37, 149);
            btnKonselor.Name = "btnKonselor";
            btnKonselor.Size = new Size(70, 29);
            btnKonselor.TabIndex = 5;
            btnKonselor.Text = "Konselor";
            btnKonselor.TextAlign = ContentAlignment.MiddleLeft;
            btnKonselor.UseVisualStyleBackColor = false;
            // 
            // btnKuisioner
            // 
            btnKuisioner.BackColor = Color.Transparent;
            btnKuisioner.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuisioner.Location = new Point(37, 111);
            btnKuisioner.Name = "btnKuisioner";
            btnKuisioner.Size = new Size(70, 29);
            btnKuisioner.TabIndex = 6;
            btnKuisioner.Text = "Kuisioner";
            btnKuisioner.UseVisualStyleBackColor = false;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = SystemColors.ControlLightLight;
            btnDaftar.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(206, 194);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(174, 33);
            btnDaftar.TabIndex = 7;
            btnDaftar.Text = "Daftar Konselor";
            btnDaftar.UseVisualStyleBackColor = false;
            // 
            // btnJadwal
            // 
            btnJadwal.BackColor = SystemColors.ControlLightLight;
            btnJadwal.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJadwal.Location = new Point(437, 194);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(174, 33);
            btnJadwal.TabIndex = 8;
            btnJadwal.Text = "Buat Janji";
            btnJadwal.UseVisualStyleBackColor = false;
            // 
            // btnKuis
            // 
            btnKuis.BackColor = SystemColors.ControlLightLight;
            btnKuis.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKuis.Location = new Point(670, 194);
            btnKuis.Name = "btnKuis";
            btnKuis.Size = new Size(174, 33);
            btnKuis.TabIndex = 9;
            btnKuis.Text = "Cek Keadaan";
            btnKuis.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeluar.Location = new Point(39, 454);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(70, 29);
            btnKeluar.TabIndex = 10;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(878, 493);
            Controls.Add(btnKeluar);
            Controls.Add(btnKuis);
            Controls.Add(btnJadwal);
            Controls.Add(btnDaftar);
            Controls.Add(btnKuisioner);
            Controls.Add(btnKonselor);
            Controls.Add(btnKonsultasi);
            Controls.Add(btnProfile);
            Controls.Add(btnBeranda);
            Controls.Add(lblJadwal);
            Controls.Add(dataGridView1);
            Name = "Dashboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblJadwal;
        private Button btnBeranda;
        private Button btnProfile;
        private Button btnKonsultasi;
        private Button btnKonselor;
        private Button btnKuisioner;
        private Button btnDaftar;
        private Button btnJadwal;
        private Button btnKuis;
        private Button btnKeluar;
    }
}