using Microsoft.VisualBasic.ApplicationServices;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using studyCenter_BL_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Study_center.Teacher_and_Subject.frmAllTeachersWhoTeachSubject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Study_center.Teacher_and_Subject
{
    public partial class frmAllTeachersWhoTeachSubject : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _GradeLevelSubjectID;

        public frmAllTeachersWhoTeachSubject(int? gradeLevelSubjectID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _GradeLevelSubjectID = gradeLevelSubjectID;
        }

        private void frmAllTeachersWhoTeachSubject_Load(object sender, EventArgs e)
        {
            if (!_GradeLevelSubjectID.HasValue)
            {
                clsMessages.GeneralErrorMessage($"Grade Level Subject ID is not provided.");
                return;
            }

            ctrlListInfo1.FillTeachersWhoTeachSubject(_GradeLevelSubjectID);
            ctrlListInfo1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlListInfo1.SetPreviousForm(this);
        }

        private void frmAllTeachersWhoTeachSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
