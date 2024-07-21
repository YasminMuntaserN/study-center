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

namespace Study_center.Teacher
{
    public partial class ctrlTeacherCard : UserControl
    {

        private clsTeacher _Teacher;

        public clsTeacher TeacherInfo => _Teacher;

        public ctrlTeacherCard()
        {
            InitializeComponent();
            ctrlPersonCardWithFilter1.SetSearchCriteria(ctrlPersonCardWithFilter.EnSearchCriteria.TeacherID);
        }

        private void FillTeacherInfoInFields()
        {
            // Fill teacher-specific fields
            lblTeacherID.Text = _Teacher.TeacherID.ToString();
            lblHireDate.Text = _Teacher.HireDate.ToString("yyyy-MM-dd");
            lblQualification.Text = _Teacher.Qualification;
            lblSalary.Text = _Teacher.Salary.ToString("C");
            lblCreatedBy.Text = _Teacher.UserID.ToString();
        }

        public void LoadTeacherInfo(int? teacherID)
        {
            _Teacher = clsTeacher.Find(teacherID, clsTeacher.EnFindTeacherBy.TeacherID);

            if (_Teacher == null)
            {
                MessageBox.Show("Teacher not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillTeacherInfoInFields();
        }

        public void LoadTeacherInfoByPerson(int? personID)
        {
            _Teacher = clsTeacher.Find(personID, clsTeacher.EnFindTeacherBy.PersonID);

            if (_Teacher == null)
            {
                MessageBox.Show("Teacher not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillTeacherInfoInFields();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            if (e.SearchCriteria == ctrlPersonCardWithFilter.EnSearchCriteria.PersonID)
            {
                LoadTeacherInfoByPerson(ctrlPersonCardWithFilter1.GetSelectedID);
            }
            else if (e.SearchCriteria == ctrlPersonCardWithFilter.EnSearchCriteria.TeacherID)
            {
                LoadTeacherInfo(ctrlPersonCardWithFilter1.GetSelectedID);
            }
        }

        private void llEditTeacherInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddTeacher frmAddTeacher = new frmAddTeacher(_Teacher.TeacherID);
            frmAddTeacher.ShowDialog();
            LoadTeacherInfo(_Teacher.TeacherID);
        }
    }
}
