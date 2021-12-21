using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        string[] portlar = System.IO.Ports.SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort sp = new SerialPort();
            
            if (sp.IsOpen == true)
            {
                sp.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
            }

            comboBox2.Items.Add("300");
            comboBox2.Items.Add("600");
            comboBox2.Items.Add("1200");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
        }
    }
}
