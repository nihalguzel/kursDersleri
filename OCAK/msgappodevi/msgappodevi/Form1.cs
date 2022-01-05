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

namespace msgappodevi
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        SimpleTcpClient client;
        public string iptxt = "192.168.43.160";
        public int port = 5454;
        public string karsiip = "192.168.43.160";
        public int karsiport = 5455;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ServerBlogu
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(iptxt);
                server.Start(ip, port);
                Thread.Sleep(1000);
                if (server.IsStarted)
                {
                    label3.Text = "Sunucu Bağlantısı Aktif";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.ToString(),"Hata");
            }
            #endregion
            
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text += e.MessageString +"\n";
            });
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            richTextBox1.Invoke((MethodInvoker)delegate () {

                richTextBox1.Text += e.MessageString+"\n";
            
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region ClientBlogu
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(karsiip);
                client.Connect(karsiip, karsiport);
                label3.Text = "Karşı Tarafa Bağlantı Gerçekleşti";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex, "Hata");
                label3.Text = "Karşı Tarafa Bağlantı Gerçekleşmedi";
            }
            client.DataReceived += Client_DataReceived;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ("Port 5454:" + richTextBox2.Text+"\n");
            Thread.Sleep(1000);
            client.WriteLineAndGetReply("Port 5454:" + richTextBox2.Text, TimeSpan.FromSeconds(3));
        }
    }
}
