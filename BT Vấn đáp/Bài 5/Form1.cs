using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtN.Text);
            double s = 0;
            if(rS1.Checked ==true)
            {
                for(int i = 1; i <= N; i++) { 
                    s= s+(2*i-1);
                }
            }
            if(rS2.Checked ==true)
            {
                for (int i = 1; i <= N; i++)
                {
                    s = (int)(s + (Math.Pow(i, 2)));

                }
            }
           if(rS3.Checked==true)
            {
                for (int i = 1; i <= N; i++)
                {
                    s = s * 1.0 + ((1.0 / i) );
                }
            }
            if (rS4.Checked == true)
            {
                for(int i=1; i <= N; i++)
                {
                    int mau = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        mau = mau * j;
                    }
                    s = s + 1.0 / mau;
                }
            }
            txtKetQua.Text = s.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtKetQua.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rS1.Checked= true;
        }
    }
}
