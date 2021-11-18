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
        bool durum = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Merhaba Yazılım";
        }

        private void tikla_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistem Açıldı Hoşgeldiniz";
            label1.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistem Kapandı Bay Bay";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            durum = !durum;

            if (durum == true)
            {

                sstmlabel.Text = "Sistem Açıldı";
                sstmlabel.ForeColor = Color.Green;
                button2.Text = "Sistemi Kapat";
            }

            else
            {
                sstmlabel.Text = "Sistem Kapandı";
                sstmlabel.ForeColor = Color.Red;
                button2.Text = "Sistemi Aç";


            }
            
            
        }
    }
}
