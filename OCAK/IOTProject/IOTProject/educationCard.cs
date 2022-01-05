using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOTProject
{
    public partial class educationCard : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0JEQ6P8;Initial Catalog=IOTProje;Integrated Security=True");
        public int eduID;
        public educationCard()
        {
            InitializeComponent();
        }
        #region Properties
        private string _title;
        private string _score;
        private string _btnname;
        private string _image;

        [Category("Custom Props")]
        public string Img
        {
            get { return _image; }
            set { _image = value; pictureBox1.ImageLocation = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; baslikLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Score
        {
            get { return _score; }
            set { _score = value; puanLbl.Text = value; }
        }
        public string Buton
        {
            get { return _btnname; }
            set { _btnname = value; gosterBtn.Name = value; }
        }



        #endregion

        private void gosterBtn_Click(object sender, EventArgs e)
        {
           
            eduID = Convert.ToInt32(gosterBtn.Name);
            getEdDetail(eduID);
           
        }

        public void getEdDetail(int ID)
        {
            Panel pnl = Application.OpenForms["Form1"].Controls["panel2"] as Panel;
            foreach (Control chldPnl in pnl.Controls) {
                if (chldPnl.Name=="pnlcontent")
                {
                    chldPnl.Controls.Clear();
                    educationContentCard ed = new educationContentCard();
                    con.Open();
                    string sql= "SELECT Educations.EducationName,Educations.EducationDescription,Educations.Picture as edPicture,Teachers.TeacherName,Teachers.TeacherSurname,Teachers.Picture as tcPicture FROM Educations inner join Teachers on(Teachers.ID=Educations.TeacherID) WHERE Educations.ID="+ID+"";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        ed.edName = rdr["EducationName"].ToString();
                        ed.descrp = rdr["EducationDescription"].ToString();
                        ed.edImage= "C:\\Users\\onura\\Desktop\\Yeni klasör (2)\\IOTProject\\images\\" + rdr["edPicture"].ToString();
                        ed.teacherImage= "C:\\Users\\onura\\Desktop\\Yeni klasör (2)\\IOTProject\\images\\" + rdr["tcPicture"].ToString();
                        ed.teacherName = rdr["TeacherName"].ToString() + " "+rdr["TeacherSurname"].ToString();
                        ed.Location = new Point(0, 0);
                        ed.Dock = DockStyle.Fill;
                        
                        
                    }
                    #region KullanıcıLoginOldugunda
                    if (Form1.isLogged == true)
                    {
                        foreach(Control edc in ed.Controls)
                        {
                            if (Form1.grsypn!="ogrt" )
                            {
                                if (edc.Name == "panel1")
                                {
                                    Form1 frm = new Form1();
                                    /*Kullanıcının Derse Kayıt Olup Olmadıgını Kontrol Eden Metod Main Formda*/
                                    if (frm.signedtoLesson(ID, Form1.userID) == true)
                                    {
                                        edc.Controls.RemoveByKey("linkLbl");
                                        /*Derse Başla Butonu*/
                                        Button btn = new Button();
                                        btn.Name = "derseBaslaBtn";
                                        btn.Text = "Derse Başla";
                                        btn.Location = new Point(286, 158);
                                        btn.Size = new Size(100, 50);
                                        btn.BackColor = Color.Green;
                                        btn.Click += Btn_Click;
                                        edc.Controls.Add(btn);
                                        /*Derse Başla Butonu*/
                                        /*Dersten Ayrıl Butonu*/
                                        Button btn1 = new Button();
                                        btn1.Name = "dersAyrilBtn";
                                        btn1.Text = "Dersten Ayrıl";
                                        btn1.Location = new Point(386, 158);
                                        btn1.Size = new Size(100, 50);
                                        btn1.Click += Btn_Click;
                                        btn1.BackColor = Color.Red;
                                        edc.Controls.Add(btn1);
                                        /*Dersten Ayrıl Butonu*/
                                    }
                                    else
                                    {
                                        edc.Controls.RemoveByKey("linkLbl");
                                        Button btn = new Button();
                                        btn.Name = "kayıtOlBtn";
                                        btn.Text = "Derse Kayıt Ol";
                                        btn.Location = new Point(286, 158);
                                        btn.Size = new Size(100, 50);
                                        btn.BackColor = Color.Aqua;
                                        btn.Click += Btn_Click;
                                        edc.Controls.Add(btn);
                                    }
                                }
                           
                                
                                //MessageBox.Show(Form1.isLogged.ToString());
                                //MessageBox.Show(Form1.userID.ToString());
                            }
                            else if (Form1.grsypn=="ogrt")
                            {
                                Button btn = new Button();
                                btn.Name = "reviewEduBtn";
                                btn.Text = "Review Education";
                                btn.Location = new Point(290, 172);
                                btn.Size = new Size(125, 50);
                                btn.Font=new Font("Arial",10);
                                btn.BackColor = Color.CadetBlue;
                                btn.Click += Btn_Click1;
                                edc.Controls.Add(btn);
                                /*1-)Eğitimi Gör Butonu EducationContentCard içine eklenecek*/
                                /*2-)Butona tıklandığında öğretmen ekranı acılacak*/
                                /*3-)Öğretmen Ekranı Açıldığında StudentsValues tablosundaki öğrenci ID leri listview da listelenecek*/
                                /*4-)Öğrenciye Çift tıklandıgında veritabanındaki değeri ögretmen ekranında görüntelenecek*/
                            }
                        }
                        
                    }
                    #endregion
                    chldPnl.Controls.Add(ed);
                    
                    con.Close();

                }
            
            } ;
            
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            teacherScreencs scr = new teacherScreencs(eduID);
            scr.ShowDialog();
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            educationContentCard ed = new educationContentCard();
            foreach(Control edc in ed.Controls)
            {
                if((sender as Button).Name== "derseBaslaBtn")
                {
                    studentScreen stuScreen = new studentScreen();
                    stuScreen.ShowDialog();
                    MessageBox.Show("Derse Baslandı");
                    break;
                    
                }
                else if ((sender as Button).Name == "dersAyrilBtn")
                {
                    derstenAyril(eduID, Form1.userID);
                    getEdDetail(eduID);
                    break;
                }
                else if ((sender as Button).Name == "kayıtOlBtn")
                {
                    derseKayitOl(eduID, Form1.userID);
                    getEdDetail(eduID);
                    break;
                }
            }
        }

        private void derseKayitOl(int edID,int userID)
        {
            string qry = "INSERT INTO StudentEducation(StudentID,EducationID,Status)VALUES('" + userID + "','" + edID + "','Aktif')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void derstenAyril(int edID,int userID)
        {
            string qry = "UPDATE StudentEducation SET Status='Pasif' WHERE StudentID="+userID+" and EducationID="+edID+"";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
