using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IOTProject
{
    public partial class userDetailsForm : Form
    {
        public userDetailsForm(int userID)
        {
            InitializeComponent();
            label1.Text = userID.ToString();
        }
    }
}
