using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bò kho");
            listBox1.Items.Add("Phở bò");
            listBox1.Items.Add("Phở gà");
            listBox1.Items.Add("Bún măng");
            listBox1.Items.Add("Bún bò");
            listBox1.Items.Add("Bún riêu");
            listBox1.Items.Add("Mì xào thập cẩm");
            listBox1.Items.Add("Mì xào bò");
            listBox1.Items.Add("Mì xào chay");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
             
                listBox2.Items.Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            int n = listBox1.Items.Count;
            for (i = 0; i < n;i++)
            {
                listBox1.SelectedIndex = i;
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        { int i;
            int n = listBox2.Items.Count;
            string sr;
            for (i = 0; i < n; i++)
            {
                listBox2.SelectedIndex = i;
                MessageBox.Show(listBox2.SelectedItem.ToString());  
              
            }
          


        }
    }
}
