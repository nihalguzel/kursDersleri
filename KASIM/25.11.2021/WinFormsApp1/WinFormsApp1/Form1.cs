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
            try
            {
                MessageBox.Show(Convert.ToInt32(textBox1.Text) + "");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Girilen Değer String"+ex);
            }
        }
    }
}
