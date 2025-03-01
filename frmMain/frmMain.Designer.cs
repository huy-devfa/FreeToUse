namespace frmMain
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCatChuoi = new System.Windows.Forms.Button();
            this.btnGhepChuoi = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCatChuoi
            // 
            this.btnCatChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatChuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCatChuoi.Location = new System.Drawing.Point(32, 58);
            this.btnCatChuoi.Name = "btnCatChuoi";
            this.btnCatChuoi.Size = new System.Drawing.Size(149, 40);
            this.btnCatChuoi.TabIndex = 0;
            this.btnCatChuoi.Text = "Cắt chuỗi";
            this.btnCatChuoi.UseVisualStyleBackColor = true;
            this.btnCatChuoi.Click += new System.EventHandler(this.btnCatChuoi_Click);
            // 
            // btnGhepChuoi
            // 
            this.btnGhepChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhepChuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGhepChuoi.Location = new System.Drawing.Point(10, 12);
            this.btnGhepChuoi.Name = "btnGhepChuoi";
            this.btnGhepChuoi.Size = new System.Drawing.Size(195, 40);
            this.btnGhepChuoi.TabIndex = 0;
            this.btnGhepChuoi.Text = "Ghép chuỗi";
            this.btnGhepChuoi.UseVisualStyleBackColor = true;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Navy;
            this.lblUpdate.Location = new System.Drawing.Point(26, 112);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(163, 37);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "Còn tiếp...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 158);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnGhepChuoi);
            this.Controls.Add(this.btnCatChuoi);
            this.MaximumSize = new System.Drawing.Size(421, 271);
            this.Name = "frmMain";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCatChuoi;
        private System.Windows.Forms.Button btnGhepChuoi;
        private System.Windows.Forms.Label lblUpdate;
    }
}

