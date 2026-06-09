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
            dgvJadwal = new DataGridView();
            btnBuat = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            SuspendLayout();
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeight = 29;
            dgvJadwal.Location = new Point(12, 12);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1500, 800);
            dgvJadwal.Dock = DockStyle.Fill;
            dgvJadwal.TabIndex = 0;
            // 
            // btnBuat
            // 
            btnBuat.Location = new Point(918, 12);
            btnBuat.Name = "btnBuat";
            btnBuat.Size = new Size(120, 40);
            btnBuat.TabIndex = 1;
            btnBuat.Text = "Buat Janji";
            btnBuat.UseVisualStyleBackColor = true;
            btnBuat.Click += btnBuat_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(918, 62);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(120, 40);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormJadwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 624);
            Controls.Add(btnKembali);
            Controls.Add(btnBuat);
            Controls.Add(dgvJadwal);
            Name = "FormJadwal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Jadwal Konsultasi";
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.Button btnKembali;
    }
}
