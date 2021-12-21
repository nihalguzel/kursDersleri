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
        GroupBox katgb;
        int kullaniciid;
        int btnx = 50;
        int btny = 20;
        int i = 1;
        int k = 1;
        int kisisayisi;
        int katid = 0;
        bool masadolumu = false;
        int masano;
        int adisyonid;
        string Dosyayolu = "";
        string Dosyaadi = "";
        NumericUpDown nud = new NumericUpDown();
        NumericUpDown nudAdet = new NumericUpDown();
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
            masalartablodoldur();
            kategorilertablodoldur();
            yemeklertablodoldur();
            kategorilercbdoldur();
            yetkilercbdoldur();
            kullanıcılartablodoldur();
            
            
        }

        public void masalar()
        {
            btnx = 50;
            btny = 20;
            i = 1;
            tabPage1.Controls.Clear();
            grp.Text = "Masalar";
            grp.Size = new Size(760, 400);
            tabPage1.Controls.Add(grp);
            grp.Controls.Clear();
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
            if((sender as Button).Name == "btn_adisyonac")
            {
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                
                con.Open();
                SqlCommand cmd = new SqlCommand("adisyonolusturma",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masaid", masano);
                cmd.Parameters.AddWithValue("@kisisayisi",nud.Value);
                cmd.Parameters.AddWithValue("@tarih", dt);
                cmd.ExecuteNonQuery();
                con.Close();

            } /*Adisyon Aç Butonu*/
            foreach(Control btn in grp.Controls.OfType<Button>())
            {
                if((sender as Button).Name == btn.Name)
                {
                    /*Geri Dön Butonu */
                    tabPage1.Controls.Clear();
                    Button backbtn = new Button();
                    backbtn.Name = "geriBtn";
                    backbtn.Text = "Geri Dön";
                    backbtn.Location = new Point(780,20);
                    backbtn.Click += Backbtn_Click;
                    tabPage1.Controls.Add(backbtn);
                    /*Geri Dön Butonu */
                   
                    

                    masaadisyon(btn.Name);
                }
            }/*Masalar Butonları*/

            if (masadolumu == true) { 
            foreach(Control butn in katgb.Controls.OfType<Button>())
            {
                if ((sender as Button).Name == "katdon")
                {

                    kategorilergetir();
                }
                else if ((sender as Button).Name == "urundon")
                {
                    urunlergetir(katid);
                }
                else if ((sender as Button).Name == "ekleBtn")
                {
                        /*Adisyon ekleme sorgusu gelecek*/
                }
                    else if ((sender as Button).Name == butn.Name)
                {

                    katid = Convert.ToInt32(butn.Name.Substring(3));
                    //MessageBox.Show(katid.ToString());
                    urunlergetir(katid);
                    //katid = 0;
                    /*Urunler  Getir Buraya Koyulacak*/
                    
                }
                

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
        }/*Masalara Geri Dön Butonu Click Eventi*/

        public void urunlergetir(int kategoriid)
        {
            
            btnx = 50;
            btny = 80;
            katgb.Controls.Clear();
            con.Open();
            string qry1 = "select * from yemekler where kategoriid="+kategoriid+"";
            SqlCommand cmd1 = new SqlCommand(qry1, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())
            {

                Button btn = new Button();
                btn.Name = "ymk" + rdr1["ID"];
                btn.Text = rdr1["yadi"].ToString();
                btn.BackColor = Color.Yellow;
                btn.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.ForeColor = Color.Black;
                btn.Location = new Point(btnx, btny);
                btn.Size = new Size(100, 100);
                btn.Click += Btn_Click2;
                btnx += 120;
                if (i == 3)
                {
                    btny += 110;
                    btnx = 50;
                    i = 1;

                }

                katgb.Controls.Add(btn);
                i++;

            }
            con.Close();
            Button katdon = new Button();
            katdon.Name = "katdon";
            katdon.Text = "Geri Dön";
            katdon.Location = new Point(110, 20);
            katdon.Click += Btn_Click;
            katgb.Controls.Add(katdon);
        }

        private void Btn_Click2(object sender, EventArgs e) /*Yemek Butonları Click Event*/
        {
            foreach (Control butn in katgb.Controls.OfType<Button>())
            {
                

              if ((sender as Button).Name == butn.Name){

                    int yemekid = Convert.ToInt32(butn.Name.Substring(3));
                    //MessageBox.Show(yemekid.ToString());
                    //katid = 0;
                    urundetaygetir(yemekid);

                }

            }
        }

        public void kategorilergetir()
        {
            katgb.Controls.Clear();
            btnx = 50;
            btny = 20;
            con.Open();
            string qry1 = "select * from kategoriler";
            SqlCommand cmd1 = new SqlCommand(qry1, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())
            {

                Button btn = new Button();
                btn.Name = "kat" + rdr1["ID"];
                btn.Text = rdr1["katad"].ToString();
                btn.BackColor = Color.Yellow;
                btn.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.ForeColor = Color.Black;
                btn.Location = new Point(btnx, btny);
                btn.Size = new Size(100, 100);
                btn.Click += Btn_Click;
                btnx += 120;
                if (i == 3)
                {
                    btny += 110;
                    btnx = 50;
                    i = 1;

                }

                katgb.Controls.Add(btn);
                i++;

            }
            con.Close();
        }
        public void masaadisyon(string mid)
        {
            btnx = 50;
            btny = 20;

            string masaid = mid.Substring(4);
            masano = Convert.ToInt32(masaid);
            con.Open();
            string qry = "select * from adisyonbilgisi where masaid="+ Convert.ToInt32(masaid) +" and durum='Aktif'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                masadolumu = true;
                int adisyonno = Convert.ToInt32(rdr["ID"].ToString());
                GroupBox adsgb = new GroupBox();
                adsgb.Name = "adsContainer";
                adsgb.Text = "Masa-"+rdr["masaid"];
                adsgb.Size = new Size(200, 200);
                adsgb.Location = new Point(20, 20);
                tabPage1.Controls.Add(adsgb);
                katgb = new GroupBox();
                katgb.Name = "katContainer";
                katgb.Text = "Kategoriler";
                katgb.Size = new Size(300, 350);
                katgb.Location = new Point(250, 20);
                tabPage1.Controls.Add(katgb);
                
                con.Close();
                kategorilergetir();
                
            }
            else
            {
                /*Adisyon Açma Butonu*/
                Button button = new Button();
                button.Name = "btn_adisyonac";
                button.Text = "Adisyon Aç";
                button.Location = new Point((tabPage1.Width / 2) - 50, 150);
                button.Click += Btn_Click;
                tabPage1.Controls.Add(button);
                /*Adisyon Açma Butonu*/
                /*Kişi Sayısı Nud*/
                nud.Name = "nud_kisisayisi";
                nud.Maximum = 20;
                nud.Minimum = 1;
                nud.Size = new Size(80, 25);
                nud.Location = new Point((tabPage1.Width / 2) - 50, 100);
                tabPage1.Controls.Add(nud);
                /*Kişi Sayısı Nud*/
            }
            con.Close();
        }

        public void masalartablodoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select * from masabilgisi ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView1.DataSource = tbl;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 78;
            dataGridView1.Columns[2].Width = 70;

        }
        public void kategorilertablodoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select * from kategoriler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView2.DataSource = tbl;
            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].Width = 80;
            dataGridView2.Columns[2].Width = 55;
        }

        public void yemeklertablodoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select yemekler.ID,yemekler.yadi,kategoriler.katad,yemekler.yaciklama,yemekler.yfiyat,yemekler.yresim,yemekler.durum from yemekler inner join kategoriler on(kategoriler.ID=kategoriid) ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView3.DataSource = tbl;
            
        }

        public void kategorilercbdoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select ID,katad from kategoriler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            comboBox1.DataSource = tbl;
            comboBox1.DisplayMember = "katad";
            comboBox1.ValueMember = "ID";
        }

        public void yetkilercbdoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select ID,yetkiadi from yetkiler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            comboBox2.DataSource = tbl;
            comboBox2.DisplayMember = "yetkiadi";
            comboBox2.ValueMember = "ID";
        }

        public void kullanıcılartablodoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select kullanicilar.ID,kullanicilar.kad,kullanicilar.ksoyad,yetkiler.yetkiadi,kullanicilar.kkuladi,kullanicilar.ksifre,kullanicilar.durum from kullanicilar inner join yetkiler on(yetkiler.ID=kullanicilar.kyetkiid)";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView4.DataSource = tbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string qry = "insert into masabilgisi(masadi,durum) values ('" + ad + "','Boş')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry,con);
            cmd.ExecuteNonQuery();
            con.Close();
            masalartablodoldur();
            masalar();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            string ad = dataGridView1.CurrentRow.Cells["masadi"].Value.ToString();

            textBox1.Text = ad;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            con.Open();
            string qry = "update masabilgisi set masadi='" + ad + "' where ID='"+ID+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            masalartablodoldur();
            masalar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            string qry = "delete from masabilgisi where ID='" + ID + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            masalartablodoldur();
            masalar();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value.ToString());
            string ad = dataGridView2.CurrentRow.Cells["katad"].Value.ToString();

            textBox2.Text = ad;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            string qry = "insert into kategoriler(katad,durum) values ('" + ad + "','Aktif')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            kategorilercbdoldur();
            kategorilertablodoldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            int ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value.ToString());
            con.Open();
            string qry = "update kategoriler set katad='" + ad + "' where ID='" + ID + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            kategorilertablodoldur();
            kategorilercbdoldur();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value.ToString());

            string qry = "delete from kategoriler where ID='" + ID + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            kategorilertablodoldur();
            kategorilercbdoldur();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView3.CurrentRow.Cells["katad"].Value.ToString();
            textBox3.Text = dataGridView3.CurrentRow.Cells["yadi"].Value.ToString();
            textBox5.Text = dataGridView3.CurrentRow.Cells["yfiyat"].Value.ToString();
            richTextBox1.Text = dataGridView3.CurrentRow.Cells["yaciklama"].Value.ToString();
            string dosyayolu = "C:\\Users\\burak\\Desktop\\" + dataGridView3.CurrentRow.Cells["yresim"].Value.ToString();
            pictureBox1.Image =Image.FromFile(dosyayolu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int kategoriid = Convert.ToInt32(comboBox1.SelectedValue);
            string ad = textBox3.Text;
            double fyt = Convert.ToDouble(textBox5.Text);
            string aciklama = richTextBox1.Text;
            string durum = "Aktif";
            if (Dosyaadi != "") {

                con.Open();
                string qry = "insert into yemekler(yadi,kategoriid,yresim,yaciklama,durum,yfiyat) " +
                    "values('" + ad + "','" + kategoriid + "','" +Dosyaadi+ "','" + aciklama + "','" + durum + "','"+fyt+"')";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                yemeklertablodoldur();
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpeg Dosyası |*.jpg";
            file.Title = "Resim Seçiniz";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Dosyayolu = file.FileName;
                Dosyaadi = file.SafeFileName;
                pictureBox1.Image = Image.FromFile(Dosyayolu);
                textBox4.Text = Dosyayolu;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ID"].Value.ToString());
            int kategoriid = Convert.ToInt32(comboBox1.SelectedValue);
            string ad = textBox3.Text;
            double fyt = Convert.ToDouble(textBox5.Text);
            string aciklama = richTextBox1.Text;
            string durum = "Aktif";
            con.Open();
            string qry = "update yemekler set yadi='" + ad + "',kategoriid='" + kategoriid + "',yresim='" + Dosyaadi + "',yaciklama='" + aciklama + "',durum='" + durum + "',yfiyat='" + fyt + "' where ID='"+ID+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            yemeklertablodoldur();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ID"].Value.ToString());
            string qry = "delete from yemekler where ID='" + ID + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            string ad = textBox6.Text;
            string soyad = textBox7.Text;
            string kuladi = textBox9.Text;
            string sifre = textBox8.Text;
            int yetkiid = Convert.ToInt32(comboBox2.SelectedValue);
            con.Open();
            SqlCommand cmd = new SqlCommand("kullaniciekleme",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ekleyiciID", kullaniciid);
            cmd.Parameters.AddWithValue("@ad",ad);
            cmd.Parameters.AddWithValue("@soyad", soyad);
            cmd.Parameters.AddWithValue("@kullaniciadi", kuladi);
            cmd.Parameters.AddWithValue("@kullanicisifre", sifre);
            cmd.Parameters.AddWithValue("@kulyetkiid", yetkiid);
            cmd.Parameters.Add("@returndegeri", SqlDbType.NVarChar, 200);
            cmd.Parameters["@returndegeri"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string message = (string)cmd.Parameters["@returndegeri"].Value;
            con.Close();

            MessageBox.Show(message);
            
            /* string durum = "Aktif";
             string qry = "insert into kullanicilar(kad,ksoyad,kkuladi,ksifre,kyetkiid,durum)" +
                 "values('" + ad + "','" + soyad + "','" + kuladi + "','" + sifre + "','" + yetkiid + "','" + durum + "')";
             con.Open();
             SqlCommand cmd = new SqlCommand(qry,con);
             cmd.ExecuteNonQuery();
             con.Close();*/
            kullanıcılartablodoldur();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ad = dataGridView4.CurrentRow.Cells["kad"].Value.ToString();
            string soyad = dataGridView4.CurrentRow.Cells["ksoyad"].Value.ToString();
            string kuladi = dataGridView4.CurrentRow.Cells["kkuladi"].Value.ToString();
            string sifre = dataGridView4.CurrentRow.Cells["ksifre"].Value.ToString();
            string yetki = dataGridView4.CurrentRow.Cells["yetkiadi"].Value.ToString();

            textBox6.Text = ad;
            textBox7.Text = soyad;
            textBox9.Text = kuladi;
            textBox8.Text = sifre;
            comboBox2.Text = yetki;
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ID =Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value.ToString());
            string ad = textBox6.Text;
            string soyad = textBox7.Text;
            string kuladi = textBox9.Text;
            string sifre = textBox8.Text;
            int yetkiid = Convert.ToInt32(comboBox2.SelectedValue);
            string query = "update kullanicilar set kad='" + ad + "',ksoyad='" + soyad + "',kkuladi='" + kuladi + "',ksifre='" + sifre + "',kyetkiid='" + yetkiid+"'where ID='"+ID+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            kullanıcılartablodoldur();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("kullanicisilme", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@islemyapanid", kullaniciid);
            cmd.Parameters.AddWithValue("@silinecekid", ID);
            cmd.Parameters.Add("@returndeger", SqlDbType.NVarChar, 200);
            cmd.Parameters["@returndeger"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string message = (string)cmd.Parameters["@returndeger"].Value;
            con.Close();
            MessageBox.Show(message);
            kullanıcılartablodoldur();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string kuladi = textBox10.Text;
            string sifre = textBox11.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from kullanicilar where kkuladi='"+kuladi+"' and ksifre='"+sifre+"' ",con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Kullanıcı Girişi Başarılı");
                tabControl1.Visible = true;
                label15.Text += kuladi;
                kullaniciid = Convert.ToInt32(rdr["kyetkiid"].ToString());
                if(rdr["kyetkiid"].ToString()=="1"|| rdr["kyetkiid"].ToString() == "2")
                {
                    tabControl1.TabPages.Add(tabPage4);
                }
                button14.Visible = false;
                Button btn = new Button();
                btn.Text = "Çıkış Yap";
                btn.Name = "cksbtn";
                btn.Location = new Point(840, 11);
                btn.Click += Btn_Click1;
                this.Controls.Add(btn);
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
            }

            con.Close();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
           
            button14.Visible = true;
            tabControl1.Visible = false;
            this.Controls.RemoveByKey("cksbtn");
            label15.Text = "Giriş Yapan Kullanıcı:";
            textBox10.Clear();
            textBox11.Clear();
            
        } /*Çıkış Butonu İşlemleri*/

        public void urundetaygetir(int urunid)
        {
            con.Open();
            string query= "select yemekler.yadi,yemekler.yresim,yemekler.yaciklama,yemekler.yfiyat,yemekbilgisi.ybilgisi from yemekler inner join yemekbilgisi on(yemekid="+urunid+") where yemekler.ID="+urunid+"";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rdr= cmd.ExecuteReader();
            if (rdr.Read())
            {
                katgb.Controls.Clear();
                Button urundon = new Button();
                urundon.Name = "urundon";
                urundon.Text = "Geri Dön";
                urundon.Location = new Point(110, 20);
                urundon.Click += Btn_Click;
                katgb.Controls.Add(urundon);

                PictureBox pct = new PictureBox();
                pct.Size = new Size(150,150);
                pct.Location = new Point(80, 50);
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                pct.ImageLocation = "C:\\Users\\burak\\Desktop\\" + rdr["yresim"].ToString();
                katgb.Controls.Add(pct);
                /*Urun Adi Label*/
                Label lbl = new Label();
                lbl.Name = "urunadilbl";
                lbl.Location = new Point(80,200);
                lbl.Size = new Size(150, 20);
                lbl.Text = rdr["yadi"].ToString();
                lbl.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                katgb.Controls.Add(lbl);
                /*Urun Adi Label*/
                /*Urun Acıklaması Rictextbox*/
                RichTextBox rct = new RichTextBox();
                rct.Name = "urunaciklama";
                rct.Location = new Point(80, 220);
                rct.Size = new Size(150, 50);
                rct.Text = rdr["yaciklama"].ToString();
                katgb.Controls.Add(rct);
                /*Urun Acıklaması Rictextbox*/
                /*Fiyat Numeric Updown*/
                NumericUpDown nudurFiyat = new NumericUpDown();
                nudurFiyat.Name = "urunfiyat";
                nudurFiyat.Location= new Point(80, 270);
                nudurFiyat.Size = new Size(150, 20);
                nudurFiyat.ReadOnly = true;
                nudurFiyat.Enabled = false;
                nudurFiyat.Maximum = 500;
                nudurFiyat.Minimum = 0;
                nudurFiyat.Value = Convert.ToDecimal(rdr["yfiyat"].ToString());
                katgb.Controls.Add(nudurFiyat);
                /*Fiyat Numeric Updown*/
                /*Yemek Adeti Numericupdown*/
                nudAdet = new NumericUpDown();
                nudAdet.Name = "adetNud";
                nudAdet.Maximum = 10;
                nudAdet.Minimum = 0;
                nudAdet.DecimalPlaces = 2;
                nudAdet.Increment = 0.5m;
                nudAdet.Location = new Point(80, 295);
                nudAdet.Size = new Size(150, 20);
                katgb.Controls.Add(nudAdet);
                /*Yemek Adeti Numericupdown*/

                /*Yemek Ekle Butonu*/
                Button addbtn = new Button();
                addbtn.Name = "ekleBtn";
                addbtn.Text = "Ekle";
                addbtn.Location = new Point(80, 320);
                addbtn.Size = new Size(150, 30);
                addbtn.Click += Btn_Click;
                katgb.Controls.Add(addbtn);
                /*Yemek Ekle Butonu */
            }
            con.Close();

        }
    }
}
