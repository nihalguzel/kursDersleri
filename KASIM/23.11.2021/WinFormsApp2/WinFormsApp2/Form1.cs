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
            
            foreach(Control rb in groupBox1.Controls.OfType<RadioButton>()) //groupBox taki radiobutonların kontrolünü alıyoruz.
            {
                if (((RadioButton)rb).Checked)
                {
                    label1.Text = rb.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            foreach(Control cb in groupBox2.Controls.OfType<CheckBox>())
            {
                if (((CheckBox)cb).Checked)
                {
                    label2.Text += cb.Text;
                }
            }
        }

    }
}
