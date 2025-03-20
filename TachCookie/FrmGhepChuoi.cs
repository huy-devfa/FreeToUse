using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TachCookie
{
    public partial class FrmGhepChuoi : Form
    {
        public FrmGhepChuoi()
        {
            InitializeComponent();
        }

        private void btnGhep_Click(object sender, EventArgs e)
        { 
            if(txtChuoi1.Lines.Length <= 1 && txtChuoi2.Lines.Length <= 1)
            {

                if (txtChuoi1.Text.Equals(string.Empty) || txtChuoi2.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Vui long nhap day du thong tin chuoi 1 - chuoi 2!");
                    if (!txtDaungancach.Text.Equals(string.Empty))
                    {
                        MessageBox.Show("Vui long nhap ki tu ngan cach : ");
                    }
                }
                else
                {
                    txtketqua.Text = txtChuoi1.Text + txtDaungancach.Text + txtChuoi2.Text;
                }
            }
            else if(txtChuoi1.Lines.Length > 1 && txtChuoi2.Lines.Length > 1)
            {
                string ketqua = "";
                for(int i = 0; i < txtChuoi1.Lines.Length; i++)
                {
                    string linechuoi1 = txtChuoi1.Lines[i];
                    string linechuoi2 = txtChuoi2.Lines[i];
                    ketqua += linechuoi1 + txtDaungancach.Text + linechuoi2 + "\r\n";
                }
                txtketqua.Text = ketqua;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtketqua.Text.Equals(string.Empty))
            {
                MessageBox.Show("Ket qua trong, copy that bai!");
            }
            else
            {
                Clipboard.SetText(txtketqua.Text);
                MessageBox.Show("Copy thanh cong!", "Thong bao");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
