using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int btnx = 50;
        int btny = 20;
        int i = 1;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NAC6GOH;Initial Catalog=restaurantdb;Integrated Security=True");
        GroupBox grp = new GroupBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;


            masalar();
           
            
        }

        public void masalar()
        {
            tabPage1.Controls.Clear();
            grp.Text = "Masalar";
            grp.Size = new Size(760, 400);
            tabPage1.Controls.Add(grp);
            con.Open();
            string qry = "Select * From masabilgisi";
            SqlCommand cmd = new SqlCommand(qry,con);
            SqlDataReader rdr = cmd.ExecuteReader();/*Data Reader gelen değerin içeriğini okur*/

            while (rdr.Read())
            {
               
                Button btn = new Button();
                btn.Name = "masa" + rdr["ID"];
                btn.Text = rdr["masadi"].ToString();

                /*Duruma Göre Buton Back Rengi*/
                if (rdr["durum"].ToString() == "Boş")
                {
                    btn.BackColor = Color.ForestGreen;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
                /*Duruma Göre Buton Back Rengi*/
                btn.Font = new Font ("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.ForeColor = Color.White;
                btn.Location = new Point(btnx, btny);
                btn.Size = new Size(150, 100);
                btn.Click += Btn_Click;

                btnx += 170;
                if (i==4)
                {
                    btny += 120;
                    btnx = 50;
                    i = 0;
                    
                }                
                grp.Controls.Add(btn);
                i++;
            }
            con.Close();
           
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach(Control btn in grp.Controls.OfType<Button>())
            {
                if((sender as Button).Name == btn.Name)
                {
                    /*Geri Dön Butonu */
                    tabPage1.Controls.Clear();
                    Button backbtn = new Button();
                    backbtn.Name = "geriBtn";
                    backbtn.Text = "Geri Dön";
                    backbtn.Location = new Point(795,105);
                    backbtn.Click += Backbtn_Click;
                    this.Controls.Add(backbtn);
                    /*Geri Dön Butonu */
                    masaadisyon(btn.Name);
                }
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            btnx = 50;
            btny = 20;
            i = 1;
            grp.Controls.Clear();
            this.Controls.RemoveByKey("geriBtn");
            masalar();
        }/*Geri Dön Buton Eventi*/

        public void masaadisyon(string mid)
        {
            string masaid = mid.Substring(4);
            MessageBox.Show(masaid);
            con.Open();
            string qry = "select * from adisyonbilgisi where masaid="+ Convert.ToInt32(masaid) +" and durum='Aktif'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                GroupBox adsgb = new GroupBox();
                adsgb.Name = "adsContainer";
                adsgb.Text = "Masa-"+rdr["masaid"];
                adsgb.Size = new Size(200, 200);
                adsgb.Location = new Point(20, 20);
                tabPage1.Controls.Add(adsgb);
            }
            con.Close();
        }
    }
}
