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
            btnDaftar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDaftar.ForeColor = SystemColors.HighlightText;
            btnDaftar.Location = new Point(103, 697);
            btnDaftar.Margin = new Padding(2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(570, 69);
            btnDaftar.TabIndex = 0;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            // 
            // tbNamaLengkap
            // 
            tbNamaLengkap.BackColor = SystemColors.Menu;
            tbNamaLengkap.BorderStyle = BorderStyle.None;
            tbNamaLengkap.Font = new Font("Segoe UI", 12F);
            tbNamaLengkap.Location = new Point(118, 229);
            tbNamaLengkap.Margin = new Padding(2);
            tbNamaLengkap.Name = "tbNamaLengkap";
            tbNamaLengkap.PlaceholderText = "Masukkan nama lengkap";
            tbNamaLengkap.Size = new Size(528, 27);
            tbNamaLengkap.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.MenuBar;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.ForeColor = SystemColors.ControlDarkDark;
            tbEmail.Location = new Point(116, 330);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(528, 27);
            tbEmail.TabIndex = 2;
            tbEmail.Text = "nama@gmail.com";
            // 
            // tbTelepon
            // 
            tbTelepon.BackColor = SystemColors.Control;
            tbTelepon.BorderStyle = BorderStyle.None;
            tbTelepon.Font = new Font("Segoe UI", 12F);
            tbTelepon.ForeColor = SystemColors.ControlDarkDark;
            tbTelepon.Location = new Point(116, 435);
            tbTelepon.Margin = new Padding(2);
            tbTelepon.Name = "tbTelepon";
            tbTelepon.Size = new Size(528, 27);
            tbTelepon.TabIndex = 3;
            tbTelepon.Text = "+628 xxxx xxxx";
            tbTelepon.TextChanged += textBox3_TextChanged;
            // 
            // tbSandi
            // 
            tbSandi.BackColor = SystemColors.Menu;
            tbSandi.BorderStyle = BorderStyle.None;
            tbSandi.Font = new Font("Segoe UI", 12F);
            tbSandi.ForeColor = SystemColors.WindowFrame;
            tbSandi.Location = new Point(116, 536);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(537, 27);
            tbSandi.TabIndex = 4;
            tbSandi.Text = "Masukkan kata sandi";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.Menu;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.ForeColor = SystemColors.WindowFrame;
            tbUsername.Location = new Point(116, 637);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(528, 27);
            tbUsername.TabIndex = 5;
            tbUsername.Text = "Masukkan nama tampilan";
            // 
            // labelMasuk
            // 
            labelMasuk.AutoSize = true;
            labelMasuk.BackColor = SystemColors.ControlLightLight;
            labelMasuk.Font = new Font("Segoe UI", 12F);
            labelMasuk.ForeColor = SystemColors.ControlDarkDark;
            labelMasuk.Location = new Point(235, 772);
            labelMasuk.Margin = new Padding(2, 0, 2, 0);
            labelMasuk.Name = "labelMasuk";
            labelMasuk.Size = new Size(182, 28);
            labelMasuk.TabIndex = 6;
            labelMasuk.Text = "Sudah punya akun?";
            // 
            // lblMasuk
            // 
            lblMasuk.ActiveLinkColor = SystemColors.HotTrack;
            lblMasuk.AutoSize = true;
            lblMasuk.BackColor = SystemColors.ControlLightLight;
            lblMasuk.Font = new Font("Segoe UI", 12F);
            lblMasuk.LinkColor = SystemColors.Highlight;
            lblMasuk.Location = new Point(412, 773);
            lblMasuk.Margin = new Padding(2, 0, 2, 0);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(69, 28);
            lblMasuk.TabIndex = 7;
            lblMasuk.TabStop = true;
            lblMasuk.Text = "Masuk";
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1518, 817);
            Controls.Add(lblMasuk);
            Controls.Add(labelMasuk);
            Controls.Add(tbUsername);
            Controls.Add(tbSandi);
            Controls.Add(tbTelepon);
            Controls.Add(tbEmail);
            Controls.Add(tbNamaLengkap);
            Controls.Add(btnDaftar);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Registrasi";
            Text = "Registrasi";
            Load += Registrasi_Load;
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