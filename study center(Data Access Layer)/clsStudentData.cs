using Study_center__DataAccess_.Global;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_center_Data_Access_Layer_
{
    public class clsStudentData
    {
        public static bool GetInfoByStudentID(int? studentID, ref int? personID, ref byte? gradeLevelID,
        ref int? createdByUserID, ref string EmergencyContactPhone, ref DateTime EnrollmentDate)
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
                                createdByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
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
            ref int? createdByUserID, ref string EmergencyContactPhone, ref DateTime EnrollmentDate)
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
                                createdByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
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

        public static int? AddNewStudent(int personID, byte gradeLevelID, string EmergencyContactPhone,  int createdByUserID)
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
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", EmergencyContactPhone);


                        SqlParameter outputIdStudentParam = new SqlParameter("@NewStudentID", SqlDbType.Int)
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

        public static bool Update(int studentID, int personID, byte gradeLevelID, string EmergencyContactPhone, int createdByUserID)
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
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

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
            =>clsDataAccessHelper.Delete("SP_DeleteStudent", "StudentID", studentID);
 
        public static bool Exists(int? studentID)
            => clsDataAccessHelper.Exists("SP_DoesStudentExist", "StudentID", studentID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllStudents");
    }
}
