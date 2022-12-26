using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai2_29._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienthi.Checked == true)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "123456";
            if (user.Equals(txtTen.Text) && pass.Equals(txtMatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
                MessageBox.Show("Không đăng nhập thành công");
        }
    }
}
