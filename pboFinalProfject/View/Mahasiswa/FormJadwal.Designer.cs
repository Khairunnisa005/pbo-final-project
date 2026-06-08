namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormJadwal
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
            this.btnBuat = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
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
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(918, 12);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(120, 40);
            this.btnBuat.Text = "Buat Janji";
            this.btnBuat.UseVisualStyleBackColor = true;
            this.btnBuat.Click += new System.EventHandler(this.btnBuat_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(918, 62);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 40);
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnBuat);
            this.Controls.Add(this.dgvJadwal);
            this.Name = "FormJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jadwal Konsultasi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.Button btnKembali;
    }
}
