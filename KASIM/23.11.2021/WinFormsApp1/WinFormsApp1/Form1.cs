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
        int zar1=0;
        int zar2=0;
        int toplamzar = 0;
        int puan1,puan2=0;
        int tahmin1, tahmin2,t1,t2=0;
        int i = 0;
        Random rastgele = new Random();


        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            timer1.Interval = 50 * i;
            if (i != 10)
            {
                zar1 = Convert.ToInt32((rastgele.NextDouble() * 5)) + 1;
                zar2 = Convert.ToInt32((rastgele.NextDouble() * 5)) + 1;
                zar1Lbl.Text = zar1.ToString();
                zar2Lbl.Text = zar2.ToString();
            }
            if( i>=10 )
            {
                timer1.Stop();
                i = 0;
                zar1Lbl.Text = zar1.ToString();
                zar2Lbl.Text = zar2.ToString();
                puanlama();
                
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void puanlama()
        {
            toplamzar = zar1 + zar2;
            t1 = Math.Abs(toplamzar - tahmin1);
            t2 = Math.Abs(toplamzar - tahmin2);

            if (t1 == 0)
            {
                puan1 += 10;
                label8.Text = puan1.ToString();

            }
            if (t2 == 0)
            {
                puan2 += 10;
                label9.Text = puan2.ToString();
            }
            if (t1 == t2)
            {
                puan1 += 5;
                puan2 += 5;
                label8.Text = puan1.ToString();
                label9.Text = puan2.ToString();
            }
            if (t1 < t2)
            {
                puan1 += 5;
                label8.Text = puan1.ToString();
            }
            if (t2 < t1)
            {
                puan2 += 5;
                label9.Text = puan2.ToString();
            }

            if (puan1 >= 100)
            {
                kazananLbl.Text = isim1;
            }
            if (puan2 >= 100)
            {
                kazananLbl.Text = isim2;
            }
        }

        string isim1,isim2;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            isim1 = oyuncu1Txt.Text;
            isim2 = oyuncu2Txt.Text;
            timer1.Start();
            tahmin1 = Convert.ToInt32(textBox3.Text);
            tahmin2 = Convert.ToInt32(textBox4.Text);
           


        }
    }
}
