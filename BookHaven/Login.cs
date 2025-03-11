using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using POSSystem;

namespace BookHaven
{
    public partial class Login: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtb_userName.Text != "" && txtb_password.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    lbl_errorMsg.Text = "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Users inner join Role on Users.RoleID = Role.RoleID where UserName = @userName and Password = @password", con);
                    cmd.Parameters.AddWithValue("@userName", txtb_userName.Text);
                    cmd.Parameters.AddWithValue("@password", txtb_password.Text);
                    

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Boolean status = true;

                        while (reader.Read())
                        {
                             status = reader.GetBoolean(11);

                            if (status == true)
                            {
                                int userID = reader.GetInt32(0);
                                string roleType = reader.GetString(13);
                                string firstName = reader.GetString(04);
                                string lastName = reader.GetString(05);

                                string name = firstName + " " + lastName;

                                MainPageDetails mpd = new MainPageDetails(userID, roleType, name);
                                this.Hide();
                                mpd.Show();
                            }
                            

                        }
                        if (status != true)
                        {
                            lbl_errorMsg.Text = "Account InActive - Contact Admin";
                        }
                        else
                        {
                            lbl_errorMsg.Text = "Invalid Login Details";
                        }
                        
                    }

                }
            }
            else
            {
                lbl_errorMsg.Text = "Please Fill The Form!";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
