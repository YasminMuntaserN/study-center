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
    public class clsPaymentData
    {
        public static bool GetInfoByID(int? paymentID, ref int? personID, ref decimal? amount, ref DateTime? paymentDate, ref int? groupID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPaymentInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaymentID", (object)paymentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                personID = reader["PersonID"] as int?;
                                amount = reader["Amount"] as decimal?;
                                paymentDate = reader["PaymentDate"] as DateTime?;
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

        public static int? Add(int? personID, decimal amount, DateTime paymentDate, int? groupID)
        {
            int? paymentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@PaymentDate", paymentDate);
                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@PaymentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        paymentID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return paymentID;
        }

        public static bool Update(int? paymentID, int? personID, decimal amount, DateTime paymentDate, int? groupID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PaymentID", paymentID);
                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@PaymentDate", paymentDate);
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

        public static bool Delete(int? paymentID)
            => clsDataAccessHelper.Delete("SP_DeletePayment", "PaymentID", paymentID);

        public static bool Exists(int? paymentID)
            => clsDataAccessHelper.Exists("SP_DoesPaymentExistByPaymentID", "PaymentID", paymentID);

        public static int Count()
            => clsDataAccessHelper.Count("SP_GetPaymentCount");

        public static DataTable All()
            => clsDataAccessHelper.All("SP_GetAllPayments");

        public static DataTable GetPaymentsByPersonID(int? personID)
        {
            DataTable dtPayments = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPaymentsByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtPayments);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return dtPayments;
        }

        public static DataTable GetPaymentsByGroupID(int? groupID)
        {
            DataTable dtPayments = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPaymentsByGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtPayments);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }

            return dtPayments;
        }

        public static DataTable GetPaymentsByPage(int pageNumber, int pageSize)
            => clsDataAccessHelper.All("SP_PaymentByPage", "PageNumber", pageNumber
                , "PageSize", pageSize);
    }

}
