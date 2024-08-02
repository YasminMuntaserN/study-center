using Microsoft.Data.SqlClient;
using StudyCenter_DataAccessLayer.Global_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter_DAL_
{
    public class clsUserData
    {
        public static int? Add(int? personID, string userName, string password, bool isActive)
        {
            int? NewUserID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID.HasValue ? (object)personID.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        NewUserID = outputIdParam.Value != DBNull.Value ? (int?)outputIdParam.Value : null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (implement logging as per your requirements)
                Console.WriteLine(ex.Message);
            }

            return NewUserID;
        }


        public static bool Update(int userID, int? personID, string userName, string password, bool isActive)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (implement logging as per your requirements)
                Console.WriteLine(ex.Message);
            }

            return rowsAffected > 0;
        }

        public static bool Delete(int userID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", userID);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (implement logging as per your requirements)
                Console.WriteLine(ex.Message);
            }

            return rowsAffected > 0;
        }

        public static bool GetInfoByID(int? userID, ref int? personID, ref string userName, ref string password, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                personID = reader["PersonID"] as int?;
                                userName = reader["UserName"] as string;
                                password = reader["Password"] as string;
                                isActive = (bool)reader["IsActive"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (implement logging as per your requirements)
                Console.WriteLine(ex.Message);
            }

            return isFound;
        }

        public static bool GetInfoByPersonID(int? personID, ref int? userID, ref string userName, ref string password, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                userID = reader["UserID"] as int?;
                                userName = reader["UserName"] as string;
                                password = reader["Password"] as string;
                                isActive = (bool)reader["IsActive"]  ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (implement logging as per your requirements)
                Console.WriteLine(ex.Message);
            }

            return isFound;
        }

        public static bool GetInfoByUserNameAndPassword( string UserName,  string password, ref int? userID, ref int? personID,  ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByIserNameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", password);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                userID = reader["UserID"] as int?;
                                personID = reader["PersonID"] as int?;
                                isActive = (bool)reader["IsActive"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (implement logging as per your requirements)
                Console.WriteLine(ex.Message);
            }

            return isFound;
        }

        public static bool Exists(int userID) => clsDataAccessHelper.Exists("SP_DoesUserExistByID", "UserID", userID);

        public static bool DoesUserExist(string UserName) => clsDataAccessHelper.Exists("SP_DoesUserExistByUserName", "UserName", UserName);
       
        public static bool DoesUserExist(string UserName, string Password)
         => clsDataAccessHelper.Exists("SP_DoesUserExistByUserNameAndPassword", "Password", Password, "UserName", UserName);
  
        public static DataTable All() => clsDataAccessHelper.All("SP_GetAllUsers");

        public static bool IsPersonUser(int? PersonID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_IsPersonUser", connection))
                    {
                        // Set the command type to StoredProcedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the input parameter for PersonID
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        // Add the output parameter for IsStudent
                        SqlParameter outputParam = new SqlParameter("@IsUser", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        command.ExecuteNonQuery();

                        // Retrieve the output parameter value
                        bool isUser = (bool)outputParam.Value;

                        return isUser;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static int Count() => clsDataAccessHelper.Count("SP_GetUsersCount");

        public static DataTable GetUsersByPage(int pageNumber, int pageSize)
          => clsDataAccessHelper.All("SP_UsersByPage", "PageNumber", pageNumber
             , "PageSize", pageSize);

    }
}
