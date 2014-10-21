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
    public partial class frmOdrDtl : Form
    {
        SqlConnection conn3 = new SqlConnection(@"Data source=AMITA-PC;initial catalog=Pizza Ordering System;integrated security=sspi");
        DataSet ds =new DataSet();
        
        //========================================Initialize global variables===========================================/
         int icounter=0;
         string beef=" ";
        string Pork=" ";
        string Chicken=" ";
        string Goat=" ";
        string Veg=" ";
         string Pine = " ";
         string Caps = " ";
         string Onion = " ";
         string Olive = " ";
         string Cheese = " ";
         string Mush= " ";
         string Garlic = " ";
         string Ginger = " ";
         string AllTropp= " ";
         
         

//==================================================Arguement Passing===============================================

         public frmOdrDtl(String ctxt,String stxt)
        {
           
            InitializeComponent();
            txtOdrCustId.Text = ctxt;
            txtOdrSin.Text = stxt;
            //conn3.Open();
            //getDataSet();
            //fillDataSet();
            //clearForm();

           // conn3.Close();
        }
        //===================================Function to fill datagrid view==================================
         private void getDataSet()
         {
             ds.Clear();
             SqlDataAdapter da = new SqlDataAdapter("select dbo.tbOrder.odrId, odrDate,odrQuantity,odrSize,odrPayMode,odrDelMode,odrDelCharges,odrPaymentDue,Beef,Pork,Chicken,Vegetarian,GoatMeat,Pineapple,Capsicum,Onion,Olive,Cheese,Mushroom,Garlic,Ginger,AllTroppings from  tbOrder inner join tbType on tbOrder.odrId=tbType.odrId inner join tbTropping on tbType.odrTypeId=tbTropping.odrTypeId ", conn3);
             da.Fill(ds);
             daGridOdrDtl.DataSource = ds.Tables[0];

         }
        //=================================================Function to fill the textboxes===============================

         private void fillDataSet()
         {
             txtOdrId.Text = ds.Tables[0].Rows[icounter]["odrId"].ToString();
             txtOdrDate.Text = ds.Tables[0].Rows[icounter]["odrDate"].ToString();
             txtOdrQuantity.Text = ds.Tables[0].Rows[icounter]["odrQuantity"].ToString();
             cmbSize.Text = ds.Tables[0].Rows[icounter]["odrSize"].ToString();
             cmbPayMode.Text = ds.Tables[0].Rows[icounter]["odrPayMode"].ToString();
             cmbDelivery.Text = ds.Tables[0].Rows[icounter]["odrDelMode"].ToString();
             txtOdrDelCharges.Text = ds.Tables[0].Rows[icounter]["odrDelCharges"].ToString();
             txtOdrPayDue.Text = ds.Tables[0].Rows[icounter]["odrPaymentDue"].ToString();
             chkBeef.Text = ds.Tables[0].Rows[icounter]["Beef"].ToString();
             chkPork.Checked = (bool)ds.Tables[0].Rows[icounter]["Pork"];
             chkChicken.Checked =(bool)ds.Tables[0].Rows[icounter]["Chicken"];
             chkVegetarian.Checked =(bool) ds.Tables[0].Rows[icounter]["Vegetarian"];
             chkMeat.Checked = (bool)ds.Tables[0].Rows[icounter]["GoatMeat"];
             chkpineapple.Checked =(bool) ds.Tables[0].Rows[icounter]["Pineapple"];
             chkcapsicum.Checked =(bool) ds.Tables[0].Rows[icounter]["Capsicum"];
             chkonion.Checked =(bool) ds.Tables[0].Rows[icounter]["Onion"];
             chkolive.Checked =(bool) ds.Tables[0].Rows[icounter]["Olive"];
             chkcheese.Checked =(bool) ds.Tables[0].Rows[icounter]["Cheese"];
             chkmushroom.Checked =(bool) ds.Tables[0].Rows[icounter]["Mushroom"];
             chkgarlic.Checked =(bool) ds.Tables[0].Rows[icounter]["Garlic"];
             chkginger.Checked =(bool) ds.Tables[0].Rows[icounter]["Ginger"];
             chkall.Checked = (bool)ds.Tables[0].Rows[icounter]["AllTroppings"];
             


         }
       //=========================================Function to Clear the form===============================================

         private void clearForm()
         {
            // txtOdrId.Text = "";
             txtOdrDate.Text = "";
             txtOdrQuantity.Text = "";
             cmbSize.Text = "";
             cmbPayMode.Text = "";
             cmbDelivery.Text = "";
             txtOdrDelCharges.Text = "";
             txtOdrPayDue.Text = "";
             chkBeef.Checked =false;
             chkPork.Checked = false;
             chkChicken.Checked = false;
             chkVegetarian.Checked =false;
             chkMeat.Checked =false;
             chkpineapple.Checked =false;
             chkcapsicum.Checked = false;
             chkonion.Checked =false;
             chkolive.Checked =false;
             chkcheese.Checked =false;
             chkmushroom.Checked =false;
             chkgarlic.Checked =false;
             chkginger.Checked =false;
             chkall.Checked = false; 
         }            

       
        

       

        private void frmOdrDtl_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet2.tbOrder' table. You can move, or remove it, as needed.
            //this.tbOrderTableAdapter.Fill(this.pizza_Ordering_SystemDataSet2.tbOrder);

        }       
                 

       /*****************************************insert the data in database***************************************************************/ 

        private void btnOdrAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtOdrDelCharges.Text;
                string text1 = txtOdrPayDue.Text;
                text = text.Replace(",", ".");
                text1 = text1.Replace(",", ".");
                decimal totalDelCharges = decimal.Parse(text);
                decimal totalPayDue = decimal.Parse(text1);

        /********************************************** If Stataement for checkbox Selection*****************************************************/        
                if (chkBeef.Checked== true)
                {
                    beef ="1";

                }
                else
                {
                    beef = "0";
                   
                }
                if (chkPork.Checked == true)
                {
                    Pork = "1";
                    
                }
                else
                {
                    Pork = "0";
                }
                if (chkChicken.Checked == true)
                {
                    Chicken = "1";
                    
                }
                else
                {
                    Chicken = "0";
                }
                if (chkMeat.Checked == true)
                {
                    Goat = "1";
                    
                }
                else
                {
                    Goat = "0";
                }
                if (chkVegetarian.Checked == true)
                {
                    Veg = "1";
                    
                }
                else
                {
                    Veg = "0";
                }
                if (chkpineapple.Checked == true)
                {
                    Pine = "1";

                }
                else
                {
                    Pine = "0";
                }
                if (chkcapsicum.Checked == true)
                {
                    Caps = "1";
                }
                else
                {
                    Caps = "0";
                }
                if (chkolive.Checked == true)
                {
                    Olive = "1";
                }
                else
                {
                   Olive = "0";
                }
                if (chkcheese.Checked == true)
                {
                    Cheese = "1";
                }
                else
                {
                    Cheese = "0";
                }
                if (chkmushroom.Checked == true)
                {
                    Mush = "1";
                }
                else
                {
                    Mush = "0";
                }
                if (chkolive.Checked == true)
                {
                    Olive = "1";
                }
                else
                {
                    Olive = "0";
                }
                if (chkgarlic.Checked == true)
                {
                   Garlic = "1";
                }
                else
                {
                    Garlic = "0";
                }
                if (chkginger.Checked == true)
                {
                    Ginger = "1";
                }
                else
                {
                    Ginger = "0";
                }
                if (chkall.Checked == true)
                {
                    AllTropp = "1";
                }
                else
                {
                    AllTropp = "0";
                }

                conn3.Open();


