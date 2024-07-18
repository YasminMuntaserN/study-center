using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Global
{
    public class clsMessages
    {
        public static void NotFound(string type, int? ID)
        {
            MessageBox.Show($"No {type} with ID = " + ID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void OperationDoneSuccessfully(string Operation)
        {
            MessageBox.Show($"Data {Operation} Successfully.", $"{Operation}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void OperationFelid(string Operation)
        {
            MessageBox.Show($"Error: Data Is not {Operation} Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ValidationErrorMessage()
        {
            MessageBox.Show("Some Fields are not Valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool conformDeleted(string type, int? ID)
        {
            return MessageBox.Show($"Are you sure you want to delete {type} with ID : [" + ID + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
        }

        public static void AddToSystem(string type)
        {
            MessageBox.Show($"This {type} is not present in the system. To add a new {type}, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GeneralErrorMessage(string message)
        {
            MessageBox.Show(message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GeneralSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
