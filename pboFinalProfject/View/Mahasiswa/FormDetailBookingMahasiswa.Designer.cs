namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormDetailBookingMahasiswa
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblPsikolog = new System.Windows.Forms.Label();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.lblMetode = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCatatanUser = new System.Windows.Forms.TextBox();
            this.txtCatatanPsikolog = new System.Windows.Forms.TextBox();
            this.lblTingkat = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.txtRekomendasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labels and textboxes - simple layout
            // 
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Size = new System.Drawing.Size(400, 23);
            this.lblPsikolog.Location = new System.Drawing.Point(12, 40);
            this.lblPsikolog.Size = new System.Drawing.Size(400, 23);
            this.lblJadwal.Location = new System.Drawing.Point(12, 70);
            this.lblJadwal.Size = new System.Drawing.Size(400, 23);
            this.lblMetode.Location = new System.Drawing.Point(12, 100);
            this.lblMetode.Size = new System.Drawing.Size(400, 23);
            this.lblStatus.Location = new System.Drawing.Point(12, 130);
            this.lblStatus.Size = new System.Drawing.Size(400, 23);
            this.txtCatatanUser.Location = new System.Drawing.Point(12, 160);
            this.txtCatatanUser.Size = new System.Drawing.Size(600, 60);
            this.txtCatatanUser.Multiline = true;
            this.txtCatatanUser.ReadOnly = true;
            this.txtCatatanPsikolog.Location = new System.Drawing.Point(12, 230);
            this.txtCatatanPsikolog.Size = new System.Drawing.Size(600, 60);
            this.txtCatatanPsikolog.Multiline = true;
            this.txtCatatanPsikolog.ReadOnly = true;
            this.lblTingkat.Location = new System.Drawing.Point(12, 300);
            this.lblTingkat.Size = new System.Drawing.Size(200, 23);
            this.lblSkor.Location = new System.Drawing.Point(220, 300);
            this.lblSkor.Size = new System.Drawing.Size(200, 23);
            this.txtRekomendasi.Location = new System.Drawing.Point(12, 330);
            this.txtRekomendasi.Size = new System.Drawing.Size(600, 80);
            this.txtRekomendasi.Multiline = true;
            this.txtRekomendasi.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(640, 430);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPsikolog);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.lblMetode);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCatatanUser);
            this.Controls.Add(this.txtCatatanPsikolog);
            this.Controls.Add(this.lblTingkat);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.txtRekomendasi);
            this.Text = "Detail Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPsikolog;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label lblMetode;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCatatanUser;
        private System.Windows.Forms.TextBox txtCatatanPsikolog;
        private System.Windows.Forms.Label lblTingkat;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.TextBox txtRekomendasi;
    }
}
