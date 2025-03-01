namespace TachCookie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCatChuoi = new System.Windows.Forms.Button();
            this.btnGhepChuoi = new System.Windows.Forms.Button();
            this.lbldiscord = new System.Windows.Forms.Label();
            this.picBoxdiscord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxdiscord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCatChuoi
            // 
            this.btnCatChuoi.Location = new System.Drawing.Point(40, 12);
            this.btnCatChuoi.Name = "btnCatChuoi";
            this.btnCatChuoi.Size = new System.Drawing.Size(136, 43);
            this.btnCatChuoi.TabIndex = 0;
            this.btnCatChuoi.Text = "Cắt Chuỗi";
            this.btnCatChuoi.UseVisualStyleBackColor = true;
            this.btnCatChuoi.Click += new System.EventHandler(this.btnCatChuoi_Click);
            // 
            // btnGhepChuoi
            // 
            this.btnGhepChuoi.Location = new System.Drawing.Point(40, 61);
            this.btnGhepChuoi.Name = "btnGhepChuoi";
            this.btnGhepChuoi.Size = new System.Drawing.Size(136, 43);
            this.btnGhepChuoi.TabIndex = 0;
            this.btnGhepChuoi.Text = "Ghép chuỗi";
            this.btnGhepChuoi.UseVisualStyleBackColor = true;
            // 
            // lbldiscord
            // 
            this.lbldiscord.AutoSize = true;
            this.lbldiscord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscord.ForeColor = System.Drawing.Color.Navy;
            this.lbldiscord.Location = new System.Drawing.Point(64, 112);
            this.lbldiscord.Name = "lbldiscord";
            this.lbldiscord.Size = new System.Drawing.Size(103, 16);
            this.lbldiscord.TabIndex = 1;
            this.lbldiscord.Text = "/tpBRgDHb25";
            this.lbldiscord.Click += new System.EventHandler(this.lbldiscord_Click);
            // 
            // picBoxdiscord
            // 
            this.picBoxdiscord.Image = global::TachCookie.Properties.Resources.logodiscord;
            this.picBoxdiscord.Location = new System.Drawing.Point(43, 107);
            this.picBoxdiscord.Name = "picBoxdiscord";
            this.picBoxdiscord.Size = new System.Drawing.Size(22, 24);
            this.picBoxdiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxdiscord.TabIndex = 2;
            this.picBoxdiscord.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(228, 134);
            this.Controls.Add(this.picBoxdiscord);
            this.Controls.Add(this.lbldiscord);
            this.Controls.Add(this.btnGhepChuoi);
            this.Controls.Add(this.btnCatChuoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(244, 173);
            this.Name = "frmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxdiscord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCatChuoi;
        private System.Windows.Forms.Button btnGhepChuoi;
        private System.Windows.Forms.Label lbldiscord;
        private System.Windows.Forms.PictureBox picBoxdiscord;
    }
}