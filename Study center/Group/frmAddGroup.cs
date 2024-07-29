using Study_center.Class.User_Control;
using Study_center.Global_Classes;
using Study_center.Global_User_Controls;
using Study_center.Main_Menu;
using Study_center.Teacher;
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

namespace Study_center.Group
{
    public partial class frmAddGroup : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        public Action<int?> GroupIDBack;

        #region 
        private int? _selectedClassID = null;
        private int? _selectedTeacherID;
        private int? _selectedGradeLevelSubjectID;
        private int? _selectedMeetingTimeID;
        #endregion

        private enum enMode { Add, Update }

        private enMode _Mode = enMode.Add;

        private int? _GroupID;

        private clsGroup _Group;

        public frmAddGroup(Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddGroup(int? GroupID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            _GroupID = GroupID;
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Group";
                _Group = new clsGroup();
            }
            else
            {
                lblTitle.Text = "Update Group";
            }
        }

        private void _LoadGroupInfoInFields()
        {
            lblGroupName.Text = _Group.GroupName.ToString();
            lblGroupID.Text = _Group.GroupID.ToString();
            lblClasssID.Text = _Group.ClassID.ToString();
            lblMeetingTimesID.Text = _Group.MeetingTimeID.ToString();
            lblSubjectGradeLevelID.Text = _Group.GradeLevelSubjectID.ToString();
            lblTeacherSubjectID.Text = _Group.TeacherSubjectID.ToString();
            lblCreationDate.Text = clsFormat.DateToShort(_Group.CreationDate);
            lblStudentCount.Text = _Group.GroupStudentCount.ToString();
        }

        private void _FillCompleteData()
        {
            _Group = clsGroup.Find(_GroupID);
            if (_Group != null)
            {
                ctrlClassCardWithFilter1.LoadData(_Group.ClassID);
                ctrlTeacherCard1.LoadTeacherInfo(_Group.TeacherSubjectInfo.TeacherID);
                _LoadGroupInfoInFields();
            }
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
            _Group.TeacherSubjectID = clsTeacherSubject.GetTeacherSubjectID(_selectedTeacherID, _selectedGradeLevelSubjectID);
            _Group.ClassID = _selectedClassID;
            _Group.MeetingTimeID = _selectedMeetingTimeID;
            _Group.IsActive = true;
        }

        #region  Event handler
       private bool AllDataSelecting()
        {
            if (!_selectedClassID.HasValue)
            {
                MessageBox.Show("Please select a class first.");
                return false;
            }
            else if (!_selectedTeacherID.HasValue)
            {
                MessageBox.Show("Please select a teacher first.");
                return false;
            }
            else if (!_selectedGradeLevelSubjectID.HasValue)
            {
                MessageBox.Show("Please select a subject first.");
                return false;
            }
            else if (!_selectedMeetingTimeID.HasValue)
            {
                MessageBox.Show("Please select a meeting time first.");
                return false;
            }
            return true;
        }

        // Event handler when a class is selected in the user control
        private void CtrlClassCardWithFilter1_ClassSelected(object sender, EventArgs e)
        {
            _selectedClassID = ctrlClassCardWithFilter1.ClassInfo.ClassID;
            lblClasssID.Text = _selectedClassID.ToString();
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
            lblTeacherSubjectID.Text = clsTeacherSubject.GetTeacherSubjectID(_selectedTeacherID, _selectedGradeLevelSubjectID).ToString();
            lblSubjectGradeLevelID.Text = _selectedGradeLevelSubjectID.ToString();
        }

        // Event handler when a MeetingTime is selected in the user control
        private void CtrlListInfo2_SelectedItem(object sender, EventArgs e)
        {
            _selectedMeetingTimeID = ctrlListInfo2.ID;
            lblMeetingTimesID.Text = _selectedMeetingTimeID.ToString();
        }
        #endregion

        private void frmAddGroup_Load_1(object sender, EventArgs e)
        {
            // Fill the data after the form is loaded
            _FillListData();

            _ResetTitles();


            if (_Mode == enMode.Update)
                _FillCompleteData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!AllDataSelecting()) return;

            _FillGroupObjectInfo();

            
            if (_Group.Save())
            {
                lblTitle.Text = "Update Group";
                this.Text = lblTitle.Text;

                // change form mode to update
                _Mode = enMode.Update;

                _LoadGroupInfoInFields();

                clsMessages.OperationDoneSuccessfully("Group");

                // Trigger the event to send data back to the caller form
                GroupIDBack?.Invoke(_Group.GroupID);
            }
            else
            {
                clsMessages.OperationFelid("group");
            }
        }

        private void frmAddGroup_FormClosed(object sender, FormClosedEventArgs e)
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
