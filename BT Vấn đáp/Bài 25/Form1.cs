using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog open;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoTapTin_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read= new StreamReader(open.FileName);
                txtSoanThao.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnLuTepTin_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName,txtSoanThao.Text);
            }
            else
            {
                MessageBox.Show("bạn chưa lưu nội dung");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
