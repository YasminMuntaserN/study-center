using Study_center.Global_Classes;
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

namespace Study_center.Teacher
{
    public partial class frmAddTeacher : Form
    {
        public Action<int?> TeacherIDBack;

        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _teacherID = null;
        private clsTeacher _teacher = null;

        private int? _selectedPersonID => ctrlPersonCardWithFilter1.PersonID;

        public frmAddTeacher()
        {
            InitializeComponent();
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Teacher";
                _teacher = new clsTeacher();
                lblCreatedBy.Text = "Admin";
            }
            else
            {
                lblTitle.Text = "Update Teacher";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillFieldsWithTeacherInfo()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_teacher.PersonID);

            lblTeacherID.Text = _teacher.TeacherID.ToString();
            lblCreatedBy.Text = "Admin";
            dtpHireData.Value = _teacher.HireDate;
            txtQualification.Text = _teacher.Qualification;
            txtSalary.Text = _teacher.Salary.ToString();
        }

        private void _LoadData()
        {
            _teacher = clsTeacher.Find(_teacherID, clsTeacher.EnFindTeacherBy.TeacherID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_teacher == null)
            {
                clsMessages.NotFound("teacher", _teacherID);

                this.Close();
                return;
            }

            _FillFieldsWithTeacherInfo();
        }

        private void _FillTeacherObjectWithFieldsData()
        {
            _teacher.PersonID = _selectedPersonID;
            _teacher.HireDate = dtpHireData.Value;
            _teacher.Qualification = txtQualification.Text;
            _teacher.Salary = decimal.Parse(txtSalary.Text);
            _teacher.UserID = 1; // Assuming the logged-in user ID is 1
        }

        private void _Save()
        {
            _FillTeacherObjectWithFieldsData();

            if (_teacher.Save())
            {
                lblTitle.Text = "Update Teacher";
                lblTeacherID.Text = _teacher.TeacherID.ToString();

                // change form mode to update
                _Mode = enMode.Update;

                clsMessages.GeneralSuccessMessage("Teacher");

                ctrlPersonCardWithFilter1.FilterEnabled = false;

                // Trigger the event to send data back to the caller form
                TeacherIDBack?.Invoke(_teacher.TeacherID);
            }
            else
            {
                clsMessages.GeneralErrorMessage("teacher");
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

            if (_Mode == enMode.Add && clsPerson.IsPerson(e.PersonID.Value, clsPerson.EnType.Teacher))
            {
                MessageBox.Show("This person is already registered as a teacher. Please select another person.",
                                "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            _teacherID = e.PersonID;
            btnSave.Enabled = true;
        }

        private void frmAddTeacher_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void frmAddTeacher_Activated_1(object sender, EventArgs e) => ctrlPersonCardWithFilter1.FilterFocus();

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSalary, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalary, null);
            }
        }
    }
}

