using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "x=" + e.X.ToString() + ",y="+e.Y.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics cizgi;
            Pen kalem = new Pen(Color.Red, 3);
            Point nokta1 = new Point(x, y);
            Point nokta2 = new Point(e.X, e.Y);

            cizgi = pictureBox1.CreateGraphics();
            cizgi.DrawLine(kalem, nokta1, nokta2);

            cizgi.Dispose();
        }
    }
}
