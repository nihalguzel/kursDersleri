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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Hashtable siniflar = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICollection degerler = siniflar.Values;
            ICollection anahtarlar = siniflar.Keys;
            foreach(string deger in degerler)
            {
                listBox1.Items.Add(deger);
            }
            foreach (string anahtar in anahtarlar)
            {
                listBox2.Items.Add(anahtar);
            }

            foreach(DictionaryEntry alldeger in siniflar)
            {
                string deger = alldeger.Key + ":" + alldeger.Value;
                listBox3.Items.Add(deger);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siniflar.Add("Burak", "PHP Web Yazılım");
            siniflar.Add("Nihal", "Aşçı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (siniflar.ContainsKey(textBox1.Text)==true)// Siniflar hashi textboxtaki değeri içeriyormu eğer içeriyorsa true değer döndürüyor
            {
                label2.Text = textBox1.Text + "Kişisi Bulundu";

            }
            else
            {
                label2.Text = textBox1.Text + "Kişisi Bulunamadı";
            }
        }
    }
}
