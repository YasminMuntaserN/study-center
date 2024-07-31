using Microsoft.Data.SqlClient;
using StudyCenter_DataAccessLayer.Global_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter_DataAccessLayer
{
    public class clsGroupData
    {
        public static bool GetInfoByID(int? groupID, ref string groupName, ref int gradeLevelSubjectID, ref decimal groupStudentCount, ref int teacherSubjectID, ref int classID, ref int meetingTimeID, ref bool isActive, ref DateTime CreationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGroupInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                groupName = (string)reader["GroupName"];
                                gradeLevelSubjectID = (int)reader["GradeLevelSubjectID"];
                                groupStudentCount = (int)reader["GroupStudentCount"];
                                teacherSubjectID = (int)reader["TeacherSubjectID"];
                                classID = (int)reader["ClassID"];
                                meetingTimeID = (int)reader["MeetingTimeID"];
                                isActive = (bool)reader["IsActive"];
                                CreationDate = (DateTime)reader["CreationDate"];
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

        public static int? Add(int? gradeLevelSubjectID, decimal groupStudentCount, int? teacherSubjectID, int? classID, int? meetingTimeID, bool isActive)
        {
            int? groupID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);
                        command.Parameters.AddWithValue("@GroupStudentCount", groupStudentCount);
                        command.Parameters.AddWithValue("@TeacherSubjectID", teacherSubjectID);
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@MeetingTimeID", meetingTimeID);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@CreationDate", DateTime.Now);

                        SqlParameter outputIdParam = new SqlParameter("@NewGroupID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        groupID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return groupID;
        }

        public static bool Update(int? groupID, string groupName, int? gradeLevelSubjectID, decimal groupStudentCount, int? teacherSubjectID, int? classID, int? meetingTimeID, bool isActive)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GroupID", groupID);
                        command.Parameters.AddWithValue("@GroupName", groupName);
                        command.Parameters.AddWithValue("@GradeLevelSubjectID", gradeLevelSubjectID);
                        command.Parameters.AddWithValue("@GroupStudentCount", groupStudentCount);
                        command.Parameters.AddWithValue("@TeacherSubjectID", teacherSubjectID);
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@MeetingTimeID", meetingTimeID);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@CreationDate", DateTime.Now);

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

        public static bool Delete(int? groupID)
            => clsDataAccessHelper.Delete("SP_DeleteGroup", "GroupID", groupID);

        public static bool Exists(int? groupID)
            => clsDataAccessHelper.Exists("SP_DoesGroupExistByGroupID", "GroupID", groupID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetGroupInfo");

        public static string GetGroupName(int groupID)
        {
            string groupName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGroupName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GroupID", groupID);

                        SqlParameter outputNameParam = new SqlParameter("@GroupName", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputNameParam);

                        command.ExecuteNonQuery();

                        groupName = outputNameParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return groupName;
        }

        public static DataTable GetAvailableMeetingTimes(int? classID, int? teacherID)
        {
            DataTable dtMeetingTimes = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAvailableMeetingTimes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtMeetingTimes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return dtMeetingTimes;
        }

        public static int Count()
             => clsDataAccessHelper.Count("SP_GetGroupCount");

        public static DataTable GetGroupsByPage(int pageNumber, int pageSize)
            => clsDataAccessHelper.All("SP_GetGroupsByPage", "PageNumber", pageNumber
                , "PageSize", pageSize);

        public static DataTable GetStudentsInGroup(int groupId) => clsDataAccessHelper.All("GetStudentsInGroup", "GroupID", groupId);

        public static bool CheckGradeLevel( int StudentID, int GroupID)
            => clsDataAccessHelper.Exists("SP_CheckGradeLevel", "GroupID", GroupID, "StudentID", StudentID);
    }
}

