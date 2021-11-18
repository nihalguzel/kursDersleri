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
        string kullaniciadi = "Burak43";
        string sifre = "4343";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)//index ile kullanırsak -1 eşitse şart tanımlanır
            {
                MessageBox.Show("Eleman Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                //listBox1.Items.Remove(listBox1.SelectedItem);//Itemin içeriğindeki değere göre siler.
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);//Itemin indexine göre siler.
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) //item ile kullanırsak null ise şart tanımlanır
            {
                MessageBox.Show("Eleman Seçmediniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int elemansayisi = listBox1.Items.Count;

            for(int i = 0; i <= elemansayisi-1; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }

            label1.Text = listBox1.Items.Count.ToString();
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            foreach (string liste in listBox2.Items) {

                listBox1.Items.Add(liste);
            }
            listBox2.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Yazılım","Başlık Alanı",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult giriskontrol = MessageBox.Show("Giriş Yapılsın Mı ?", "Giriş Sistemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (giriskontrol == DialogResult.Yes)
            {
                if (textBox3.Text == kullaniciadi && textBox4.Text == sifre)
                {

                    MessageBox.Show("Giriş Başarılı Kullanıcı Adı ve Şifre Doğru", "Mesaj Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Hata Ekranı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
            
            
        }
    }
}
