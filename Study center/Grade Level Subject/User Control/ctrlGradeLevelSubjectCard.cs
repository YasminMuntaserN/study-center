using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Teacher;
using Study_center.Teacher_and_Subject;
using studyCenter_Bl_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Study_center.Grade_Level_Subject.User_Control
{
    public partial class ctrlGradeLevelSubjectCard : UserControl
    {
        private clsGradeLevelSubject _GradeLevelSubject;

        private int? _GradeLevelSubjectID;

        public ctrlGradeLevelSubjectCard()
        {
            InitializeComponent();
        }

        #region Shown In Main Menu
        private frmMainMenu mainMenuForm;
        private Form previousForm;
        public void SetMainMenuForm(frmMainMenu form)
        {
            this.mainMenuForm = form;
        }

        public void SetPreviousForm(Form form)
        {
            this.previousForm = form;
        }
        #endregion

        private void _FillObjectInFailed()
        {
            lblSubjectGradeLevelID.Text = _GradeLevelSubjectID.ToString();
            lblGradeLevelID.Text = _GradeLevelSubject.GradeLevelID.ToString();
            lblSubjectID.Text = _GradeLevelSubject.SubjectID.ToString() ; 
            lblFees.Text =_GradeLevelSubject.Fees.ToString("C");
            lblTitle.Text = _GradeLevelSubject.Title;    
            lblGradeLevel.Text = _GradeLevelSubject.GradeLevelInfo.GradeName;
            lblSubject.Text = _GradeLevelSubject.SubjectInfo.SubjectName;
        }
     
        public void LoadData(int? gradeLevelSubjectID)
        {
            if(!gradeLevelSubjectID.HasValue)
            {
                clsMessages.GeneralErrorMessage($"Cannot Find Grade Level Subject with ID {_GradeLevelSubjectID}");
            }
            _GradeLevelSubjectID = gradeLevelSubjectID;

            _GradeLevelSubject = clsGradeLevelSubject.Find(_GradeLevelSubjectID);
            if( _GradeLevelSubject == null )
            {
                clsMessages.GeneralErrorMessage($"Cannot Find Grade Level Subject with ID {_GradeLevelSubjectID}");
                return;
            }
            _FillObjectInFailed();
        }

        private void llWhoTeachesIt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAllTeachersWhoTeachSubject Teachers = new frmAllTeachersWhoTeachSubject(_GradeLevelSubjectID, previousForm, mainMenuForm);
            mainMenuForm.ShowFormInPanel(Teachers);
        }
    }
}
