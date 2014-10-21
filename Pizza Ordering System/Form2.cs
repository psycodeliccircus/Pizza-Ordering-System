using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Ordering_System
{
    public partial class FrmLogOut : Form
    {
        public FrmLogOut()
        {
            InitializeComponent();
        }
       //============================================LogOut Button Codding==============================================

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Pizza Ordering System").ToString();
            Application.Exit();
        }
    }
}
