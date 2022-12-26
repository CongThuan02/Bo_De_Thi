using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myImageList.Images.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = myImageList.Images[i];
                pic.Size = new Size(50, 50);
                pic.Click += new EventHandler(Form1_Click);
                myFlowLayoutPanel.Controls.Add(pic);
            }  
        
        }
        private void Form1_Click(object sender, EventArgs e)
        {
           try
            {
                PictureBox pic = (PictureBox)sender;
                myPictureBox.Image = pic.Image;
            }
            catch (Exception) { }
        }
    }
}
