using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsAdminDataAccess
    {

        static public int AddNewAdmin(string FirstName, string LastName, byte Age, string Email, string PhoneNumber, bool IsActive,
            string UserName, string Password, int Permissions, DateTime DateJoined)
        {
            int AdminID = -1;
           using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
           {

                string query = @"INSERT INTO SystemPermissions(FirstName, LastName, Age, Email, PhoneNumber,
                UserName, Password, Permissions, IsActive, DateJoined) VALUES(@FirstName, @LastName, @Age, @Email, @PhoneNumber,
                                                        @UserName, @Password, @Permissions, @IsActive, @DateJoined)";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    Command.Parameters.AddWithValue("@FirstName", FirstName);
                    Command.Parameters.AddWithValue("@LastName", LastName);
                    Command.Parameters.AddWithValue("@Age", Age);
                    Command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                    Command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                    Command.Parameters.AddWithValue("@UserName", UserName);
                    Command.Parameters.AddWithValue("@Password", Password);
                    Command.Parameters.AddWithValue("@Permissions", (object)Permissions ?? DBNull.Value);
                    Command.Parameters.AddWithValue("@IsActive", IsActive);
                    Command.Parameters.AddWithValue("@DateJoined", DateJoined);


                    try
                    {
                        Connection.Open();

                        object result = Command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))

                            AdminID = InsertedID;
                    }
                    catch (Exception)
                    {
                    }
                }
                return AdminID;
           }
        }


        static public bool UpdateAdmin(int AdminID, string FirstName, string LastName, byte Age, string Email, string PhoneNumber, bool IsActive,
            string UserName, string Password, int Permissions, DateTime DateJoined)
        {
            int RowsEffected = 0;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Admins 
                         SET FirstName = @FirstName, 
                             LastName = @LastName, 
                             Age = @Age, 
                             Permissions = @Permissions, 
                             Username = @Username, 
                             Password = @Password, 
                             Email = @Email, 
                             PhoneNumber = @PhoneNumber, 
                             IsActive = @IsActive,
                             DateJoined = @DateJoined
                         WHERE AdminID = @AdminID;";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AdminID", AdminID);
                    Command.Parameters.AddWithValue("@FirstName", FirstName);
                    Command.Parameters.AddWithValue("@LastName", LastName);
                    Command.Parameters.AddWithValue("@Age", Age);
                    Command.Parameters.AddWithValue("@Permissions", (object)Permissions ?? DBNull.Value);
                    Command.Parameters.AddWithValue("@UserName", UserName);
                    Command.Parameters.AddWithValue("@Password", Password);
                    Command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                    Command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                    Command.Parameters.AddWithValue("@IsActive", IsActive);
                    Command.Parameters.AddWithValue("@DateJoined", DateJoined);

                    try
                    {
                        Connection.Open();
                        RowsEffected = Command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return (RowsEffected > 0);
        }

        static public DataTable GetAllAdmins()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"select * from Admins;";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();

                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }

                        Reader.Close();
                    }
                    catch (Exception)
                    {
                    }
                
                }
            }
            return dt;
        }

        static public bool GetAdminByUsernameAndPassword(ref int AdminID, ref string FirstName, ref string LastName, ref byte Age, ref string Email, ref string PhoneNumber, ref bool IsActive,
            ref string UserName, ref string Password, ref int Permissions, ref DateTime DateJoined)
        {
            bool isFound = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"select * from Admins where UserName = @UserName and Password = @Password;";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    Command.Parameters.AddWithValue("@UserName", UserName);
                    Command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();

                        if (Reader.Read())
                        {
                            isFound = true;

                            AdminID = (int)Reader["AdminID"];
                            FirstName = (string)Reader["FirstName"];
                            LastName = (string)Reader["LastName"];
                            Age = (byte)Reader["Age"];
                            Email = (string)Reader["Email"];
                            PhoneNumber = (string)Reader["PhoneNumber"];
                            IsActive = (bool)Reader["IsActive"];
                            UserName = (string)Reader["UserName"];
                            Password = (string)Reader["Password"];
                            Permissions = (short)Reader["Permissions"];
                            DateJoined = (DateTime)Reader["DateJoined"];
                        }
                        else
                        {
                            isFound = false;
                        }

                        Reader.Close();
                    }
                    catch (Exception)
                    {
                        isFound = false;
                    }

                }
            }
            return isFound;
        }

    }


}
