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
    public class clsMeetingTimesData
    {
        public static bool GetInfoByID(int? meetingTimeID, ref int? patternID, ref TimeSpan? startTime, ref TimeSpan? endTime)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetMeetingTimeInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MeetingTimeID", (object)meetingTimeID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                patternID = reader["PatternID"] as int?;
                                startTime = reader["StartTime"] as TimeSpan?;
                                endTime = reader["EndTime"] as TimeSpan?;
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

        public static int? Add(int patternID, TimeSpan startTime, TimeSpan endTime)
        {
            int? meetingTimeID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewMeetingTime", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PatternID", patternID);
                        command.Parameters.AddWithValue("@StartTime", startTime);
                        command.Parameters.AddWithValue("@EndTime", endTime);

                        SqlParameter outputIdParam = new SqlParameter("@NewMeetingTimeID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        meetingTimeID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return meetingTimeID;
        }

        public static bool Update(int meetingTimeID, int patternID, TimeSpan startTime, TimeSpan endTime)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateMeetingTime", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MeetingTimeID", meetingTimeID);
                        command.Parameters.AddWithValue("@PatternID", patternID);
                        command.Parameters.AddWithValue("@StartTime", startTime);
                        command.Parameters.AddWithValue("@EndTime", endTime);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return (rowsAffected > 0);
        }

        public static bool Delete(int? meetingTimeID)
            => clsDataAccessHelper.Delete("SP_DeleteMeetingTime", "MeetingTimeID", meetingTimeID);

        public static bool Exists(int? meetingTimeID)
            => clsDataAccessHelper.Exists("SP_DoesMeetingTimeExistByID", "MeetingTimeID", meetingTimeID);

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllMeetingTimes");

        public static DataTable GetMeetingTimesByPattern(int patternID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetMeetingTimesByPattern", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatternID", patternID);

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

        public static bool GetPatternDetailsByID(int patternID, ref string patternDescription, ref string encodedDays)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPatternDetailsByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatternID", patternID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                patternDescription = reader["PatternDescription"] as string;
                                encodedDays = reader["EncodedDays"] as string;
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
    }

}
