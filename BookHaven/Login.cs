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
                    SqlCommand cmd = new SqlCommand("select * from Users inner join Role on Users.Role = Role.RoleID where UserName = @userName and Password = @password", con);
                    cmd.Parameters.AddWithValue("@userName", txtb_userName.Text);
                    cmd.Parameters.AddWithValue("@password", txtb_password.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        String userID = dt.Rows[0][0].ToString();
                        string roleType = dt.Rows[0][13].ToString();
                        string firstName = dt.Rows[0][4].ToString();
                        string lastName = dt.Rows[0][5].ToString();

                        string name = firstName + " " + lastName;

                        MainPageDetails mpd = new MainPageDetails(userID, roleType, name);
                        this.Hide();
                        mpd.Show();
                        
                    }
                    else
                    {
                        lbl_errorMsg.Text = "Invalid Login Details";
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
