using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            //Khai báo biến 
            int soluong;
            decimal dongia, thanhtien;

            //Kiểm tra giá trị rỗng 
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng hàng");
                txtSoluong.Focus();
            }
            else if (txtDongia.Text == "")
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtDongia.Focus();
            }
            else
            {
                soluong = int.Parse(txtSoluong.Text);
                dongia = decimal.Parse(txtDongia.Text);
                //Kiểm tra dữ liệu hợp lệ
                if (soluong <= 0)
                {
                    MessageBox.Show("Số lượng hàng phải lớn hơn 0");
                    txtSoluong.SelectAll();
                    txtSoluong.Focus();
                }
                else if (dongia <= 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 0");
                    txtDongia.SelectAll();
                    txtDongia.Focus();
                }
                else
                {
                    thanhtien = soluong * dongia;
                    txtThanhtien.Text = thanhtien.ToString();
                }
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenhang.Clear();
            txtSoluong.Clear();
            txtDongia.Clear();
            txtThanhtien.Clear();
            txtTenhang.Focus();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            DialogResult dt;
            dt = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
                Close();
        }
    }
}
