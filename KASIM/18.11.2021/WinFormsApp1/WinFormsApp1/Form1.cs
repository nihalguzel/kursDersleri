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
        string[] isimler = new string[100];
        int sayi = 1;
        int indexsayisi = 0;
        string[,] ililce = new string[3,4];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            MessageBox.Show("Kişi Ekleme Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void kytBtn_Click(object sender, EventArgs e)
        {
            adLbl.Text = adTxt.Text;
            soyadLbl.Text = soyadTxt.Text;
            meslekLbl.Text = listBox2.SelectedItem.ToString();
            cinsiyetLbl.Text = comboBox2.SelectedItem.ToString();
            telLbl.Text = telTxt.Text;

            MessageBox.Show("Kayıt Başarılı");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Kadın")
            {
                this.BackColor = Color.Pink;
            }
            else if (comboBox2.SelectedItem == "Erkek")
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text != null)
            {
                comboBox3.Items.Add(textBox2.Text);
                isimler[sayi] = textBox2.Text;
                sayi++;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(string eleman in isimler)
            {
                if(eleman != null && eleman != "")
                {
                    listBox3.Items.Add(eleman);
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Kadıköy");
                listBox4.Items.Add("Eminönü");
                listBox4.Items.Add("Eyüp");
                listBox4.Items.Add("Ümraniye");
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Kızılay");
                listBox4.Items.Add("Çankaya");
                listBox4.Items.Add("Polatlı");
                listBox4.Items.Add("Etimesgut");
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("İlçe 1");
                listBox4.Items.Add("İlçe 2");
                listBox4.Items.Add("İlçe 3");
                listBox4.Items.Add("İlçe 4");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ilcesayisi = ililce.GetLength(1);
            int p=0;
            listBox4.Items.Clear();
            for(int k = 0; k < 4; k++)
            {
                if(ililce[comboBox4.SelectedIndex,k]!=null&& ililce[comboBox4.SelectedIndex, k] != "")
                {
                    p++ ;
                }
            }
           
            for (int j = 1; j <= p; j++)
            {
                if (ililce[comboBox4.SelectedIndex, j] != null)
                {
                    listBox4.Items.Add(ililce[comboBox4.SelectedIndex, j]);
                }

            }

            label14.Text = p + "tane eleman var";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ililce[0, 0] = "İSTANBUL";
            ililce[1, 0] = "ANKARA";
            ililce[2, 0] = "İZMİR";

            for(int i=0; i<3; i++)
            {
                comboBox4.Items.Add(ililce[i, 0]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ililce[comboBox4.SelectedIndex, indexsayisi] = textBox3.Text;
            listBox4.Items.Clear();
            label14.Text = comboBox4.SelectedIndex.ToString();
            for(int j = 0; j < ililce.GetLength(1) ; j++)
            {
                if(ililce[comboBox4.SelectedIndex,j] != null)
               {
                listBox4.Items.Add(ililce[comboBox4.SelectedIndex, j]);
                }
                
            }
            indexsayisi++;
            if (indexsayisi > 3)
            {
                indexsayisi = 0;
            }
        }
    }
}
