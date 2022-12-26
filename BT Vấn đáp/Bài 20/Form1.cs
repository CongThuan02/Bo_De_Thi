using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemGoc_Click(object sender, EventArgs e)
        {
            TV_Test.Nodes.Add(txtTieuDe.Text);
            txtTieuDe.Text = "";
        }

        private void btnThemCon_Click(object sender, EventArgs e)
        {
            TV_Test.SelectedNode.Nodes.Add(txtTieuDe.Text);
            txtTieuDe.Text = "";
            TV_Test.ExpandAll();
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            TV_Test.Nodes.Clear();
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            TV_Test.SelectedNode.Remove();
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            TV_Test.ExpandAll();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            TV_Test.CollapseAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
