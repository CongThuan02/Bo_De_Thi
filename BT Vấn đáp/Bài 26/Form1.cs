using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_26
{
    public partial class Form1 : Form
    {
        float Tu1, Tu2, Mau1, Mau2, Tu, Mau, USC;

        private void btnTru_Click(object sender, EventArgs e)
        {
            this.groupBoxPhepTinh.Text = "Kết quả trừ";
            Tu = (Tu1 * Mau2) - (Tu2 * Mau1);
            Mau = Mau1 * Mau2;
            USC = USCLN(Tu, Mau);
            txtTu.Text = Convert.ToString(Tu / USC);
            txtMau.Text =Convert.ToString(Mau / USC);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            this.groupBoxKetQua.Text = "Kết quả nhân";
            Tu = (Tu1 * Tu2);
            Mau = Mau1 * Mau2;
            USC = USCLN(Tu, Mau);
            txtTu.Text = Convert.ToString(Tu / USC);
            txtMau.Text = Convert.ToString(Mau / USC);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            this.groupBoxKetQua.Text = "Kết quả chia";
            Tu = (Tu1 * Mau2);
            Mau = Mau1 * Tu2;
            USC = USCLN(Tu, Mau);
            txtTu.Text = Convert.ToString(Tu / USC);
            txtMau.Text = Convert.ToString(Mau / USC);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            this.groupBoxKetQua.Text = "Kết quả cộng";
            Tu = (Tu1 * Mau2) + (Tu2 * Mau1);
            Mau = Mau1 * Mau2;
            USC = USCLN(Tu, Mau);
            txtTu.Text = Convert.ToString(Tu / USC);
            txtMau.Text = Convert.ToString(Mau / USC);
        }

        private void groupBoxPhepTinh_Enter(object sender, EventArgs e)
        {
            Tu1 = float.Parse(txtTu1.Text);
            Tu2 = float.Parse(txtTu2.Text);
            Mau1 = float.Parse(txtMau1.Text);
            Mau2 = float.Parse(txtMau2.Text);
        }
        public static float USCLN(float a, float b)
        {
            if (b == 0)
                return a;
            else
                return USCLN(b, a % b);
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTu1.ResetText();
            txtTu2.ResetText();
            txtMau1.ResetText();
            txtMau2.ResetText();
            txtMau.ResetText();
            txtTu.ResetText();
            groupBoxKetQua.Text = "Kết quả";
            Tu = 0; Tu1 = 0; Tu2 = 0;
            Mau = 0 ; Mau1 = 0; Mau2 = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
