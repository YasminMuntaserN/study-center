using Guna.UI2.WinForms;
using StudyCenter_DataAccessLayer.Global_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Study_center.Global_Classes
{
    public class clsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }
    }

    public class clsFormat
    {
        public static string DateToShort(DateTime Dt1) => Dt1.ToString("dd/MMM/yyyy");

        public static string FormatTime(TimeSpan startTime, TimeSpan endTime)
        {
            if (endTime < startTime)
            {
                throw new ArgumentException("End time must be greater than or equal to start time");
            }

            // Format the times to "HH:mm"
            string formattedStartTime = startTime.ToString(@"hh\:mm");
            string formattedEndTime = endTime.ToString(@"hh\:mm");

            return $"{formattedStartTime} - {formattedEndTime}";
        }
    }
   
    public class HelperClass
    {
        public static void FillComboBox(Guna2ComboBox comboBox, DataTable dataTable, string displayMember)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
        }
        public static void GetTotalPagesAndRows(string TableName, int pageSize, out int totalRows, out int totalPages)
          => clsDataAccessHelper.GetTotalPagesAndRows($"{TableName}", pageSize, out totalRows, out totalPages);

    }
}
