namespace pboFinalProfject.View.Mahasiswa;

partial class FormDashboardMahasiswa 
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardMahasiswa));
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
        dataGridView1.Location = new Point(314, 535);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(1179, 253);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // lblJadwal
        // 
        lblJadwal.AutoSize = true;
        lblJadwal.BackColor = SystemColors.ControlLightLight;
        lblJadwal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblJadwal.Location = new Point(314, 501);
        lblJadwal.Name = "lblJadwal";
        lblJadwal.Size = new Size(205, 31);
        lblJadwal.TabIndex = 1;
        lblJadwal.Text = "Jadwal Konsultasi";
        // 
        // btnBeranda
        // 
        btnBeranda.BackColor = Color.Transparent;
        btnBeranda.Font = new Font("Calibri", 12F);
        btnBeranda.Location = new Point(80, 155);
        btnBeranda.Name = "btnBeranda";
        btnBeranda.Size = new Size(165, 38);
        btnBeranda.TabIndex = 2;
        btnBeranda.Text = "Beranda";
        btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
        btnBeranda.UseVisualStyleBackColor = false;
        btnBeranda.Click += button1_Click;
        // 
        // btnProfile
        // 
        btnProfile.BackColor = Color.Transparent;
        btnProfile.Font = new Font("Calibri", 12F);
        btnProfile.ImageAlign = ContentAlignment.TopRight;
        btnProfile.Location = new Point(82, 417);
        btnProfile.Name = "btnProfile";
        btnProfile.Size = new Size(165, 38);
        btnProfile.TabIndex = 3;
        btnProfile.Text = "Profil";
        btnProfile.TextAlign = ContentAlignment.MiddleLeft;
        btnProfile.UseVisualStyleBackColor = false;
        btnProfile.Click += btnProfile_Click;
        // 
        // btnKonsultasi
        // 
        btnKonsultasi.BackColor = Color.Transparent;
        btnKonsultasi.Font = new Font("Calibri", 12F);
        btnKonsultasi.Location = new Point(80, 352);
        btnKonsultasi.Name = "btnKonsultasi";
        btnKonsultasi.Size = new Size(167, 38);
        btnKonsultasi.TabIndex = 4;
        btnKonsultasi.Text = "Jadwal Konsultasi";
        btnKonsultasi.TextAlign = ContentAlignment.MiddleLeft;
        btnKonsultasi.UseVisualStyleBackColor = false;
        // 
        // btnKonselor
        // 
        btnKonselor.BackColor = Color.Transparent;
        btnKonselor.Font = new Font("Calibri", 12F);
        btnKonselor.Location = new Point(80, 289);
        btnKonselor.Name = "btnKonselor";
        btnKonselor.Size = new Size(165, 38);
        btnKonselor.TabIndex = 5;
        btnKonselor.Text = "Konselor";
        btnKonselor.TextAlign = ContentAlignment.MiddleLeft;
        btnKonselor.UseVisualStyleBackColor = false;
        // 
        // btnKuisioner
        // 
        btnKuisioner.BackColor = Color.Transparent;
        btnKuisioner.Font = new Font("Calibri", 12F);
        btnKuisioner.ImageAlign = ContentAlignment.MiddleLeft;
        btnKuisioner.Location = new Point(80, 221);
        btnKuisioner.Name = "btnKuisioner";
        btnKuisioner.Size = new Size(165, 38);
        btnKuisioner.TabIndex = 6;
        btnKuisioner.Text = "Kuisioner";
        btnKuisioner.TextAlign = ContentAlignment.MiddleLeft;
        btnKuisioner.UseVisualStyleBackColor = false;
        btnKuisioner.Click += btnKuisioner_Click;
        // 
        // btnDaftar
        // 
        btnDaftar.BackColor = SystemColors.ControlLightLight;
        btnDaftar.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnDaftar.Location = new Point(345, 395);
        btnDaftar.Name = "btnDaftar";
        btnDaftar.Size = new Size(311, 59);
        btnDaftar.TabIndex = 7;
        btnDaftar.Text = "Daftar Konselor";
        btnDaftar.UseVisualStyleBackColor = false;
        btnDaftar.Click += btnDaftar_Click;
        // 
        // btnJadwal
        // 
        btnJadwal.BackColor = SystemColors.ControlLightLight;
        btnJadwal.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnJadwal.Location = new Point(751, 395);
        btnJadwal.Name = "btnJadwal";
        btnJadwal.Size = new Size(315, 59);
        btnJadwal.TabIndex = 8;
        btnJadwal.Text = "Buat Janji";
        btnJadwal.UseVisualStyleBackColor = false;
        btnJadwal.Click += BtnJadwal_Click;
        // 
        // btnKuis
        // 
        btnKuis.BackColor = SystemColors.ControlLightLight;
        btnKuis.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnKuis.Location = new Point(1159, 395);
        btnKuis.Name = "btnKuis";
        btnKuis.Size = new Size(312, 58);
        btnKuis.TabIndex = 9;
        btnKuis.Text = "Cek Keadaan";
        btnKuis.UseVisualStyleBackColor = false;
        btnKuis.Click += btnKuis_Click;
        // 
        // btnKeluar
        // 
        btnKeluar.BackColor = Color.Transparent;
        btnKeluar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnKeluar.Location = new Point(80, 785);
        btnKeluar.Name = "btnKeluar";
        btnKeluar.Size = new Size(116, 40);
        btnKeluar.TabIndex = 10;
        btnKeluar.Text = "Keluar";
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
        btnKeluar.UseVisualStyleBackColor = false;
        btnKeluar.Click += btnKeluar_Click;
        // 
        // FormDashboardMahasiswa
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        ClientSize = new Size(1518, 817);
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
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(1536, 864);
        MinimumSize = new Size(1536, 864);
        Name = "FormDashboardMahasiswa";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Form1";
        Load += Dashboard_Load;
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
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
}