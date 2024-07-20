using Study_center.Global_Classes;
using studyCenter_BusineesLayer;
using StudyCenter_DataAccessLayer.Global_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Study_center.Student
{
    public partial class frmAddStudent : Form
    {
        public Action<int?> StudentIDBack;

        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _studentID = null;
        private clsStudent _student = null;

        private int? _selectedPersonID => ctrlPersonCardWithFilter1.PersonID;

        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void _FillGradeLevelsInComboBox()
        {

            DataTable dtGradeLevels = clsGradeLevel.All();

            foreach (DataRow row in dtGradeLevels.Rows)
            {
                cbGradeLevels.Items.Add(row["GradeLevelName"]);
            }
            if (cbGradeLevels.Items.Count > 0)
                cbGradeLevels.SelectedIndex = 0;
        }

        private void _ResetTitles()
        {
            _FillGradeLevelsInComboBox();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Student";
                _student = new clsStudent();
                lblCreatedBy.Text = "Admin";
            }
            else
            {
                lblTitle.Text = "Update Student";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillFieldsWithStudentInfo()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_student.PersonID);

            lblStudentID.Text = _student.StudentID.ToString();
            //  lblCreatedBy.Text = _student.CreatedByUserInfo?.Username;
            lblCreatedBy.Text = "Admin";
            txtEmergencyContactPhone.Text = _student.EmergencyContactPhone.ToString();
            cbGradeLevels.SelectedIndex = cbGradeLevels.FindString(clsGradeLevel.GetGradeLevelName(_student.GradeLevelID));
       
        }

        private void _LoadData()
        {
            _student = clsStudent.Find(_studentID, clsStudent.EnFindStudentBy.StudentID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_student == null)
            {
                clsMessages.NotFound("student", _studentID);

                this.Close();
                return;
            }

            _FillFieldsWithStudentInfo();
        }

        private void _FillStudentObjectWithFieldsData()
        {
            _student.PersonID = _selectedPersonID;
            _student.GradeLevelID = clsGradeLevel.GetGradeLevelID(cbGradeLevels.Text);
            _student.CreatedByUserID = 1;
            _student.EmergencyContactPhone =txtEmergencyContactPhone.Text;
        }

        private void _Save()
        {
            _FillStudentObjectWithFieldsData();

            if (_student.Save())
            {
                lblTitle.Text = "Update Student";
                lblStudentID.Text = _student.StudentID.ToString();

                // change form mode to update
                _Mode = enMode.Update;

                clsMessages.GeneralSuccessMessage("Student");

                ctrlPersonCardWithFilter1.FilterEnabled = false;

                // Trigger the event to send data back to the caller form
                StudentIDBack?.Invoke(_student.StudentID);
            }
            else
            {
                clsMessages.GeneralErrorMessage("student");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }

            _Save();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, Study_center.Person.User_Controls.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            if (!e.PersonID.HasValue)
            {
                btnSave.Enabled = false;
                return;
            }

            if (_Mode == enMode.Add && clsPerson.IsPerson(e.PersonID.Value, clsPerson.EnType.student))
            {
                MessageBox.Show("This person is already registered as a student. Please select another person.",
                                "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            _studentID = e.PersonID;
            btnSave.Enabled = true;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void frmAddStudent_Activated(object sender, EventArgs e) => ctrlPersonCardWithFilter1.FilterFocus();

        private void txtEmergencyContactPhone_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
