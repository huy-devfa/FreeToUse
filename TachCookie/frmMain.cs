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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lbldiscord_Click(object sender, EventArgs e)
        {

        }

        private void btnCatChuoi_Click(object sender, EventArgs e)
        {
            Form Catchuoi = new frmCatChuoi();
            Catchuoi.Show();
        }
    }
}
