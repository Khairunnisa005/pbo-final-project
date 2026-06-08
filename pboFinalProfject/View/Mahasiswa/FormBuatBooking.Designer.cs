namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormBuatBooking
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
            this.lblKategori = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.lblPsikolog = new System.Windows.Forms.Label();
            this.comboPsikolog = new System.Windows.Forms.ComboBox();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.chkAttachAssessment = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKategori
            // 
            this.lblKategori.Location = new System.Drawing.Point(12, 15);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(100, 23);
            this.lblKategori.Text = "Kategori";
            // 
            // comboKategori
            // 
            this.comboKategori.Location = new System.Drawing.Point(120, 12);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(300, 28);
            // 
            // lblPsikolog
            // 
            this.lblPsikolog.Location = new System.Drawing.Point(12, 55);
            this.lblPsikolog.Name = "lblPsikolog";
            this.lblPsikolog.Size = new System.Drawing.Size(100, 23);
            this.lblPsikolog.Text = "Pilih Psikolog";
            // 
            // comboPsikolog
            // 
            this.comboPsikolog.Location = new System.Drawing.Point(120, 52);
            this.comboPsikolog.Name = "comboPsikolog";
            this.comboPsikolog.Size = new System.Drawing.Size(300, 28);
            // 
            // lblJadwal
            // 
            this.lblJadwal.Location = new System.Drawing.Point(12, 95);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(100, 23);
            this.lblJadwal.Text = "Pilih Jadwal";
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.Location = new System.Drawing.Point(12, 120);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.Size = new System.Drawing.Size(760, 250);
            this.dgvJadwal.TabIndex = 0;
            // 
            // lblCatatan
            // 
            this.lblCatatan.Location = new System.Drawing.Point(12, 385);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(100, 23);
            this.lblCatatan.Text = "Catatan";
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(120, 382);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(652, 80);
            // 
            // chkAttachAssessment
            // 
            this.chkAttachAssessment.Location = new System.Drawing.Point(12, 475);
            this.chkAttachAssessment.Name = "chkAttachAssessment";
            this.chkAttachAssessment.Size = new System.Drawing.Size(300, 24);
            this.chkAttachAssessment.Text = "Lampirkan hasil kuisioner terbaru";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(632, 508);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 36);
            this.btnSubmit.Text = "Kirim Permintaan";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(486, 508);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 36);
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormBuatBooking
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkAttachAssessment);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.dgvJadwal);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.comboPsikolog);
            this.Controls.Add(this.lblPsikolog);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.lblKategori);
            this.Name = "FormBuatBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buat Booking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Label lblPsikolog;
        private System.Windows.Forms.ComboBox comboPsikolog;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.CheckBox chkAttachAssessment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnKembali;
    }
}
