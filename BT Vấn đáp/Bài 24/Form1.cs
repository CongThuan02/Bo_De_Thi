using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            if (rMauChu.Checked == true)
            {
                if(colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Color color = colorDialog1.Color;
                    lbText.ForeColor = color;
                }
            }
             if(rMauNen.Checked == true)
            {
                if(colorDialog1.ShowDialog()== DialogResult.OK)
                {
                    Color color = colorDialog1.Color;
                    paBackground.BackColor= color;
                }
            }
        }
    }
}
