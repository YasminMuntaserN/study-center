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
    public class clsEnrollmentData
    {
        public static bool GetInfoByID(int? enrollmentID, ref bool isActive, ref DateTime enrollmentDate, ref DateTime? deletionDate, ref int? studentID, ref int? groupID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEnrollmentInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EnrollmentID", (object)enrollmentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                isActive = (bool)reader["IsActive"];
                                enrollmentDate = (DateTime)reader["EnrollmentDate"];
                                deletionDate = reader["DeletionDate"] as DateTime?;
                                studentID = reader["StudentID"] as int?;
                                groupID = reader["GroupID"] as int?;
                            }
                            else
                            {
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

        public static int? Add(bool isActive, DateTime enrollmentDate, DateTime? deletionDate, int? studentID, int? groupID)
        {
            int? enrollmentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewEnrollment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);
                        command.Parameters.AddWithValue("@DeletionDate", (object)deletionDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewEnrollmentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        enrollmentID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return enrollmentID;
        }

        public static bool Update(int? enrollmentID, bool isActive, DateTime enrollmentDate, DateTime? deletionDate, int? studentID, int? groupID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateEnrollment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EnrollmentID", enrollmentID);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);
                        command.Parameters.AddWithValue("@DeletionDate", (object)deletionDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return rowsAffected > 0;
        }

        public static bool Delete(int? enrollmentID)
            => clsDataAccessHelper.Delete("SP_DeleteEnrollment", "EnrollmentID", enrollmentID);

        public static bool Exists(int? enrollmentID)
            => clsDataAccessHelper.Exists("SP_DoesEnrollmentExistByEnrollmentID", "EnrollmentID", enrollmentID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllEnrollments");

        public static DataTable GetEnrollmentsByStudentID(int? studentID)
        {
            DataTable dtEnrollments = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEnrollmentsByStudentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtEnrollments);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return dtEnrollments;
        }

        public static DataTable GetEnrollmentsByGroupID(int? groupID)
        {
            DataTable dtEnrollments = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEnrollmentsByGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtEnrollments);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return dtEnrollments;
        }
    }
}