namespace pboFinalProfject.View.Mahasiswa
{
    partial class FormKuesioner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMulaiLagi = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelQuestions
            // 
            this.panelQuestions.AutoScroll = true;
            this.panelQuestions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestions.Location = new System.Drawing.Point(12, 12);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(920, 600);
            this.panelQuestions.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(760, 625);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Kirim Kuisioner";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMulaiLagi
            // 
            this.btnMulaiLagi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMulaiLagi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular);
            this.btnMulaiLagi.Location = new System.Drawing.Point(580, 625);
            this.btnMulaiLagi.Name = "btnMulaiLagi";
            this.btnMulaiLagi.Size = new System.Drawing.Size(172, 45);
            this.btnMulaiLagi.TabIndex = 2;
            this.btnMulaiLagi.Text = "Mulai Lagi";
            this.btnMulaiLagi.UseVisualStyleBackColor = false;
            this.btnMulaiLagi.Visible = false;
            this.btnMulaiLagi.Click += new System.EventHandler(this.btnMulaiLagi_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKembali.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular);
            this.btnKembali.Location = new System.Drawing.Point(400, 625);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(172, 45);
            this.btnKembali.TabIndex = 3;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Visible = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 620);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(380, 60);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "";
            this.lblResult.Visible = false;
            // 
            // FormKuisioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnMulaiLagi);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.panelQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormKuisioner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kuisioner Kesehatan Mental";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMulaiLagi;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblResult;
    }
}
