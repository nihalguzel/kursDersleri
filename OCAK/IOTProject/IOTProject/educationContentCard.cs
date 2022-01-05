using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IOTProject
{
    public partial class educationContentCard : UserControl
    {
        public educationContentCard()
        {
            InitializeComponent();
        }
        #region Properties
        private string _edImage;
        private string _teacherImage;
        private string _point;
        private string _descrp;
        private string _edName;
        private string _teacherName;

        [Category ("Custom Props")]

        public string edImage 
        { 
        
            get { return _edImage; }
            set { _edImage = value; pictureBox1.ImageLocation = value.ToString(); }

        }

        [Category("Custom Props")]
        public string teacherImage
        {

            get { return _teacherImage; }
            set { _teacherImage = value; pictureBox2.ImageLocation = value.ToString(); }

        }

        [Category("Custom Props")]
        public string point
        {

            get { return _point; }
            set { _point = value; puanLbl.Text = value.ToString(); }

        }

        [Category("Custom Props")]
        public string descrp
        {

            get { return _descrp; }
            set { _descrp = value; aciklamaLbl.Text = value.ToString(); }

        }

        [Category("Custom Props")]
        public string edName
        {

            get { return _edName; }
            set { _edName = value; egtmAdLbl.Text = value.ToString(); }

        }

        [Category("Custom Props")]
        public string teacherName
        {

            get { return _teacherName; }
            set { _teacherName = value; egtmnAdiLbl.Text = value.ToString(); }

        }
        #endregion
    }
}
