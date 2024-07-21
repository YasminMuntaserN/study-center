using Study_center.Global_Classes;
using studyCenter_Bl_;
using studyCenter_BusineesLayer;
using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Grade_Level_Subject
{
    public partial class frmAddGradeLevelSubject : Form
    {
        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _gradeLevelSubjectID = null;
        private clsGradeLevelSubject _gradeLevelSubject = null;

        public frmAddGradeLevelSubject()
        {
            InitializeComponent();
        }

        public frmAddGradeLevelSubject(int? gradeLevelSubjectID)
        {
            InitializeComponent();
            _gradeLevelSubjectID = gradeLevelSubjectID;
            _Mode= enMode.Update;  
        }

        private void _ResetTitles()
        {
            // Fill Grade Levels In ComboBox
            HelperClass.FillComboBox(cbGradeLevels, clsGradeLevel.AllGradeLevelNames(), "GradeLevelName");

            // Fill Subjects In ComboBox
            HelperClass.FillComboBox(cbSubjects, clsSubject.AllSubjectNames(), "SubjectName");

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Grade Level Subject";
                _gradeLevelSubject = new clsGradeLevelSubject();
            }
            else
            {
                lblTitle.Text = "Update Grade Level Subject";
            }
        }

        private void _FillFieldsWithGradeLevelSubjectInfo()
        {
            cbGradeLevels.SelectedIndex = cbGradeLevels.FindString(clsGradeLevel.GetGradeLevelName(_gradeLevelSubject.GradeLevelID));
            cbSubjects.SelectedIndex = cbSubjects.FindString(clsSubject.GetSubjectName(_gradeLevelSubject.SubjectID));
            txtFees.Text = _gradeLevelSubject.Fees.ToString();
            lblGradeLevelSubjectTitle.Text = _gradeLevelSubject.Title;
        }

        private void _LoadData()
        {
            _gradeLevelSubject = clsGradeLevelSubject.Find(_gradeLevelSubjectID);

            if (_gradeLevelSubject == null)
            {
                clsMessages.GeneralErrorMessage($"Grade Level Subject with ID {_gradeLevelSubjectID} not found.");
                this.Close();
                return;
            }

            _FillFieldsWithGradeLevelSubjectInfo();
        }

        private bool _checkCorrectData()
        {
            if (!ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return false;
            }

            if (clsGradeLevelSubject.CheckIfTitleExists(lblGradeLevelSubjectTitle.Text.Trim())&& _Mode != enMode.Update)
            {
                clsMessages.GeneralErrorMessage("Failed to save Grade Level Subject.");
                return false;
            }
            return true;
        }

        private void _FillGradeLevelSubjectObjectWithFieldsData()
        {
            _gradeLevelSubject.GradeLevelID = clsGradeLevel.GetGradeLevelID(cbGradeLevels.Text); ;
            _gradeLevelSubject.SubjectID = clsSubjectData.GetSubjectID(cbSubjects.Text);
            _gradeLevelSubject.Fees = decimal.Parse(txtFees.Text);
            if (_gradeLevelSubject.GenerateTitle())
            {
                lblGradeLevelSubjectTitle.Text = _gradeLevelSubject.Title;
            }
            else
            {
                clsMessages.GeneralErrorMessage("Cant Provide Grade Level Subject Title");
            }
        }

        private void _Save()
        {
            if (_gradeLevelSubject.Save())
            {
                lblTitle.Text = "Update Grade Level Subject";
                lblGradeLevelSubjectID.Text = _gradeLevelSubject.GradeLevelSubjectID.ToString();
                // change form mode to update
                _Mode = enMode.Update;
                clsMessages.GeneralSuccessMessage("Grade Level Subject saved successfully.");
            }
            else
            {
                clsMessages.GeneralErrorMessage("Failed to save Grade Level Subject.");
            }
           
        }

        private void frmAddGradeLevelSubject_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            _FillGradeLevelSubjectObjectWithFieldsData();

            if (!_checkCorrectData()) return;

            _Save();
        }

        private void txtFees_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required!");
                return;
            }
            else if (!decimal.TryParse(txtFees.Text, out decimal fees))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid fee amount!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
