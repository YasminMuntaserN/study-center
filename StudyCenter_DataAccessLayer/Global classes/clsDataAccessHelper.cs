﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter_DataAccessLayer.Global_classes
{
    public class clsDataAccessHelper
    {
        public static DataTable All(string storedProcedureName)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
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

        public static bool Delete<T>(string storedProcedureName, string parameterName, T value)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue($"@{parameterName}", (object)value ?? DBNull.Value);

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

        public static bool Exists<T>(string storedProcedureName, string parameterName, T value)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue($"@{parameterName}", value);

                        SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(existsParam);

                        command.ExecuteNonQuery();

                        isFound = (bool)existsParam.Value;
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

        public static bool Exists<T1, T2>(string storedProcedureName, string parameterName1, T1 value1, string parameterName2, T2 value2)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue($"@{parameterName1}", (object)value1 ?? DBNull.Value);
                        command.Parameters.AddWithValue($"@{parameterName2}", (object)value2 ?? DBNull.Value);

                        SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(existsParam);

                        command.ExecuteNonQuery();

                        isFound = (bool)existsParam.Value;
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

        public static int Count(string storedProcedureName)
        {
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
            return count;
        }

        public static DataTable All<T>(string storedProcedureName, string parameterName, T value)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue($"@{parameterName}", (object)value ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
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

        public static DataTable All<T1, T2>(string storedProcedureName, string parameterName1, T1 value1, string parameterName2, T2 value2)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue($"@{parameterName1}", (object)value1 ?? DBNull.Value);
                        command.Parameters.AddWithValue($"@{parameterName2}", (object)value2 ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
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

        public static void GetTotalPagesAndRows(string tableName, int pageSize, out int totalRows, out int totalPages)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetTotalPagesAndRows", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableName", tableName);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(totalRowsParam);

                    SqlParameter totalPagesParam = new SqlParameter("@TotalPages", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(totalPagesParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    totalRows = (int)totalRowsParam.Value;
                    totalPages = (int)totalPagesParam.Value;
                }
            }
        }

    }
}
