﻿using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Group;
using Study_center.Main_Menu;
using Study_center.Teacher_and_Subject;
using studyCenter_Bl_;
using studyCenter_BL_;
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

namespace Study_center.Grade_Level_Subject
{
    public partial class frmListSubjectsGradeLevel : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmListSubjectsGradeLevel(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? selectedSubjectsGradeLevelID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            HelperClass.GetTotalPagesAndRows("GradeLevelSubjects", clsGlobal.Rows, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsGradeLevelSubject.GetGradeLevelSubjectByPage((int)NUMPageNumber.Value, clsGlobal.Rows);
            dgvList.DataSource = _dtList;

            lblRecordsNum.Text = (dgvList.Rows.Count).ToString();
        }

        private void _Search(string searchBy, Guna2ComboBox comboBox)
        {
            if (_dtList == null || _dtList.Rows.Count == 0)
                return;

            if (comboBox.Text == "All")
            {
                _dtList.DefaultView.RowFilter = "";
                return;
            }

            _dtList.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", $"{searchBy}", comboBox.Text);

            lblRecordsNum.Text = (dgvList.Rows.Count).ToString();
        }

        #region Fill comboBoxies
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGradeLevels.Visible = (cbFilter.Text == "Grade Level");
            txtFilterBy.Visible = (cbFilter.Text == "Subject Grade Level ID");
            cbSubjects.Visible = (cbFilter.Text == "Subject Name");

            if (cbGradeLevels.Visible)
                cbGradeLevels.SelectedIndex = 0;

            if (cbSubjects.Visible)
                cbSubjects.SelectedIndex = 0;

        }

        private void cbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("GradeLevelName", cbGradeLevels);
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("SubjectName", cbSubjects);
        }

        private void _FillComboBoxies()
        {
            HelperClass.FillComboBox(cbSubjects, clsSubject.All(), "SubjectName");
            HelperClass.FillComboBox(cbGradeLevels, clsGradeLevel.All(), "GradeLevelName");
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddGradeLevelSubject( this._mainMenuForm, this));
            _RefreshList();
        }

        private void frmListSubjectsGradeLevel_Load(object sender, EventArgs e)
        {
            _FillComboBoxies();
            _RefreshList();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits if person id is selected
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterBy.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsNum.Text = (dgvList.Rows.Count).ToString();

                return;
            }

            if (cbFilter.Text == "Subject Grade Level ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", "GradeLevelSubjectID", txtFilterBy.Text.Trim());
            }

        }

        private void miShowSubjectsDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmSubjectGradeLevelInfo(selectedSubjectsGradeLevelID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddGradeLevelSubject(selectedSubjectsGradeLevelID, this._mainMenuForm, this));
            _RefreshList();
        }

        private void miWhoTeachesIt_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAllTeachersWhoTeachSubject(selectedSubjectsGradeLevelID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void NUMPageNumber_ValueChanged(object sender, EventArgs e) => _RefreshList();

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
 