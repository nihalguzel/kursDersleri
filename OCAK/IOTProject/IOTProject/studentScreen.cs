using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
namespace IOTProject
{
    public partial class studentScreen : Form
    {
        public string[] portlar = System.IO.Ports.SerialPort.GetPortNames();
        SerialPort serialport1 = new SerialPort();
        string[] values=new string[4];

        public studentScreen()
        {
            
            InitializeComponent();
            FormClosing += ShowPdfForm_FormClosing;
            serialport1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(30);
            string veri = serialport1.ReadLine();
           
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text = veri; }));
            }
            
        }

        private void ShowPdfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialport1.IsOpen == true)
            {
                serialport1.Close();
            }
        }

        private void showPdfForm_Load(object sender, EventArgs e)
        {
            foreach(string port in portlar)
            {
                comboBox1.Items.Add(port);
               
            }
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("115200");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialport1.PortName = comboBox1.SelectedItem.ToString();
            serialport1.BaudRate = Convert.ToInt32(comboBox2.SelectedItem);
            serialport1.Open();
            if (serialport1.IsOpen)
            {
                label1.Text += "Bağlantı Gerçekleşti.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialport1.Close();

            label1.Text = "Bağlantı Kapatıldı.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialport1.Write("o");
            Thread.Sleep(1000);
            veriBol();
           

        }
        public void veriBol()
        {
            int i = 0;
            string deger = richTextBox1.Text;

            foreach(String dg in deger.Split('/'))
            {
                values[i] = dg;
                i++;
            }
            label2.Text = values[0];
            label3.Text = values[1];
            label4.Text = values[2];
            label5.Text = values[3];
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            veriBol();
            
        }

        
    }
}
