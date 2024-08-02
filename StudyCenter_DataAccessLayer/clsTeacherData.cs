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
    public class clsTeacherData
    {
        public static bool GetInfoByTeacherID(int? TeacherID, ref int? personID, ref decimal Salary,
        ref int? UserID, ref string Qualification, ref DateTime HireDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTeacherInfoByTeacherID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", (object)TeacherID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                HireDate = (DateTime)reader["HireDate"];
                                Qualification = (string)reader["Qualification"];
                                Salary = (decimal)reader["Salary"];

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

        public static bool GetInfoByPersonID(  int? personID, ref int? TeacherID, ref decimal Salary,
        ref int? UserID, ref string Qualification, ref DateTime HireDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTeacherInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@personID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                TeacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                HireDate = (DateTime)reader["HireDate"];
                                Qualification = (string)reader["Qualification"];
                                Salary = (decimal)reader["Salary"];
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

        public static int? AddNewTeacher(int personID, decimal Salary, string Qualification, int UserID)
        {
            int? TeacherID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Qualification", Qualification);
                        command.Parameters.AddWithValue("@HireDate", DateTime.Now);

                        SqlParameter outputIdStudentParam = new SqlParameter("@TeacherID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdStudentParam);

                        command.ExecuteNonQuery();

                        TeacherID = (int?)outputIdStudentParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return TeacherID;
        }

        public static bool Update(int TeacherID, int personID, decimal Salary, string Qualification, DateTime HireDate, int UserID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Qualification", Qualification);
                        command.Parameters.AddWithValue("@HireDate", DateTime.Now);

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

        public static bool Delete(int? TeacherID)
           => clsDataAccessHelper.Delete("SP_DeleteTeacher", "TeacherID", TeacherID);

        public static bool Exists(int? TeacherID)
            => clsDataAccessHelper.Exists("SP_DoesTeacherExist", "TeacherID", TeacherID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllTeachers");

        public static bool IsPersonTeacher(int? TeacherID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_IsPersonTeacher", connection))
                    {
                        // Set the command type to StoredProcedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the input parameter for PersonID
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);

                        // Add the output parameter for IsStudent
                        SqlParameter outputParam = new SqlParameter("@IsTeacher", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        command.ExecuteNonQuery();

                        // Retrieve the output parameter value
                        bool isTeacher = (bool)outputParam.Value;

                        return isTeacher;
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
            => clsDataAccessHelper.Count("SP_GetTeacherCount");

        public static DataTable GetTeachersByPage(int pageNumber, int pageSize)
          => clsDataAccessHelper.All("SP_TeachersByPage", "PageNumber", pageNumber
             , "PageSize", pageSize);

        public static DataTable GetAllTeachersClasses(int ClassID)
          => clsDataAccessHelper.All("SP_GetTeachersInClasses", "ClassID", ClassID);


    }
}
