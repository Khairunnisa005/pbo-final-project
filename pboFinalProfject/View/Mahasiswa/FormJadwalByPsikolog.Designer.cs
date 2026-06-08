namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormJadwalByPsikolog
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
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.Location = new System.Drawing.Point(12, 12);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.Size = new System.Drawing.Size(900, 600);
            this.dgvJadwal.TabIndex = 0;
            // 
            // btnKembali
            // 
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnKembali.Location = new System.Drawing.Point(12, 620);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 34);
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormJadwalByPsikolog
            // 
            this.ClientSize = new System.Drawing.Size(924, 664);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvJadwal);
            this.Name = "FormJadwalByPsikolog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jadwal Konsultasi - Psikolog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Button btnKembali;
    }
}
