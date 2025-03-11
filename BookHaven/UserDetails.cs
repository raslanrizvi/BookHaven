using BookHaven.Models;
using BookHaven.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class UserDetails: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public UserDetails()
        {
            InitializeComponent();
            ReadUser();
        }

        int usrId = 0;

        public void UpdateUser(UserModel usr)
        {
            this.txt_userFirstName.Text = usr.firstName;   
            this.txt_userLastName.Text = usr.lastName;   
            this.txt_userUName.Text = usr.userName;   
            this.txt_userEmail.Text = usr.email;   
            this.txt_userMobile.Text = usr.mobile;   
            this.dtp_userDOB.Value = usr.dob;  
            this.txt_userPassword.Text = usr.password;  
            this.txt_userConfirmPassword.Text = usr.password;
            this.cmb_userType.SelectedValue = usr.roleId;

            if (usr.isActive == true)
            {
                this.cmb_userIsAccountActive.Text = "Active";
            }
            else
            {
                this.cmb_userIsAccountActive.Text = "InActive";
            }

            this.cmb_userStoreId.SelectedValue = usr.storeId;
            
            this.usrId = usr.id;
        }

        //Code to Display User on Data Grid
        private void ReadUser()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Branch");
            dt.Columns.Add("Role Type");
            dt.Columns.Add("UserName");
            dt.Columns.Add("Firast Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("DOB");
            dt.Columns.Add("Age");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Email");
            dt.Columns.Add("Password");
            dt.Columns.Add("Account Status");


            var repo = new UserRepository();
            var usr = repo.GetUsers();

            foreach (var item in usr)
            {
                var row = dt.NewRow();

                row["ID"] = item.id;
                row["Branch"] = item.branch;
                row["Role Type"] = item.role;
                row["UserName"] = item.userName;
                row["Firast Name"] = item.firstName;
                row["Last Name"] = item.lastName;
                row["DOB"] = item.dob;
                row["Age"] = item.age;
                row["Mobile"] = item.mobile;
                row["Email"] = item.email;
                row["Password"] = item.password;
                

                if (item.isActive == true)
                {
                    row["Account Status"] = "Active";
                }
                else
                {
                    row["Account Status"] = "InActive";
                }
                dt.Rows.Add(row);
            }

            this.userDetails_datagrid.DataSource = dt;

        }

            //To add New or update existing user
        private void btn_save_Click(object sender, EventArgs e)
        {
            UserModel usr = new UserModel();

            usr.id = this.usrId;

            if (cmb_userStoreId.SelectedItem != null && cmb_userType.SelectedItem != null)
            {
                int x = int.Parse(cmb_userStoreId.SelectedValue.ToString());
                usr.storeId = x;
                int y = int.Parse(cmb_userType.SelectedValue.ToString());
                usr.roleId = y;
            }
            else if (usrId != 0)
            {
                usr.id = this.usrId;
            }

            usr.userName = this.txt_userUName.Text;
            usr.firstName = this.txt_userFirstName.Text;
            usr.lastName = this.txt_userLastName.Text;
            usr.dob = this.dtp_userDOB.Value;

            //Method To Calculate AGE
            int AgeInYears(DateTime userDOB)
            {
                DateTime now = DateTime.Today;
                int age = now.Year - userDOB.Year;
                if (userDOB.AddYears(age) > now) age--;
                return age;
            }
            usr.age = AgeInYears(usr.dob);

            usr.mobile = this.txt_userMobile.Text;
            usr.email = this.txt_userEmail.Text;

            if (cmb_userIsAccountActive.Text == "Active")
            {
                usr.isActive = true;
            }
            else if (cmb_userIsAccountActive.Text == "InActive")
            {
                usr.isActive = false;
            }
           

            var repo = new UserRepository();

            if (usr.id == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Add This New User?", "Add New User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                if (this.txt_userPassword.Text == this.txt_userConfirmPassword.Text)
                {
                    usr.password = this.txt_userPassword.Text;
                    repo.CreateUser(usr);

                    //To Refresh the table with newly added record
                    ReadUser();
                    cmb_userStoreId.SelectedValue = 0;
                    cmb_userType.SelectedValue = 0;

                    txt_userUName.Clear();
                    txt_userFirstName.Clear();
                    txt_userLastName.Clear();
                    dtp_userDOB.Value = DateTime.Now;
                    txt_userMobile.Clear();
                    txt_userEmail.Clear();
                    txt_userPassword.Clear();
                    txt_userConfirmPassword.Clear();

                    
                }
                else
                {
                    MessageBox.Show("The Entered Password does not match with the Confirm Password.");
                }
                

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Update This Details?", "Update Existing User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (this.txt_userPassword.Text == this.txt_userConfirmPassword.Text)
                {
                    usr.password = this.txt_userPassword.Text;
                    repo.UpdateUser(usr);

                    //To Refresh the table with newly added record
                    ReadUser();
                    cmb_userStoreId.SelectedValue = 0;
                    cmb_userType.SelectedValue = 0;

                    txt_userUName.Clear();
                    txt_userFirstName.Clear();
                    txt_userLastName.Clear();
                    dtp_userDOB.Value = DateTime.Now;
                    txt_userMobile.Clear();
                    txt_userEmail.Clear();
                    txt_userPassword.Clear();
                    txt_userConfirmPassword.Clear();


                }
                else
                {
                    MessageBox.Show("The Entered Password does not match with the Confirm Password.");

                }
            }



        }



        private void UserDetails_Load(object sender, EventArgs e)
        {
            //Code for loading details on ComboBox Role
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sql_usrTyp = "select * from Role";
                    //cmb_customerBranch.Items.Clear(); // Clear existing items
                    using (SqlCommand cmd_usrTyp = new SqlCommand(sql_usrTyp, con))
                    {
                        SqlDataAdapter da_usrTyp = new SqlDataAdapter(cmd_usrTyp);
                        DataTable dt_usrTyp = new DataTable();
                        da_usrTyp.Fill(dt_usrTyp);

                        //setting default value to ComboBox
                        DataRow itemRow = dt_usrTyp.NewRow();
                        itemRow[1] = "Select Role";
                        dt_usrTyp.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_userType.DataSource = dt_usrTyp;
                        //Branch is displayed on dropdown
                        cmb_userType.DisplayMember = "RoleType";
                        //ID is rememberd to use later
                        cmb_userType.ValueMember = "RoleID";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Connection Error: {ex.Message}");
            }

            //Combobox Role Code Ends Here

            //Code for loading details on ComboBox Branch
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sql_branch = "select ID, Branch from Store";
                    //cmb_customerBranch.Items.Clear(); // Clear existing items
                    using (SqlCommand cmd_branch = new SqlCommand(sql_branch, con))
                    {
                        SqlDataAdapter da_branch = new SqlDataAdapter(cmd_branch);
                        DataTable dt_branch = new DataTable();
                        da_branch.Fill(dt_branch);

                        //setting default value to ComboBox
                        DataRow itemRow = dt_branch.NewRow();
                        itemRow[1] = "Select Branch";
                        dt_branch.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_userStoreId.DataSource = dt_branch;
                        //Branch is displayed on dropdown
                        cmb_userStoreId.DisplayMember = "Branch";
                        //ID is rememberd to use later
                        cmb_userStoreId.ValueMember = "ID";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Connection Error: {ex.Message}");
            }

            //Combobox Branch Code Ends Here
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var val = this.userDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int usrId = int.Parse(val);

            var repo = new UserRepository();
            var usr = repo.GetUser(usrId);

            if (usr == null) return;

            this.UpdateUser(usr);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var val = this.userDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int usrId = int.Parse(val);

            //Showing Confirmation Dialog
            DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Delete This Record?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new UserRepository();
            repo.DeleteUser(usrId);

            //Update the Data Grid
            ReadUser();
        }
    }
}
