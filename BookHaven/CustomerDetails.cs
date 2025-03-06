using BookHaven.Models;
using BookHaven.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class CustomerDetails: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public CustomerDetails()
        {
            InitializeComponent();
            ReadClients();
        }

        private int cstmrId = 0;

        public void UpdateCustomer(CustomerModel cstmr)
        {
            this.cmb_customerBranch.Enabled = false;
            this.cmb_customerBranch.SelectedValue = cstmr.StoreID;
            this.txt_customerName.Text = cstmr.name;
            this.txt_customerNic.Text = cstmr.nic;
            this.txt_customerMobile.Text = cstmr.mobile;
            this.txt_customerEmail.Text = cstmr.email;

            if (cstmr.isActive == true)
            {
                cmb_isMembActive.Text = "Active";
            }
            else if (cstmr.isActive == false)
            {
                cmb_isMembActive.Text = "InActive";
            }
            
            this.txt_customerAddress.Text = cstmr.address;
            this.cstmrId = cstmr.id;
        }

        //Code to Display Customers on Data Grid
        private void ReadClients()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Store ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("NIC");
            dt.Columns.Add("Address");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Email");
            dt.Columns.Add("Membership Status");


            var repo = new CustomerRepository();
            var cstmr = repo.GetCustomers();

            foreach (var item in cstmr)
            {
                var row = dt.NewRow();

                row["ID"] = item.id;
                row["Store ID"] = item.StoreID;
                row["Name"] = item.name;
                row["NIC"] = item.nic;
                row["Address"] = item.address;
                row["Mobile"] = item.mobile;
                row["Email"] = item.email;
                
                    if (item.isActive == true)
                    {
                        row["Membership Status"] = "Active";
                    }
                    else
                    {
                        row["Membership Status"] = "InActive";
                    }
                dt.Rows.Add(row);
            }

            this.customerDetails_datagrid.DataSource = dt;

        }

        //To add New or update existing customer
        private void btn_save_Click(object sender, EventArgs e)
        {
            CustomerModel cstmr = new CustomerModel();

            cstmr.id = this.cstmrId;

            if (cmb_customerBranch.SelectedItem != null && cstmrId == 0)
            {
                int x = int.Parse(cmb_customerBranch.SelectedValue.ToString());
                cstmr.StoreID = x;
            }
            else if (cstmrId != 0)
            {
                cstmr.id = this.cstmrId;
            }

            cstmr.name = this.txt_customerName.Text;
            cstmr.nic = this.txt_customerNic.Text;
            cstmr.mobile = this.txt_customerMobile.Text;
            cstmr.email = this.txt_customerEmail.Text;
            if (cmb_isMembActive.Text == "Active")
            {
                cstmr.isActive = true;
            }
            else if (cmb_isMembActive.Text == "InActive")
            {
                cstmr.isActive = false;
            }
            cstmr.address = this.txt_customerAddress.Text;

            var repo = new CustomerRepository();

            if (cstmr.id == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Add This New Customer?", "Add New Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                repo.CreateCustomer(cstmr);
                //To Refresh the table with newly added record
                ReadClients();
                cmb_customerBranch.SelectedValue = 0;
                txt_customerName.Clear();
                txt_customerNic.Clear();
                txt_customerMobile.Clear();
                txt_customerEmail.Clear();
                cmb_isMembActive.Items.Clear();
                txt_customerAddress.Clear();
                
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Update This Details?", "Update Existing Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                repo.UpdateCustomer(cstmr);
                //To Refresh the table with newly added record
                ReadClients();
                cmb_customerBranch.SelectedValue = 0;
                txt_customerName.Clear();
                txt_customerNic.Clear();
                txt_customerMobile.Clear();
                txt_customerEmail.Clear();
                cmb_isMembActive.Items.Clear();
                txt_customerAddress.Clear();
                cmb_customerBranch.Enabled = true;
            }

            
            
        }

        

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            //Code for loading details on ComboBox Branch
            try
            {
                  
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {

                        con.Open();
                        //MessageBox.Show("Connection Successful!");

                        string sql = "select ID, Branch from Store";
                        //cmb_customerBranch.Items.Clear(); // Clear existing items
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            //setting default value to ComboBox
                            DataRow itemRow = dt.NewRow();
                            itemRow[1] = "Select Branch";
                            dt.Rows.InsertAt(itemRow, 0);

                            //Displaying values while keeping the ID
                            cmb_customerBranch.DataSource = dt;
                            //Branch is displayed on dropdown
                            cmb_customerBranch.DisplayMember = "Branch";
                            //ID is rememberd to use later
                            cmb_customerBranch.ValueMember = "ID";
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                MessageBox.Show($"Database Connection Error: {ex.Message}");
            }

            //Combobox Branch Code Ends Here 
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var val = this.customerDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int cstmrId = int.Parse(val);

            var repo = new CustomerRepository();
            var cstmr = repo.GetCustomer(cstmrId);

            if (cstmr == null) return;

            this.UpdateCustomer(cstmr);
                
            

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var val = this.customerDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int cstmrId = int.Parse(val);

            //Showing Confirmation Dialog
            DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Delete This Record?", "Delete Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new CustomerRepository();
            repo.DeleteCustomer(cstmrId);

            //Update the Data Grid
            ReadClients();
        }
    }
}
