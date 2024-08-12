﻿using Study_center.Global_Classes;
using Study_center.Grade_Level_Subject;
using Study_center.Group;
using Study_center.Main_Menu;
using Study_center.Meeting_Times;
using Study_center.Teacher;
using Study_center.Teacher_and_Subject;
using studyCenter_Bl_;
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

        public event EventHandler SelectedItem;
        private int? _ID;
        public int? ID => _ID;

        private DataTable _List;

        private int? _storedTeacherID;
        private int? _storedGradeLevelSubjectID;
        private int? _storedClassID;
        private int? _storedGroupID;


        private enum enItemTypes { Subjects = 0, Teachers = 1, MeetingTimes = 2, students = 3, Classes = 4 }
        private enItemTypes _Type;

        public ctrlListInfo()
        {
            InitializeComponent();
        }

        public void RefreshDataGridView()
        {
            dgvList.DataSource = null;
            dgvList.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
        }

        public void FillSubjectsTaughtByTeacher(int? TeacherID)
        {
            _Type = enItemTypes.Subjects;

            clsTeacher teacherInfo = clsTeacher.Find(TeacherID, clsTeacher.EnFindTeacherBy.TeacherID);

            if (teacherInfo != null)
            {
                string prefix = teacherInfo.Gender == clsPerson.EnGender.Male ? "Mr." : "Ms.";
                lblListName.Text = string.Concat("Subjects Taught By Teacher", ' ', prefix, ' ', teacherInfo.FullName);
            }
            _List = clsTeacherSubject.GetSubjectsByTeacherID(TeacherID);
            dgvList.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedTeacherID = TeacherID;
            btnaAdd.Enabled = true;
        }

        public void FillStudentsInGroup(int? GroupID)
        {
            _Type = enItemTypes.students;

            if (!GroupID.HasValue)
            {
                clsMessages.GeneralErrorMessage("Group ID is required.");
                return;
            }
            lblListName.Text = string.Concat("All Students In Group => ", clsGroup.GetGroupName(GroupID));
            _List = clsGroup.GetStudentsInGroup(GroupID);
            dgvList.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedGroupID = GroupID;
            btnaAdd.Enabled = true;
        }

        public void FillClassesAreTaughtByTeacher(int? classID)
        {
            _Type = enItemTypes.Classes;
            btnaAdd.Visible = false;

            if (!classID.HasValue)
            {
                clsMessages.GeneralErrorMessage("class ID is required.");
                return;
            }

            clsClass classInfo = clsClass.Find(classID.Value);

            if (classInfo != null)
            {
                lblListName.Text = string.Concat("  Teachers are teaching in the class ", ' ', classInfo.ClassName);
            }
            _List = clsTeacher.GetAllTeachersClasses(classID);
            dgvList.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            btnaAdd.Enabled = true;
        }

        public void FillTeachersWhoTeachSubject(int? GradeLevelSubjectID)
        {
            _Type = enItemTypes.Teachers;

            if (!GradeLevelSubjectID.HasValue)
            {
                clsMessages.GeneralErrorMessage("Grade Level Subject ID is required.");
                return;
            }

            clsGradeLevelSubject gradeLevelSubjectInfo = clsGradeLevelSubject.Find(GradeLevelSubjectID);

            if (gradeLevelSubjectInfo == null)
            {
                clsMessages.GeneralErrorMessage($"There is no Grade Level Subject with id {GradeLevelSubjectID} ");
                return;
            }

            lblListName.Text = $"Teachers Who Teach Subject {gradeLevelSubjectInfo.Title}";

            _List = clsTeacherSubject.GetTeachersBySubject(gradeLevelSubjectInfo.SubjectID);
            dgvList.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedGradeLevelSubjectID = GradeLevelSubjectID;
            btnaAdd.Enabled = true;
        }

        public DataTable FillMeetingTimes(int? classID, int? TeacherID)
        {
            _Type = enItemTypes.MeetingTimes;

            if (!classID.HasValue)
            {
                clsMessages.GeneralErrorMessage("class ID is required.");
                return null;
            }
            if (!TeacherID.HasValue)
            {
                clsMessages.GeneralErrorMessage("Teacher ID is required.");
                return null;
            }
            lblListName.Text = $"Available Meeting Times";

            _List = clsGroup.GetAvailableMeetingTimes(classID, TeacherID);
            dgvList.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedTeacherID = TeacherID; _storedClassID = classID;
            btnaAdd.Enabled = true;
            return _List;
        }

        private void dgvList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (_Type)
                {
                    case enItemTypes.Subjects:
                        _ID = (int)dgvList.Rows[e.RowIndex].Cells["GradeLevelSubjectID"].Value;
                        break;
                    case enItemTypes.Teachers:
                        _ID = (int)dgvList.Rows[e.RowIndex].Cells["TeacherID"].Value;
                        break;
                    case enItemTypes.MeetingTimes:
                        _ID = (int)dgvList.Rows[e.RowIndex].Cells["MeetingTimeID"].Value;
                        break;
                    case enItemTypes.students:
                        _ID = (int)dgvList.Rows[e.RowIndex].Cells["StudentID"].Value;
                        break;
                }
                SelectedItem?.Invoke(this, EventArgs.Empty);
            }
        }

        #region 
        private void _SaveSubjectTeacher()
        {
            clsTeacherSubject _subjectTeacher = new clsTeacherSubject();
            _subjectTeacher.TeacherID = _storedTeacherID;
            _subjectTeacher.GradeLevelSubjectID = _storedGradeLevelSubjectID;

            if (_subjectTeacher.Save())
            {
                clsMessages.GeneralSuccessMessage("Subject Teacher");
            }
            else
            {
                clsMessages.GeneralErrorMessage("Subject Teacher");
            }
        }

        private void _GetTeacherIDFromFindTeacherForm(int? teacherID)
        {
            _storedTeacherID = teacherID;

            if (clsTeacherSubject.IsTeachingSubject(teacherID, _storedGradeLevelSubjectID))
            {
                MessageBox.Show("This teacher is currently teaching the specified subject. Choose another one.",
                    "Teacher Subject Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _SaveSubjectTeacher();
                FillSubjectsTaughtByTeacher(_storedGradeLevelSubjectID);
            }
        }

        #endregion
        private void _RefreshList(int? ID)
        {
            switch (_Type)
            {
                case enItemTypes.Subjects:
                    FillSubjectsTaughtByTeacher(_storedTeacherID);
                    break;

                case enItemTypes.MeetingTimes:
                    FillMeetingTimes(_storedClassID, _storedTeacherID);
                    break;
                case enItemTypes.students:
                    FillStudentsInGroup(_storedGroupID);
                    break;
            }
        }

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            switch (_Type)
            {
                case enItemTypes.Subjects:
                    frmAppointingTeacherForTheSubject frmAdd = new frmAppointingTeacherForTheSubject(previousForm, mainMenuForm);
                    frmAdd.selectedTeacherIDBack += _RefreshList;
                    mainMenuForm.ShowFormInPanel(frmAdd);
                    break;

                case enItemTypes.Teachers:
                    frmFindTeacher tec = new frmFindTeacher(previousForm, mainMenuForm);
                    tec.TeacherSelected += _GetTeacherIDFromFindTeacherForm;
                    mainMenuForm.ShowFormInPanel(tec);
                    break;

                case enItemTypes.MeetingTimes:
                    frmAddMeetingTime time = new frmAddMeetingTime(mainMenuForm, previousForm);
                    time.selectedTimeIDBack += _RefreshList;
                    mainMenuForm.ShowFormInPanel(time);
                    break;

                case enItemTypes.students:
                    frmAddAssignStudentToGroup assign = new frmAddAssignStudentToGroup(_storedGroupID
                        , frmAddAssignStudentToGroup.enLoddingAccordingTo.GroupID, previousForm, mainMenuForm);
                    assign.selectedGroupIDBack += _RefreshList;
                    mainMenuForm.ShowFormInPanel(assign);
                   
                    break;
            }

            // Refresh the DataGridView
            RefreshDataGridView();
        }
    }
}
