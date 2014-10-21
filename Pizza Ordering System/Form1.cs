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
    public partial class frmSetUp : Form
    {
        public frmSetUp()
        {
            InitializeComponent();
        }

        private void frmSetUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser fn = new frmNewUser();
            fn.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogIn fi = new frmLogIn();
            fi.Show();  
            
        }

        private void customerDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustDtl fcd = new frmCustDtl(null);
            fcd.Show();
        }

        private void orderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdrDtl fod = new frmOdrDtl(null,null);
            fod.Show();
        }

        private void typeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void troppingDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogOut fo = new FrmLogOut();
            fo.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetUp  fsetup = new frmSetUp();
            fsetup.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabout_us fcus = new frmabout_us();
            fcus.Show();
        }

        private void userSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
