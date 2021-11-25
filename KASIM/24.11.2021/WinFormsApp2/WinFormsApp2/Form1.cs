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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nesneadi = nameTxt.Text;
            string nesnetexti = textTxt.Text;
            int xkor = Convert.ToInt32(xkorTxt.Text);
            int ykor = Convert.ToInt32(ykorTxt.Text);
            int gen = Convert.ToInt32(genTxt.Text);
            int yuk = Convert.ToInt32(yukTxt.Text);
            int indeks = listBox1.SelectedIndex;
            bool clickable = false;
            if (radioButton1.Checked == true)
            {
                clickable = true;
            }
            if (radioButton2.Checked == true)
            {
                clickable = false;
            }
            switch (indeks)
            {
                case 0:
                    butonOlusturma(nesneadi, nesnetexti, xkor, ykor, gen, yuk, clickable);
                    break;
                case 1:
                    labelOlusturma(nesneadi, nesnetexti, xkor, ykor, gen, yuk, clickable);
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    listboxOlusturma(nesneadi, xkor, ykor, gen, yuk);
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    comboboxOlusturma(nesneadi, xkor, ykor, gen, yuk);
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    textboxOlusturma(nesneadi,nesnetexti, xkor, ykor, gen, yuk);
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radiobuttonOlusturma(nesneadi, nesnetexti, xkor, ykor, gen, yuk);
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    checkboxOlusturma(nesneadi, nesnetexti, xkor, ykor, gen, yuk);
                    break;

            }
            nameTxt.Clear();
            textTxt.Clear();
            xkorTxt.Clear();
            ykorTxt.Clear();
            genTxt.Clear();
            yukTxt.Clear();
                 

        }
        public void butonOlusturma(string ad,string text,int xkor,int ykor,int gen,int yuk,bool tiklama)
        {
            Button bt = new Button();
            bt.Name = ad;
            bt.Text = text;
            bt.Location = new Point(xkor, ykor);
            bt.Size = new Size(gen, yuk);
            if (tiklama == true)
            {
                bt.Click += Bt_Click;
            }

            groupBox1.Controls.Add(bt);
        }

        public void labelOlusturma(string ad, string text, int xkor, int ykor, int gen, int yuk, bool tiklama)
        {
            Label lb = new Label();
            lb.Name = ad;
            lb.Text = text;
            lb.Location = new Point(xkor, ykor);
            lb.Size = new Size(gen, yuk);
            if (tiklama == true)
            {
                lb.Click += Bt_Click;
            }

            groupBox1.Controls.Add(lb);
        }
        public void listboxOlusturma(string ad,int xkor, int ykor, int gen, int yuk)
        {
            ListBox lbx = new ListBox();
            lbx.Name = ad;
            lbx.Location = new Point(xkor, ykor);
            lbx.Size = new Size(gen, yuk);
            groupBox1.Controls.Add(lbx);
        }
        public void comboboxOlusturma(string ad, int xkor, int ykor, int gen, int yuk)
        {
            ComboBox cbx = new ComboBox();
            cbx.Name = ad;
            cbx.Location = new Point(xkor, ykor);
            cbx.Size = new Size(gen, yuk);
            groupBox1.Controls.Add(cbx);
        }
        public void textboxOlusturma(string ad,string text, int xkor, int ykor, int gen, int yuk)
        {
            TextBox tbx = new TextBox();
            tbx.Name = ad;
            tbx.Text = text;
            tbx.Location = new Point(xkor, ykor);
            tbx.Size = new Size(gen, yuk);
            groupBox1.Controls.Add(tbx);
        }
        public void radiobuttonOlusturma(string ad, string text, int xkor, int ykor, int gen, int yuk)
        {
            RadioButton rb = new RadioButton();
            rb.Name = ad;
            rb.Text = text;
            rb.Location = new Point(xkor, ykor);
            rb.Size = new Size(gen, yuk);
            groupBox1.Controls.Add(rb);
        }
        public void checkboxOlusturma(string ad, string text, int xkor, int ykor, int gen, int yuk)
        {
            CheckBox cb = new CheckBox();
            cb.Name = ad;
            cb.Text = text;
            cb.Location = new Point(xkor, ykor);
            cb.Size = new Size(gen, yuk);
            groupBox1.Controls.Add(cb);
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            if(sender.Equals((sender as Button)))
            {
                MessageBox.Show("Bu Bir Butondur");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox2.Items.Clear();
                foreach(Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        listBox2.Items.Add(c.Name);
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox2.Items.Clear();
                foreach (Control c in groupBox1.Controls.OfType<Label>())
                {
                    
                        listBox2.Items.Add(c.Name);
                    
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = listBox2.SelectedItem.ToString();
            foreach(Control c in groupBox1.Controls.OfType<Button>())
            {
                if (name == c.Name)
                {
                    nameTxt.Text = c.Name;
                    textTxt.Text = c.Text;
                    xkorTxt.Text = c.Location.X.ToString();
                    ykorTxt.Text = c.Location.Y.ToString();
                    genTxt.Text = c.Size.Width.ToString();
                    yukTxt.Text = c.Size.Height.ToString();
                    
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = listBox2.SelectedItem.ToString();
            foreach (Control c in groupBox1.Controls.OfType<Button>())
            {
                if (name == c.Name)
                {

                    c.Text = textTxt.Text;
                    c.Location = new Point(Convert.ToInt32(xkorTxt.Text), Convert.ToInt32(ykorTxt.Text));
                    c.Size = new Size(Convert.ToInt32(genTxt.Text), Convert.ToInt32(yukTxt.Text));
                   

                }
            }

        }
    }
}
