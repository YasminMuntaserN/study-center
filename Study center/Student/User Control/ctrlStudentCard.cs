using Study_center.Person.User_Controls;
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

namespace Study_center.Student.User_Control
{
    public partial class ctrlStudentCard : UserControl
    {
        private clsStudent _Student;

        public clsStudent StudentInfo => _Student;

        public ctrlStudentCard()
        {
            InitializeComponent();
        }

        private void FillStudentInfoInFelids()
        {
            // Fill student-specific fields
            lblGradeLevel.Text = clsGradeLevel.GetGradeLevelName(_Student.GradeLevelID);
            lblEmergencyContactPhone.Text = _Student.EmergencyContactPhone;
            lblEnrollmentDate.Text = _Student.EnrollmentDate.ToString("yyyy-MM-dd");
        }

        public void LoadStudentInfo(int? studentID)
        {
            _Student = clsStudent.Find(studentID, clsStudent.EnFindStudentBy.StudentID);

            if (_Student == null)
            {
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillStudentInfoInFelids();
        }

        public void LoadStudentInfoByPerson(int? PersonID)
        {
            _Student = clsStudent.Find(PersonID, clsStudent.EnFindStudentBy.PersonID);

            if (_Student == null)
            {
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillStudentInfoInFelids();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, Study_center.Person.User_Controls.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            if (e.SearchCriteria == ctrlPersonCardWithFilter.EnSearchCriteria.PersonID)
            {
                LoadStudentInfoByPerson(ctrlPersonCardWithFilter1.GetSelectedID);
            }
            else if (e.SearchCriteria == ctrlPersonCardWithFilter.EnSearchCriteria.StudentID)
            {
                LoadStudentInfo(ctrlPersonCardWithFilter1.GetSelectedID);
            }
        }

        private void llEditStudentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent(_Student.StudentID);
            frmAddStudent.ShowDialog();
            LoadStudentInfo(_Student.StudentID);
        }
    }
}
