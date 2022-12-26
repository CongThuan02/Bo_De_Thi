﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myWebsite.Navigate("www.google.com");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLink.Text);
            listLinkWebsite.Items.Add(lvi);
            txtLink.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            listLinkWebsite.FocusedItem.Text = txtLink.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = listLinkWebsite.FocusedItem.Index;
            listLinkWebsite.Items.RemoveAt(i);
            txtLink.Text = "";
            myWebsite.Navigate("www.google.com");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
