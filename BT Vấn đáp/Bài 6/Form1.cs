using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tong = 0;
            foreach (string s in listBox1.Items)
            {
                tong += double.Parse(s);
            }
            MessageBox.Show(" tong danh sach " + tong.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 2)
            {
                listBox1.Items.Remove(0);
            }
            else
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox1.Items[i] = (int.Parse(listBox1.Items[i].ToString() )+ 2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox1.Items[i] = int.Parse(listBox1.Items[i].ToString()) * int.Parse(listBox1.Items[i].ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (int.Parse(listBox1.Items[i].ToString()) % 2 == 0)
                    listBox1.SetSelected(i, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (int.Parse(listBox1.Items[i].ToString()) % 2 == 1)
                    listBox1.SetSelected(i, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
