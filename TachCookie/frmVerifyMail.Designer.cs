namespace TachCookie
{
    partial class frmVerifyMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerifyMail));
            this.lblNhapCookie = new System.Windows.Forms.Label();
            this.txtNhapCookie = new System.Windows.Forms.TextBox();
            this.lblTaiKhoanThanhCong = new System.Windows.Forms.Label();
            this.txtTaiKhoanThanhCong = new System.Windows.Forms.TextBox();
            this.txtNhaphotmail = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.lblNhaphotmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhapCookie
            // 
            this.lblNhapCookie.AutoSize = true;
            this.lblNhapCookie.Location = new System.Drawing.Point(29, 13);
            this.lblNhapCookie.Name = "lblNhapCookie";
            this.lblNhapCookie.Size = new System.Drawing.Size(72, 13);
            this.lblNhapCookie.TabIndex = 0;
            this.lblNhapCookie.Text = "Nhập Cookie:";
            // 
            // txtNhapCookie
            // 
            this.txtNhapCookie.Location = new System.Drawing.Point(34, 46);
            this.txtNhapCookie.Multiline = true;
            this.txtNhapCookie.Name = "txtNhapCookie";
            this.txtNhapCookie.Size = new System.Drawing.Size(411, 192);
            this.txtNhapCookie.TabIndex = 1;
            this.txtNhapCookie.Text = "1 cookie 1 dòng";
            // 
            // lblTaiKhoanThanhCong
            // 
            this.lblTaiKhoanThanhCong.AutoSize = true;
            this.lblTaiKhoanThanhCong.Location = new System.Drawing.Point(451, 256);
            this.lblTaiKhoanThanhCong.Name = "lblTaiKhoanThanhCong";
            this.lblTaiKhoanThanhCong.Size = new System.Drawing.Size(115, 13);
            this.lblTaiKhoanThanhCong.TabIndex = 2;
            this.lblTaiKhoanThanhCong.Text = "Tài khoản thành công:";
            // 
            // txtTaiKhoanThanhCong
            // 
            this.txtTaiKhoanThanhCong.Location = new System.Drawing.Point(220, 284);
            this.txtTaiKhoanThanhCong.Multiline = true;
            this.txtTaiKhoanThanhCong.Name = "txtTaiKhoanThanhCong";
            this.txtTaiKhoanThanhCong.Size = new System.Drawing.Size(553, 192);
            this.txtTaiKhoanThanhCong.TabIndex = 1;
            // 
            // txtNhaphotmail
            // 
            this.txtNhaphotmail.Location = new System.Drawing.Point(497, 46);
            this.txtNhaphotmail.Multiline = true;
            this.txtNhaphotmail.Name = "txtNhaphotmail";
            this.txtNhaphotmail.Size = new System.Drawing.Size(411, 192);
            this.txtNhaphotmail.TabIndex = 1;
            this.txtNhaphotmail.Text = "1 hotmail 1 dòng";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(820, 362);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 50);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(820, 295);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 47);
            this.btnXuLy.TabIndex = 4;
            this.btnXuLy.Text = "Xử lý";
            this.btnXuLy.UseVisualStyleBackColor = true;
            // 
            // lblNhaphotmail
            // 
            this.lblNhaphotmail.AutoSize = true;
            this.lblNhaphotmail.Location = new System.Drawing.Point(497, 13);
            this.lblNhaphotmail.Name = "lblNhaphotmail";
            this.lblNhaphotmail.Size = new System.Drawing.Size(74, 13);
            this.lblNhaphotmail.TabIndex = 5;
            this.lblNhaphotmail.Text = "Nhập Hotmail:";
            // 
            // frmVerifyMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 488);
            this.Controls.Add(this.lblNhaphotmail);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblTaiKhoanThanhCong);
            this.Controls.Add(this.txtTaiKhoanThanhCong);
            this.Controls.Add(this.txtNhaphotmail);
            this.Controls.Add(this.txtNhapCookie);
            this.Controls.Add(this.lblNhapCookie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerifyMail";
            this.Text = "AutoVerifyMailRoblox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapCookie;
        private System.Windows.Forms.TextBox txtNhapCookie;
        private System.Windows.Forms.Label lblTaiKhoanThanhCong;
        private System.Windows.Forms.TextBox txtTaiKhoanThanhCong;
        private System.Windows.Forms.TextBox txtNhaphotmail;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Label lblNhaphotmail;
    }
}