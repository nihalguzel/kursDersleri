using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        double sayi1;
        string oprt;
        double sayi2;
        double sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            degerAl("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            degerAl("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            degerAl("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            degerAl("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            degerAl("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            degerAl("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            degerAl("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            degerAl("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            degerAl("9");
        
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            oprt = "/";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            oprt = "*";
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            oprt = "-";
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            oprt = "+";
        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            switch (oprt)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    textBox1.Text = sonuc.ToString();
                    sayi1 = sonuc;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    textBox1.Text = sonuc.ToString();
                    sayi1 = sonuc;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    textBox1.Text = sonuc.ToString();
                    sayi1 = sonuc;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    textBox1.Text = sonuc.ToString();
                    sayi1 = sonuc;
                    break;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            textBox1.Text = null;
            sonuc = 0;
            oprt = "";
            
            
        }
        
        public string degerAl(string sayi)
        {
            if (textBox1.Text == "0" && textBox1==null)
            {
                textBox1.Text = sayi;
            }

            else
            {
                textBox1.Text += sayi;
            }
            return sayi;
        }
       
    }
}
