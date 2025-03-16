using BookHaven.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookHaven.Repositories
{
    public class OrderRepository
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //To Create New Inventory Record
        public void CreateNewOrder(OrdersModel ord)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "INSERT INTO Orders " +
                                 "(EmpId, CustId, OrdType, PytMethod, Total, PayAmt, Status, Created_At) VALUES " +
                                 "(@empId, @custId, @ordType, @pytMethod, @total, @payAmt, @status, @createdAt);";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@empId", ord.empId);
                        cmd.Parameters.AddWithValue("@custId", ord.custId);
                        cmd.Parameters.AddWithValue("@ordType", ord.ordType);
                        cmd.Parameters.AddWithValue("@pytMethod", ord.pytMethod);
                        cmd.Parameters.AddWithValue("@total", ord.tot);
                        cmd.Parameters.AddWithValue("@payAmt", ord.payAmt);
                        cmd.Parameters.AddWithValue("@status", ord.status);
                        cmd.Parameters.AddWithValue("@createdAt", ord.cretedAt);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New Order Created Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("New Order Was Not Created!" + ex.ToString());
            }
        }
    }
}
