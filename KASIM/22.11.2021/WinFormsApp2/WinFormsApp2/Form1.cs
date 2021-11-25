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

        //math fonksiyonları
        double sayi1 = 15.49;
        double sayi2 = 15.01;
        double sayi3 = 15.99;
        double sayi4 = 15.5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*label1.Text = Math.Floor(sayi4).ToString();//Floor sayıyı tam sayı olarak aşşağı yuvarlar.
            label2.Text = Math.Ceiling(sayi1).ToString();//Ceiling sayıyı tam sayı olarak yukarı yuvarlar.
            label3.Text = Math.Round(sayi2).ToString();//Sayıyı en yakın tam sayıya yuvarlar
            textBox1.Text = Math.Max(sayi1, sayi2).ToString();//verilen iki değer arasındaki maksimum olanını verir.
            textBox1.Text = Math.Min(sayi1, sayi2).ToString();//verilen iki değer arasındaki minimum olanını verir.
            textBox1.Text = Math.PI.ToString();*/

            Random rastgele = new Random() ;
            textBox1.Text = Math.Round(rastgele.NextDouble()*10).ToString();//next double 0 ve 1 arasında değer üretir çarpan ve toplama ile bu aralığı belirleyebiliriz.





        }
    }
}
