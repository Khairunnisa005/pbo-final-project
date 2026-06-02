namespace pboFinalProfject.View
{
    partial class Registrasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrasi));
            btnDaftar = new Button();
            tbNamaLengkap = new TextBox();
            tbEmail = new TextBox();
            tbTelepon = new TextBox();
            tbSandi = new TextBox();
            tbUsername = new TextBox();
            labelMasuk = new Label();
            lblMasuk = new LinkLabel();
            SuspendLayout();
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = SystemColors.MenuHighlight;
            btnDaftar.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = SystemColors.HighlightText;
            btnDaftar.Location = new Point(47, 390);
            btnDaftar.Margin = new Padding(2, 2, 2, 2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(343, 42);
            btnDaftar.TabIndex = 0;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            // 
            // tbNamaLengkap
            // 
            tbNamaLengkap.BackColor = SystemColors.Menu;
            tbNamaLengkap.BorderStyle = BorderStyle.None;
            tbNamaLengkap.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaLengkap.Location = new Point(58, 124);
            tbNamaLengkap.Margin = new Padding(2, 2, 2, 2);
            tbNamaLengkap.Name = "tbNamaLengkap";
            tbNamaLengkap.PlaceholderText = "Masukkan nama lengkap";
            tbNamaLengkap.Size = new Size(260, 14);
            tbNamaLengkap.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.MenuBar;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = SystemColors.ControlDarkDark;
            tbEmail.Location = new Point(58, 185);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(260, 14);
            tbEmail.TabIndex = 2;
            tbEmail.Text = "nama@gmail.com";
            // 
            // tbTelepon
            // 
            tbTelepon.BackColor = SystemColors.Control;
            tbTelepon.BorderStyle = BorderStyle.None;
            tbTelepon.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTelepon.ForeColor = SystemColors.ControlDarkDark;
            tbTelepon.Location = new Point(58, 242);
            tbTelepon.Margin = new Padding(2, 2, 2, 2);
            tbTelepon.Name = "tbTelepon";
            tbTelepon.Size = new Size(260, 14);
            tbTelepon.TabIndex = 3;
            tbTelepon.Text = "+628 xxxx xxxx";
            tbTelepon.TextChanged += textBox3_TextChanged;
            // 
            // tbSandi
            // 
            tbSandi.BackColor = SystemColors.Menu;
            tbSandi.BorderStyle = BorderStyle.None;
            tbSandi.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSandi.ForeColor = SystemColors.WindowFrame;
            tbSandi.Location = new Point(58, 298);
            tbSandi.Margin = new Padding(2, 2, 2, 2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(260, 14);
            tbSandi.TabIndex = 4;
            tbSandi.Text = "Masukkan kata sandi";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.Menu;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = SystemColors.WindowFrame;
            tbUsername.Location = new Point(60, 360);
            tbUsername.Margin = new Padding(2, 2, 2, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(260, 14);
            tbUsername.TabIndex = 5;
            tbUsername.Text = "Masukkan nama tampilan";
            // 
            // labelMasuk
            // 
            labelMasuk.AutoSize = true;
            labelMasuk.BackColor = SystemColors.ControlLightLight;
            labelMasuk.Font = new Font("Segoe UI", 6F);
            labelMasuk.ForeColor = SystemColors.ControlDarkDark;
            labelMasuk.Location = new Point(134, 439);
            labelMasuk.Margin = new Padding(2, 0, 2, 0);
            labelMasuk.Name = "labelMasuk";
            labelMasuk.Size = new Size(93, 12);
            labelMasuk.TabIndex = 6;
            labelMasuk.Text = "Sudah punya akun?";
            // 
            // lblMasuk
            // 
            lblMasuk.ActiveLinkColor = SystemColors.HotTrack;
            lblMasuk.AutoSize = true;
            lblMasuk.BackColor = SystemColors.ControlLightLight;
            lblMasuk.Font = new Font("Segoe UI", 6F);
            lblMasuk.LinkColor = SystemColors.Highlight;
            lblMasuk.Location = new Point(231, 439);
            lblMasuk.Margin = new Padding(2, 0, 2, 0);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(34, 12);
            lblMasuk.TabIndex = 7;
            lblMasuk.TabStop = true;
            lblMasuk.Text = "Masuk";
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(878, 493);
            Controls.Add(lblMasuk);
            Controls.Add(labelMasuk);
            Controls.Add(tbUsername);
            Controls.Add(tbSandi);
            Controls.Add(tbTelepon);
            Controls.Add(tbEmail);
            Controls.Add(tbNamaLengkap);
            Controls.Add(btnDaftar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Registrasi";
            Text = "Registrasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDaftar;
        private TextBox tbNamaLengkap;
        private TextBox tbEmail;
        private TextBox tbTelepon;
        private TextBox tbSandi;
        private TextBox tbUsername;
        private Label labelMasuk;
        private LinkLabel lblMasuk;
    }
}