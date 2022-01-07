using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace msgappodevi
{
    public partial class messageCard : UserControl
    {
           
        public messageCard()
        {
            InitializeComponent();
        }

        private string _personName;
        private string _message;
        #region getsetMethodları
        [Category("Custom Props")]
        public string personName
        {
            get { return _personName; }
            set { _personName = value;personNameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string message
        {
            get { return _message; }
            set { _message = value; messageLbl.Text = value; }
        }
        #endregion

    }
}
