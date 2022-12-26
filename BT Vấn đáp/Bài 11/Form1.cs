using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_11
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            txtA.ResetText();
            txtB.ResetText();
            txtBS.ResetText();
            txtUS.ResetText();
        }
        public static int USCLN(int a, int b)
        {
            if (a==0 || b == 0)
                return a + b;
            while (a != b)
                if (a > b)
                    a = a - b;
            else
                    b=b-a;
            return a;   
        }
        public static int BSCNN(int a,int b)
        {
            return (a*b) / USCLN(a,b);
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtBS.Text = USCLN(a, b).ToString();
            txtUS.Text = BSCNN(a, b).ToString();
        }
    }
}
