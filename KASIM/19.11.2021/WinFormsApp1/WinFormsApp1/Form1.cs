using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList isimler = new ArrayList();// arraylist tanımlama arraylist System.Collections kütüphanesinde bulunur. Kullanmak için kütüphaneyi eklemek gerekli.
        ArrayList kitaplar = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isimler.Add(textBox1.Text);//ArrayListe e eleman ekleme
            listedoldurma();

            
        }

        public void listedoldurma()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < isimler.Count; i++)
            {
                if (isimler[i] != null)
                {
                    listBox1.Items.Add(isimler[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isimler.Insert(Convert.ToInt32(textBox2.Text), textBox1.Text);//Array listte araya eleman ekleme. İndeks belirtilerek yapılır bu örnekte indexi textboxtan alıyoruz.
            listedoldurma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isimler[Convert.ToInt32(textBox2.Text)] = textBox1.Text; //belirtilen indexteki değer değiştirildi.
            
            listedoldurma();
        
        }

        private void yntekleBtn_Click(object sender, EventArgs e)
        {
            
            if(yntindxTxt.Text == "" || yntindxTxt.Text==null)
            {
                if (listBox2.SelectedIndex != -1)
                {
                    int index = listBox2.SelectedIndex;
                    kitaplar.Insert(index, yntadTxt.Text);
                }
                else
                {
                    kitaplar.Add(yntadTxt.Text);
                }
                
            }
            else if(yntindxTxt.Text!= null || yntindxTxt.Text!=""){

                int index = Convert.ToInt32(yntindxTxt.Text);
                kitaplar.Insert(index, yntadTxt.Text);

            }

            kitaplargetir();
        }

        public void kitaplargetir()
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            foreach(string kitap in kitaplar)
            {
                listBox2.Items.Add(kitap);
            }
          
            ArrayList kitaplarfixed = ArrayList.FixedSize(kitaplar);

            foreach(string kitap in kitaplarfixed)
            {
                listBox3.Items.Add(kitap);
            }

         
        }

        private void yntduzenleBtn_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex != -1 && yntindxTxt.Text!="")
            {
                MessageBox.Show("Aynı Anda Listeden Eleman Seçip İndex Giremezsiniz");
            }
            else if(listBox2.SelectedIndex != -1)
            {
                int index = listBox2.SelectedIndex;
                kitaplar[index] = yntadTxt.Text;
            }
            else if (yntindxTxt.Text != "" || yntindxTxt != null)
            {
                int index = Convert.ToInt32(yntindxTxt.Text);
                kitaplar[index] = yntadTxt.Text;
            }

            kitaplargetir();

        }

        private void usrduzenleBtn_Click(object sender, EventArgs e)
        {
            ArrayList kitaplarfixed = ArrayList.FixedSize(kitaplar);

            if (listBox3.SelectedIndex!= -1 && userındxTxt.Text != "")
            {
                MessageBox.Show("Aynı Anda Listeden Seçim Yaparak İndex Giremezsiniz");
            }
            else if(listBox3.SelectedIndex != -1)
            {
                int index = listBox3.SelectedIndex;
                kitaplarfixed[index] = useradTxt.Text;
                
            }
            else if(userındxTxt.Text != "" || userındxTxt != null)
            {
                int index = Convert.ToInt32(userındxTxt.Text);
                kitaplarfixed[index] = useradTxt.Text;
            }

            kitaplargetir();

            
        }

        private void yntsilBtn_Click(object sender, EventArgs e)
        {
            // kitaplar.Remove(listBox2.SelectedItem); itemin iceriginde bulunan string değere göre siler.
            if (yntadTxt.Text != "")
            {
                kitaplar.Remove(yntadTxt.Text);
            }
            else if(yntadTxt.Text!="" && yntindxTxt.Text != "")
            {
                kitaplar.RemoveAt(Convert.ToInt32(yntindxTxt.Text));
            }
            else
            {
                if(listBox2.SelectedIndex!= -1)
                {
                    kitaplar.RemoveAt(listBox2.SelectedIndex);
                }
            }
            //kitaplar.RemoveAt(listBox2.SelectedIndex);//seçilen itemin indexine göre siler.
            kitaplargetir();
        }

    }
}
