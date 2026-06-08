namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormProfilMahasiswa
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

        private void InitializeComponent()
        {
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(12, 12);
            this.tbUsername.Size = new System.Drawing.Size(400, 27);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(12, 50);
            this.tbNama.Size = new System.Drawing.Size(400, 27);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 88);
            this.tbEmail.Size = new System.Drawing.Size(400, 27);
            // 
            // tbTelepon
            // 
            this.tbTelepon.Location = new System.Drawing.Point(12, 126);
            this.tbTelepon.Size = new System.Drawing.Size(400, 27);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 164);
            this.btnSimpan.Size = new System.Drawing.Size(120, 34);
            this.btnSimpan.Text = "Simpan";
            // 
            // FormProfilMahasiswa
            // 
            this.ClientSize = new System.Drawing.Size(440, 210);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbTelepon);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbUsername);
            this.Name = "FormProfilMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.Button btnSimpan;
    }
}
