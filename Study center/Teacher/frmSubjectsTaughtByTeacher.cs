using Study_center.Global_Classes;
using Study_center.Main_Menu;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
using StudyCenter_DAL_;
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
    public partial class frmSubjectsTaughtByTeacher : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _TeacherID;
        public frmSubjectsTaughtByTeacher(int? TeacherID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            _TeacherID = TeacherID;
            InitializeComponent();
        }

        private void _FillData()
        {
            if (_TeacherID == null)
            {
                clsMessages.GeneralErrorMessage($"No Teacher with ID : {_TeacherID}");
                return;
            }
            ctrlTeacherCard1.LoadTeacherInfo(_TeacherID);
            ctrlListInfo1.FillSubjectsTaughtByTeacher(_TeacherID);
        }

        private void frmSubjectsTaughtByTeacher_Load(object sender, EventArgs e)
        {
            _FillData();
            ctrlTeacherCard1.SetMainMenuForm(mainMenuForm);
            ctrlTeacherCard1.SetPreviousForm(previousForm);
        }

        private void frmSubjectsTaughtByTeacher_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
