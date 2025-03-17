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
    public class OrderItemRepository
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //To load Orders items to Bill Data Grid
        public List<OrderItemsModel> GetOrderItems(int ordId)
        {
            var orderItems = new List<OrderItemsModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT o.*, b.Title FROM OrderItems o INNER JOIN Books b ON o.BookId = b.ID WHERE OrdId=@ordId ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ordId", ordId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrderItemsModel ordItm = new OrderItemsModel();
                                ordItm.id = reader.GetInt32(0);
                                ordItm.ordId = reader.GetInt32(1);
                                ordItm.bookId = reader.GetInt32(2);
                                ordItm.qty = reader.GetInt32(3);
                                ordItm.price = reader.GetDecimal(4);
                                ordItm.tot = reader.GetDecimal(5);
                                ordItm.title = reader.GetString(6);


                                orderItems.Add(ordItm);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Read Data To Data Grid Bill Items Order Error : " + ex.ToString());
            }
            return orderItems;
        }

        //To Create New Order Item Record
        public void CreateNewOrderItem(OrderItemsModel ordItm)
        {
            int ordId = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                        string sqlOrdId = "SELECT IDENT_CURRENT('Orders') + 1";
                        using (SqlCommand cmdOrdId = new SqlCommand(sqlOrdId, con))
                        {
                            ordId = Convert.ToInt32(cmdOrdId.ExecuteScalar());
                        }
                    


                    string sql = "INSERT INTO OrderItems " +
                         "(OrdId, BookId, Ord_qty, Price, Total) VALUES " +
                         "(@ordId, @bookId, @ordQty, @price, @total);";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ordId", ordId);
                        cmd.Parameters.AddWithValue("@bookId", ordItm.bookId);
                        cmd.Parameters.AddWithValue("@ordQty", ordItm.qty);
                        cmd.Parameters.AddWithValue("@price", ordItm.price);
                        cmd.Parameters.AddWithValue("@total", ordItm.tot);


                        cmd.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Order Items error" + ex.ToString());
            }
        }

        //Delete an Existing Order Item
        public void DeleteOrderItem(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "DELETE FROM OrderItems WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Delete Order Item : " + ex.ToString());
            }
        }
    }
}
