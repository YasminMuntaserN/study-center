using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Student.User_Control;
using studyCenter_BL_;
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
    public partial class frmAddAssignStudentToGroup : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? selectedStudentID;
        private int? selectedGroupID;

        private clsEnrollment _Enrollment;
        private DataTable _dtGroups;

        public enum enLoddingAccordingTo { StudentID, GroupID }
        private enLoddingAccordingTo? _AccordingTo;

        public frmAddAssignStudentToGroup(Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _Enrollment = new clsEnrollment();
            _FillComboBoxies();
        }

        public frmAddAssignStudentToGroup(int? value, enLoddingAccordingTo accordingTo,
            Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;

            InitializeComponent();
            _Enrollment = new clsEnrollment();

            switch (accordingTo)
            {
                case enLoddingAccordingTo.StudentID:
                    selectedStudentID = value;
                    _AccordingTo = enLoddingAccordingTo.StudentID;
                    break;

                case enLoddingAccordingTo.GroupID:
                    selectedGroupID = value;
                    _AccordingTo = enLoddingAccordingTo.GroupID;
                    break;
            }
        }

        private void _LoadData()
        {
            if (_AccordingTo.HasValue)
            {
                switch (_AccordingTo.Value)
                {
                    case enLoddingAccordingTo.GroupID:
                        gbSelectGroup.Visible = false;
                        ctrlGroupCard1.Visible = true;
                        ctrlGroupCard1.Location = new System.Drawing.Point(25, 22);
                        ctrlGroupCard1.Size = new System.Drawing.Size(862, 316);
                        ctrlGroupCard1.LoadData(selectedGroupID);
                        break;
                    case enLoddingAccordingTo.StudentID:
                        ctrlStudentCard1.LoadStudentInfo(selectedStudentID);
                        ctrlGroupCard1.Visible = false;
                        _FillComboBoxies();
                        break;
                }
            }
        }

        private void _FillEnrollmentInfo()
        {
            _Enrollment.StudentID = selectedStudentID;
            _Enrollment.GroupID = selectedGroupID;
            _Enrollment.EnrollmentDate = DateTime.Now;
            _Enrollment.IsActive = true;
        }

        private bool _CheckCorrectData()
        {
            if (!selectedGroupID.HasValue)
            {
                clsMessages.GeneralErrorMessage("Please select a group.");
                return false;
            }

            if (!selectedStudentID.HasValue)
            {
                clsMessages.GeneralErrorMessage("Please select a student.");
                return false;
            }

            if (clsEnrollment.CanAddStudentToGroup(selectedGroupID))
            {
                clsMessages.GeneralErrorMessage("Cannot add student. Class capacity exceeded.");
                return false;
            }

            if (clsEnrollment.Exists(selectedStudentID, selectedGroupID))
            {
                MessageBox.Show("This student is already enrolled in the selected group.",
                    "Enrollment Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (!clsGroup.CheckGradeLevel(selectedStudentID, selectedGroupID))
            {
                MessageBox.Show("The student''s grade level does not match the group''s grade level.",
                    "Enrollment Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        }

        private void _RefreshList()
        {
            if (_AccordingTo != enLoddingAccordingTo.StudentID)
                selectedStudentID = ctrlStudentCard1.StudentInfo.StudentID;

            // Fill Groups In DataGridView
            _dtGroups = clsEnrollment.GetAvailableGroupsByStudentID(selectedStudentID);
            dgvList.DataSource = _dtGroups;
        }

        private void _Search(string searchBy, Guna2ComboBox comboBox)
        {
            if (_dtGroups == null || _dtGroups.Rows.Count == 0)
                return;

            if (comboBox.Text == "All")
            {
                _dtGroups.DefaultView.RowFilter = "";
                return;
            }

            _dtGroups.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", $"{searchBy}", comboBox.Text);
        }

        #region Fill comboBoxies
        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            cbGroups.Visible = (cbFilter.Text == "Group Name");
            cbTeachers.Visible = (cbFilter.Text == "Teacher Name");
            cbSubjects.Visible = (cbFilter.Text == "Subject Name");
            cbClasses.Visible = (cbFilter.Text == "Class Name");

            if (cbGroups.Visible)
                cbGroups.SelectedIndex = 0;

            if (cbTeachers.Visible)
                cbTeachers.SelectedIndex = 0;

            if (cbSubjects.Visible)
                cbSubjects.SelectedIndex = 0;

            if (cbClasses.Visible)
                cbClasses.SelectedIndex = 0;
        }

        private void cbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("TeacherName", cbTeachers);
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("ClassName", cbClasses);
        }

        private void cbGroups_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _Search("GroupName", cbGroups);
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("SubjectName", cbSubjects);
        }
        #endregion

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_AccordingTo != enLoddingAccordingTo.GroupID)
                selectedGroupID = (int)dgvList.CurrentRow.Cells[0].Value;

            if (_AccordingTo != enLoddingAccordingTo.StudentID)
            {
                if(ctrlStudentCard1.StudentInfo != null)
                selectedStudentID = ctrlStudentCard1.StudentInfo.StudentID;

            }


            if (!_CheckCorrectData())
            {
                return;
            }

            _FillEnrollmentInfo();

            // Save the new enrollment
            if (_Enrollment.Save())
            {
                clsGroup group = clsGroup.Find(selectedGroupID);
                clsMessages.GeneralSuccessMessage($"Student with ID: {selectedStudentID} has been enrolled in group: {group.GroupName}.");
            }
            else
            {
                MessageBox.Show("Failed to enroll student in the group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillComboBoxWithGroupNames()
        {
            cbGroups.Items.Clear();

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                cbGroups.Items.Add(letter);
            }
        }

        private void CtrlStudentCard1_StudentSelected(object sender, EventArgs e) => _RefreshList();

        private void _FillComboBoxies()
        {
            HelperClass.FillComboBox(cbSubjects, clsSubject.All(), "SubjectName");
            _FillComboBoxWithGroupNames();
            HelperClass.FillComboBox(cbTeachers, clsTeacher.All(), "TeacherName");
            HelperClass.FillComboBox(cbClasses, clsClass.All(), "ClassName");
        }

        private void frmAddAssignStudentToGroup_Load(object sender, EventArgs e)
        {
            ctrlGroupCard1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlGroupCard1.SetPreviousForm(this); // Set the current form as the previous form

            _LoadData();

        }

        private void btnClose_Click_1(object sender, EventArgs e) => this.Close();

        private void frmAddAssignStudentToGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }
    }
}
