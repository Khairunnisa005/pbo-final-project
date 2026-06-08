namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormDaftarKonselor
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
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsikolog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPsikolog
            // 
            this.dgvPsikolog.Location = new System.Drawing.Point(12, 12);
            this.dgvPsikolog.Name = "dgvPsikolog";
            this.dgvPsikolog.Size = new System.Drawing.Size(900, 600);
            this.dgvPsikolog.TabIndex = 0;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 620);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 34);
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormDaftarKonselor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvPsikolog);
            this.Name = "FormDaftarKonselor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daftar Konselor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsikolog)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPsikolog;
        private System.Windows.Forms.Button btnKembali;
    }
}
