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
using System.Data.SqlClient;

namespace msgappodevi
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        SimpleTcpClient client;
        public string iptxt = "172.16.100.207";
        public int port = 5454;
        public static string personName;
        public static int senderID;
        int receiverID = 5;
        int conuserid = 0;
        int x = 0;
        int y = 10;
        int fcx = 0;
        int fcy = 10;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NAC6GOH;Initial Catalog=chatapp;Integrated Security=True");
        

        public Form1()
        {
            InitializeComponent();
            
        }
       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
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
                label3.Text = "Bağlantı Hatası.";
            }
            #endregion
            getFriends();
           

        }
        public void connectToFriend(string ip,int port)
        {
            #region ClientBlogu

            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
           
            try
            {
                
                client.Connect(ip,port);
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
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text += e.MessageString + "\n";
            });
        }

        
        private  void  Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            createMessage(e.MessageString);
            /*richTextBox1.Invoke((MethodInvoker)delegate () {

                richTextBox1.Text += e.MessageString+"\n";
            
            });
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ("Port 5454:" + richTextBox2.Text+"\n");
            client.WriteLine("Port 5454:" + richTextBox2.Text);
            cardMessageSending msg = new cardMessageSending();
            msg.message = richTextBox2.Text;
            msg.Location = new Point(x, y);
            y += 85;
            panel1.Controls.Add(msg);
            saveReceviedMessage(senderID,receiverID,richTextBox2.Text);

        }

        
        private  void createMessage(string message)
        {
            
            Task createCard()
            {
                return Task.Run(() =>
                {
                    messageCard msg = new messageCard();
                    msg.message = message;
                    msg.personName = personName;
                    msg.Location = new Point(x, y);
                    y += 85;
                    if (panel1.InvokeRequired)
                    {
                        panel1.Invoke((MethodInvoker)delegate () { 
                            panel1.Controls.Add(msg);
                            saveReceviedMessage(receiverID, senderID, message);
                        });
                    }
                });
            }
            createCard();

           
        }

        private void getFriends()
        {
            string qry = "select * from userInf";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                friendCard frc = new friendCard();
                frc.senderID = Convert.ToInt32(rdr["ID"].ToString());
                frc.personName = rdr["username"].ToString();
                frc.personIp = rdr["userıp"].ToString();
                frc.port = Convert.ToInt32(rdr["userport"].ToString());
                frc.Location = new Point(fcx, fcy);
                panel2.Controls.Add(frc);
                fcy += 54;
            }
            con.Close();
            
        }

        private void saveReceviedMessage(int receiverid,int senderid,string message)
        {
            
            String query = "INSERT INTO messages (recieverID,senderID,message) VALUES(" + receiverid + "," + senderid + ",'" + message + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
