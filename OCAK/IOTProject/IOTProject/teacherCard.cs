using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IOTProject
{
    public partial class teacherCard : UserControl
    {
        public teacherCard()
        {
            InitializeComponent();
        }
        #region Properties
        private string _teachername;
        private string _describe;
        private string _img;

        [Category("Custom Props")]
        public string Img
        {
            get { return _img; }
            set { _img = value; pictureBox1.ImageLocation = value.ToString(); }
        }

        [Category("Custom Props")]
        public string NameSurname
        {
            get { return _teachername; }
            set { _teachername = value; ogrtmnAdi.Text = value; }
        }
        [Category("Custom Props")]
        public string Describe
        {
            get { return _describe; }
            set { _describe = value; ogrtmnAciklama.Text = value; }
        }
        #endregion
    }
}
