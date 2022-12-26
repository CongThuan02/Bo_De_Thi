using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                lvi.SubItems[0].Text = txtTenNV.Text;
                lvi.SubItems[1].Text = txtChucVuNV.Text;
                lvi.SubItems[2].Text = txtHeSoLuongNV.Text;
                lvi.SubItems[3].Text = txtLuongCBNV.Text;
            }    
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtLuongCBNV.Text != "" && txtTenNV.Text != "" && txtHeSoLuongNV.Text != "" && txtChucVuNV.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(txtTenNV.Text);
                ListViewItem.ListViewSubItem LVSItemCV = newListViewItem.ListViewSubItem(LVItem, txtChucVuNV.Text);
                ListViewItem.ListViewSubItem LVSItemHSL = newListViewItem.ListViewSubItem(LVItem, txtHeSoLuongNV.Text);
                LVItem.SubItems.Add(LVSItemCV);
                LVItem.SubItems.Add(LVSItemHSL);
                LVItem.SubItems.Add(LVSItemLCB);
                listNhanVien.Items.Add(LVItem);
                txtLuongCBNV.Text = "";
                txtTenNV.Text = "";
                txtHeSoLuongNV.Text = "";
                txtChucVuNV.Text = "";
            }   
            else
                MessageBox.Show("Phải nhập đầy đủ thông tin nhân viên");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (listNhanVien.SelectedIndices.Count > 0)
            {
                listNhanVien.Items.RemoveAt(listNhanVien.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn nhân viên muốn");
        }
        private void listNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                txtTenNV.Text = lvi.SubItems[0].Text;
                txtChucVuNV.Text = lvi.SubItems[1].Text;
                txtHeSoLuongNV.Text = lvi.SubItems[2].Text;
                txtLuongCBNV.Text = lvi.SubItems[3].Text;
            }   
        }
    }
}
