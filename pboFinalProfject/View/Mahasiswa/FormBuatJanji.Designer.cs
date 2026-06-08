namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormBuatJanji
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
            this.dgvPsikolog = new System.Windows.Forms.DataGridView();
            this.dgvAvailableJadwal = new System.Windows.Forms.DataGridView();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.btnBuat = new System.Windows.Forms.Button();
            this.btnBatalkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 
            // dgvPsikolog
            // 
            this.dgvPsikolog.Location = new System.Drawing.Point(12, 12);
            this.dgvPsikolog.Name = "dgvPsikolog";
            this.dgvPsikolog.Size = new System.Drawing.Size(300, 300);
            this.dgvPsikolog.TabIndex = 0;
            // 
            // dgvAvailableJadwal
            // 
            this.dgvAvailableJadwal.Location = new System.Drawing.Point(320, 12);
            this.dgvAvailableJadwal.Name = "dgvAvailableJadwal";
            this.dgvAvailableJadwal.Size = new System.Drawing.Size(600, 300);
            this.dgvAvailableJadwal.TabIndex = 1;
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.Location = new System.Drawing.Point(12, 320);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.Size = new System.Drawing.Size(908, 200);
            this.dgvRiwayat.TabIndex = 2;
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(12, 520);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(120, 34);
            this.btnBuat.Text = "Buat Janji";
            this.btnBuat.Click += new System.EventHandler(this.btnBuat_Click);
            // 
            // btnBatalkan
            // 
            this.btnBatalkan.Location = new System.Drawing.Point(148, 520);
            this.btnBatalkan.Name = "btnBatalkan";
            this.btnBatalkan.Size = new System.Drawing.Size(120, 34);
            this.btnBatalkan.Text = "Batalkan";
            this.btnBatalkan.Click += new System.EventHandler(this.btnBatalkan_Click);
            // 
            // FormBuatJanji
            // 
            this.ClientSize = new System.Drawing.Size(932, 536);
            this.Controls.Add(this.btnBatalkan);
            this.Controls.Add(this.btnBuat);
            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.dgvAvailableJadwal);
            this.Controls.Add(this.dgvPsikolog);
            this.Name = "FormBuatJanji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buat Janji";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.DataGridView dgvPsikolog;
        private System.Windows.Forms.DataGridView dgvAvailableJadwal;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.Button btnBatalkan;
    }
}
