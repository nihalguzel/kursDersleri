using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace IOTProject
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0JEQ6P8;Initial Catalog=IOTProje;Integrated Security=True");
        int btnx = 20;
        int btny = 20;
        int colcount = 0;
        public static bool isLogged { get; set; }
        public static int userID { get; set; }
        public static string grsypn { get; set; }
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            geteducationcatalogue();
        }

        public void geteducationcatalogue()
        {
            int btnx = 20;
            int btny = 20;
            int colcount = 0;
            pnlcontent.Controls.Clear();
            con.Open();
            string qry = "Select * From Educations";
            SqlCommand cmd = new SqlCommand(qry,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                educationCard card = new educationCard();
                card.Title = rdr["EducationName"].ToString();
                card.Buton = rdr["ID"].ToString();
                card.Img = "C:\\Users\\onura\\Desktop\\Yeni klasör (2)\\IOTProject\\images\\" + rdr["Picture"].ToString();
                card.Location = new Point(btnx, btny);
                card.Click += Card_Click;
                btnx += 300;
                if (colcount == 4)
                {
                    btny += 395;
                    btnx = 20;
                    colcount = 0;
                }
                pnlcontent.Controls.Add(card);
                colcount ++;
            }
            con.Close();
        }

        public void getteachersedu(int teacherid)
        {
            int btnx = 20;
            int btny = 20;
            int colcount = 0;
            pnlcontent.Controls.Clear();
            con.Open();
            string qry = "Select * From Educations where TeacherID ="+teacherid+"";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                educationCard card = new educationCard();
                card.Title = rdr["EducationName"].ToString();
                card.Buton = rdr["ID"].ToString();
                card.Img = "C:\\Users\\onura\\Desktop\\Yeni klasör (2)\\IOTProject\\images\\" + rdr["Picture"].ToString();
                card.Location = new Point(btnx, btny);
                card.Click += Card_Click;
                btnx += 275;
                if (colcount == 2)
                {
                    btny += 310;
                    btnx = 20;
                    colcount = 0;
                }
                pnlcontent.Controls.Add(card);
                colcount++;
            }
            con.Close();
        }

        public void getteachercatalogue()
        {
            int btnx = 20;
            int btny = 20;
            int colcount = 0;
            pnlcontent.Controls.Clear();
            con.Open();
            string qry = "Select * From Teachers";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                teacherCard tcard = new teacherCard();
                tcard.NameSurname = rdr["TeacherName"].ToString();
                tcard.Describe = rdr["TeacherDescription"].ToString();
                tcard.Img = "C:\\Users\\onura\\Desktop\\Yeni klasör (2)\\IOTProject\\images\\" + rdr["Picture"].ToString();
                tcard.Location = new Point(btnx, btny);
                tcard.Click += Card_Click;
                btnx += 450;
                if (colcount == 2)
                {
                    btny += 230;
                    btnx = 20;
                    colcount = 0;
                }
                pnlcontent.Controls.Add(tcard);
                colcount++;
            }
            con.Close();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getteachercatalogue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (grsypn == "ogrt")
            {
                getteachersedu(userID);

            }
            else
            {
                geteducationcatalogue();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlcontent.Controls.Clear();

            loginForm lg = new loginForm();
            lg.Location = new Point(100, 40);
            lg.TopLevel = false;
            lg.Show();
            pnlcontent.Controls.Add(lg);


        }

        public void changeLoggedStatus()
        {
            isLogged = true;
        }

        public bool signedtoLesson(int edID,int userID)
        {

            string qry = "Select * From StudentEducation where StudentID=" + userID + " and EducationID=" + edID + " and Status='Aktif'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return true;
            }

            return false;
        }
    }
}
