using Study_center.Global_Classes;
using Study_center.Grade_Level_Subject;
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
        public event EventHandler SelectedItem;
        private int? _ID;
        public int? ID => _ID;

        private DataTable _List;

        private int? _storedTeacherID;
        private int? _storedGradeLevelSubjectID;
        private int? _storedClassID;

        private enum enItemTypes { Subjects = 0, Teachers = 1, MeetingTimes = 2 }
        private enItemTypes _Type;

        public ctrlListInfo()
        {
            InitializeComponent();
        }

        public void RefreshDataGridView()
        {
            dgvGradeLevelSubjects.DataSource = null;
            dgvGradeLevelSubjects.DataSource = _List;
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
            dgvGradeLevelSubjects.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedTeacherID = TeacherID;
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
            dgvGradeLevelSubjects.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedGradeLevelSubjectID = GradeLevelSubjectID;
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
            dgvGradeLevelSubjects.DataSource = _List;
            lblRecordsNum.Text = _List.Rows.Count.ToString();
            _storedTeacherID = TeacherID; _storedClassID = classID;
            return _List;
        }

        private void dgvGradeLevelSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (_Type)
                {
                    case enItemTypes.Subjects:
                        _ID = (int)dgvGradeLevelSubjects.Rows[e.RowIndex].Cells["GradeLevelSubjectID"].Value;
                        break;
                    case enItemTypes.Teachers:
                        _ID = (int)dgvGradeLevelSubjects.Rows[e.RowIndex].Cells["TeacherID"].Value;
                        break;
                    case enItemTypes.MeetingTimes:
                        _ID = (int)dgvGradeLevelSubjects.Rows[e.RowIndex].Cells["MeetingTimeID"].Value;
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
            }
            else
            {
                _SaveSubjectTeacher();
                _List = clsTeacherSubject.GetTeachersBySubject(_storedGradeLevelSubjectID);
            }
        }
        #endregion

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            switch (_Type)
            {
                case enItemTypes.Subjects:
                    frmAppointingTeacherForTheSubject frmAdd = new frmAppointingTeacherForTheSubject();
                    frmAdd.ShowDialog();
                    _List = clsTeacherSubject.GetSubjectsByTeacherID(_storedTeacherID);
                    break;

                case enItemTypes.Teachers:
                    frmFindTeacher tec = new frmFindTeacher();
                    tec.TeacherSelected += _GetTeacherIDFromFindTeacherForm;
                    tec.ShowDialog();
                    break;

                case enItemTypes.MeetingTimes:
                    frmAddMeetingTime time = new frmAddMeetingTime();
                    time.ShowDialog();
                    _List = clsGroup.GetAvailableMeetingTimes(_storedClassID, _storedTeacherID);

                    break;
            }

            // Refresh the DataGridView
            RefreshDataGridView();
        }
    }
}
