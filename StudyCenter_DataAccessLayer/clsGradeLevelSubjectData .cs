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
    public class clsGradeLevelSubjectData
    {
        public static bool GetInfoByID(int? gradeLevelSubjectID, ref int gradeLevelID, ref int subjectID, ref string title, ref decimal fees)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelSubjectInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelSubjectID", (object)gradeLevelSubjectID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                gradeLevelID = (int)reader["GradeLevelID"];
                                subjectID = (int)reader["SubjectID"];
                                title = reader["Title"] as string;
                                fees = (decimal)reader["Fees"];
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

        public static int? Add(int gradeLevelID, int subjectID, string title, decimal fees)
        {
            int? gradeLevelSubjectID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewGradeLevelSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@SubjectID", subjectID);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Fees", fees);

                        SqlParameter outputIdParam = new SqlParameter("@NewGradeLevelSubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        gradeLevelSubjectID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return gradeLevelSubjectID;
        }

        public static bool Update(int gradeLevelSubjectID, int gradeLevelID, int subjectID, string title, decimal fees)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateGradeLevelSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);
                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@SubjectID", subjectID);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Fees", fees);

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

        public static bool Delete(int? gradeLevelSubjectID)
            => clsDataAccessHelper.Delete("SP_DeleteGradeLevelSubject", "GradeLevelSubjectID", gradeLevelSubjectID);

        public static bool Exists(int? gradeLevelSubjectID)
            => clsDataAccessHelper.Exists("SP_DoesGradeLevelSubjectExistByID", "GradeLevelSubjectID", gradeLevelSubjectID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllGradeLevelSubjects");


        public static bool GenerateTitle(int? gradeLevelID, int? subjectID, out string title)
        {
            title = string.Empty;
            bool isSuccessful = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GenerateGradeLevelSubjectTitle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@SubjectID", subjectID);

                        SqlParameter titleParam = new SqlParameter("@Title", SqlDbType.NVarChar, 255)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(titleParam);

                        command.ExecuteNonQuery();

                        title = titleParam.Value?.ToString();
                        isSuccessful = !string.IsNullOrEmpty(title);
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return isSuccessful;
        }

        public static bool CheckIfTitleExists(string title)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_CheckIfTitleExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    command.Parameters.AddWithValue("@Title", title);

                    // Output parameter
                    SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(existsParam);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    // Retrieve the output parameter value
                    exists = (bool)existsParam.Value;
                }
            }

            return exists;
        }

        public static DataTable GetAllGradeLevelSubjectsWithNames()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllGradeLevelSubjectsWithNames", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return dt;
        }


    }
}

