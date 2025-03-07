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
    public class CustomerRepository
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //To load customers to Data Grid
        public List<CustomerModel> GetCustomers()
        {
            var customers = new List<CustomerModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Customer ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CustomerModel cstmr = new CustomerModel();
                                cstmr.id = reader.GetInt32(0);
                                cstmr.StoreID = reader.GetInt32(1);
                                cstmr.name = reader.GetString(2);
                                cstmr.nic = reader.GetString(3);
                                cstmr.address = reader.GetString(4);
                                cstmr.mobile = reader.GetString(5);
                                cstmr.email = reader.GetString(6);
                                cstmr.isActive = reader.GetBoolean(7);

                                customers.Add(cstmr);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
                return customers;
        }

        //To Check for Specific Customer
        public CustomerModel GetCustomer(int id)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Customer WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerModel cstmr = new CustomerModel();
                                cstmr.id = reader.GetInt32(0);
                                cstmr.StoreID = reader.GetInt32(1);
                                cstmr.name = reader.GetString(2);
                                cstmr.nic = reader.GetString(3);
                                cstmr.address = reader.GetString(4);
                                cstmr.mobile = reader.GetString(5);
                                cstmr.email = reader.GetString(6);
                                cstmr.isActive = reader.GetBoolean(7);

                                return cstmr;
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

        //To Create New Customer Record
        public void CreateCustomer(CustomerModel cstmr)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "INSERT INTO Customer " +
                                 "(StoreID, Name, NIC, Address, Mobile, Email, isActive) VALUES " +
                                 "(@storeId, @name, @nic, @address, @mobile, @email, @isActive);";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@storeId", cstmr.StoreID);
                        cmd.Parameters.AddWithValue("@name", cstmr.name);
                        cmd.Parameters.AddWithValue("@nic", cstmr.nic);
                        cmd.Parameters.AddWithValue("@address", cstmr.address);
                        cmd.Parameters.AddWithValue("@mobile", cstmr.mobile);
                        cmd.Parameters.AddWithValue("@email", cstmr.email);
                        cmd.Parameters.AddWithValue("@isActive", cstmr.isActive);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New Customer " + cstmr.name + " Added Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show("New Customer " + cstmr.name + " Was Not Added!" + ex.ToString());
            }
        }

        //Update Existing Customer Information
        public void UpdateCustomer(CustomerModel cstmr)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "UPDATE Customer " +
                                 "SET Name=@name, NIC=@nic, Address=@address, Mobile=@mobile, Email=@email, IsActive=@isActive " +
                                 "WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", cstmr.id);
                        cmd.Parameters.AddWithValue("@name", cstmr.name);
                        cmd.Parameters.AddWithValue("@nic", cstmr.nic);
                        cmd.Parameters.AddWithValue("@address", cstmr.address);
                        cmd.Parameters.AddWithValue("@mobile", cstmr.mobile);
                        cmd.Parameters.AddWithValue("@email", cstmr.email);
                        cmd.Parameters.AddWithValue("@isActive", cstmr.isActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
        
        //Delete an Existing Customer
        public void DeleteCustomer(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "DELETE FROM Customer WHERE ID=@id";

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
