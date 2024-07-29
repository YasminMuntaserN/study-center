using Guna.UI2.WinForms;
using Study_center.Global_Classes;
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
        private int? selectedTeacherID;

        private int? selectedGradeLevelSubjectID
            => (int)dgvGradeLevelSubjects.CurrentRow.Cells[0].Value;

        private clsTeacherSubject _TeacherSubject;

        private DataTable _dtTeacherSubjects;

        public frmAppointingTeacherForTheSubject()
        {
            InitializeComponent();
            _TeacherSubject = new clsTeacherSubject();
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

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAppointingTeacherForTheSubject_Load(object sender, EventArgs e)
        {
            // Fill Grade Levels In ComboBox
            HelperClass.FillComboBox(cbGradeLevels, clsGradeLevel.AllGradeLevelNames(), "GradeLevelName");

            // Fill Subjects In ComboBox
            HelperClass.FillComboBox(cbSubjects, clsSubject.AllSubjectNames(), "SubjectName");

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
    }
}
