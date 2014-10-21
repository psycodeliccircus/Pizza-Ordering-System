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
    public partial class frmCustDtl : Form
    {
        SqlConnection conn2 = new SqlConnection(@"Data Source=AMITA-PC;initial catalog=Pizza Ordering System;integrated security=sspi");
        DataSet ds=new DataSet();
        int counter=0;

        public frmCustDtl(String ctxt)
        {
         //=======================================Arguement Passing from one form to another form==============================   
            InitializeComponent();
            txtCustSin.Text = ctxt;
           // conn2.Open();           
            //showData();
            //clearForm();
            //fillData();
            //conn2.Close();
        }

      //=========================================Show Data Method to Display the data in Data Grid ================================== 
        private void showData()
        {

            ds.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select custId,custName,custAddress,custPhone from tbCustomer", conn2);
                da.Fill(ds);
                daGridCustDtl.DataSource = ds.Tables[0];
                MessageBox.Show("data scuccessfully displayed");
            
        }
        //===========================================FillData Method to Fill data in Text Boxes=========================
        private void fillData()
        {
            txtCustId.Text = ds.Tables[0].Rows[counter]["custId"].ToString();
            txtCustName.Text = ds.Tables[0].Rows[counter]["custName"].ToString();
            txtCustAddress.Text = ds.Tables[0].Rows[counter]["custAddress"].ToString();
            txtCustPhone.Text = ds.Tables[0].Rows[counter]["custPhone"].ToString();

        }
       
        //============================================Clear Method to Clear Form=======================================
        private void clearForm()

        {
            txtCustId.Text = "";
            txtCustName.Text = "";
            txtCustAddress.Text = "";
            txtCustPhone.Text = "";
        }
        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCustDtl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet1.tbCustomer' table. You can move, or remove it, as needed.
            this.tbCustomerTableAdapter.Fill(this.pizza_Ordering_SystemDataSet1.tbCustomer);

        }

        //==========================================Insert the data into Customer table=====================================
        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                SqlCommand scd = new SqlCommand("insert into tbCustomer( custName,custAddress,custPhone)values('" + txtCustName.Text + "','" + txtCustAddress.Text + "','" + txtCustPhone.Text + "')", conn2);
                scd.ExecuteNonQuery();
                MessageBox.Show("Record on ID'" + txtCustId.Text + "'successfully inserted");
                showData();
                fillData();
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn2.Close();
            clearForm();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //============================Display Order Detail at close button click============================
        private void btnCustClose_Click(object sender, EventArgs e)
        {
            frmOdrDtl fodrdtl = new frmOdrDtl(txtCustId.Text,txtCustSin.Text);
            fodrdtl.Show();
            this.Close();
        }

        private void daGridCustDtl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
//===========================================================Codding for prevoius button==============================
        private void btnCustPrev_Click(object sender, EventArgs e)
        {
            try
            {
                counter -= 1;
                fillData();
            }
            catch
            {

                counter+=1;
                clearForm();
            }


        }
        //=====================================================Codding for Next Button====================================
        private void btnCustNext_Click(object sender, EventArgs e)
        {
            try
            {
                counter += 1;
                fillData();
            }
            catch
            {
                counter -= 1;
                clearForm();
            }

        }
        //===============================Show Form Order Detail on menu click in Customer Detail form============

        private void orderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdrDtl fodrdtl = new frmOdrDtl(txtCustId.Text,txtCustSin.Text);
            fodrdtl.Show();
        }

       
    }
}
