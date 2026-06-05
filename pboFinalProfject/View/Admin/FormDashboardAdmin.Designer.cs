namespace pboFinalProfject.View
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblUnimindLogo = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.btnMenuJadwal = new System.Windows.Forms.Button();
            this.btnMenuPasien = new System.Windows.Forms.Button();
            this.pnlUserProfile = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.lblSubSelamatDatang = new System.Windows.Forms.Label();
            this.pnlStatsCard = new System.Windows.Forms.Panel();
            this.lblCountBooking = new System.Windows.Forms.Label();
            this.lblCountPasien = new System.Windows.Forms.Label();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTableSub = new System.Windows.Forms.Label();
            this.dgvBookingMasuk = new System.Windows.Forms.DataGridView();
            this.btnKelolaJadwal = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserProfile.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlStatsCard.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.pnlSidebar.Controls.Add(this.btnKeluar);
            this.pnlSidebar.Controls.Add(this.pnlUserProfile);
            this.pnlSidebar.Controls.Add(this.btnMenuPasien);
            this.pnlSidebar.Controls.Add(this.btnMenuJadwal);
            this.pnlSidebar.Controls.Add(this.lblTagline);
            this.pnlSidebar.Controls.Add(this.lblUnimindLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 680);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblUnimindLogo
            // 
            this.lblUnimindLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUnimindLogo.ForeColor = System.Drawing.Color.White;
            this.lblUnimindLogo.Location = new System.Drawing.Point(20, 25);
            this.lblUnimindLogo.Name = "lblUnimindLogo";
            this.lblUnimindLogo.Size = new System.Drawing.Size(200, 35);
            this.lblUnimindLogo.Text = "Unimind";
            // 
            // lblTagline
            // 
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.lblTagline.Location = new System.Drawing.Point(22, 60);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(200, 20);
            this.lblTagline.Text = "Learn • Grow • Achieve";
            // 
            // btnMenuJadwal
            // 
            this.btnMenuJadwal.FlatAppearance.BorderSize = 0;
            this.btnMenuJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuJadwal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuJadwal.ForeColor = System.Drawing.Color.White;
            this.btnMenuJadwal.Location = new System.Drawing.Point(0, 130);
            this.btnMenuJadwal.Name = "btnMenuJadwal";
            this.btnMenuJadwal.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenuJadwal.Size = new System.Drawing.Size(240, 50);
            this.btnMenuJadwal.Text = "📅  Jadwal Konseling";
            this.btnMenuJadwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuJadwal.UseVisualStyleBackColor = true;
            this.btnMenuJadwal.Click += new System.EventHandler(this.menuJadwal_Click);
            // 
            // btnMenuPasien
            // 
            this.btnMenuPasien.FlatAppearance.BorderSize = 0;
            this.btnMenuPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPasien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuPasien.ForeColor = System.Drawing.Color.White;
            this.btnMenuPasien.Location = new System.Drawing.Point(0, 185);
            this.btnMenuPasien.Name = "btnMenuPasien";
            this.btnMenuPasien.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenuPasien.Size = new System.Drawing.Size(240, 50);
            this.btnMenuPasien.Text = "👥  Daftar Pasien";
            this.btnMenuPasien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPasien.UseVisualStyleBackColor = true;
            this.btnMenuPasien.Click += new System.EventHandler(this.menuPasien_Click);
            // 
            // pnlUserProfile
            // 
            this.pnlUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUserProfile.Controls.Add(this.lblAdminRole);
            this.pnlUserProfile.Controls.Add(this.lblAdminName);
            this.pnlUserProfile.Location = new System.Drawing.Point(0, 550);
            this.pnlUserProfile.Name = "pnlUserProfile";
            this.pnlUserProfile.Size = new System.Drawing.Size(240, 65);
            // 
            // lblAdminName
            // 
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(25, 12);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(190, 20);
            this.lblAdminName.Text = "Admin";
            // 
            // lblAdminRole
            // 
            this.lblAdminRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAdminRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.lblAdminRole.Location = new System.Drawing.Point(25, 34);
            this.lblAdminRole.Name = "lblAdminRole";
            this.lblAdminRole.Size = new System.Drawing.Size(190, 15);
            this.lblAdminRole.Text = "Administrator";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(0, 620);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKeluar.Size = new System.Drawing.Size(240, 45);
            this.btnKeluar.Text = "🚪  Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlMainContent.Controls.Add(this.btnKelolaJadwal);
            this.pnlMainContent.Controls.Add(this.pnlTableContainer);
            this.pnlMainContent.Controls.Add(this.pnlStatsCard);
            this.pnlMainContent.Controls.Add(this.lblSubSelamatDatang);
            this.pnlMainContent.Controls.Add(this.lblSelamatDatang);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(240, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(814, 680);
            this.pnlMainContent.TabIndex = 1;
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSelamatDatang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.lblSelamatDatang.Location = new System.Drawing.Point(30, 25);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(400, 40);
            this.lblSelamatDatang.Text = "Selamat Datang";
            // 
            // lblSubSelamatDatang
            // 
            this.lblSubSelamatDatang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubSelamatDatang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubSelamatDatang.Location = new System.Drawing.Point(32, 65);
            this.lblSubSelamatDatang.Name = "lblSubSelamatDatang";
            this.lblSubSelamatDatang.Size = new System.Drawing.Size(400, 25);
            this.lblSubSelamatDatang.Text = "Silakan kelola booking konseling yang masuk.";
            // 
            // pnlStatsCard
            // 
            this.pnlStatsCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsCard.BackColor = System.Drawing.Color.White;
            this.pnlStatsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatsCard.Controls.Add(this.lblCountPasien);
            this.pnlStatsCard.Controls.Add(this.lblCountBooking);
            this.pnlStatsCard.Location = new System.Drawing.Point(35, 110);
            this.pnlStatsCard.Name = "pnlStatsCard";
            this.pnlStatsCard.Size = new System.Drawing.Size(744, 85);
            this.pnlStatsCard.TabIndex = 2;
            // 
            // lblCountBooking
            // 
            this.lblCountBooking.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCountBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblCountBooking.Location = new System.Drawing.Point(25, 25);
            this.lblCountBooking.Name = "lblCountBooking";
            this.lblCountBooking.Size = new System.Drawing.Size(250, 35);
            this.lblCountBooking.Text = "0 Sesi Aktif";
            // 
            // lblCountPasien
            // 
            this.lblCountPasien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCountPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCountPasien.Location = new System.Drawing.Point(380, 25);
            this.lblCountPasien.Name = "lblCountPasien";
            this.lblCountPasien.Size = new System.Drawing.Size(250, 35);
            this.lblCountPasien.Text = "0 Pasien Terdaftar";
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlTableContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableContainer.Controls.Add(this.dgvBookingMasuk);
            this.pnlTableContainer.Controls.Add(this.lblTableSub);
            this.pnlTableContainer.Controls.Add(this.lblTableTitle);
            this.pnlTableContainer.Location = new System.Drawing.Point(35, 220);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(744, 380);
            this.pnlTableContainer.TabIndex = 3;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.lblTableTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTableTitle.Text = "Daftar Booking Masuk";
            // 
            // lblTableSub
            // 
            this.lblTableSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTableSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTableSub.Location = new System.Drawing.Point(20, 42);
            this.lblTableSub.Name = "lblTableSub";
            this.lblTableSub.Size = new System.Drawing.Size(500, 20);
            this.lblTableSub.Text = "Daftar mahasiswa yang telah melakukan booking konseling.";
            // 
            // dgvBookingMasuk
            // 
            this.dgvBookingMasuk.AllowUserToAddRows = false;
            this.dgvBookingMasuk.AllowUserToDeleteRows = false;
            this.dgvBookingMasuk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookingMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingMasuk.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookingMasuk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingMasuk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingMasuk.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookingMasuk.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookingMasuk.EnableHeadersVisualStyles = false;
            this.dgvBookingMasuk.Location = new System.Drawing.Point(22, 80);
            this.dgvBookingMasuk.Name = "dgvBookingMasuk";
            this.dgvBookingMasuk.ReadOnly = true;
            this.dgvBookingMasuk.RowHeadersVisible = false;
            this.dgvBookingMasuk.RowTemplate.Height = 30;
            this.dgvBookingMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingMasuk.Size = new System.Drawing.Size(700, 275);
            this.dgvBookingMasuk.TabIndex = 2;
            // 
            // btnKelolaJadwal
            // 
            this.btnKelolaJadwal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKelolaJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnKelolaJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaJadwal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKelolaJadwal.ForeColor = System.Drawing.Color.White;
            this.btnKelolaJadwal.Location = new System.Drawing.Point(629, 615);
            this.btnKelolaJadwal.Name = "btnKelolaJadwal";
            this.btnKelolaJadwal.Size = new System.Drawing.Size(150, 42);
            this.btnKelolaJadwal.Text = "📅 Kelola Jadwal";
            this.btnKelolaJadwal.UseVisualStyleBackColor = false;
            this.btnKelolaJadwal.Click += new System.EventHandler(this.btnKelolaJadwal_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 680);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniMind Admin - Dashboard Admin";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlUserProfile.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlStatsCard.ResumeLayout(false);
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingMasuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblUnimindLogo;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Button btnMenuJadwal;
        private System.Windows.Forms.Button btnMenuPasien;
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Label lblSubSelamatDatang;
        private System.Windows.Forms.Panel pnlStatsCard;
        private System.Windows.Forms.Label lblCountBooking;
        private System.Windows.Forms.Label lblCountPasien;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTableSub;
        private System.Windows.Forms.DataGridView dgvBookingMasuk;
        private System.Windows.Forms.Button btnKelolaJadwal;
    }
}