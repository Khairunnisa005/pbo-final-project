namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormCekKeadaan
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(900, 300);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Memuat...";
            // 
            // btnRetake
            // 
            this.btnRetake = new System.Windows.Forms.Button();
            this.btnRetake.Location = new System.Drawing.Point(12, 320);
            this.btnRetake.Name = "btnRetake";
            this.btnRetake.Size = new System.Drawing.Size(120, 34);
            this.btnRetake.Text = "Isi Kuisioner";
            this.btnRetake.Click += new System.EventHandler(this.btnRetake_Click);
            this.btnRetake.Visible = false;
            // 
            // btnKembali
            // 
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnKembali.Location = new System.Drawing.Point(140, 320);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 34);
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormCekKeadaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 324);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnRetake);
            this.Controls.Add(this.lblInfo);
            this.Name = "FormCekKeadaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cek Keadaan";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnRetake;
        private System.Windows.Forms.Button btnKembali;
    }
}
