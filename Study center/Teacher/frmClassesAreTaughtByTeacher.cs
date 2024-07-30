using Study_center.Global_User_Controls;
using Study_center.Main_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Teacher
{
    public partial class frmClassesAreTaughtByTeacher : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _TeacherID;

        public frmClassesAreTaughtByTeacher(int? TeacherID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            _TeacherID = TeacherID;
            InitializeComponent();
        }

        private void frmClassesAreTaughtByTeacher_Load(object sender, EventArgs e)
        {
            ctrlListInfo1.SetMainMenuForm(mainMenuForm);
            ctrlListInfo1.SetPreviousForm(previousForm);
            ctrlListInfo1.FillClassesAreTaughtByTeacher(_TeacherID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClassesAreTaughtByTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
            else
            {
                mainMenuForm.ShowFormInPanel(mainMenuForm);
            }
        }
    }
}
