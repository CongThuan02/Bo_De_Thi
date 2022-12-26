using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBongChayTrenform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        int w, h, dx, dy,x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            x += dx; 
            y = y + dy;
            if ((x+50 +dx) > this.Width|| (x + 50 + dx)<0)
            {
                dx=- dx;
               
            }
            if ((y+50+dy) > this.Height|| (y + 50 + dy)<0)
            {
                dy =- dy;
            }
            x = x + dx; y= y + dy;
            g.FillEllipse(Brushes.Red, x, y, 50, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            w = this.Width;
            h = this.Height;
            x = h / 2;
            y = h / 2;
            dx = 10;
            dy = 10;
            g.FillEllipse(Brushes.Red, new Rectangle(10, 20, 50, 50));
            g.Clear(this.BackColor);
        }

    }
}
