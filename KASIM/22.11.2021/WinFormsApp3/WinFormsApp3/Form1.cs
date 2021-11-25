using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        bool durum = false;
        int[] atlar = new int[4];
        double[] randomdegerler = new double[4];
        bool[] durumlar = new bool[4];
        string[] isimler = new string[4];
        Random rastgele = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            if (i == 100)
            {
                timer1.Stop();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < durumlar.Length; i++)
            {
                durumlar[i] = false;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            label2.Text = j.ToString();
            if (j == 200)
            {
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (durum == false)
            {
                i = 0;
                j = 0;
                timer1.Start();
                timer2.Start();
                button1.Text = "Durdur";
            }
            else
            {
                button1.Text = "Başlat";
                timer1.Stop();
                timer2.Stop();
            }

            durum = !durum;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (durum == false)
            {
                timer3.Start();
                button2.Text = "Durdur";
            }
            else
            {
                timer3.Stop();
                button2.Text = "Başlat";
            }

            durum = !durum;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label2.Text);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            i++;
            label2.Text = i.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1) { 
            label3.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            for (i = 0; i < randomdegerler.Length; i++)
            {
                randomdegerler[i] = Math.Round((rastgele.NextDouble() * 2)) + 1;
            }

            for (i = 0; i < atlar.Length; i++)
            {
                atlar[i] += Convert.ToInt32(randomdegerler[i]);
            }

            for (i = 0; i < atlar.Length; i++)
            {
                if (atlar[i] >= 100)
                {
                    atlar[i] = 100;
                    if (durumlar[i] == false)
                    {
                        listBox2.Items.Add(isimler[i]);
                        durumlar[i] = !durumlar[i];
                    }


                }
            }




            if (atlar[0] == 100 && atlar[1] == 100 && atlar[2] == 100 && atlar[3] == 100)
            {
                timer4.Stop();
            }

            progressBar1.Value = atlar[0];
            progressBar2.Value = atlar[1];
            progressBar3.Value = atlar[2];
            progressBar4.Value = atlar[3];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            isimler[0] = textBox1.Text;
            isimler[1] = textBox2.Text;
            isimler[2] = textBox3.Text;
            isimler[3] = textBox4.Text;
            timer4.Start();

        }
    }
}
