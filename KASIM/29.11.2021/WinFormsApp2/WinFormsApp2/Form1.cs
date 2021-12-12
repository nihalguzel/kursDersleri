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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pictureBox1.Image = Image.FromFile(@"C:\Users\burak\Desktop\1.jpg");
            pictureBox1.Image = Properties.Resources._1;//Resource Dan Resim Alma Kullanımı
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\burak\Desktop\"+((listBox1.SelectedIndex + 1).ToString())+".jpg");
        }
    }
}
