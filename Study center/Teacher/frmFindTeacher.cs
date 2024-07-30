using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Person.User_Controls;
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
    public partial class frmFindTeacher : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        public Action<int?> TeacherSelected;

        public frmFindTeacher(Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
        }

        private void frmFindTeacher_Load(object sender, EventArgs e)
        {
            ctrlTeacherCard1.Focus();
            ctrlTeacherCard1.SetMainMenuForm(mainMenuForm);
            ctrlTeacherCard1.SetPreviousForm(previousForm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Raise the event
            if (ctrlTeacherCard1.TeacherInfo != null) TeacherSelected?.Invoke(ctrlTeacherCard1.TeacherInfo.TeacherID);
            else { clsMessages.GeneralErrorMessage("select Teacher ID!"); return; }
            this.Close();
        }

        private void frmFindTeacher_FormClosed(object sender, FormClosedEventArgs e)
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
