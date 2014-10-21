using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pizza_Ordering_System
{
    public partial class frmLogIn : Form
    {
        SqlConnection conn1 = new SqlConnection(@"Data Source=AMITA-PC;initial Catalog=Pizza Ordering System;integrated security=sspi");
        public frmLogIn()
        {
            InitializeComponent();
            
        }
//================================Codding for refresh Button==================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            txtLogName.Text = "";
            txtLogPwd.Text = "";
            this.Close();
        }
        //==================================Codding for LogIn Authentication=============================
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                conn1.Open();//======================Open Connection===============
                SqlCommand sclogin = new SqlCommand("select userPwd,userName from tbUser where '" + txtLogPwd.Text + "' = userPwd and '" + txtLogName.Text + "' = userName", conn1);
                SqlDataReader dAuth = sclogin.ExecuteReader();
                if (dAuth.Read())
                {
                    MessageBox.Show("user authenticated");
                    frmCustDtl custdtl = new frmCustDtl(txtLogPwd.Text);
                    custdtl.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("user LogIn authentication failed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn1.Close();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
