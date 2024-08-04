using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Person.User_Controls;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Teacher
{
    public partial class frmAddTeacher : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        public Action<int?> TeacherIDBack;

        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _teacherID = null;
        private clsTeacher _teacher = null;

        private int? _selectedPersonID => ctrlPersonCardWithFilter1.PersonID;

        public frmAddTeacher( frmMainMenu mainMenuForm = null, Form previousForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
        }

        public frmAddTeacher(int? TeacherId, frmMainMenu mainMenuForm = null, Form previousForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            _teacherID = TeacherId;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Teacher";
                _teacher = new clsTeacher();
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lblTitle.Text = "Update Teacher";
            }
        }

        private void _FillFieldsWithTeacherInfo()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(ctrlPersonCardWithFilter.EnSearchCriteria.PersonID, _teacher.PersonID);

            lblTeacherID.Text = _teacher.TeacherID.ToString();
            lblCreatedBy.Text = _teacher.GetUserName; ;
            dtpHireData.Value = _teacher.HireDate;
            txtQualification.Text = _teacher.Qualification;
            txtSalary.Text = _teacher.Salary.ToString("c");
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
            _teacher.Salary = decimal.Parse(txtSalary.Text, NumberStyles.Currency);
            _teacher.UserID =clsGlobal.CurrentUser.UserID ; 
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

        private void btnSave_Click_1(object sender, EventArgs e)
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

            if (_Mode == enMode.Add && clsPerson.IsPerson(e.PersonID.Value,clsTeacher.IsPersonTeacher))
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

            ctrlPersonCardWithFilter1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlPersonCardWithFilter1.SetPreviousForm(this); // Set the current form as the previous form
            _ResetTitles();
            ctrlPersonCardWithFilter1.SetSearchCriteria(ctrlPersonCardWithFilter.EnSearchCriteria.PersonID);
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

        private void frmAddTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
            else
            {
                mainMenuForm.ShowFormInPanel(new frmDashborder());
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            TeacherIDBack?.Invoke(_teacher.TeacherID);
            this.Close();
        }

 
    }
}

