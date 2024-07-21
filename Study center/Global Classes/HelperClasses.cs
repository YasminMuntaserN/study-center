using Guna.UI2.WinForms;
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
    }
   
    public class HelperClass
    {
        public static void FillComboBox(Guna2ComboBox comboBox, DataTable dataTable, string displayMember)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
        }
    }
}
