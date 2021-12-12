using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int red = 0, green = 0, blue = 0, kalem = 0, sx = 0, sy = 0, fx = 0, fy = 0;

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Pen ciz = new Pen(Color.Red, 3);
            SolidBrush firca = new SolidBrush(Color.Green);
            e.Graphics.DrawRectangle(ciz,new Rectangle(10,10,40,40));
            e.Graphics.DrawEllipse(ciz, new Rectangle(10, 50, 60, 100));
            e.Graphics.DrawEllipse(ciz, new Rectangle(100, 100, 50, 50));

            e.Graphics.FillRectangle(firca, new Rectangle(200, 50, 100, 60));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    red = 255;
                    green = 0;
                    blue = 0;
                        break;
                case 1:
                    red = 3;
                    green = 107;
                    blue = 252;
                    break;
                case 2:
                    red = 3;
                    green = 252;
                    blue = 7;
                    break;
                case 3:
                    red = 252;
                    green = 252;
                    blue = 3;
                    break;
                case 4:
                    red = 0;
                    green = 0;
                    blue = 0;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
     
            Pen pen1 = new Pen(Color.FromArgb(red,green,blue),kalem);
            e.Graphics.DrawLine(pen1, new Point(sx, sy),new Point(fx,fy));
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kalem = Convert.ToInt32(numericUpDown1.Value);
            sx = Convert.ToInt32(numericUpDown2.Value);
            sy = Convert.ToInt32(numericUpDown3.Value);
            fx = Convert.ToInt32(numericUpDown4.Value);
            fy = Convert.ToInt32(numericUpDown5.Value);
            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
