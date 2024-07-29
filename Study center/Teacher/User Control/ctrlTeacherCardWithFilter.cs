using Study_center.Class;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
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
    public partial class ctrlTeacherCardWithFilter : UserControl
    {
        #region Shown In Main Menu
        private frmMainMenu mainMenuForm;
        private Form previousForm;
        public void SetMainMenuForm(frmMainMenu form)
        {
            this.mainMenuForm = form;
        }

        public void SetPreviousForm(Form form)
        {
            this.previousForm = form;
        }
        #endregion

        public event EventHandler TeacherSelected;

        private clsTeacher _Teacher;

        public clsTeacher TeacherInfo => _Teacher;

        public ctrlTeacherCardWithFilter()
        {
            InitializeComponent();
            ctrlPersonCardWithFilter1.SetSearchCriteria(ctrlPersonCardWithFilter.EnSearchCriteria.TeacherID);
        }

        private void FillTeacherInfoInFields()
        {
            ctrlPersonCardWithFilter1.setFilterEnabledAndLoadData(_Teacher.PersonID);
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
            OnTeacherSelected(EventArgs.Empty);
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
            OnTeacherSelected(EventArgs.Empty);
        }

        protected virtual void OnTeacherSelected(EventArgs e)
        {
            TeacherSelected?.Invoke(this, e);
        }

        private void llEditTeacherInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Teacher == null)
            {
                clsMessages.GeneralErrorMessage("Select Teacher First !");
                return;
            }
            frmAddTeacher frmAddTeacher = new frmAddTeacher(_Teacher.TeacherID, previousForm, mainMenuForm);
            mainMenuForm.ShowFormInPanel(frmAddTeacher);
            LoadTeacherInfo(_Teacher.TeacherID);
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            //  ctrlPersonCardWithFilter1.setFilterEnabledAndLoadData(_Teacher.PersonID);
            if (e.SearchCriteria == ctrlPersonCardWithFilter.EnSearchCriteria.PersonID)
            {
                LoadTeacherInfoByPerson(ctrlPersonCardWithFilter1.GetSelectedID);
            }
            else if (e.SearchCriteria == ctrlPersonCardWithFilter.EnSearchCriteria.TeacherID)
            {
                LoadTeacherInfo(ctrlPersonCardWithFilter1.GetSelectedID);
            }
        }

    }
}
