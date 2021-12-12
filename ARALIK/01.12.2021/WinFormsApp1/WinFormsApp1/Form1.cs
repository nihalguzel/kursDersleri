using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[,] urunler = new string[5, 4];
        int urunadeti = 0;
        Thread guncelle;
        int urunindexi;
        int urunindexi2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            guncelle = new Thread(new ThreadStart(urunlergetir));
            guncelle.Start();
           
        }
        public void urunlergetir()
        {
            while (true) {
                urunlerLabel.Text = "";
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            for(int i = 0; i < 5; i++)
            {
                if (urunler[i, 0] != null) {
                    urunlerLabel.Text += urunler[i, 0]+"-"+urunler[i,1]+"-"+urunler[i,2]+"-"+urunler[i,3]+"\n";
                    listBox1.Items.Add(urunler[i, 0] + "-" + urunler[i, 1] + "-" + urunler[i, 2] + "-" + urunler[i, 3]);
                    listBox2.Items.Add(urunler[i, 0] + "-" + urunler[i, 1] + "-" + urunler[i, 2] + "-" + urunler[i, 3]);

                    }

            }
                Thread.Sleep(2000);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                    urunler[urunadeti, 0] = textBox1.Text;
                    urunler[urunadeti, 1] = textBox2.Text;
                    urunler[urunadeti, 2] = textBox3.Text;
                    urunler[urunadeti, 3] = comboBox1.SelectedItem.ToString();
                    urunadeti++;

                    urunlerLabel.Text = "";
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunindexi = listBox1.SelectedIndex;
            textBox6.Text = urunler[urunindexi, 0];
            textBox5.Text = urunler[urunindexi, 1];
            textBox4.Text = urunler[urunindexi, 2];
            if(urunler[urunindexi,3]=="Stokta Var")
            {
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                comboBox2.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunler[urunindexi, 0] = textBox6.Text;
            urunler[urunindexi, 1] = textBox5.Text;
            urunler[urunindexi, 2] = textBox4.Text;
            urunler[urunindexi, 3] = comboBox2.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunindexi2 = listBox2.SelectedIndex;
            label10.Text = "Ürün Adı:" + urunler[urunindexi2, 0] + "\n" + "Adet:" + urunler[urunindexi2, 1] + "\n" + "Fiyat:" + urunler[urunindexi2, 2] + "\n" + "Durum:" + urunler[urunindexi2, 3] + "\n";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunler[urunindexi2, 0] = "";
            urunler[urunindexi2, 1] = "";
            urunler[urunindexi2, 2] = "";
            urunler[urunindexi2, 3] = "";
            
            for (int i = urunindexi2; i < urunler.GetLength(1); i++)
            {
                urunler[i, 0] = urunler[i + 1, 0];
                urunler[i, 1] = urunler[i + 1, 1];
                urunler[i, 2] = urunler[i + 1, 2];
                urunler[i, 3] = urunler[i + 1, 3];
            }
            urunler[urunadeti-1, 0] = "-";
            urunler[urunadeti-1, 1] = "-";
            urunler[urunadeti-1, 2] = "-";
            urunler[urunadeti-1, 3] = "-";
            urunadeti += -1;
        }
    }
}
