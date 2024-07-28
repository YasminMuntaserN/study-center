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
    public class clsStudentData
    {
        public static bool GetInfoByStudentID(int? studentID, ref int? personID, ref byte? gradeLevelID,
        ref int? UserID, ref string EmergencyContactPhone, ref DateTime EnrollmentDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStudentInfoByStudentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["GradeLevelID"]) : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                EnrollmentDate = (DateTime)reader["EnrollmentDate"];
                                EmergencyContactPhone = (string)reader["EmergencyContactPhone"];
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

        public static bool GetInfoByPersonID(int? personID, ref int? studentID, ref byte? gradeLevelID,
            ref int? UserID, ref string EmergencyContactPhone, ref DateTime EnrollmentDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStudentInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@personID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                studentID = (reader["studentID"] != DBNull.Value) ? (int?)reader["studentID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["GradeLevelID"]) : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                EnrollmentDate = (DateTime)reader["EnrollmentDate"];
                                EmergencyContactPhone = (string)reader["EmergencyContactPhone"];
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

        public static int? AddNewStudent(int personID, int gradeLevelID, string EmergencyContactPhone, int userID)
        {
            int? studentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", EmergencyContactPhone);
                        command.Parameters.AddWithValue("@EnrollmentDate", DateTime.Now);

                        SqlParameter outputIdStudentParam = new SqlParameter("@StudentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdStudentParam);

                        command.ExecuteNonQuery();

                        studentID = (int?)outputIdStudentParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return studentID;
        }

        public static bool Update(int studentID, int personID, int gradeLevelID, string EmergencyContactPhone, int UserID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", EmergencyContactPhone);
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool Delete(int? studentID)
            => clsDataAccessHelper.Delete("SP_DeleteStudent", "StudentID", studentID);

        public static bool Exists(int? studentID)
            => clsDataAccessHelper.Exists("SP_DoesStudentExist", "StudentID", studentID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllStudents");

        public static bool IsPersonStudent(int? personId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_IsPersonStudent", connection))
                    {
                        // Set the command type to StoredProcedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the input parameter for PersonID
                        command.Parameters.AddWithValue("@PersonID", personId);

                        // Add the output parameter for IsStudent
                        SqlParameter outputParam = new SqlParameter("@IsStudent", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        command.ExecuteNonQuery();

                        // Retrieve the output parameter value
                        bool isStudent = (bool)outputParam.Value;

                        return isStudent;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static int Count()
             => clsDataAccessHelper.Count("SP_GetStudentCount");
    }
}
