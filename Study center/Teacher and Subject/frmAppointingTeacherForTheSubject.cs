using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using studyCenter_Bl_;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Teacher_and_Subject
{
    public partial class frmAppointingTeacherForTheSubject : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? selectedTeacherID;

        private enum _enMode { AddNew, Update };
        private _enMode _mode = _enMode.AddNew;

        private int? selectedGradeLevelSubjectID
            => (int)dgvGradeLevelSubjects.CurrentRow.Cells[0].Value;

        private clsTeacherSubject _TeacherSubject;

        private DataTable _dtTeacherSubjects;

        public frmAppointingTeacherForTheSubject(Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _TeacherSubject = new clsTeacherSubject();
        }

        public frmAppointingTeacherForTheSubject(int? TeacherID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            selectedTeacherID = TeacherID;
            InitializeComponent();
            _TeacherSubject = new clsTeacherSubject();
            _mode = _enMode.Update;
        }

        private void _FillGradeLevelSubjectInfo()
        {
            _TeacherSubject.GradeLevelSubjectID = selectedGradeLevelSubjectID;
            _TeacherSubject.TeacherID = selectedTeacherID;
        }

        private bool _CheckCorrectData()
        {
            if (clsTeacherSubject.IsTeachingSubject(selectedTeacherID, selectedGradeLevelSubjectID))
            {
                MessageBox.Show("This teacher is currently teaching the specified subject.",
                    "Teacher Subject Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (!selectedGradeLevelSubjectID.HasValue)
            {
                clsMessages.GeneralErrorMessage("Please select a subject.");
                return false;
            }
            return true;
        }

        private void frmAppointingTeacherForTheSubject_Load(object sender, EventArgs e)
        {
            ctrlTeacherCard1.SetPreviousForm(this);
            ctrlTeacherCard1.SetMainMenuForm(mainMenuForm);
            // Fill Grade Levels In ComboBox
            HelperClass.FillComboBox(cbGradeLevels, clsGradeLevel.AllGradeLevelNames(), "GradeLevelName");

            // Fill Subjects In ComboBox
            HelperClass.FillComboBox(cbSubjects, clsSubject.AllSubjectNames(), "SubjectName");

            if (_mode == _enMode.Update)
                ctrlTeacherCard1.LoadTeacherInfo(selectedTeacherID);

            _dtTeacherSubjects = clsGradeLevelSubject.GetAllGradeLevelSubjectsWithNames();
            dgvGradeLevelSubjects.DataSource = _dtTeacherSubjects;
        }

        private void _Search(string searchBy, Guna2ComboBox comboBox)
        {
            if (_dtTeacherSubjects == null || _dtTeacherSubjects.Rows.Count == 0)
                return;

            if (comboBox.Text == "All")
            {
                _dtTeacherSubjects.DefaultView.RowFilter = "";

                return;
            }

            _dtTeacherSubjects.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", $"{searchBy}", comboBox.Text);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubjects.Visible = (cbFilter.Text == "Subject");

            cbGradeLevels.Visible = (cbFilter.Text == "Grade Level");

            if (cbSubjects.Visible)
                cbSubjects.SelectedIndex = 0;

            if (cbGradeLevels.Visible)
                cbGradeLevels.SelectedIndex = 0;
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("SubjectName", cbSubjects);
        }

        private void cbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("GradeLevelName", cbGradeLevels);
        }

        private void frmAppointingTeacherForTheSubject_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ctrlTeacherCard1.TeacherInfo == null)
            {
                clsMessages.GeneralErrorMessage("Please select a teacher.");
                return;
            }
            else
            {
                selectedTeacherID = ctrlTeacherCard1.TeacherInfo.TeacherID;

            }

            if (!_CheckCorrectData()) return;

            _FillGradeLevelSubjectInfo();

            // Save the new assignment
            if (_TeacherSubject.Save())
            {
                clsGradeLevelSubject levelSubject = clsGradeLevelSubject.Find(selectedGradeLevelSubjectID);
                clsMessages.GeneralSuccessMessage($"Teacher with ID : {selectedTeacherID} has been appointed to teach : {levelSubject.Title} ," +
                    $"with Teacher Subject ID : {_TeacherSubject.TeacherSubjectID}");
            }
            else
            {
                MessageBox.Show("Failed to assign teacher to subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