//===============================================Insert Command to insert Data to Database====================================================================================

                SqlCommand scd = new SqlCommand("insert into tbOrder(odrDate,odrQuantity,odrSize,odrPayMode,odrDelMode,odrDelCharges,odrPaymentDue)values('" + txtOdrDate.Text +
                       "','" + txtOdrQuantity.Text + "','" + cmbSize.Text + "','" + cmbPayMode.Text + "','"
                       + cmbDelivery.Text + "','" + totalDelCharges + "','" + totalPayDue +  "')", conn3);



               scd.ExecuteNonQuery();
               getDataSet();
               
                SqlCommand Type = new SqlCommand("insert into tbType(odrId, Beef,Chicken,Pork,GoatMeat,Vegetarian)values(@@identity,'"+beef + 
                    "','" + Chicken + "','" + Pork + "','" +Goat + "','" + Veg + "')", conn3); 

                    
                    
                    Type.ExecuteNonQuery();
                    getDataSet();
                  
               

                    SqlCommand Tropp = new SqlCommand("insert into tbTropping(odrTypeId,Pineapple,Capsicum,Onion,Olive,Cheese,Mushroom,Garlic,Ginger,AllTroppings)values(@@identity,'" + Pine +
                        "','" + Caps + "','" + Onion + "','" + Olive + "','" + Cheese + "','"+Mush+"','"+Garlic+"','"+Ginger+"','"+AllTropp+"')", conn3);



                    Tropp.ExecuteNonQuery();
                    getDataSet();
                   
               
                    MessageBox.Show("Record on odrId#" + txtOdrId.Text + "successfully inserted");
                   
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn3.Close();
            clearForm();
           


        }

        private void daGridOdrDtl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void frmOdrDtl_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet11.orderview' table. You can move, or remove it, as needed.
            this.orderviewTableAdapter1.Fill(this.pizza_Ordering_SystemDataSet11.orderview);
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet10.orderview' table. You can move, or remove it, as needed.
            this.orderviewTableAdapter.Fill(this.pizza_Ordering_SystemDataSet10.orderview);
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet9.tbOrder' table. You can move, or remove it, as needed.
            this.tbOrderTableAdapter.Fill(this.pizza_Ordering_SystemDataSet9.tbOrder);
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet8.tbOrder' table. You can move, or remove it, as needed.
            this.tbOrderTableAdapter3.Fill(this.pizza_Ordering_SystemDataSet8.tbOrder);
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet6.tbOrder' table. You can move, or remove it, as needed.
           // this.tbOrderTableAdapter2.Fill(this.pizza_Ordering_SystemDataSet6.tbOrder);
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet5.tbOrder' table. You can move, or remove it, as needed.
           // this.tbOrderTableAdapter1.Fill(this.pizza_Ordering_SystemDataSet5.tbOrder);
            // TODO: This line of code loads data into the 'pizza_Ordering_SystemDataSet4.tbOrder' table. You can move, or remove it, as needed.
          //  this.tbOrderTableAdapter.Fill(this.pizza_Ordering_SystemDataSet4.tbOrder);

        }
        
         
        
        //===============================Close the Current Form on Close button Click===================================

        private void btnOdrClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                   
        
       
           
        //===========================================Move Data to Previous=====================================================
       
        private void btnOdrPrev_Click_1(object sender, EventArgs e)
        {
            try
            {
                icounter -= 1;
                fillDataSet();

            }
            catch
            {
                icounter += 1;
                clearForm();
            }

        }
        //===============================================Move Data to Next Position=======================================

        private void btnOdrNext_Click_1(object sender, EventArgs e)
        {
            try
            {
                icounter += 1;
                fillDataSet();

            }
            catch
            {
                icounter -= 1;
                 clearForm();
            }

        }
        //========================================Delete the Data from Database============================================

        private void btnOdrDelete_Click_1(object sender, EventArgs e)
        
            
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete ID # '" + txtOdrId.Text + "'?", "Confirmation",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Convert.ToString(dr) == "Yes")
                {
                    conn3.Open();
                    SqlCommand scdelete = new SqlCommand("delete from tbOrder where '" + txtOdrId.Text + "' = odrId", conn3);
                    scdelete.ExecuteNonQuery();
                    MessageBox.Show("Record on OdrId # '" + txtOdrId.Text, "' has been deleted successfully");
                    getDataSet();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn3.Close();
            clearForm();
        }
        //=======================================Update in to Database=================================================
        private void btnOdrUpdate_Click_1(object sender, EventArgs e)
        {        
     
            try
            {
                string text = txtOdrDelCharges.Text;
                string text1 = txtOdrPayDue.Text;
                text = text.Replace(",", ".");
                text1 = text1.Replace(",", ".");
                decimal totalDelCharges = decimal.Parse(text);
                decimal totalPayDue = decimal.Parse(text1);
                if (chkBeef.Checked == true)
                {
                    beef = "True";

                }
                else
                {
                    beef = "False";

                }
                if (chkPork.Checked == true)
                {
                    Pork = "True";

                }
                else
                {
                    Pork = "False";
                }
                if (chkChicken.Checked == true)
                {
                    Chicken = "True";

                }
                else
                {
                    Chicken = "False";
                }
                if (chkMeat.Checked == true)
                {
                    Goat = "True";

                }
                else
                {
                    Goat = "False";
                }
                if (chkVegetarian.Checked == true)
                {
                    Veg = "True";

                }
                else
                {
                    Veg = "False";
                }
                if (chkpineapple.Checked == true)
                {
                    Pine = "True";

                }
                else
                {
                    Pine = "False";
                }
                if (chkcapsicum.Checked == true)
                {
                    Caps = "True";
                }
                else
                {
                    Caps = "False";
                }
                if (chkolive.Checked == true)
                {
                    Olive = "True";
                }
                else
                {
                    Olive = "Flase";
                }
                if (chkcheese.Checked == true)
                {
                    Cheese = "True";
                }
                else
                {
                    Cheese = "False";
                }
                if (chkmushroom.Checked == true)
                {
                    Mush = "True";
                }
                else
                {
                    Mush = "False";
                }
                if (chkolive.Checked == true)
                {
                    Olive = "True";
                }
                else
                {
                    Olive = "False";
                }
                if (chkgarlic.Checked == true)
                {
                    Garlic = "True";
                }
                else
                {
                    Garlic = "False";
                }
                if (chkginger.Checked == true)
                {
                    Ginger = "True";
                }
                else
                {
                    Ginger = "Flase";
                }
                if (chkall.Checked == true)
                {
                    AllTropp = "True";
                }
                else
                {
                    AllTropp = "False";
                }

                string TypeId="";
               TypeId= txtOdrId.Text;


                conn3.Open();
                SqlCommand sud = new SqlCommand("update tbOrder set odrDate='" + txtOdrDate.Text +
                    "',odrQuantity='" + txtOdrQuantity.Text + "',odrSize='" + cmbSize.Text + "',odrPayMode='" +
                   cmbPayMode.Text + "',odrDelMode='" + cmbDelivery.Text + "',odrDelCharges='" + totalDelCharges + "',odrPaymentDue='" + totalPayDue +
                   "' where '" + txtOdrId.Text + "'=odrId", conn3);
                sud.ExecuteNonQuery();
                getDataSet();
                fillDataSet();
                SqlCommand Type = new SqlCommand("update tbType set Beef ='" + chkBeef.Text +
                   "',Pork='" + Pork + "',chicken='" + Chicken + "',Vegetarian='" +
                  Veg + "',GoatMeat='" +Goat + "' where '" + txtOdrId.Text + "'=odrId", conn3);
                Type.ExecuteNonQuery();
                getDataSet();
                fillDataSet();

                SqlCommand Tropp = new SqlCommand("update tbtropping set Pineapple ='" + Pine +
                   "',Capsicum='" + Caps + "',Onion='" + Onion + "',Olive='" +
                 Olive + "',Cheese='" + Cheese + "',Mushroom='" + Mush + "',Garlic='" + Garlic + "',Ginger='" + Ginger + "',AllTroppings='" + AllTropp +
                 "' where '" + TypeId + "'= odrTypeId", conn3);
                Tropp.ExecuteNonQuery();
                getDataSet();
                fillDataSet();

                MessageBox.Show("Record on OrderId#:'" + txtOdrId.Text + "'successfully updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn3.Close();
            clearForm();



        }

        }

        

       
       
               
       
    }

 