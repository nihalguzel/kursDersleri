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
        int i = 1;
        int y = 20;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Name = ("Buton"+i).ToString();
            btn.Text = ("Kod İle Eklenen"+i).ToString();
            btn.Size = new Size(97,40);
            btn.Location = new Point(10*i*2, 10*i*2);
            this.Controls.Add(btn);
            

            Label lbl = new Label();
            lbl.Text= ("Label" + i).ToString();
            lbl.Name = ("Label" + i).ToString();
            lbl.Text = ("Kod İle Eklenen" + i).ToString();
            lbl.Size = new Size(97, 40);
            lbl.Location = new Point(700-i*10, 400-i*10);
            this.Controls.Add(lbl);

            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CheckBox cb = new CheckBox();
            cb.Name = "cb_" + i.ToString();
            i++;
            cb.Text = textBox1.Text;
            cb.Location = new Point(10,y);
            y += 30;
            groupBox1.Controls.Add(cb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Name = "btn_" + i.ToString();
            i++;
            bt.Text = textBox1.Text;
            bt.Location = new Point(10, y);
            y += 30;
            bt.Click += Bt_Click;
            groupBox1.Controls.Add(bt);
        }

        private void Bt_Click(object sender, EventArgs e)
        {
           

            if (sender.Equals(sender as Button))//sender olarak hangi object geldiğini kontrol ediyoruz. Buton ise bu if blogunu oluşturduk.
            {
                label1.Text = (sender as Button).Name;
            }
            else if(sender.Equals(sender as Label))//sender olarak hangi object geldiğini kontrol ediyoruz. Label ise bu if blogunu oluşturduk.
            {
                label1.Text = (sender as Label).Name;
            }
            

            /* if(((sender as Button).Name) == "btn_1")
              {
                  label2.Text = (sender as Button).Text;
              }
              if (((sender as Button).Name) == "btn_2")
              {
                  label2.Text = (sender as Button).Name;
              }*/

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.Name = "label_" + i.ToString();
            i++;
            lb.Text = textBox1.Text;
            lb.Location = new Point(10,y);
            y += 30;
            lb.Click += Bt_Click;
            groupBox1.Controls.Add(lb);
        }
    }
}
