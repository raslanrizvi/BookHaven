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
                                 "(EmpId, CustId, OrdType, PytMethod, Total, PayAmt, Status, Created_At, Discount, DeliveryFree) VALUES " +
                                 "(@empId, @custId, @ordType, @pytMethod, @total, @payAmt, @status, @createdAt, @discount, @deliveryFree);";

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
                        cmd.Parameters.AddWithValue("@discount", ord.discount);
                        cmd.Parameters.AddWithValue("@deliveryFree", ord.deliveryFree);


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

        //To load Orders to Data Grid
        public List<OrdersModel> GetOrders()
        {
            var orders = new List<OrdersModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Orders ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrdersModel ord = new OrdersModel();
                                ord.ordId = reader.GetInt32(0);
                                ord.empId = reader.GetInt32(1);
                                ord.custId = reader.GetInt32(2);
                                ord.ordType = reader.GetString(3);
                                ord.pytMethod = reader.GetString(4);
                                ord.tot = reader.GetDecimal(5);
                                ord.payAmt = reader.GetDecimal(6);
                                ord.status = reader.GetString(7);
                                ord.cretedAt = reader.GetDateTime(8);
                                ord.discount = reader.GetDecimal(9);
                                ord.deliveryFree = reader.GetBoolean(10);



                                orders.Add(ord);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Read Data To Data Grid Order Management Error : " + ex.ToString());
            }
            return orders;
        }

        //To Check for Specific Order
        public OrdersModel GetOrder(int id)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Orders WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                OrdersModel ord = new OrdersModel();
                                ord.ordId = reader.GetInt32(0);
                                ord.empId = reader.GetInt32(1);
                                ord.custId = reader.GetInt32(2);
                                ord.ordType = reader.GetString(3);
                                ord.pytMethod = reader.GetString(4);
                                ord.tot = reader.GetDecimal(5);
                                ord.payAmt = reader.GetDecimal(6);
                                ord.status = reader.GetString(7);
                                ord.cretedAt = reader.GetDateTime(8);
                                ord.discount = reader.GetDecimal(9);
                                ord.deliveryFree = reader.GetBoolean(10);

                                return ord;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Load Order Details to Update Error : " + ex.ToString());
            }

            return null;
        }

        //Update Existing Order Information
        public void UpdateOrder(OrdersModel ord)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "UPDATE Orders " +
                                 "SET OrdType=@ordType, PytMethod=@pytMethod, Total=@total, PayAmt=@payAmt, Status=@status, Created_At=@createdAt, Discount=@discount, DeliveryFree=@deliveryFree " +
                                 "WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", ord.ordId);
                        cmd.Parameters.AddWithValue("@ordType", ord.ordType);
                        cmd.Parameters.AddWithValue("@pytMethod", ord.pytMethod);
                        cmd.Parameters.AddWithValue("@total", ord.tot);
                        cmd.Parameters.AddWithValue("@payAmt", ord.payAmt);
                        cmd.Parameters.AddWithValue("@status", ord.status);
                        cmd.Parameters.AddWithValue("@createdAt", ord.cretedAt);
                        cmd.Parameters.AddWithValue("@discount", ord.discount);
                        cmd.Parameters.AddWithValue("@deliveryFree", ord.deliveryFree);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Update Information To order : " + ex.ToString());
            }
        }

        //Delete an Existing Order
        public void DeleteOrder(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "DELETE FROM Orders WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Delete Order : " + ex.ToString());
            }
        }
    }
}
