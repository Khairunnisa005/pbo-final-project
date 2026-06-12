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
            lblStatusMhs = new Label();
            cmbStatusMhs = new ComboBox();
            txtTelpMhs = new TextBox();
            lblTelpMhs = new Label();
            txtEmailMhs = new TextBox();
            lblEmailMhs = new Label();
            txtNamaMhs = new TextBox();
            lblNamaMhs = new Label();
            txtUserMhs = new TextBox();
            lblUserMhs = new Label();
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
            tabUserControl.Location = new Point(325, 138);
            tabUserControl.Margin = new Padding(3, 4, 3, 4);
            tabUserControl.Name = "tabUserControl";
            tabUserControl.SelectedIndex = 0;
            tabUserControl.Size = new Size(1158, 688);
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
            pagePsikolog.Size = new Size(1150, 652);
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
            dgvPsikolog.Size = new Size(807, 644);
            dgvPsikolog.TabIndex = 0;
            dgvPsikolog.CellClick += dgvPsikolog_CellClick;
            // 
            // pnlSideInputPsi
            // 
            pnlSideInputPsi.BackColor = Color.FromArgb(245, 247, 250);
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
            pnlSideInputPsi.Size = new Size(337, 644);
            pnlSideInputPsi.TabIndex = 1;
            // 
            // btnHapusPsi
            // 
            btnHapusPsi.BackColor = Color.FromArgb(217, 83, 79);
            btnHapusPsi.FlatStyle = FlatStyle.Flat;
            btnHapusPsi.ForeColor = Color.White;
            btnHapusPsi.Location = new Point(21, 437);
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
            btnSimpanPsikolog.Location = new Point(20, 382);
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
            pageMahasiswa.Size = new Size(1150, 652);
            pageMahasiswa.TabIndex = 1;
            pageMahasiswa.Text = "Manage Mahasiswa";
            // 
            // dgvMahasiswa
            // 
            dgvMahasiswa.AllowUserToAddRows = false;
            dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMahasiswa.BackgroundColor = Color.White;
            dgvMahasiswa.BorderStyle = BorderStyle.None;
            dgvMahasiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMahasiswa.ColumnHeadersHeight = 34;
            dgvMahasiswa.Dock = DockStyle.Fill;
            dgvMahasiswa.EnableHeadersVisualStyles = false;
            dgvMahasiswa.Location = new Point(343, 0);
            dgvMahasiswa.Margin = new Padding(3, 4, 3, 4);
            dgvMahasiswa.Name = "dgvMahasiswa";
            dgvMahasiswa.RowHeadersWidth = 62;
            dgvMahasiswa.Size = new Size(807, 652);
            dgvMahasiswa.TabIndex = 0;
            dgvMahasiswa.CellClick += dgvMahasiswa_CellClick;
            // 
            // pnlSideInputMhs
            // 
            pnlSideInputMhs.BackColor = Color.FromArgb(245, 247, 250);
            pnlSideInputMhs.Controls.Add(btnHapusMhs);
            pnlSideInputMhs.Controls.Add(btnSimpanMhs);
            pnlSideInputMhs.Controls.Add(lblStatusMhs);
            pnlSideInputMhs.Controls.Add(cmbStatusMhs);
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
            pnlSideInputMhs.Size = new Size(343, 652);
            pnlSideInputMhs.TabIndex = 1;
            // 
            // btnHapusMhs
            // 
            btnHapusMhs.BackColor = Color.FromArgb(217, 83, 79);
            btnHapusMhs.FlatStyle = FlatStyle.Flat;
            btnHapusMhs.ForeColor = Color.White;
            btnHapusMhs.Location = new Point(21, 574);
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
            btnSimpanMhs.Location = new Point(21, 520);
            btnSimpanMhs.Margin = new Padding(3, 4, 3, 4);
            btnSimpanMhs.Name = "btnSimpanMhs";
            btnSimpanMhs.Size = new Size(297, 46);
            btnSimpanMhs.TabIndex = 1;
            btnSimpanMhs.Text = "TAMBAH MAHASISWA";
            btnSimpanMhs.UseVisualStyleBackColor = false;
            btnSimpanMhs.Click += btnSimpanMhs_Click;
            // 
            // lblStatusMhs
            // 
            lblStatusMhs.Location = new Point(21, 248);
            lblStatusMhs.Name = "lblStatusMhs";
            lblStatusMhs.Size = new Size(114, 22);
            lblStatusMhs.TabIndex = 2;
            lblStatusMhs.Text = "Status Keanggotaan";
            // 
            // cmbStatusMhs
            // 
            cmbStatusMhs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusMhs.Items.AddRange(new object[] { "REGULER", "VIP", "BEASISWA" });
            cmbStatusMhs.Location = new Point(21, 274);
            cmbStatusMhs.Margin = new Padding(3, 4, 3, 4);
            cmbStatusMhs.Name = "cmbStatusMhs";
            cmbStatusMhs.Size = new Size(297, 31);
            cmbStatusMhs.TabIndex = 3;
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
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(28, 167, 236);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(1349, 36);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(147, 42);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
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
            Controls.Add(tabUserControl);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniMind - User Management Control";
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
        private System.Windows.Forms.TextBox txtNamaPsi;
        private System.Windows.Forms.Label lblNamaPsi;
        private System.Windows.Forms.TextBox txtUserPsi;
        private System.Windows.Forms.Label lblUserPsi;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Panel pnlSideInputMhs;
        private System.Windows.Forms.Button btnHapusMhs;
        private System.Windows.Forms.Button btnSimpanMhs;
        private System.Windows.Forms.Label lblStatusMhs;
        private System.Windows.Forms.ComboBox cmbStatusMhs;
        private System.Windows.Forms.TextBox txtTelpMhs;
        private System.Windows.Forms.Label lblTelpMhs;
        private System.Windows.Forms.TextBox txtEmailMhs;
        private System.Windows.Forms.Label lblEmailMhs;
        private System.Windows.Forms.TextBox txtNamaMhs;
        private System.Windows.Forms.Label lblNamaMhs;
        private System.Windows.Forms.TextBox txtUserMhs;
        private System.Windows.Forms.Label lblUserMhs;
        private System.Windows.Forms.Button btnKembali;
    }
}