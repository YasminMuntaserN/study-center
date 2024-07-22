using Study_center.Global_Classes;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
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

namespace Study_center.Global_User_Controls
{
    public partial class ctrlListInfo : UserControl
    {
        private DataTable _List;
        public ctrlListInfo()
        {
            InitializeComponent();
        }
     
        public void FillSubjectsTaughtByTeacher(int? TeacherID)
        {
            clsTeacher teacherInfo = clsTeacher.Find(TeacherID, clsTeacher.EnFindTeacherBy.TeacherID);

            if (teacherInfo != null)
            {
                string prefix = teacherInfo.Gender == clsPerson.EnGender.Male ? "Mr." : "Ms.";
                lblListName.Text = string.Concat("Subjects Taught By Teacher", ' ', prefix, ' ', teacherInfo.FullName);
            }
            _List = clsTeacherSubject.GetSubjectsByTeacherID(TeacherID);
            dgvGradeLevelSubjects.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
        }

        public void FillTeachersWhoTeachSubject(int? TeacherSubject)
        {
            clsTeacherSubject TeacherSubjectInfo = clsTeacherSubject.Find(TeacherSubject);

            if (TeacherSubjectInfo == null)
            {
                clsMessages.GeneralErrorMessage($"There is no Teacher Subject with id {TeacherSubject} ");
                return;
            }
            lblListName.Text = $"Teachers Who Teach Subject {TeacherSubjectInfo.GradeLevelSubjectInfo.Title}";
            _List = clsTeacherSubject.GetTeachersBySubject(TeacherSubjectInfo.GradeLevelSubjectInfo.SubjectID);
            dgvGradeLevelSubjects.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
        }

        private void ctrlListInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
