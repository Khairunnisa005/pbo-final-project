using System.Drawing.Drawing2D;
using System.Drawing;

namespace pboFinalProfject
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            tbEmail = new TextBox();
            tbSandi = new TextBox();
            btnMasuk = new Button();
            labelDaftar = new Label();
            lblDaftar = new LinkLabel();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.HighlightText;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = SystemColors.WindowFrame;
            tbEmail.Location = new Point(460, 341);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(600, 27);
            tbEmail.TabIndex = 0;
            tbEmail.Text = "nama@gmail.com";
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbSandi
            // 
            tbSandi.BackColor = SystemColors.HighlightText;
            tbSandi.BorderStyle = BorderStyle.None;
            tbSandi.Font = new Font("Segoe UI", 12F);
            tbSandi.ForeColor = SystemColors.WindowFrame;
            tbSandi.Location = new Point(460, 400);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(600, 27);
            tbSandi.TabIndex = 1;
            tbSandi.Text = "Masukkan kata sandi";
            // 
            // btnMasuk
            // 
            btnMasuk.BackColor = SystemColors.MenuHighlight;
            btnMasuk.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMasuk.ForeColor = SystemColors.ButtonHighlight;
            btnMasuk.Location = new Point(460, 470);
            btnMasuk.Margin = new Padding(2);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(600, 81);
            btnMasuk.TabIndex = 2;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = false;
            // 
            // labelDaftar
            // 
            labelDaftar.AutoSize = true;
            labelDaftar.BackColor = SystemColors.ControlLightLight;
            labelDaftar.FlatStyle = FlatStyle.Flat;
            labelDaftar.Font = new Font("Segoe UI", 12F);
            labelDaftar.ForeColor = SystemColors.ControlDarkDark;
            labelDaftar.Location = new Point(1030, 653);
            labelDaftar.Margin = new Padding(2, 0, 2, 0);
            labelDaftar.Name = "labelDaftar";
            labelDaftar.Size = new Size(201, 28);
            labelDaftar.TabIndex = 3;
            labelDaftar.Text = "Belum memiliki akun?";
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.BackColor = SystemColors.ControlLightLight;
            lblDaftar.Font = new Font("Segoe UI", 12F);
            lblDaftar.LinkColor = SystemColors.Highlight;
            lblDaftar.Location = new Point(1227, 653);
            lblDaftar.Margin = new Padding(2, 0, 2, 0);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(66, 28);
            lblDaftar.TabIndex = 4;
            lblDaftar.TabStop = true;
            lblDaftar.Text = "Daftar";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            // Lock scaling to avoid DPI/layout shifts
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1536, 864);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1536, 864);
            MaximumSize = new Size(1536, 864);
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(lblDaftar);
            Controls.Add(labelDaftar);
            Controls.Add(btnMasuk);
            Controls.Add(tbSandi);
            Controls.Add(tbEmail);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormLogin";
            Text = "Form1";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Masukkan email...")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbSandi;
        private Button btnMasuk;
        private Label labelDaftar;
        private LinkLabel lblDaftar;
    }
}
