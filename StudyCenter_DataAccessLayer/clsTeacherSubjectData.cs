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
    public class clsTeacherSubjectData
    {
        public static bool GetInfoByID(int? teacherSubjectID, ref int teacherID, ref int gradeLevelSubjectID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTeacherSubjectInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherSubjectID", (object)teacherSubjectID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                teacherID = (int)reader["TeacherID"];
                                gradeLevelSubjectID = (int)reader["GradeLevelSubjectID"];
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

        public static int? GetTeacherSubjectID(int teacherID, int gradeLevelSubjectID)
        {
            int? teacherSubjectID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("GetTeacherSubjectID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TeacherID", teacherID);
                    command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);

                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        teacherSubjectID = Convert.ToInt32(result);
                    }
                }
            }

            return teacherSubjectID;
        }

        public static int? Add(int teacherID, int gradeLevelSubjectID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewTeacherSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);

                        SqlParameter outputIdParam = new SqlParameter("@TeacherSubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();
                        return (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return null;
            }
        }

        public static bool Update(int teacherSubjectID, int teacherID, int gradeLevelSubjectID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateTeacherSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeacherSubjectID", teacherSubjectID);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static bool Delete(int teacherSubjectID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteTeacherSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeacherSubjectID", teacherSubjectID);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllTeacherSubjects", connection))
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

        public static bool IsTeachingSubject(int teacherID, int gradeLevelSubjectID)
        {
            bool isTeaching = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_IsTeachingSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);

                        SqlParameter outputParam = new SqlParameter("@IsTeaching", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        command.ExecuteNonQuery();

                        isTeaching = (bool)outputParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return isTeaching;
        }

        public static DataTable GetSubjectsByTeacherID(int teacherID)
             => clsDataAccessHelper.All("SP_GetSubjectsByTeacherID", "TeacherID", teacherID);

        public static DataTable GetTeachersBySubject(int subjectID)
             => clsDataAccessHelper.All("SP_GetTeachersBySubject", "subjectID", subjectID);

        public static bool IsTeacherTeachingSameSubject(int teacherId, int gradeLevelSubjectId)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckIfTeacherTeachesSameSubject", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.AddWithValue("@TeacherID", teacherId);
                    command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectId);

                    // Output parameter
                    SqlParameter isTeachingSameSubjectParam = new SqlParameter("@IsTeachingSameSubject", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(isTeachingSameSubjectParam);

                    // Open the connection and execute the command
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the value of the output parameter
                    return (bool)isTeachingSameSubjectParam.Value;
                }
            }
        }
    }
}
