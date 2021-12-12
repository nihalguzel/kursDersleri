using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        StreamWriter kisiekle;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            Directory.CreateDirectory(@"C:\Users\burak\Desktop\kursDersler\"+name);
            MessageBox.Show(name + "dosyası oluştu", "Klasör Oluşturma İşlemi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Directory.Delete(@"C:\Users\burak\Desktop\kursDersler\" + name);
            MessageBox.Show(name + "Dosyası Silindi", "Klasör Silme İşlemi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            FileStream olustur = File.Create(@"C:\Users\burak\Desktop\kursDersler\" + name + ".txt");
            olustur.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                kisiekle.WriteLine(richTextBox1.Text);
                MessageBox.Show("Oldu Oldu");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiekle = new StreamWriter(@"C:\Users\burak\Desktop\kursDersler\yeni.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kisiekle.Write(textBox2.Text);
            MessageBox.Show("Kişi Eklenndi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kisiekle.Close();//az çıkan şey çok değerli olur. bu turkcell yeni mezun alıyormuş bizi almaz mı ?? arif neden böyle
            // biri kazanıcak biri kaybedecek . hiç bir zaman herkes kazanamaz . milyarlar gitti milyarlar . senin benim paramla dönmuyor bu işler. 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
            StreamReader oku = new StreamReader(@"C:\Users\burak\Desktop\kursDersler\yeni.txt");
            richTextBox1.Text = oku.ReadToEnd();
            oku.Close();
            }
            catch ( Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }
    }
}
