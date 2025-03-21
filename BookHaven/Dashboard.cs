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
    public partial class Dashboard : Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Dashboard()
        {
            InitializeComponent();
        }

        string role = "Sales Clark";
        public Dashboard(string Role)
        {
            InitializeComponent();

            role = Role;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (role == "Sales Clark")
            {
                pnl_urs.Hide();
            }
            LoadCustomerCounts();
            LoadOrderCounts();
            LoadInventoryCounts();
            LoadUsersCounts();
        }

        //Loading Customer Count
        private void LoadCustomerCounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql = @"
                             SELECT 
                             SUM(CASE WHEN isActive = 1 THEN 1 ELSE 0 END) AS ActiveCustomers,
                             SUM(CASE WHEN isActive = 0 THEN 1 ELSE 0 END) AS InactiveCustomers
                             FROM Customer";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_CstmrActive.Text = reader["ActiveCustomers"].ToString();
                            lbl_CstmrInActive.Text = reader["InactiveCustomers"].ToString();
                        }
                    }
                }
            }
        }

        //Loading Orders Count
        private void LoadOrderCounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql = @"
                            SELECT 
                                COUNT(CASE WHEN CAST(Created_At AS DATE) = CAST(GETDATE() AS DATE) THEN 1 END) AS OrdersToday,
                                COUNT(CASE WHEN Created_At >= DATEADD(DAY, -30, GETDATE()) THEN 1 END) AS OrdersLast30Days
                            FROM Orders";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_ordToday.Text = reader["OrdersToday"].ToString();
                            lbl_ord30d.Text = reader["OrdersLast30Days"].ToString();
                        }
                    }
                }
            }
        }

        //Loading Inventory Count
        private void LoadInventoryCounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql = @"
                            SELECT 
                                COUNT(CASE WHEN Qty < 5 THEN 1 END) AS LowStock,
                                COUNT(CASE WHEN Qty > 20 THEN 1 END) AS HighStock
                            FROM Books";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_lowStock.Text = reader["LowStock"].ToString();
                            lbl_highStock.Text = reader["HighStock"].ToString();
                        }
                    }
                }
            }
        }

        //Loading Users Count
        private void LoadUsersCounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql = @"
                            SELECT 
                                COUNT(CASE WHEN IsActive = 1 THEN 1 END) AS ActiveUsers,
                                COUNT(CASE WHEN IsActive = 0 THEN 1 END) AS InactiveUsers
                            FROM Users";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_usrActive.Text = reader["ActiveUsers"].ToString();
                            lbl_usrInActive.Text = reader["InactiveUsers"].ToString();
                        }
                    }
                }
            }
        }
    }
}

