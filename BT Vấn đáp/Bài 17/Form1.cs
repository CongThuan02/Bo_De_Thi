using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int a = 0;
        private int b = 0;
        private float x = 0;
        Random rd = new Random();
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            float kq = float.Parse(txtX.Text);
            if (Math.Abs(kq - x) < 0.01)
            {
                MessageBox.Show("Bạn đã làm đúng");
                Close();
            }
            else
                MessageBox.Show("Bạn đã trả lời sai");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = rd.Next(-10, 10);
            txtA.Text = a.ToString();
            b = rd.Next(-10, 10);
            txtB.Text = b.ToString();
            x = -b / (float)a;
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            if (ProGressTG.Value == 30000)
            {
                ThoiGian.Enabled = false;
                MessageBox.Show("Hết thời gian làm bài");
            }
            ProGressTG.PerformStep();
        }
    }
}
