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
    }
}
