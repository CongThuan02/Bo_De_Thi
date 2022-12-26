using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.Items.Clear();
            else
                MessageBox.Show("Danh sách chưa có dòng nào!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThemDong.Text.Trim() != "")
            {
                listBox1.Items.Add(txtThemDong.Text);
                txtThemDong.Text = "";
            }
            else
                MessageBox.Show("Nhập tên dòng cần nhập!");
        }
    }
}
