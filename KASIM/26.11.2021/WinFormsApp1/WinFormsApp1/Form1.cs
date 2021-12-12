using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        bool visibility = true;
        string[,] placeholder = new string[10,10];
        int foldercount=0;
        int filecount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Location = new Point(8, 69);
            textBox1.Location = new Point(133, 61);
            label4.Location = new Point(8, 95);
            textBox2.Location = new Point(133, 90);
            button1.Location = new Point(133, 119);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                createDirectory(textBox1.Text);
                fillTheList();
            }
            else if (radioButton2.Checked == true)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Listeden Bir Klasör Seçmelisninz");
                }
                else
                {
                    createFile(textBox1.Text);
                   
                }
            }
            else
            {
                MessageBox.Show("Dosya Yada Klasör Seçimi Yapmalısınız.");
            }
        }
        public void createDirectory(string dirname)
        {
            try
            {
                Directory.CreateDirectory(@"C:\Users\burak\Desktop\kursDersler\" + dirname);
                placeholder[foldercount, 0] = dirname;
                foldercount++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public void fillTheList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for(int i=0; i < placeholder.GetLength(0); i++)
            {
                if (placeholder[i, 0] != null)
                {

                    listBox1.Items.Add(placeholder[i, 0]);
                    listBox2.Items.Add(placeholder[i, 0]);
                }
            }
        }
        public void fillTheFileList(int selectedIndex)
        {
            listBox3.Items.Clear();

            for (int i = 1; i < placeholder.GetLength(1); i++)
            {
                if (placeholder[selectedIndex, i] != null)
                {

                    listBox3.Items.Add(placeholder[selectedIndex,i]);
                }
            }
        }
        public void createFile(string fileName)
        {
            string selectedFolder = listBox1.SelectedItem.ToString();
            FileStream create = File.Create(@"C:\Users\burak\Desktop\kursDersler\" + selectedFolder +"\\" +fileName+ ".txt");
            create.Close();
            placeholder[listBox1.SelectedIndex, filecount] = fileName;
            filecount++;

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (visibility == true)
            {
                listBox1.Visible = true;
                label5.Visible = true;
                label3.Location = new Point(8, 178);
                textBox1.Location = new Point(133, 173);
                label4.Location = new Point(8, 207);
                textBox2.Location = new Point(133, 202);
                button1.Location = new Point(133, 231);

            }
            else
            {
                listBox1.Visible = false;
                label5.Visible = false;
                label3.Location = new Point(8, 69);
                textBox1.Location = new Point(133, 61);
                label4.Location = new Point(8, 95);
                textBox2.Location = new Point(133, 90);
                button1.Location = new Point(133, 119);
            }
            visibility = !visibility;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTheFileList(listBox2.SelectedIndex);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folder = listBox2.SelectedItem.ToString();
            string file = listBox3.SelectedItem.ToString();
            label9.Text = file;
            label10.Text = @"C:\Users\burak\Desktop\kursDersler\" + folder + "\\" + file;
            readFile(folder, file);
        }

        public void readFile(string folder,string file)
        {
            StreamReader rdr = new StreamReader(@"C:\Users\burak\Desktop\kursDersler\" + folder + "\\" + file + ".txt");
            richTextBox2.Text = rdr.ReadToEnd();
            rdr.Close();
            
        }
        public void writeFile(string folder,string file,string text)
        {
            StreamWriter wrt = new StreamWriter(@"C:\Users\burak\Desktop\kursDersler\" + folder + "\\" + file + ".txt");
            wrt.WriteLine(text);
            wrt.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folder = listBox2.SelectedItem.ToString();
            string file = listBox3.SelectedItem.ToString();
            string text = richTextBox2.Text;
            writeFile(folder, file, text);
        }
    }
}
