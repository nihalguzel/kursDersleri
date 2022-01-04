using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace WinFormsApp1TCP_IPClient
{
    
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        string iptx = "172.16.100.173";
        string port = "5454";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            button1.Enabled = false;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text += e.MessageString;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistem Başlatılıyor";
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(iptx);
                client.Connect(iptx,5454);
                button1.Enabled = true;
                label1.Text = "Bağlantı Gerçekleşti";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex, "Hata"); 
                label1.Text = "Bağlantı Gerçekleşmedi";
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            label1.Text = "Server Bağlantısı Kapatıldı";
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("Burak:"+textBox1.Text,TimeSpan.FromSeconds(3));
        }
    }
}
