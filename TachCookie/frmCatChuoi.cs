using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TachCookie
{
    public partial class frmCatChuoi : Form
    {
        public frmCatChuoi()
        {
            InitializeComponent();
        }

        private void frmCatChuoi_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (txtNhapAccount.Text.Equals(string.Empty))
            {
                MessageBox.Show("Không được để trống, vui lòng nhập account theo đúng định dạng đã chọn!", "Thông báo!");
            }
            else
            {
                if (txtNhapAccount.Lines.Length <= 1)
                {
                    //xu ly lay cookie 1 dong
                    if (cbBoxDinhDang.SelectedIndex == 1 && rbtnCookie.Checked == true)
                    {
                        bool Dau2Chamdautien = false;
                        for (int i = 0; i < txtNhapAccount.TextLength; i++)
                        {
                            if (txtNhapAccount.Text[i].ToString() == ":")
                            {
                                if (!Dau2Chamdautien)
                                {
                                    Dau2Chamdautien = true;
                                }
                                else
                                {
                                    int cc = i + 1;
                                    txtKetQua.Text = txtNhapAccount.Text.Substring(cc);
                                    break;
                                }
                            }
                        }
                        int sodong = txtKetQua.Lines.Length;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 2 && rbtnCookie.Checked == true)
                    {
                        bool daugachcheodautien = false;
                        for (int i = 0; i < txtNhapAccount.TextLength; i++)
                        {
                            if (txtNhapAccount.Text[i].ToString() == "/")
                            {
                                if (!daugachcheodautien)
                                {
                                    daugachcheodautien = true;
                                }
                                else
                                {
                                    txtKetQua.Text = txtNhapAccount.Text.Substring(i + 1);
                                    break;
                                }
                            }
                        }
                        int sodong = txtKetQua.Lines.Length;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 3 && rbtnCookie.Checked == true)
                    {
                        bool daudanhdocdautien = false;
                        for (int i = 0; i < txtNhapAccount.TextLength; i++)
                        {
                            if (txtNhapAccount.Text[i].ToString() == "|")
                            {
                                if (!daudanhdocdautien)
                                {
                                    daudanhdocdautien = true;
                                }
                                else
                                {
                                    txtKetQua.Text = txtNhapAccount.Text.Substring(i + 1);
                                    break;
                                }
                            }
                        }
                        int sodong = txtKetQua.Lines.Length;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    //xu ly lay user:pass
                    else if (cbBoxDinhDang.SelectedIndex == 1 && rbtnUserPass.Checked == true)
                    {
                        bool dau2chamdautien = false;
                        int sokitu = 0;
                        for (int i = 0; i < txtNhapAccount.TextLength; i++)
                        {
                            if (txtNhapAccount.Text[i].ToString() == ":")
                            {
                                if (!dau2chamdautien)
                                {
                                    dau2chamdautien = true;
                                }
                                else
                                {
                                    sokitu = i;
                                    break;
                                }
                            }
                        }
                        txtNhapAccount.Select(0, sokitu);
                        txtKetQua.Text = txtNhapAccount.SelectedText;
                        int sodong = txtKetQua.Lines.Length;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 2 && rbtnUserPass.Checked == true)
                    {
                        bool daugachcheodautien = false;
                        int sokitu = 0;
                        for (int i = 0; i < txtNhapAccount.TextLength; i++)
                        {
                            if (txtNhapAccount.Text[i].ToString() == "/")
                            {
                                if (!daugachcheodautien)
                                {
                                    daugachcheodautien = true;
                                }
                                else
                                {
                                    sokitu = i;
                                    break;
                                }
                            }
                        }
                        txtNhapAccount.Select(0, sokitu);
                        txtKetQua.Text = txtNhapAccount.SelectedText;
                        int sodong = txtKetQua.Lines.Length;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 3 && rbtnUserPass.Checked == true)
                    {
                        bool daugachcheodautien = false;
                        int sokitu = 0;
                        for (int i = 0; i < txtNhapAccount.TextLength; i++)
                        {
                            if (txtNhapAccount.Text[i].ToString() == "|")
                            {
                                if (!daugachcheodautien)
                                {
                                    daugachcheodautien = true;
                                }
                                else
                                {
                                    sokitu = i;
                                    break;
                                }
                            }
                        }
                        txtNhapAccount.Select(0, sokitu);
                        txtKetQua.Text = txtNhapAccount.SelectedText;
                        int sodong = txtKetQua.Lines.Length;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                }
                //xu ly lay cookie nhieu dong
                else if (txtNhapAccount.Lines.Length > 1)
                {
                    if (cbBoxDinhDang.SelectedIndex == 1 && rbtnCookie.Checked == true)
                    {
                        string ketqua = "";
                        bool dau2chamdautien2 = false;
                        for (int j = 0; j < txtNhapAccount.Lines.Length; j++)
                        {
                            string dong = txtNhapAccount.Lines[j];

                            for (int i = 0; i < dong.Length; i++)
                            {
                                if (txtNhapAccount.Text[i].ToString() == ":")
                                {
                                    if (!dau2chamdautien2)
                                    {
                                        dau2chamdautien2 = true;

                                    }
                                    else
                                    {
                                        ketqua += dong.Substring(i + 1) + "\r\n";
                                        break;
                                    }
                                }
                            }
                            dau2chamdautien2 = false;
                        }

                        txtKetQua.Text = ketqua;
                        int sodong = txtKetQua.Lines.Length - 1;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 2 && rbtnCookie.Checked == true)
                    {
                        string ketqua = "";
                        bool daugachcheodautien2 = false;
                        for (int i = 0; i < txtNhapAccount.Lines.Length; i++)
                        {
                            for (int j = 0; j < txtNhapAccount.Lines[i].Length; j++)
                            {
                                if (txtNhapAccount.Text[j].ToString() == "/")
                                {
                                    if (!daugachcheodautien2)
                                    {
                                        daugachcheodautien2 = true;
                                    }
                                    else
                                    {
                                        ketqua += txtNhapAccount.Lines[i].Substring(j + 1) + "\r\n";
                                        break;
                                    }
                                }
                            }
                            daugachcheodautien2 = false;
                            txtKetQua.Text = ketqua;
                            int sodong = txtKetQua.Lines.Length - 1;
                            string sodongchu = sodong.ToString() + " Account";
                            lblKetQua.Text = "kết quả: " + sodongchu;
                        }
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 3 && rbtnCookie.Checked == true)
                    {
                        bool daudanhdocdautien2 = false;
                        string ketqua = "";
                        for (int i = 0; i < txtNhapAccount.Lines.Length; i++)
                        {
                            for (int j = 0; j < txtNhapAccount.Lines[i].Length; j++)
                            {
                                if (txtNhapAccount.Text[j].ToString() == "|")
                                {
                                    if (!daudanhdocdautien2)
                                    {
                                        daudanhdocdautien2 = true;
                                    }
                                    else
                                    {
                                        ketqua += txtNhapAccount.Lines[i].Substring(j + 1) + "\r\n";
                                        break;
                                    }
                                }
                            }
                            daudanhdocdautien2 = false;
                            txtKetQua.Text = ketqua;
                            int sodong = txtKetQua.Lines.Length - 1;
                            string sodongchu = sodong.ToString() + " Account";
                            lblKetQua.Text = "kết quả: " + sodongchu;
                        }
                    }
                    //xu ly lay user pass nhieu dong
                    else if (cbBoxDinhDang.SelectedIndex == 1 && rbtnUserPass.Checked == true)
                    {
                        bool dau2chamdautien = false;
                        int sokitu = 0;
                        string ketqua = "";
                        for (int i = 0; i < txtNhapAccount.Lines.Length; i++)
                        {
                            for (int j = 0; j < txtNhapAccount.Lines[i].Length; j++)
                            {
                                if (txtNhapAccount.Text[j].ToString() == ":")
                                {
                                    if (!dau2chamdautien)
                                    {
                                        dau2chamdautien = true;
                                    }
                                    else
                                    {
                                        sokitu = j;
                                        break;
                                    }
                                }
                            }
                            txtNhapAccount.Select(0, sokitu);
                            ketqua += txtNhapAccount.SelectedText + "\r\n";
                            dau2chamdautien = false;
                        }
                        txtKetQua.Text = ketqua;
                        int sodong = txtKetQua.Lines.Length - 1;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 2 && rbtnUserPass.Checked == true)
                    {
                        bool daugachcheodautien = false;
                        int sokitu = 0;
                        string ketqua = "";
                        for (int i = 0; i < txtNhapAccount.Lines.Length; i++)
                        {
                            for (int j = 0; j < txtNhapAccount.Lines[i].Length; j++)
                            {
                                if (txtNhapAccount.Text[j].ToString() == "/")
                                {
                                    if (!daugachcheodautien)
                                    {
                                        daugachcheodautien = true;
                                    }
                                    else
                                    {
                                        sokitu = j;
                                        break;
                                    }
                                }
                            }
                            txtNhapAccount.Select(0, sokitu);
                            ketqua += txtNhapAccount.SelectedText + "\r\n";
                            daugachcheodautien = false;
                        }
                        txtKetQua.Text = ketqua;
                        int sodong = txtKetQua.Lines.Length - 1;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                    else if (cbBoxDinhDang.SelectedIndex == 3 && rbtnUserPass.Checked == true)
                    {
                        bool daudanhdocdautien = false;
                        int sokitu = 0;
                        string ketqua = "";
                        for (int i = 0; i < txtNhapAccount.Lines.Length; i++)
                        {
                            for (int j = 0; j < txtNhapAccount.Lines[i].Length; j++)
                            {
                                if (txtNhapAccount.Text[j].ToString() == "|")
                                {
                                    if (!daudanhdocdautien)
                                    {
                                        daudanhdocdautien = true;
                                    }
                                    else
                                    {
                                        sokitu = j;
                                        break;
                                    }
                                }
                            }
                            txtNhapAccount.Select(0, sokitu);
                            ketqua += txtNhapAccount.SelectedText + "\r\n";
                            daudanhdocdautien = false;
                        }
                        txtKetQua.Text = ketqua;
                        int sodong = txtKetQua.Lines.Length - 1;
                        string sodongchu = sodong.ToString() + " Account";
                        lblKetQua.Text = "kết quả: " + sodongchu;
                    }
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtKetQua.Text.Equals(string.Empty))
            {
                MessageBox.Show("Kết quả trống, vui lòng xử lý trước khi copy!");
            }
            else
            {
                Clipboard.SetText(txtKetQua.Text);
                MessageBox.Show("Copy thành công!");
            }
        }
    }
}

