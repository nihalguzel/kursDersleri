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
        int say = 0;
        string[] isimler = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(listedoldur));
            th.Start();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                isimler[say] = textBox1.Text;
                say++;
            }

        }

        public void listedoldur(){

            while (true)
            {
                listBox1.Items.Clear();
                foreach(string isim in isimler)
                {
                    if (!string.IsNullOrEmpty(isim))
                    {
                        listBox1.Items.Add(isim);
                    }
                }

                Thread.Sleep(2000);
            }


         }
    }
}
