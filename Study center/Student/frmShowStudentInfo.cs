using Study_center.Main_Menu;
using Study_center.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Student
{
    public partial class frmShowStudentInfo : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _StudentID;

        public frmShowStudentInfo(int? StudentID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _StudentID = StudentID;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowStudentInfo_Load(object sender, EventArgs e)
        {
            ctrlStudentCard1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlStudentCard1.SetPreviousForm(this); // Set the current form as the previous form
            ctrlStudentCard1.LoadStudentInfo(_StudentID);
        }

        private void frmShowStudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }

    }
}
