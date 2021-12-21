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
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] portlar = System.IO.Ports.SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();

            FormClosing += Form1_FormClosing;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void serialPort1_DataReceived(object sender,SerialDataReceivedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string port in portlar)
            {
                comboBox1.Items.Add(port);

            }

            comboBox2.Items.Add("9600");
            comboBox3.Items.Add("Led Yak");
            comboBox3.Items.Add("Led Söndür");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.SelectedItem);

            serialPort1.Open();

            if (serialPort1.IsOpen == true)
            {
                label2.Text = "Bağlantı Gerçekleşti";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            if (serialPort1.IsOpen == false)
            {
                label2.Text = "Bağlantı Kesildi";
            }
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(30);

            string veri = serialPort1.ReadLine();

            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text += veri + "\n"; }));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Led Yak")
            {
                serialPort1.Write("1");
            }
            else if (comboBox3.SelectedItem.ToString() == "Led Söndür")
            {
                serialPort1.Write("0");
            }
        }
    }
}
