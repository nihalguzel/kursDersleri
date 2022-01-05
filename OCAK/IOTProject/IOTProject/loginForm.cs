using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOTProject
{
    public partial class loginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0JEQ6P8;Initial Catalog=IOTProje;Integrated Security=True");
        public loginForm()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox2.Text==null ||textBox2.Text==""){

                MessageBox.Show("Şifre Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string user = textBox1.Text;
            string pass = textBox2.Text;
            con.Open();
            string query = "select * from students where UserName='"+user+"' and Password='"+pass+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string username = rdr["StudentName"].ToString() +" "+ rdr["StudentSurname"].ToString();
                Form1.userID = Convert.ToInt32(rdr["ID"]);
                MessageBox.Show("Giriş Yapan Kullanıcı: " + username);
                Panel pnl = Application.OpenForms["Form1"].Controls["panel5"] as Panel;
                pnl.Controls.RemoveByKey("button5");
                Form1 frm = new Form1();
                frm.changeLoggedStatus();
                /*Profil Detay Butonu Ekleme*/
                Button profildetailsbtn = new Button();
                profildetailsbtn.Name = "prfbtn";
                profildetailsbtn.Text = "Kullanici Profili";
                profildetailsbtn.Size = new Size(134, 42);
                profildetailsbtn.Location = new Point(836, 15);
                profildetailsbtn.BackColor = Color.Gray;
                profildetailsbtn.Click += Profildetailsbtn_Click;
                pnl.Controls.Add(profildetailsbtn);
                /*Profil Detay Butonu Ekleme*/
                getUserDetails(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
            con.Close();
        }
        /*Kullanıcı Profili İşlemleri*/
        private void Profildetailsbtn_Click(object sender, EventArgs e)
        {
            getUserDetails();
        }

        public void getUserDetails()
        {
            Panel pnl1 = Application.OpenForms["Form1"].Controls["panel2"] as Panel;
            foreach (Control chldPnl in pnl1.Controls)
            {
                if (chldPnl.Name == "pnlcontent")
                {
                    if (Form1.grsypn != "ogrt")
                    {
                        chldPnl.Controls.Clear();
                        userDetailsForm ud = new userDetailsForm(Form1.userID);
                        ud.Location = new Point(0, 0);
                        ud.TopLevel = false;
                        ud.Show();
                        chldPnl.Controls.Add(ud);
                    }
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == null || textBox1.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox2.Text == null || textBox2.Text == "")
                {

                    MessageBox.Show("Şifre Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string user = textBox1.Text;
                string pass = textBox2.Text;
                con.Open();
                string query = "select * from Teachers where UserName='" + user + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string username = rdr["TeacherName"].ToString() + " " + rdr["TeacherSurname"].ToString();
                    Form1.userID = Convert.ToInt32(rdr["ID"]);
                    MessageBox.Show("Giriş Yapan Kullanıcı: " + username);
                    Panel pnl = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
                    foreach (Control chldPnl in pnl.Controls)
                    {
                        if (chldPnl.Name == "panel5")
                        {

                            chldPnl.Controls.RemoveByKey("button5");
                            /*Profil Detay Butonu Ekleme*/
                            Button profildetailsbtn = new Button();
                            profildetailsbtn.Name = "prfbtn";
                            profildetailsbtn.Text = "Kullanici Profili";
                            profildetailsbtn.Size = new Size(134, 42);
                            profildetailsbtn.Location = new Point(20, 20);
                            profildetailsbtn.BackColor = Color.Gray;
                            profildetailsbtn.Click += Profildetailsbtn_Click;
                            chldPnl.Controls.Add(profildetailsbtn);
                            /*Profil Detay Butonu Ekleme*/
                        }
                    }
                   
                    Form1 frm = new Form1();
                    frm.changeLoggedStatus();
                    
                    getUserDetails();
                    frm.getteachersedu(Convert.ToInt32(rdr["ID"]));
                    Form1.grsypn = "ogrt";
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
                con.Close();
            }
        }
        /*Kullanıcı Profili İşlemleri*/
    }
}
