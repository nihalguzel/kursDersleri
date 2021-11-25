using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boykiloendeksi
{
    public partial class Form1 : Form
    {
        Hashtable sonuclar = new Hashtable();
        string cinsiyet,adsoyad = "";
        double boy, kilo;
        double sonuc = 0;
        double endeks = 0;
        string durum = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            foreach (Control rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (((RadioButton)rb).Checked)
                {
                 cinsiyet = rb.Text;
                }
                
            }

            adsoyad = textBox1.Text;
            boy = Convert.ToDouble(textBox2.Text);
            kilo = Convert.ToDouble(textBox3.Text);

            if (cinsiyet == "Kadın")
            {
                endeks=kadinendeks(boy, kilo);
                listeyeekle(adsoyad, endeks);
            }
            if (cinsiyet == "Erkek")
            {
                endeks = erkekendeks(boy, kilo);
                listeyeekle(adsoyad, endeks);
            }
        }

        public double kadinendeks(double boy,double kilo)
        {
            sonuc = (kilo / (boy * boy) * 0.9)*10000;
            return sonuc;
        }
        public double erkekendeks(double boy, double kilo)
        {
            sonuc = (kilo / (boy * boy) * 0.9)*10000;
        
            return sonuc;
        }

        public void listeyeekle(string adsoyad,double endeks)
        {
            listBox1.Items.Clear();
            if (endeks < 18.5)
            {
                durum = "Zayif";
            }
            else if (endeks > 18.5 && endeks <= 24.9)
            {
                durum = "Normal";
            }
            else if (endeks > 25.0 && endeks <= 29.9)
            {
                durum = "Kilolu";
            }
            else
            {
                durum = "Obez";
            }


            sonuclar.Add(endeks,adsoyad+"-"+durum);
           
            foreach(DictionaryEntry sonuc in sonuclar)
            {
                listBox1.Items.Add((sonuc.Value +"-" +sonuc.Key).ToString());
            }
        }
    }
}
