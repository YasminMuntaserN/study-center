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

    public static class clsClassesDAL
    {
        public static bool GetInfoByID(int? classID, ref string className, ref byte? capacity)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetClassInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ClassID", (object)classID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                className = reader["ClassName"] as string;
                                capacity = reader["Capacity"] as byte?;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsErrorLogger.LogError(ex);
            }

            return isFound;
        }

        public static bool GetInfoByName(string className, ref int? classID,  ref byte? capacity)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetClassInfoByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ClassName", className);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                classID = reader["classID"] as int?; 
                                capacity = reader["Capacity"] as byte?;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsErrorLogger.LogError(ex);
            }

            return isFound;
        }

        public static int? Add(string className, byte? capacity)
        {
            int? classID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ClassName", className);
                        command.Parameters.AddWithValue("@Capacity", (object)capacity ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewClassID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        classID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return classID;
        }

        public static bool Update(int classID, string className, byte? capacity)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@ClassName", className);
                        command.Parameters.AddWithValue("@Capacity", (object)capacity ?? DBNull.Value);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return rowAffected > 0;
        }

        public static bool Delete(int? classID)
            => clsDataAccessHelper.Delete("SP_DeleteClass", "ClassID", classID);

        public static bool Exists(int? classID)
            => clsDataAccessHelper.Exists("SP_DoesClassExistByID", "ClassID", classID);

        public static bool Exists(string className)
            => clsDataAccessHelper.Exists("SP_DoesClassExistByClassName", "className", className);
    
        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllClasses");
    }
}
