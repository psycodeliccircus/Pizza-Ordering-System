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
    
    public partial class frmNewUser : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=marcio;initial catalog=Pizza Ordering System;integrated security=sspi");
        DataSet dsuserInfo = new DataSet();
        //==================================Initialize variables========================================================
        int iCurrentRow = 0; 
        public frmNewUser()
        {
            
            InitializeComponent();
            conn.Open();
            clearForm();
            getdataset();
            filltextbox();
            conn.Close();
        }
        //=============================================Function to fill datagrid view=============================
        private void getdataset()
        {
            dsuserInfo.Clear();
            SqlDataAdapter dauserInfo = new SqlDataAdapter("select userSIN,userPwd,userName,userAddress,userPhone from tbUser", conn);
            dauserInfo.Fill(dsuserInfo);
            dagridUserInfo.DataSource = dsuserInfo.Tables[0];
        }
        //===============================================Function to fill textbox====================================
        private void filltextbox()
        {


            txtSin.Text = dsuserInfo.Tables[0].Rows[iCurrentRow]["userSIN"].ToString();
            txtPwd.Text = dsuserInfo.Tables[0].Rows[iCurrentRow]["userPwd"].ToString();
            txtName.Text = dsuserInfo.Tables[0].Rows[iCurrentRow]["userName"].ToString();
            txtAddress.Text = dsuserInfo.Tables[0].Rows[iCurrentRow]["userAddress"].ToString();
            txtPhone.Text = dsuserInfo.Tables[0].Rows[iCurrentRow]["userPhone"].ToString();


        }
        //===============================================Function to Clear form==================================
        private void clearForm()
        {
            txtSin.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtPwd.Text = "";
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //===========================================insert the data to database====================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {                       
                                 
                    conn.Open();
                 if (txtSin.Text == txtPwd.Text)//====================if statement to check user authentication=====================
                 {
                    
                    SqlCommand scd = new SqlCommand("insert into tbUser(userSIN,userName,userPWD,userAddress,userPhone)values('" + txtSin.Text + "','" + txtName.Text + "','" + txtPwd.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "')", conn);
                    scd.ExecuteNonQuery();
                    MessageBox.Show("Record on userSIN#" + txtSin.Text + "successfully inserted");
                    getdataset();
                    filltextbox();
                }
                else
                {
                    MessageBox.Show("enter valid password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
             clearForm();   



        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet.tbUser' table. You can move, or remove it, as needed.
            this.tbUserTableAdapter.Fill(this.pizza_Ordering_SystemDataSet.tbUser);

        }
        //===========================================Upadate data to database===============================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sud = new SqlCommand("update tbuser set userName='" + txtName.Text + "',userAddress='" + txtAddress.Text + "',userPhone='" + txtPhone.Text + "',userPWD='" + txtPwd.Text + "' where '" + txtSin.Text + "'=userSIN",conn);
                sud.ExecuteNonQuery();
                MessageBox.Show("Record on userSIN#:'" + txtSin.Text + "'successfully updated");
                getdataset();
                filltextbox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            clearForm();

                

        }
        //========================================Delete data from database===============================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete Sin # '" + txtSin.Text + "'?", "Confirmation",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Convert.ToString(dr) == "Yes")
                {
                    conn.Open();
                    SqlCommand scdelete = new SqlCommand("delete from tbUser where '" + txtSin.Text + "' = userSIN", conn);
                    scdelete.ExecuteNonQuery();
                    MessageBox.Show("Record on Sin # '"+ txtSin.Text , "' has been deleted successfully");
                    getdataset();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            clearForm();



        }
        //===============================Close the current  form and open LogIn form on Button Click==================================

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogIn fi = new frmLogIn();
            fi.Show();
            this.Close();
        }
        //===============================Move the data to previous Cursor position=====================================

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                iCurrentRow -= 1;
                filltextbox();

            }
            catch
            {
                iCurrentRow += 1;
                clearForm();
            }

        }
        //============================================Move Data to Next Cursor Position=====================================
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                iCurrentRow += 1;
                filltextbox();

            }
            catch
            {
                iCurrentRow -= 1;
                clearForm();
            }


        }
    }
}
