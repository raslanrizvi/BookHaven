using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookHaven.Models;
using System.Windows;

namespace BookHaven.Repositories
{
    public class SupplierRepository
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //To load Suppliers to Data Grid
        public List<SupplierModel> GetSuppliers()
        {
            var suppliers = new List<SupplierModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT s.*, st.Type FROM Supplier s INNER JOIN SupplierType st ON s.TypeID = st.ID ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SupplierModel suplir = new SupplierModel();
                                suplir.id = reader.GetInt32(0);
                                suplir.name = reader.GetString(1);
                                suplir.typeId = reader.GetInt32(2);
                                suplir.mobile = reader.GetString(3);
                                suplir.email = reader.GetString(4);
                                suplir.address = reader.GetString(5);
                                suplir.curntStock = reader.GetInt32(6);
                                suplir.typeName = reader.GetString(7);

                                

                                suppliers.Add(suplir);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            return suppliers;
        }

        //To Check for Specific Supplier
        public SupplierModel GetSupplier(int id)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Supplier WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SupplierModel suplir = new SupplierModel();
                                suplir.id = reader.GetInt32(0);
                                suplir.name = reader.GetString(1);
                                suplir.typeId = reader.GetInt32(2);
                                suplir.mobile = reader.GetString(3);
                                suplir.email = reader.GetString(4);
                                suplir.address = reader.GetString(5);
                                suplir.curntStock = reader.GetInt32(6);

                                return suplir;
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

        //To Create New Supplier Record
        public void CreateSupplier(SupplierModel suplir)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "INSERT INTO Supplier " +
                                 "(Name, TypeID, Mobile, Email, Address, CurrentStock) VALUES " +
                                 "(@name, @typeId, @mobile, @email, @address, @currentStock);";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@name", suplir.name);
                        cmd.Parameters.AddWithValue("@typeId", suplir.typeId);
                        cmd.Parameters.AddWithValue("@mobile", suplir.mobile);
                        cmd.Parameters.AddWithValue("@email", suplir.email);
                        cmd.Parameters.AddWithValue("@address", suplir.address);
                        cmd.Parameters.AddWithValue("@currentStock", suplir.curntStock);
                        

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New Supplier " + suplir.name + " Added Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("New Supplier " + suplir.name + " Was Not Added!" + ex.ToString());
            }
        }

        //Update Existing Supplier Information
        public void UpdateSupplier(SupplierModel suplir)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "UPDATE Supplier " +
                                 "SET Name=@name, TypeID=@typeId, Mobile=@mobile, Email=@email, Address=@address, CurrentStock=@curntStock " +
                                 "WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", suplir.id);
                        cmd.Parameters.AddWithValue("@name", suplir.name);
                        cmd.Parameters.AddWithValue("@typeId", suplir.typeId);
                        cmd.Parameters.AddWithValue("@mobile", suplir.mobile);
                        cmd.Parameters.AddWithValue("@email", suplir.email);
                        cmd.Parameters.AddWithValue("@address", suplir.address);
                        cmd.Parameters.AddWithValue("@curntStock", suplir.curntStock);
                        

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        //Delete an Existing Supplier
        public void DeleteSupplier(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "DELETE FROM Supplier WHERE ID=@id";

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
