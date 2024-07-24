using Study_center.Class.User_Control;
using Study_center.Global_User_Controls;
using Study_center.Teacher;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Group
{
    public partial class frmAddGroup : Form
    {
        #region 
        private int? _selectedClassID = null;
        private int? _selectedTeacherID;
        private int? _selectedGradeLevelSubjectID;
        private int? _selectedMeetingTimeID;
        #endregion

        private int? _GroupID;

        private clsGroup _Group;

        public frmAddGroup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillListData()
        {
            // Initial fill for subjects and meeting times based on initial selections (if any)
            if (_selectedClassID.HasValue && _selectedTeacherID.HasValue)
            {
                ctrlListInfo1.FillSubjectsTaughtByTeacher(_selectedTeacherID);
                ctrlListInfo2.FillMeetingTimes(_selectedClassID, _selectedTeacherID);
            }
        }

        private void _FillGroupObjectInfo()
        {
            _Group.GradeLevelSubjectID = _selectedGradeLevelSubjectID;
          //  _Group.TeacherSubjectID = _;
            _Group.ClassID = _selectedClassID;
            _Group.MeetingTimeID = _selectedMeetingTimeID;
            _Group.IsActive = true;
        }

        #region  Event handler
        // Event handler to restrict tab navigation
        private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex > 0 && !_selectedClassID.HasValue)
            {
                MessageBox.Show("Please select a class first.");
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 1 && !_selectedTeacherID.HasValue)
            {
                MessageBox.Show("Please select a teacher first.");
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 2 && !_selectedGradeLevelSubjectID.HasValue)
            {
                MessageBox.Show("Please select a subject first.");
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 3 && !_selectedMeetingTimeID.HasValue)
            {
                MessageBox.Show("Please select a meeting time first.");
                e.Cancel = true;
            }
        }

        // Event handler when a class is selected in the user control
        private void CtrlClassCardWithFilter1_ClassSelected(object sender, EventArgs e)
        {
            _selectedClassID = ctrlClassCardWithFilter1.ClassInfo.ClassID;

            // Refresh the meeting times based on the selected class and teacher
            if (_selectedTeacherID.HasValue)
            {
                ctrlListInfo2.FillMeetingTimes(_selectedClassID, _selectedTeacherID);
            }
        }

        // Event handler when a teacher is selected in the user control
        private void CtrlTeacherCard1_TeacherSelected(object sender, EventArgs e)
        {
            _selectedTeacherID = ctrlTeacherCard1.TeacherInfo.TeacherID;

            // Refresh the subjects and meeting times based on the selected teacher and class
            ctrlListInfo1.FillSubjectsTaughtByTeacher(_selectedTeacherID);

            if (_selectedClassID.HasValue)
            {
                ctrlListInfo2.FillMeetingTimes(_selectedClassID, _selectedTeacherID);
            }
        }

        // Event handler when a GradeLevelSubject is selected in the user control
        private void CtrlListInfo1_SelectedItem(object sender, EventArgs e)
        {
            _selectedGradeLevelSubjectID = ctrlListInfo1.ID;
        }

        // Event handler when a MeetingTime is selected in the user control
        private void CtrlListInfo2_SelectedItem(object sender, EventArgs e)
        {
            _selectedMeetingTimeID = ctrlListInfo2.ID;
        }
        #endregion
        private void frmAddGroup_Load_1(object sender, EventArgs e)
        {
            // Fill the data after the form is loaded
            _FillListData();
        }
    }

}
