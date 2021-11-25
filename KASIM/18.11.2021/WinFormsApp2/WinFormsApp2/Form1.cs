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
        string[,] dizi = new string[81, 100];
        int ilsayisi=0;
        public Form1()
        {
            InitializeComponent();
            fonksiyon1();
        }

        private void fonksiyon1()
        {

            textBox1.PlaceholderText = "Adınızı Girin";
            textBox2.PasswordChar = '*';
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı Adı=" + textBox1.Text + "\n Şifre=" + textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //il Ekleme
            if (textBox3.Text == null || textBox3.Text == "")
            {
                MessageBox.Show("Girilen Değer Boş Olamaz Lütfen Giriş Yapın");
            }
            else if(listBox1.SelectedIndex == -1)
            {
                if (dizi.GetLength(0) > 81)
                {
                    MessageBox.Show("Maksimum İl Adetine Ulaştı Giriş Yapamazsınız");
                }
                else
                {
                    dizi[ilsayisi, 0] = textBox3.Text;
                    ilsayisi++;
                }

                
            }
            //il Ekleme Sonu
            //İlçe Ekleme
            else if(listBox1.SelectedIndex != -1)
            {
                int ilindeksi = listBox1.SelectedIndex;
                int mevcutilcesayisi = 0;
                int sayi=dizi.GetLength(1);

                if (dizi.GetLength(1) > 100)
                {
                    MessageBox.Show("Maksimum İlçe Adetine Ulaştı Giriş Yapamazsınız");
                }

                else
                {
                    for (int i = 0; i < sayi; i++)
                    {
                        if (dizi[listBox1.SelectedIndex, i] != null && dizi[listBox1.SelectedIndex, i] != "")
                        {
                            mevcutilcesayisi++;
                        }
                    }

                    dizi[ilindeksi, mevcutilcesayisi + 1] = textBox3.Text;
                }
               
            }
            //İlçe Ekleme Sonu
            //İl Gösterme
            listBox1.Items.Clear();
            for(int i = 0; i < ilsayisi; i++)
            {
                
                listBox1.Items.Add(dizi[i,0]);
            }
            //İl Gösterme Sonu


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //İlçe Gösterme
            int seciliindex;
            int sayi = dizi.GetLength(1);           
            seciliindex = listBox1.SelectedIndex;
            listBox2.Items.Clear();
            for(int i = 1; i < sayi; i++)
            {
                if(dizi[seciliindex,i]!=null&& dizi[seciliindex, i] != "")
                {
                    listBox2.Items.Add(dizi[seciliindex, i]);
                }
            }
            //İlçe Gösterme

        }
    }
}
