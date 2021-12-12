using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NAC6GOH;Initial Catalog=bankadb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabloyudoldur();
            ikincitabloyudoldur();
            hesapturleritabloyudoldur();
            subelertablosudoldurma();
            departmanlartablosudoldurma();
            yetkilertablosudoldurma();
            personellertablosudoldurma();
            DPTcomboboxdoldur();
            SBcomboboxdoldur();
            YTcomboboxdoldur();

        }

        public void tabloyudoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select musteriler.ID,musteriler.madi,musteriler.msoyadi,musteriler.myas,hesapturleri.hesapturuadi,musteriler.durum from musteriler inner join hesapturleri on(musteriler.hesapturid=hesapturleri.ID) ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView1.DataSource = tbl;
            dataGridView3.DataSource = tbl;
            
        }

        public void HTcomboboxdoldur() {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select ID,hesapturuadi from hesapturleri ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            comboBox4.DataSource = tbl;
            comboBox4.DisplayMember = "hesapturuadi";
            comboBox4.ValueMember = "ID";
        }/*hesapturleri combobox doldurma*/
        public void DPTcomboboxdoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select ID,departmanadi from departmanlar ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            comboBox5.DataSource = tbl;
            comboBox5.DisplayMember = "departmanadi";
            comboBox5.ValueMember = "ID";

        } /*departmanlar combobox doldurma*/

        public void SBcomboboxdoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select ID,subeadi from subeler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            comboBox9.DataSource = tbl;
            comboBox9.DisplayMember = "subeadi";
            comboBox9.ValueMember = "ID";
        } /*subeler combobox doldurma*/

        public void YTcomboboxdoldur() {

            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select ID,yetkiadi from yetkiler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            comboBox10.DataSource = tbl;
            comboBox10.DisplayMember = "yetkiadi";
            comboBox10.ValueMember = "ID";

        }/*yetkiler combobox doldurma*/

        public void hesapturleritabloyudoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select * from hesapturleri ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView4.DataSource = tbl;
        }/*hesapturleritablosunu doldurma*/

        public void subelertablosudoldurma()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select * from subeler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView5.DataSource = tbl;
        } /*Subeler tablosunu doldurma*/

        public void departmanlartablosudoldurma()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select * from departmanlar ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView6.DataSource = tbl;
        }/*Departmanlar tablosu doldurma*/
       

        public void yetkilertablosudoldurma()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select * from yetkiler ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView7.DataSource = tbl;
        }/*Yetkiler tablosu doldurma*/

        public void personellertablosudoldurma()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select personeller.ID,personeller.padi,personeller.psoyadi,departmanlar.departmanadi,subeler.subeadi,yetkiler.yetkiadi,personeller.pdurum from personeller inner join  departmanlar on(departmanlar.ID=personeller.pdepartmanid) inner join subeler on(subeler.ID=personeller.psubeid) inner join yetkiler on(yetkiler.ID=personeller.pyetki)";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView8.DataSource = tbl;
        }/*Personeller tablosu doldurma*/

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label4.Text = dataGridView2.CurrentRow.Cells["ID"].Value.ToString();
            textBox4.Text= dataGridView2.CurrentRow.Cells["madi"].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells["msoyadi"].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells["myas"].Value.ToString();
            comboBox4.SelectedItem =dataGridView2.CurrentRow.Cells["hesapturuadi"].Value.ToString();
            comboBox3.SelectedItem = dataGridView2.CurrentRow.Cells["durum"].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells["mbakiye"].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells["mtelefon"].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells["memail"].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells["madres"].Value.ToString();

            con.Open();
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = textBox4.Text;
            string soyad = textBox5.Text;
            int yas = Convert.ToInt32(textBox6.Text);
            int hesapturu = Convert.ToInt32(comboBox4.SelectedIndex+1);
            string durum = comboBox3.SelectedItem.ToString();
            double bakiye = Convert.ToDouble(textBox13.Text);
            string tel = textBox14.Text;
            string email = textBox15.Text;
            string adres = textBox16.Text;


            int ID = Convert.ToInt32(label4.Text);
           con.Open();
            string mguncellesorgu = "update musteriler set " +
                "madi='"+ad+"',msoyadi='"+soyad+"',myas='"+yas+"',hesapturid='"+hesapturu+"',durum='"+durum+"' where ID='"+ID+"' ";
            string mbguncellesorgu = "update musteribilgileri set " +
                "madres='" + adres + "',mtelefon='" + tel + "',memail='" + email + "',mbakiye='" + bakiye + "' where musteriid='" + ID + "' ";

            SqlCommand command = new SqlCommand(mguncellesorgu, con);
            SqlCommand command1 = new SqlCommand(mbguncellesorgu, con);

            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            con.Close();
            tabloyudoldur();
            ikincitabloyudoldur();
        }

        public void ikincitabloyudoldur()
        {
            con.Open();
            DataTable tbl = new DataTable();
            string sql = "select musteriler.ID,musteriler.madi,musteriler.msoyadi,musteriler.myas,hesapturleri.hesapturuadi,musteriler.durum,musteribilgileri.madres,musteribilgileri.mtelefon,musteribilgileri.memail,musteribilgileri.mbakiye from musteriler inner join musteribilgileri on(musteribilgileri.musteriid=musteriler.ID) inner join hesapturleri on (hesapturleri.ID=musteriler.hesapturid)";

            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tbl);
            con.Close();
            dataGridView2.DataSource = tbl;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView3.CurrentRow.Cells["ID"].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text!= "")
            {
                con.Open();
                string silmequery = "Delete from musteriler where ID='" + Convert.ToInt32(textBox7.Text) + "'";
                SqlCommand silme = new SqlCommand(silmequery, con);
                silme.ExecuteNonQuery();
                con.Close();
                tabloyudoldur();
            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            int yas = Convert.ToInt32(textBox3.Text);
            int hesapturu = comboBox1.SelectedIndex + 1;
            string durum = comboBox2.SelectedItem.ToString();

            con.Open();
            string meklemesorgu = "insert into musteriler(madi,msoyadi,myas,hesapturid,durum) " +
                "values ('" + ad + "','" + soyad + "','" + yas + "','" + hesapturu + "','" + durum + "')";

            SqlCommand command = new SqlCommand(meklemesorgu, con);
            command.ExecuteNonQuery();
            con.Close();
            tabloyudoldur();
            ikincitabloyudoldur();
            DialogResult res1 = MessageBox.Show("Kayıt İşlemi Başarılı Müşteriye Ait Eksik Bilgiler" +
                " Mevcut Bilgileri Girmek İstermisiniz", "Kayıt İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res1 == DialogResult.Yes)
            {
                tabControl1.SelectedIndex = 1;

            }

            else
            {
                MessageBox.Show("Müşteri Bilgileri Güncellenmedi Halen Tanımsız Bilgiler Bulunmakta");
            }
        } /*Müsteri Ekleme*/

        private void button5_Click(object sender, EventArgs e)
        {
            string ad = hesapturAdtxt.Text;
           

            con.Open();
            string meklemesorgu = "insert into hesapturleri(hesapturuadi) values ('" + ad + "')";

            SqlCommand command = new SqlCommand(meklemesorgu, con);
            command.ExecuteNonQuery();
            con.Close();
            hesapturleritabloyudoldur();
        }/*Hesap Türü Ekleme*/

        private void button6_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string ad = hesapturAdtxt.Text;
            ID = Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value.ToString());

            con.Open();
            if (ID != 0) {
                string mguncellesorgu = "update hesapturleri set " +
                "hesapturuadi='" + ad + "'where ID='" + ID + "' ";
                SqlCommand command = new SqlCommand(mguncellesorgu, con);
                command.ExecuteNonQuery();
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Güncelleme Yapmak İçin Listenden Bir Hesap Türü Seçmelisiniz");
            }
            hesapturleritabloyudoldur();
        }/*Hesap Türü Güncelleme*/

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string silmequery = "Delete from hesapturleri where ID='" +Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value.ToString())+ "'";
            SqlCommand silme = new SqlCommand(silmequery, con);
            silme.ExecuteNonQuery();
            con.Close();
            hesapturleritabloyudoldur();
        }/*Hesap Türü Silme*/

        private void button8_Click(object sender, EventArgs e)
        {
            string ad = textBox8.Text;
            string durum = comboBox6.SelectedItem.ToString();

            con.Open();
            string meklemesorgu = "insert into subeler(subeadi,durum) values ('" + ad + "','" + durum + "')";

            SqlCommand command = new SqlCommand(meklemesorgu, con);
            command.ExecuteNonQuery();
            con.Close();
            subelertablosudoldurma();
        } /*Şube Ekleme*/

        private void button9_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string ad = textBox8.Text;
            ID = Convert.ToInt32(dataGridView5.CurrentRow.Cells["ID"].Value.ToString());
            string durum = comboBox6.SelectedItem.ToString();
            con.Open();
            if (ID != 0)
            {
                string mguncellesorgu = "update subeler set " +
                "subeadi='" + ad + "',durum='"+durum+"' where ID='" + ID + "' ";
                SqlCommand command = new SqlCommand(mguncellesorgu, con);
                command.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("Güncelleme Yapmak İçin Listenden Bir Şube Seçmelisiniz");
            }
            subelertablosudoldurma();
        }/*Şube Güncelleme*/

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            string silmequery = "Delete from subeler where ID='" + Convert.ToInt32(dataGridView5.CurrentRow.Cells["ID"].Value.ToString()) + "'";
            SqlCommand silme = new SqlCommand(silmequery, con);
            silme.ExecuteNonQuery();
            con.Close();
            subelertablosudoldurma();
        }/*Şube Silme*/

        private void button13_Click(object sender, EventArgs e) /*Departman Ekleme*/
        {
            string ad = textBox9.Text;
            string durum = comboBox7.SelectedItem.ToString();

            con.Open();
            string meklemesorgu = "insert into departmanlar(departmanadi,durum) values ('" + ad + "','" + durum + "')";

            SqlCommand command = new SqlCommand(meklemesorgu, con);
            command.ExecuteNonQuery();
            con.Close();
            departmanlartablosudoldurma();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string ad = textBox9.Text;
            ID = Convert.ToInt32(dataGridView6.CurrentRow.Cells["ID"].Value.ToString());
            string durum = comboBox7.SelectedItem.ToString();
            con.Open();
            if (ID != 0)
            {
                string mguncellesorgu = "update departmanlar set " +
                "departmanadi='" + ad + "',durum='" + durum + "' where ID='" + ID + "' ";
                SqlCommand command = new SqlCommand(mguncellesorgu, con);
                command.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("Güncelleme Yapmak İçin Listenden Bir Şube Seçmelisiniz");
            }
            departmanlartablosudoldurma();
        }/*Departman Güncelleme*/

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            string silmequery = "Delete from departmanlar where ID='" + Convert.ToInt32(dataGridView6.CurrentRow.Cells["ID"].Value.ToString()) + "'";
            SqlCommand silme = new SqlCommand(silmequery, con);
            silme.ExecuteNonQuery();
            con.Close();
            departmanlartablosudoldurma();
        }/*Departman Silme*/

        private void button16_Click(object sender, EventArgs e) /*Yetki Ekleme*/
        {
            string ad = textBox10.Text;
            string durum = comboBox8.SelectedItem.ToString();

            con.Open();
            string meklemesorgu = "insert into yetkiler(yetkiadi,durum) values ('" + ad + "','" + durum + "')";

            SqlCommand command = new SqlCommand(meklemesorgu, con);
            command.ExecuteNonQuery();
            con.Close();
            yetkilertablosudoldurma();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string ad = textBox10.Text;
            ID = Convert.ToInt32(dataGridView7.CurrentRow.Cells["ID"].Value.ToString());
            string durum = comboBox8.SelectedItem.ToString();
            con.Open();
            if (ID != 0)
            {
                string mguncellesorgu = "update yetkiler set " +
                "yetkiadi='" + ad + "',durum='" + durum + "' where ID='" + ID + "' ";
                SqlCommand command = new SqlCommand(mguncellesorgu, con);
                command.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("Güncelleme Yapmak İçin Listenden Bir Şube Seçmelisiniz");
            }
            yetkilertablosudoldurma();
        }/*Yetki Güncelleme*/

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            string silmequery = "Delete from yetkiler where ID='" + Convert.ToInt32(dataGridView7.CurrentRow.Cells["ID"].Value.ToString()) + "'";
            SqlCommand silme = new SqlCommand(silmequery, con);
            silme.ExecuteNonQuery();
            con.Close();
            yetkilertablosudoldurma();
        }/*Yetki Silme*/

        private void button19_Click(object sender, EventArgs e)
        {
            string ad = textBox11.Text;
            string soyad = textBox12.Text;
            int dpid = Convert.ToInt32(comboBox5.SelectedValue);
            int sbid = Convert.ToInt32(comboBox9.SelectedValue);
            int ytid = Convert.ToInt32(comboBox10.SelectedValue);
            string durum = comboBox11.SelectedItem.ToString();

            con.Open();
            string meklemesorgu = "insert into personeller(padi,psoyadi,pdepartmanid,psubeid,pyetki,pdurum) " +
                "values ('" + ad + "','" + soyad + "','" + dpid + "','" + sbid + "','" + ytid + "','" + durum + "')";

            SqlCommand command = new SqlCommand(meklemesorgu, con);
            command.ExecuteNonQuery();
            con.Close();
            personellertablosudoldurma();
        } /*Personel Ekleme*/

        private void button18_Click(object sender, EventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(dataGridView8.CurrentRow.Cells["ID"].Value.ToString());
            string ad = textBox11.Text;
            string soyad = textBox12.Text;
            int dpid = Convert.ToInt32(comboBox5.SelectedValue);
            int sbid = Convert.ToInt32(comboBox9.SelectedValue);
            int ytid = Convert.ToInt32(comboBox10.SelectedValue);
            string durum = comboBox11.SelectedItem.ToString();

            con.Open();
            if (ID != 0)
            {
                string mguncellesorgu = "update personeller set " +
                "padi='" + ad + "',psoyadi='" + soyad + "',pdepartmanid='" + dpid + "',psubeid='" + sbid + "',pyetki='" + ytid + "',pdurum='" + durum + "' where ID='" + ID + "' ";
                SqlCommand command = new SqlCommand(mguncellesorgu, con);
                command.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("Güncelleme Yapmak İçin Listenden Bir Personel Seçmelisiniz");
            }

            personellertablosudoldurma();

        }/*Personel Güncelleme*/

        private void button17_Click(object sender, EventArgs e)
        {
            con.Open();
            string silmequery = "Delete from personeller where ID='" + Convert.ToInt32(dataGridView8.CurrentRow.Cells["ID"].Value.ToString()) + "'";
            SqlCommand silme = new SqlCommand(silmequery, con);
            silme.ExecuteNonQuery();
            con.Close();
            personellertablosudoldurma();
        }/*Personel Silme*/

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGridView2.CurrentRow.Cells["ID"].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells["madi"].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells["msoyadi"].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells["myas"].Value.ToString();
            comboBox3.SelectedItem = dataGridView2.CurrentRow.Cells["durum"].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells["mbakiye"].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells["mtelefon"].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells["memail"].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells["madres"].Value.ToString();
        }
    }
}
