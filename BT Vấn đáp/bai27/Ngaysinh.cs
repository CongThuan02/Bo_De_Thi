using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace bai27
{
    public partial class Ngaysinh : Form
    {
        public Ngaysinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length == 0) {
                MessageBox.Show("vui long nhập!");
            }
            string[] elements = textBox2.Text.Split('/');
            string year = string.Format("{0}", elements[2]);
            string month = string.Format("{0}", elements[1]);
            string day = string.Format("{0}", elements[0]);
            int tuoi = DateTime.Now.Year - Convert.ToInt32(year);


            //int a =  Convert.ToInt32(year);
           // int a1 = Convert.ToInt32(month);
           // int a2 = Convert.ToInt32(month);
           // DateTime date = new DateTime(a, a1, a2);
    

          

            string s = "";
            if(rBNam.Checked == true)
            {
                s = "Anh";
            }
            if (radioButton2.Checked == true)
            {
                s = "Chị";
            }
            string kq = textBox1.Text + ", "+ s +tuoi + " tuổi";
             MessageBox.Show(kq);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
