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
using SimpleTCP;

namespace WinFormsApp1TCP_IP
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        public string iptxt ="172.16.100.173";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//Enter tuşunun hex kodu(/n in hex kodu)
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text += e.MessageString;
                e.ReplyLine(string.Format("Gelen Mesaj{0}", richTextBox1.Text));
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistem Başlatılıyor";
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(iptxt);
                server.Start(ip, 5454);
                Thread.Sleep(1000);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex, "Hata");
            }
            
            label1.Text = "Bağlantı Gerçekleşti";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                label1.Text = "Sistem Durduruluyor";
                server.Stop();
                Thread.Sleep(1000);
                label1.Text = "Sistem Kapatıldı";
            }
           
        }
    }
}
