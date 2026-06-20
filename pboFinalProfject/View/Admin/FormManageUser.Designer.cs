namespace pboFinalProfject.View
{
    partial class FormManageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageUser));
            tabUserControl = new TabControl();
            pagePsikolog = new TabPage();
            dgvPsikolog = new DataGridView();
            pnlSideInputPsi = new Panel();
            lblDeskPsi = new Label();
            txtDeskPsi = new TextBox();
            lblIzinPraktek = new Label();
            txtIzinPraktek = new TextBox();
            lblPendidikan = new Label();
            txtPendidikan = new TextBox();
            lblGelar = new Label();
            txtGelar = new TextBox();
            btnHapusPsi = new Button();
            btnSimpanPsikolog = new Button();
            lblKeahlian = new Label();
            txtKeahlian = new TextBox();
            txtTelpPsi = new TextBox();
            lblTelpPsi = new Label();
            txtEmailPsi = new TextBox();
            lblEmailPsi = new Label();
            txtNamaPsi = new TextBox();
            lblNamaPsi = new Label();
            txtUserPsi = new TextBox();
            lblUserPsi = new Label();
            pageMahasiswa = new TabPage();
            dgvMahasiswa = new DataGridView();
            pnlSideInputMhs = new Panel();
            btnHapusMhs = new Button();
            btnSimpanMhs = new Button();
            txtTelpMhs = new TextBox();
            lblTelpMhs = new Label();
            txtEmailMhs = new TextBox();
            lblEmailMhs = new Label();
            txtNamaMhs = new TextBox();
            lblNamaMhs = new Label();
            txtUserMhs = new TextBox();
            lblUserMhs = new Label();
            btnKeluar = new Button();
            btnDashboard = new Button();
            btnLaporan = new Button();
            btnKelolaUser = new Button();
            btnKembali = new Button();
            tabUserControl.SuspendLayout();
            pagePsikolog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPsikolog).BeginInit();
            pnlSideInputPsi.SuspendLayout();
            pageMahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).BeginInit();
            pnlSideInputMhs.SuspendLayout();
            SuspendLayout();
            // 
            // tabUserControl
            // 
            tabUserControl.Controls.Add(pagePsikolog);
            tabUserControl.Controls.Add(pageMahasiswa);
            tabUserControl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tabUserControl.Location = new Point(317, 106);
            tabUserControl.Margin = new Padding(3, 4, 3, 4);
            tabUserControl.Name = "tabUserControl";
            tabUserControl.SelectedIndex = 0;
            tabUserControl.Size = new Size(1158, 741);
            tabUserControl.TabIndex = 1;
            // 
            // pagePsikolog
            // 
            pagePsikolog.Controls.Add(dgvPsikolog);
            pagePsikolog.Controls.Add(pnlSideInputPsi);
            pagePsikolog.Location = new Point(4, 32);
            pagePsikolog.Margin = new Padding(3, 4, 3, 4);
            pagePsikolog.Name = "pagePsikolog";
            pagePsikolog.Padding = new Padding(3, 4, 3, 4);
            pagePsikolog.Size = new Size(1150, 705);
            pagePsikolog.TabIndex = 0;
            pagePsikolog.Text = "Manage Psikolog";
            // 
            // dgvPsikolog
            // 
            dgvPsikolog.AllowUserToAddRows = false;
            dgvPsikolog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPsikolog.BackgroundColor = Color.White;
            dgvPsikolog.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 54, 141);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvPsikolog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPsikolog.ColumnHeadersHeight = 34;
            dgvPsikolog.Dock = DockStyle.Fill;
            dgvPsikolog.EnableHeadersVisualStyles = false;
            dgvPsikolog.Location = new Point(340, 4);
            dgvPsikolog.Margin = new Padding(3, 4, 3, 4);
            dgvPsikolog.Name = "dgvPsikolog";
            dgvPsikolog.RowHeadersWidth = 62;
            dgvPsikolog.Size = new Size(807, 697);
            dgvPsikolog.TabIndex = 0;
            dgvPsikolog.CellClick += dgvPsikolog_CellClick;
            // 
            // pnlSideInputPsi
            // 
            pnlSideInputPsi.BackColor = Color.FromArgb(245, 247, 250);
            pnlSideInputPsi.Controls.Add(lblDeskPsi);
            pnlSideInputPsi.Controls.Add(txtDeskPsi);
            pnlSideInputPsi.Controls.Add(lblIzinPraktek);
            pnlSideInputPsi.Controls.Add(txtIzinPraktek);
            pnlSideInputPsi.Controls.Add(lblPendidikan);
            pnlSideInputPsi.Controls.Add(txtPendidikan);
            pnlSideInputPsi.Controls.Add(lblGelar);
            pnlSideInputPsi.Controls.Add(txtGelar);
            pnlSideInputPsi.Controls.Add(btnHapusPsi);
            pnlSideInputPsi.Controls.Add(btnSimpanPsikolog);
            pnlSideInputPsi.Controls.Add(lblKeahlian);
            pnlSideInputPsi.Controls.Add(txtKeahlian);
            pnlSideInputPsi.Controls.Add(txtTelpPsi);
            pnlSideInputPsi.Controls.Add(lblTelpPsi);
            pnlSideInputPsi.Controls.Add(txtEmailPsi);
            pnlSideInputPsi.Controls.Add(lblEmailPsi);
            pnlSideInputPsi.Controls.Add(txtNamaPsi);
            pnlSideInputPsi.Controls.Add(lblNamaPsi);
            pnlSideInputPsi.Controls.Add(txtUserPsi);
            pnlSideInputPsi.Controls.Add(lblUserPsi);
            pnlSideInputPsi.Dock = DockStyle.Left;
            pnlSideInputPsi.Location = new Point(3, 4);
            pnlSideInputPsi.Margin = new Padding(3, 4, 3, 4);
            pnlSideInputPsi.Name = "pnlSideInputPsi";
            pnlSideInputPsi.Size = new Size(337, 697);
            pnlSideInputPsi.TabIndex = 1;
            // 
            // lblDeskPsi
            // 
            lblDeskPsi.Location = new Point(21, 492);
            lblDeskPsi.Name = "lblDeskPsi";
            lblDeskPsi.Size = new Size(160, 22);
            lblDeskPsi.TabIndex = 11;
            lblDeskPsi.Text = "Deskripsi Singkat";
            // 
            // txtDeskPsi
            // 
            txtDeskPsi.Location = new Point(20, 518);
            txtDeskPsi.Margin = new Padding(3, 4, 3, 4);
            txtDeskPsi.Name = "txtDeskPsi";
            txtDeskPsi.Size = new Size(297, 30);
            txtDeskPsi.TabIndex = 10;
            // 
            // lblIzinPraktek
            // 
            lblIzinPraktek.Location = new Point(20, 430);
            lblIzinPraktek.Name = "lblIzinPraktek";
            lblIzinPraktek.Size = new Size(157, 24);
            lblIzinPraktek.TabIndex = 16;
            lblIzinPraktek.Text = "No Izin Praktik";
            // 
            // txtIzinPraktek
            // 
            txtIzinPraktek.Location = new Point(20, 458);
            txtIzinPraktek.Margin = new Padding(3, 4, 3, 4);
            txtIzinPraktek.Name = "txtIzinPraktek";
            txtIzinPraktek.Size = new Size(297, 30);
            txtIzinPraktek.TabIndex = 17;
            // 
            // lblPendidikan
            // 
            lblPendidikan.Location = new Point(20, 368);
            lblPendidikan.Name = "lblPendidikan";
            lblPendidikan.Size = new Size(114, 24);
            lblPendidikan.TabIndex = 14;
            lblPendidikan.Text = "Pendidikan";
            // 
            // txtPendidikan
            // 
            txtPendidikan.Location = new Point(20, 396);
            txtPendidikan.Margin = new Padding(3, 4, 3, 4);
            txtPendidikan.Name = "txtPendidikan";
            txtPendidikan.Size = new Size(297, 30);
            txtPendidikan.TabIndex = 15;
            // 
            // lblGelar
            // 
            lblGelar.Location = new Point(20, 306);
            lblGelar.Name = "lblGelar";
            lblGelar.Size = new Size(114, 24);
            lblGelar.TabIndex = 12;
            lblGelar.Text = "Gelar";
            // 
            // txtGelar
            // 
            txtGelar.Location = new Point(20, 334);
            txtGelar.Margin = new Padding(3, 4, 3, 4);
            txtGelar.Name = "txtGelar";
            txtGelar.Size = new Size(297, 30);
            txtGelar.TabIndex = 13;
            // 
            // btnHapusPsi
            // 
            btnHapusPsi.BackColor = Color.FromArgb(217, 83, 79);
            btnHapusPsi.FlatStyle = FlatStyle.Flat;
            btnHapusPsi.ForeColor = Color.White;
            btnHapusPsi.Location = new Point(21, 636);
            btnHapusPsi.Margin = new Padding(3, 4, 3, 4);
            btnHapusPsi.Name = "btnHapusPsi";
            btnHapusPsi.Size = new Size(297, 46);
            btnHapusPsi.TabIndex = 0;
            btnHapusPsi.Text = "HAPUS PSIKOLOG";
            btnHapusPsi.UseVisualStyleBackColor = false;
            btnHapusPsi.Click += btnHapusPsi_Click;
            // 
            // btnSimpanPsikolog
            // 
            btnSimpanPsikolog.BackColor = Color.FromArgb(26, 54, 141);
            btnSimpanPsikolog.FlatStyle = FlatStyle.Flat;
            btnSimpanPsikolog.ForeColor = Color.White;
            btnSimpanPsikolog.Location = new Point(20, 582);
            btnSimpanPsikolog.Margin = new Padding(3, 4, 3, 4);
            btnSimpanPsikolog.Name = "btnSimpanPsikolog";
            btnSimpanPsikolog.Size = new Size(297, 46);
            btnSimpanPsikolog.TabIndex = 1;
            btnSimpanPsikolog.Text = "TAMBAH PSIKOLOG";
            btnSimpanPsikolog.UseVisualStyleBackColor = false;
            btnSimpanPsikolog.Click += btnSimpanPsikolog_Click;
            // 
            // lblKeahlian
            // 
            lblKeahlian.Location = new Point(21, 244);
            lblKeahlian.Name = "lblKeahlian";
            lblKeahlian.Size = new Size(114, 24);
            lblKeahlian.TabIndex = 2;
            lblKeahlian.Text = "Keahlian";
            // 
            // txtKeahlian
            // 
            txtKeahlian.Location = new Point(21, 272);
            txtKeahlian.Margin = new Padding(3, 4, 3, 4);
            txtKeahlian.Name = "txtKeahlian";
            txtKeahlian.Size = new Size(297, 30);
            txtKeahlian.TabIndex = 3;
            // 
            // txtTelpPsi
            // 
            txtTelpPsi.Location = new Point(21, 213);
            txtTelpPsi.Margin = new Padding(3, 4, 3, 4);
            txtTelpPsi.Name = "txtTelpPsi";
            txtTelpPsi.Size = new Size(297, 30);
            txtTelpPsi.TabIndex = 4;
            // 
            // lblTelpPsi
            // 
            lblTelpPsi.Location = new Point(21, 185);
            lblTelpPsi.Name = "lblTelpPsi";
            lblTelpPsi.Size = new Size(114, 24);
            lblTelpPsi.TabIndex = 5;
            lblTelpPsi.Text = "No. Telepon";
            // 
            // txtEmailPsi
            // 
            txtEmailPsi.Location = new Point(21, 154);
            txtEmailPsi.Margin = new Padding(3, 4, 3, 4);
            txtEmailPsi.Name = "txtEmailPsi";
            txtEmailPsi.Size = new Size(297, 30);
            txtEmailPsi.TabIndex = 6;
            // 
            // lblEmailPsi
            // 
            lblEmailPsi.Location = new Point(21, 128);
            lblEmailPsi.Name = "lblEmailPsi";
            lblEmailPsi.Size = new Size(114, 22);
            lblEmailPsi.TabIndex = 7;
            lblEmailPsi.Text = "Email";
            // 
            // txtNamaPsi
            // 
            txtNamaPsi.Location = new Point(21, 97);
            txtNamaPsi.Margin = new Padding(3, 4, 3, 4);
            txtNamaPsi.Name = "txtNamaPsi";
            txtNamaPsi.Size = new Size(297, 30);
            txtNamaPsi.TabIndex = 8;
            // 
            // lblNamaPsi
            // 
            lblNamaPsi.Location = new Point(21, 67);
            lblNamaPsi.Name = "lblNamaPsi";
            lblNamaPsi.Size = new Size(178, 26);
            lblNamaPsi.TabIndex = 9;
            lblNamaPsi.Text = "Nama Lengkap";
            // 
            // txtUserPsi
            // 
            txtUserPsi.Location = new Point(21, 36);
            txtUserPsi.Margin = new Padding(3, 4, 3, 4);
            txtUserPsi.Name = "txtUserPsi";
            txtUserPsi.Size = new Size(297, 30);
            txtUserPsi.TabIndex = 10;
            // 
            // lblUserPsi
            // 
            lblUserPsi.Location = new Point(21, 10);
            lblUserPsi.Name = "lblUserPsi";
            lblUserPsi.Size = new Size(114, 22);
            lblUserPsi.TabIndex = 11;
            lblUserPsi.Text = "Username";
            // 
            // pageMahasiswa
            // 
            pageMahasiswa.Controls.Add(dgvMahasiswa);
            pageMahasiswa.Controls.Add(pnlSideInputMhs);
            pageMahasiswa.Location = new Point(4, 32);
            pageMahasiswa.Margin = new Padding(3, 4, 3, 4);
            pageMahasiswa.Name = "pageMahasiswa";
            pageMahasiswa.Size = new Size(1150, 705);
            pageMahasiswa.TabIndex = 1;
            pageMahasiswa.Text = "Manage Mahasiswa";
            // 
            // dgvMahasiswa
            // 
            dgvMahasiswa.AllowUserToAddRows = false;
            dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMahasiswa.BackgroundColor = Color.White;
            dgvMahasiswa.BorderStyle = BorderStyle.None;
            dgvMahasiswa.ColumnHeadersHeight = 34;
            dgvMahasiswa.Dock = DockStyle.Fill;
            dgvMahasiswa.EnableHeadersVisualStyles = false;
            dgvMahasiswa.Location = new Point(343, 0);
            dgvMahasiswa.Margin = new Padding(3, 4, 3, 4);
            dgvMahasiswa.Name = "dgvMahasiswa";
            dgvMahasiswa.RowHeadersWidth = 62;
            dgvMahasiswa.Size = new Size(807, 705);
            dgvMahasiswa.TabIndex = 0;
            dgvMahasiswa.CellClick += dgvMahasiswa_CellClick;
            // 
            // pnlSideInputMhs
            // 
            pnlSideInputMhs.BackColor = Color.FromArgb(245, 247, 250);
            pnlSideInputMhs.Controls.Add(btnHapusMhs);
            pnlSideInputMhs.Controls.Add(btnSimpanMhs);
            pnlSideInputMhs.Controls.Add(txtTelpMhs);
            pnlSideInputMhs.Controls.Add(lblTelpMhs);
            pnlSideInputMhs.Controls.Add(txtEmailMhs);
            pnlSideInputMhs.Controls.Add(lblEmailMhs);
            pnlSideInputMhs.Controls.Add(txtNamaMhs);
            pnlSideInputMhs.Controls.Add(lblNamaMhs);
            pnlSideInputMhs.Controls.Add(txtUserMhs);
            pnlSideInputMhs.Controls.Add(lblUserMhs);
            pnlSideInputMhs.Dock = DockStyle.Left;
            pnlSideInputMhs.Location = new Point(0, 0);
            pnlSideInputMhs.Margin = new Padding(3, 4, 3, 4);
            pnlSideInputMhs.Name = "pnlSideInputMhs";
            pnlSideInputMhs.Size = new Size(343, 705);
            pnlSideInputMhs.TabIndex = 1;
            // 
            // btnHapusMhs
            // 
            btnHapusMhs.BackColor = Color.FromArgb(217, 83, 79);
            btnHapusMhs.FlatStyle = FlatStyle.Flat;
            btnHapusMhs.ForeColor = Color.White;
            btnHapusMhs.Location = new Point(21, 643);
            btnHapusMhs.Margin = new Padding(3, 4, 3, 4);
            btnHapusMhs.Name = "btnHapusMhs";
            btnHapusMhs.Size = new Size(297, 46);
            btnHapusMhs.TabIndex = 0;
            btnHapusMhs.Text = "HAPUS MAHASISWA";
            btnHapusMhs.UseVisualStyleBackColor = false;
            btnHapusMhs.Click += btnHapusMhs_Click;
            // 
            // btnSimpanMhs
            // 
            btnSimpanMhs.BackColor = Color.FromArgb(26, 54, 141);
            btnSimpanMhs.FlatStyle = FlatStyle.Flat;
            btnSimpanMhs.ForeColor = Color.White;
            btnSimpanMhs.Location = new Point(21, 589);
            btnSimpanMhs.Margin = new Padding(3, 4, 3, 4);
            btnSimpanMhs.Name = "btnSimpanMhs";
            btnSimpanMhs.Size = new Size(297, 46);
            btnSimpanMhs.TabIndex = 1;
            btnSimpanMhs.Text = "TAMBAH MAHASISWA";
            btnSimpanMhs.UseVisualStyleBackColor = false;
            btnSimpanMhs.Click += btnSimpanMhs_Click;
            // 
            // txtTelpMhs
            // 
            txtTelpMhs.Location = new Point(21, 217);
            txtTelpMhs.Margin = new Padding(3, 4, 3, 4);
            txtTelpMhs.Name = "txtTelpMhs";
            txtTelpMhs.Size = new Size(297, 30);
            txtTelpMhs.TabIndex = 4;
            // 
            // lblTelpMhs
            // 
            lblTelpMhs.Location = new Point(21, 189);
            lblTelpMhs.Name = "lblTelpMhs";
            lblTelpMhs.Size = new Size(143, 24);
            lblTelpMhs.TabIndex = 5;
            lblTelpMhs.Text = "No. Telepon";
            // 
            // txtEmailMhs
            // 
            txtEmailMhs.Location = new Point(21, 158);
            txtEmailMhs.Margin = new Padding(3, 4, 3, 4);
            txtEmailMhs.Name = "txtEmailMhs";
            txtEmailMhs.Size = new Size(297, 30);
            txtEmailMhs.TabIndex = 6;
            // 
            // lblEmailMhs
            // 
            lblEmailMhs.Location = new Point(21, 133);
            lblEmailMhs.Name = "lblEmailMhs";
            lblEmailMhs.Size = new Size(114, 21);
            lblEmailMhs.TabIndex = 7;
            lblEmailMhs.Text = "Email";
            // 
            // txtNamaMhs
            // 
            txtNamaMhs.Location = new Point(21, 102);
            txtNamaMhs.Margin = new Padding(3, 4, 3, 4);
            txtNamaMhs.Name = "txtNamaMhs";
            txtNamaMhs.Size = new Size(297, 30);
            txtNamaMhs.TabIndex = 8;
            // 
            // lblNamaMhs
            // 
            lblNamaMhs.Location = new Point(21, 70);
            lblNamaMhs.Name = "lblNamaMhs";
            lblNamaMhs.Size = new Size(143, 28);
            lblNamaMhs.TabIndex = 9;
            lblNamaMhs.Text = "Nama Lengkap";
            // 
            // txtUserMhs
            // 
            txtUserMhs.Location = new Point(21, 38);
            txtUserMhs.Margin = new Padding(3, 4, 3, 4);
            txtUserMhs.Name = "txtUserMhs";
            txtUserMhs.Size = new Size(297, 30);
            txtUserMhs.TabIndex = 10;
            // 
            // lblUserMhs
            // 
            lblUserMhs.Location = new Point(21, 10);
            lblUserMhs.Name = "lblUserMhs";
            lblUserMhs.Size = new Size(114, 25);
            lblUserMhs.TabIndex = 11;
            lblUserMhs.Text = "Username (NIM)";
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Calibri", 10.9F, FontStyle.Bold);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(80, 755);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(179, 41);
            btnKeluar.TabIndex = 15;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri Light", 11.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(73, 157);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 45);
            btnDashboard.TabIndex = 14;
            btnDashboard.Text = "Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Calibri Light", 11.5F, FontStyle.Bold);
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(74, 318);
            btnLaporan.Margin = new Padding(3, 4, 3, 4);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(163, 45);
            btnLaporan.TabIndex = 12;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Transparent;
            btnKelolaUser.FlatAppearance.BorderSize = 0;
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.Font = new Font("Corbel", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(73, 238);
            btnKelolaUser.Margin = new Padding(3, 4, 3, 4);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(163, 45);
            btnKelolaUser.TabIndex = 13;
            btnKelolaUser.Text = "Kelola Pengguna";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Calibri", 10.8F);
            btnKembali.ForeColor = SystemColors.ButtonHighlight;
            btnKembali.Location = new Point(1413, 32);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(81, 51);
            btnKembali.TabIndex = 16;
            btnKembali.Text = "Kembali";
            btnKembali.TextAlign = ContentAlignment.MiddleLeft;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormManageUser
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 860);
            Controls.Add(btnKembali);
            Controls.Add(btnKeluar);
            Controls.Add(btnDashboard);
            Controls.Add(btnLaporan);
            Controls.Add(btnKelolaUser);
            Controls.Add(tabUserControl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind - User Management Control";
            WindowState = FormWindowState.Maximized;
            Load += FormManageUser_Load;
            tabUserControl.ResumeLayout(false);
            pagePsikolog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPsikolog).EndInit();
            pnlSideInputPsi.ResumeLayout(false);
            pnlSideInputPsi.PerformLayout();
            pageMahasiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).EndInit();
            pnlSideInputMhs.ResumeLayout(false);
            pnlSideInputMhs.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabUserControl;
        private System.Windows.Forms.TabPage pagePsikolog;
        private System.Windows.Forms.TabPage pageMahasiswa;
        private System.Windows.Forms.DataGridView dgvPsikolog;
        private System.Windows.Forms.Panel pnlSideInputPsi;
        private System.Windows.Forms.Button btnHapusPsi;
        private System.Windows.Forms.Button btnSimpanPsikolog;
        private System.Windows.Forms.Label lblKeahlian;
        private System.Windows.Forms.TextBox txtKeahlian;
        private System.Windows.Forms.TextBox txtTelpPsi;
        private System.Windows.Forms.Label lblTelpPsi;
        private System.Windows.Forms.TextBox txtEmailPsi;
        private System.Windows.Forms.Label lblEmailPsi;
        private System.Windows.Forms.TextBox txtGelar;
        private System.Windows.Forms.Label lblGelar;
        private System.Windows.Forms.TextBox txtPendidikan;
        private System.Windows.Forms.Label lblPendidikan;
        private System.Windows.Forms.TextBox txtIzinPraktek;
        private System.Windows.Forms.Label lblIzinPraktek;
        private System.Windows.Forms.TextBox txtNamaPsi;
        private System.Windows.Forms.Label lblNamaPsi;
        private System.Windows.Forms.TextBox txtUserPsi;
        private System.Windows.Forms.Label lblUserPsi;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Panel pnlSideInputMhs;
        private System.Windows.Forms.Button btnHapusMhs;
        private System.Windows.Forms.Button btnSimpanMhs;
        private System.Windows.Forms.TextBox txtTelpMhs;
        private System.Windows.Forms.Label lblTelpMhs;
        private System.Windows.Forms.TextBox txtEmailMhs;
        private System.Windows.Forms.Label lblEmailMhs;
        private System.Windows.Forms.TextBox txtNamaMhs;
        private System.Windows.Forms.Label lblNamaMhs;
        private System.Windows.Forms.TextBox txtUserMhs;
        private System.Windows.Forms.Label lblUserMhs;
        private System.Windows.Forms.Label lblDeskPsi;
        private System.Windows.Forms.TextBox txtDeskPsi;
        private Button btnKeluar;
        private Button btnDashboard;
        private Button btnLaporan;
        private Button btnKelolaUser;
        private Button btnKembali;
        //private System.Windows.Forms.Label lblIzinPraktek;
        //private System.Windows.Forms.TextBox txtIzinPraktek;
        //private System.Windows.Forms.Label lblPendidikan;
        //private System.Windows.Forms.TextBox txtPendidikan;
        //private System.Windows.Forms.Label lblGelar;
        //private System.Windows.Forms.TextBox txtGelar;
    }
}