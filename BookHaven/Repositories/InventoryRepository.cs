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
    public class InventoryRepository
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //To load Inventory to Data Grid
        public List<InventoryModel> GetInventories()
        {
            var inventories = new List<InventoryModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT b.*, s.Name, g.Genre FROM ((Books b INNER JOIN Supplier s ON b.supID = s.ID) INNER JOIN BookGenre g ON b.GenreID = g.ID) ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InventoryModel inv = new InventoryModel();
                                inv.id = reader.GetInt32(0);
                                inv.supId = reader.GetInt32(1);
                                inv.supName = reader.GetString(9);
                                inv.genreId = reader.GetInt32(2);
                                inv.genre = reader.GetString(10);
                                inv.title = reader.GetString(3);
                                inv.isbn = reader.GetString(4);
                                inv.author = reader.GetString(5);
                                inv.qty = reader.GetInt32(6);
                                inv.costPrice = reader.GetDecimal(7);
                                inv.sellPrice = reader.GetDecimal(8);
                                

                                inventories.Add(inv);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: DataGrid " + ex.ToString());
            }
            return inventories;
        }

        //TO Search for Inventories
        public List<InventoryModel> SearchInventories(string txtSearch)
        {
            var inventory = new List<InventoryModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT b.*, s.Name, g.Genre FROM ((Books b INNER JOIN Supplier s ON b.supID=s.ID) INNER JOIN BookGenre g ON b.GenreID=g.ID) WHERE Title LIKE @title OR ISBN LIKE @isbn OR Author LIKE @author OR Genre LIKE @genre OR Name LIKE @name ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@title", string.Format("%{0}%", txtSearch));
                        cmd.Parameters.AddWithValue("@isbn", string.Format("%{0}%", txtSearch));
                        cmd.Parameters.AddWithValue("@author", string.Format("%{0}%", txtSearch));
                        cmd.Parameters.AddWithValue("@genre", string.Format("%{0}%", txtSearch));
                        cmd.Parameters.AddWithValue("@name", string.Format("%{0}%", txtSearch));
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                InventoryModel inv = new InventoryModel();
                                inv.id = reader.GetInt32(0);
                                inv.supId = reader.GetInt32(1);
                                inv.supName = reader.GetString(9);
                                inv.genreId = reader.GetInt32(2);
                                inv.genre = reader.GetString(10);
                                inv.title = reader.GetString(3);
                                inv.isbn = reader.GetString(4);
                                inv.author = reader.GetString(5);
                                inv.qty = reader.GetInt32(6);
                                inv.costPrice = reader.GetDecimal(7);
                                inv.sellPrice = reader.GetDecimal(8);

                                inventory.Add(inv);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Search Inventory Details Error : " + ex.ToString());
            }

            return inventory;
        }

        //To Check for Specific Inventory
        public InventoryModel GetInventory(int id)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Books WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                InventoryModel inv = new InventoryModel();
                                inv.id = reader.GetInt32(0);
                                inv.supId = reader.GetInt32(1);
                                //inv.supName = reader.GetString(9);
                                inv.genreId = reader.GetInt32(2);
                               // inv.genre = reader.GetString(10);
                                inv.title = reader.GetString(3);
                                inv.isbn = reader.GetString(4);
                                inv.author = reader.GetString(5);
                                inv.qty = reader.GetInt32(6);
                                inv.costPrice = reader.GetDecimal(7);
                                inv.sellPrice = reader.GetDecimal(8);

                                return inv;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return null;
        }

        //To Create New Inventory Record
        public void CreateInventory(InventoryModel inv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "INSERT INTO Books " +
                                 "(supID, GenreID, Title, ISBN, Author, Qty, CostPrice, SellPrice) VALUES " +
                                 "(@supId, @genreId, @title, @isbn, @author, @qty, @costPrice, @sellPrice);";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@supId", inv.supId);
                        cmd.Parameters.AddWithValue("@genreId", inv.genreId);
                        cmd.Parameters.AddWithValue("@title", inv.title);
                        cmd.Parameters.AddWithValue("@isbn", inv.isbn);
                        cmd.Parameters.AddWithValue("@author", inv.author);
                        cmd.Parameters.AddWithValue("@qty", inv.qty);
                        cmd.Parameters.AddWithValue("@costPrice", inv.costPrice);
                        cmd.Parameters.AddWithValue("@sellPrice", inv.sellPrice);
                        

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New Book " + inv.title + " Added Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("New Book " + inv.title + " Was Not Added!" + ex.ToString());
            }
        }

        //Update Existing Inventory Information
        public void UpdateInventory(InventoryModel inv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "UPDATE Books " +
                                 "SET supID=@supId, GenreID=@genreId, Title=@title, ISBN=@isbn, Author=@author, Qty=@qty, CostPrice=@costPrice, SellPrice=@sellPrice " +
                                 "WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", inv.id);
                        cmd.Parameters.AddWithValue("@supId", inv.supId);
                        cmd.Parameters.AddWithValue("@genreId", inv.genreId);
                        cmd.Parameters.AddWithValue("@title", inv.title);
                        cmd.Parameters.AddWithValue("@isbn", inv.isbn);
                        cmd.Parameters.AddWithValue("@author", inv.author);
                        cmd.Parameters.AddWithValue("@qty", inv.qty);
                        cmd.Parameters.AddWithValue("@costPrice", inv.costPrice);
                        cmd.Parameters.AddWithValue("@sellPrice", inv.sellPrice);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        //Delete an Existing Inventory
        public void DeleteInventory(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "DELETE FROM Books WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

    }
}
