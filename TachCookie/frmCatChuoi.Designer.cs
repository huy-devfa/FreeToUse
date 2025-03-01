namespace TachCookie
{
    partial class frmCatChuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatChuoi));
            this.lblNhapAccount = new System.Windows.Forms.Label();
            this.txtNhapAccount = new System.Windows.Forms.TextBox();
            this.cbBoxDinhDang = new System.Windows.Forms.ComboBox();
            this.rbtnUserPass = new System.Windows.Forms.RadioButton();
            this.rbtnCookie = new System.Windows.Forms.RadioButton();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapAccount
            // 
            this.lblNhapAccount.AutoSize = true;
            this.lblNhapAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapAccount.ForeColor = System.Drawing.Color.Navy;
            this.lblNhapAccount.Location = new System.Drawing.Point(12, 9);
            this.lblNhapAccount.Name = "lblNhapAccount";
            this.lblNhapAccount.Size = new System.Drawing.Size(118, 18);
            this.lblNhapAccount.TabIndex = 0;
            this.lblNhapAccount.Text = "Nhập Account:";
            // 
            // txtNhapAccount
            // 
            this.txtNhapAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapAccount.ForeColor = System.Drawing.Color.Navy;
            this.txtNhapAccount.Location = new System.Drawing.Point(14, 40);
            this.txtNhapAccount.Multiline = true;
            this.txtNhapAccount.Name = "txtNhapAccount";
            this.txtNhapAccount.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNhapAccount.Size = new System.Drawing.Size(622, 199);
            this.txtNhapAccount.TabIndex = 1;
            this.txtNhapAccount.Text = "1 dòng 1 account...";
            this.txtNhapAccount.WordWrap = false;
            // 
            // cbBoxDinhDang
            // 
            this.cbBoxDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxDinhDang.ForeColor = System.Drawing.Color.Black;
            this.cbBoxDinhDang.FormattingEnabled = true;
            this.cbBoxDinhDang.Items.AddRange(new object[] {
            "Chọn định dạng",
            "user:pass:cookie",
            "user/pass/cookie",
            "user|pass|cookie"});
            this.cbBoxDinhDang.Location = new System.Drawing.Point(653, 40);
            this.cbBoxDinhDang.Name = "cbBoxDinhDang";
            this.cbBoxDinhDang.Size = new System.Drawing.Size(134, 28);
            this.cbBoxDinhDang.TabIndex = 2;
            this.cbBoxDinhDang.Text = "Chọn định dạng";
            // 
            // rbtnUserPass
            // 
            this.rbtnUserPass.AutoSize = true;
            this.rbtnUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUserPass.Location = new System.Drawing.Point(677, 92);
            this.rbtnUserPass.Name = "rbtnUserPass";
            this.rbtnUserPass.Size = new System.Drawing.Size(103, 19);
            this.rbtnUserPass.TabIndex = 3;
            this.rbtnUserPass.TabStop = true;
            this.rbtnUserPass.Text = "Lấy User Pass";
            this.rbtnUserPass.UseVisualStyleBackColor = true;
            // 
            // rbtnCookie
            // 
            this.rbtnCookie.AutoSize = true;
            this.rbtnCookie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCookie.Location = new System.Drawing.Point(677, 117);
            this.rbtnCookie.Name = "rbtnCookie";
            this.rbtnCookie.Size = new System.Drawing.Size(85, 19);
            this.rbtnCookie.TabIndex = 5;
            this.rbtnCookie.TabStop = true;
            this.rbtnCookie.Text = "Lấy Cookie";
            this.rbtnCookie.UseVisualStyleBackColor = true;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Location = new System.Drawing.Point(665, 162);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(103, 77);
            this.btnXuLy.TabIndex = 6;
            this.btnXuLy.Text = "Xử Lý";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Navy;
            this.lblKetQua.Location = new System.Drawing.Point(12, 250);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(91, 24);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "Kết Quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(12, 284);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(622, 199);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.WordWrap = false;
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCopy.Location = new System.Drawing.Point(668, 310);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(102, 54);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(668, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 54);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCatChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(799, 504);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.rbtnCookie);
            this.Controls.Add(this.rbtnUserPass);
            this.Controls.Add(this.cbBoxDinhDang);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapAccount);
            this.Controls.Add(this.lblNhapAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(815, 543);
            this.Name = "frmCatChuoi";
            this.Text = "discord.gg/";
            this.Load += new System.EventHandler(this.frmCatChuoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapAccount;
        private System.Windows.Forms.TextBox txtNhapAccount;
        private System.Windows.Forms.ComboBox cbBoxDinhDang;
        private System.Windows.Forms.RadioButton rbtnUserPass;
        private System.Windows.Forms.RadioButton rbtnCookie;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnThoat;
    }
}

