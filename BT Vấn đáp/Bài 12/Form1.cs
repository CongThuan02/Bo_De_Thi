using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        int n;
        private string ketqua;

        public static bool SNT(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtIn.Text);
            n = Convert.ToInt32(txtOut.Text);
            string ketqua = "";
        }
    }
}
