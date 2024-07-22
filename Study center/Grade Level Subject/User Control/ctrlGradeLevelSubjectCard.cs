using Study_center.Global_Classes;
using Study_center.Teacher;
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

namespace Study_center.Grade_Level_Subject.User_Control
{
    public partial class ctrlGradeLevelSubjectCard : UserControl
    {
        private clsGradeLevelSubject _GradeLevelSubject;

        private int? _GradeLevelSubjectID;

        public ctrlGradeLevelSubjectCard(int? gradeLevelSubjectID)
        {
            InitializeComponent();
            _GradeLevelSubjectID = gradeLevelSubjectID;  
        }
    
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
     
        public void LoadData()
        {
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

        }
    }
}
