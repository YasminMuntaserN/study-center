using Microsoft.Data.SqlClient;
using StudyCenter_DataAccessLayer.Global_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter_DataAccessLayer
{
    public class clsGradeLevelData
    {
        public static bool GetInfoByID(int? gradeLevelID, ref string GradeLevelName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", (object)gradeLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                GradeLevelName = (string)reader["GradeLevelName"];
                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
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

        public static byte? Add(string GradeLevelName)
        {
            // This function will return the new person id if succeeded and null if not
            byte? gradeLevelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelName", GradeLevelName);

                        SqlParameter outputIdParam = new SqlParameter("@NewGradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        gradeLevelID = (byte?)(int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return gradeLevelID;
        }

        public static bool Update(int gradeLevelID, string GradeLevelName)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@GradeLevelName", GradeLevelName);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return (rowAffected > 0);
        }

        public static bool Delete(int? gradeLevelID)
            => clsDataAccessHelper.Delete("SP_DeleteGradeLevel", "GradeLevelID", gradeLevelID);

        public static bool Exists(int? gradeLevelID)
            => clsDataAccessHelper.Exists("SP_DoesGradeLevelExistByGradeLevelID", "GradeLevelID", gradeLevelID);

        public static bool Exists(string GradeLevelName)
            => clsDataAccessHelper.Exists("SP_DoesGradeLevelExistByGradeLevelName", "GradeLevelName", GradeLevelName);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllGradeLevels");


        public static DataTable AllGradeLevelNames()
            => clsDataAccessHelper.All("SP_GetAllGradeLevelNames");

        public static string GetGradeLevelName(int? gradeLevelID)
        {
            // This function will return the new person id if succeeded and null if not
            string GradeLevelName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);

                        SqlParameter outputIdParam = new SqlParameter("@GradeName", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        GradeLevelName = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return GradeLevelName;
        }

        public static int? GetGradeLevelID(string GradeLevelName)
        {
            int? gradeLevelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelName", GradeLevelName);

                        SqlParameter outputIdParam = new SqlParameter("@GradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        gradeLevelID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return gradeLevelID;
        }

        public static int Count()
          => clsDataAccessHelper.Count("SP_GetGradeLevelCount");
    }
}
