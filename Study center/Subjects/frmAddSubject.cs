using Study_center.Global_Classes;
using Study_center.Main_Menu;
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

namespace Study_center.Subjects
{
    public partial class frmAddSubject : Form
    {
        private frmMainMenu mainMenuForm;

        public Action<int?> SubjectIDBack;
        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _subjectID = null;
        private clsSubject _subject = null;

        public frmAddSubject(frmMainMenu mainMenu = null)
        {
            this.mainMenuForm = mainMenu;
            InitializeComponent();
        }

        public frmAddSubject(int? subjectID, frmMainMenu mainMenu = null)
        {
            this.mainMenuForm = mainMenu;
            InitializeComponent();
            _subjectID = subjectID;
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Subject";
                _subject = new clsSubject();
            }
            else
            {
                lblTitle.Text = "Update Subject";
            }
        }

        private void _FillFieldsWithSubjectInfo()
        {
            txtSubjectName.Text = _subject.SubjectName;
        }

        private void _LoadData()
        {
            _subject = clsSubject.Find(_subjectID);

            if (_subject == null)
            {
                clsMessages.GeneralErrorMessage($"Subject with ID {_subjectID} not found.");
                this.Close();
                return;
            }

            _FillFieldsWithSubjectInfo();
        }

        private bool _checkCorrectData()
        {
            if (!ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return false;
            }

            if (clsSubject.Exists(txtSubjectName.Text.Trim()) && _Mode != enMode.Update)
            {
                clsMessages.GeneralErrorMessage("Failed to save Subject. This subject name already exists.");
                return false;
            }
            return true;
        }

        private void _FillSubjectObjectWithFieldsData()
        {
            _subject.SubjectName = txtSubjectName.Text.Trim();
        }

        private void _Save()
        {
            if (_subject.Save())
            {
                lblTitle.Text = "Update Subject";
                lblSubjectID.Text = _subject.SubjectID.ToString();
                _Mode = enMode.Update;
                clsMessages.GeneralSuccessMessage("Subject saved successfully.");
            }
            else
            {
                clsMessages.GeneralErrorMessage("Failed to save Subject.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillSubjectObjectWithFieldsData();

            if (!_checkCorrectData()) return;

            _Save();

            SubjectIDBack?.Invoke(_subject?.SubjectID);
        }

        private void txtSubjectName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubjectName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSubjectName, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtSubjectName, null);
            }
        }

        private void frmAddSubject_Load_1(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
