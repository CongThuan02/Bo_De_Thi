using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "" && txtTenLop.Text != "")
            {
                ListViewItem LVItem = new
                ListViewItem(txtSoLuong.Text);
                ListViewItem.ListViewSubItem LVSItem = new
                ListViewItem.ListViewSubItem(LVItem, txtSoLuong.Text);
                LVItem.SubItems.Add(LVSItem);
                myListView.Items.Add(LVItem);
                txtSoLuong.Text = "";
                txtTenLop.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myListView.Columns.Add("Tên lớp", 160);
            myListView.Columns.Add("Số lượng sinh viên", 180);
        }
    }
}
