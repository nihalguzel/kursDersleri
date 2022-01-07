using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;

namespace msgappodevi
{
    public partial class friendCard : UserControl
    {
        public friendCard()
        {
            InitializeComponent();
        }
        private string _personName;
        private string _personIp;
        private int _personPort;
        private int _senderID;

        #region GetSetMethods
        [Category("Custom Props")]
        public string personName
        {
            get { return _personName; }
            set { _personName = value; personNameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string personIp
        {
            get { return _personIp; }
            set { _personIp = value; personIpLbl.Text = value; }
        }
        [Category("Custom Props")]
        public int port
        {
            get { return _personPort; }
            set { _personPort = value;}
        }

        public int senderID
        {
            get { return _senderID; }
            set { _senderID = value; }
        }
        #endregion

        private void friendCard_DoubleClick(object sender, EventArgs e)
        {
            Form1.personName = personName;
            Form1.senderID = senderID;
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.connectToFriend(personIp,port);

        }
        private void friendCard_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void friendCard_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
          
        }
    }
}
