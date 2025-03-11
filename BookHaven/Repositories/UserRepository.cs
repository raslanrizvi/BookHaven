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
    public class UserRepository
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //To load User to Data Grid
        public List<UserModel> GetUsers()
        {
            var user = new List<UserModel>();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT u.*, s.Branch, r.RoleType FROM ((Users u INNER JOIN Store s ON u.StoreID=s.ID) INNER JOIN Role r ON u.RoleID=r.RoleID) ORDER BY ID DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserModel usr = new UserModel();
                                usr.id = reader.GetInt32(0);
                                usr.storeId = reader.GetInt32(1);
                                usr.roleId = reader.GetInt32(2);
                                usr.userName = reader.GetString(3);
                                usr.firstName = reader.GetString(4);
                                usr.lastName = reader.GetString(5);
                                usr.dob = reader.GetDateTime(6);
                                usr.age = reader.GetInt32(7);
                                usr.mobile = reader.GetString(8);
                                usr.email = reader.GetString(9);
                                usr.password = reader.GetString(10);
                                usr.isActive = reader.GetBoolean(11);
                                usr.branch = reader.GetString(12);
                                usr.role = reader.GetString(13);

                                user.Add(usr);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return user;
        }

        //To Check for Specific User
        public UserModel GetUser(int id)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Users WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                UserModel usr = new UserModel();
                                usr.id = reader.GetInt32(0);
                                usr.storeId = reader.GetInt32(1);
                                usr.roleId = reader.GetInt32(2);
                                usr.userName = reader.GetString(3);
                                usr.firstName = reader.GetString(4);
                                usr.lastName = reader.GetString(5);
                                usr.dob = reader.GetDateTime(6);
                                usr.age = reader.GetInt32(7);
                                usr.mobile = reader.GetString(8);
                                usr.email = reader.GetString(9);
                                usr.password = reader.GetString(10);
                                usr.isActive = reader.GetBoolean(11);

                                return usr;
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

        //To Create New User Record
        public void CreateUser(UserModel usr)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "INSERT INTO Users " +
                                 "(StoreID, RoleID, UserName, FirstName, LastName, DOB, Age, Mobile, Email, Password, IsActive) VALUES " +
                                 "(@storeId, @roleId, @userName, @firstName, @lastName, @dob, @age, @mobile, @email, @password, @isActive);";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@storeId", usr.storeId);
                        cmd.Parameters.AddWithValue("@roleId", usr.roleId);
                        cmd.Parameters.AddWithValue("@userName", usr.userName);
                        cmd.Parameters.AddWithValue("@firstName", usr.firstName);
                        cmd.Parameters.AddWithValue("@lastName", usr.lastName);
                        cmd.Parameters.AddWithValue("@dob", usr.dob);
                        cmd.Parameters.AddWithValue("@age", usr.age);
                        cmd.Parameters.AddWithValue("@mobile", usr.mobile);
                        cmd.Parameters.AddWithValue("@email", usr.email);
                        cmd.Parameters.AddWithValue("@password", usr.password);
                        cmd.Parameters.AddWithValue("@isActive", usr.isActive);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New User " + usr.userName + " Added Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show("New User " + usr.userName + " Was Not Added!" + ex.ToString());
            }
        }

        //Update Existing User Information
        public void UpdateUser(UserModel usr)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "UPDATE Users " +
                                 "SET StoreID=@storeId, RoleID=@roleId, UserName=@userName, FirstName=@firstName, LastName=@lastName, DOB=@dob, Age=@age, Mobile=@mobile, Email=@email, Password=@password, IsActive=@isActive " +
                                 "WHERE ID=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", usr.id);
                        cmd.Parameters.AddWithValue("@storeId", usr.storeId);
                        cmd.Parameters.AddWithValue("@roleId", usr.roleId);
                        cmd.Parameters.AddWithValue("@userName", usr.userName);
                        cmd.Parameters.AddWithValue("@firstName", usr.firstName);
                        cmd.Parameters.AddWithValue("@lastName", usr.lastName);
                        cmd.Parameters.AddWithValue("@dob", usr.dob);
                        cmd.Parameters.AddWithValue("@age", usr.age);
                        cmd.Parameters.AddWithValue("@mobile", usr.mobile);
                        cmd.Parameters.AddWithValue("@email", usr.email);
                        cmd.Parameters.AddWithValue("@password", usr.password);
                        cmd.Parameters.AddWithValue("@isActive", usr.isActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        //Delete an Existing User
        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "DELETE FROM Users WHERE ID=@id";

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
