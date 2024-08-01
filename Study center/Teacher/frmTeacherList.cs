using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Group;
using Study_center.Main_Menu;
using Study_center.Student;
using Study_center.Teacher_and_Subject;
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
using static studyCenter_BusineesLayer.clsPerson;

namespace Study_center.Teacher
{
    public partial class frmTeacherList : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmTeacherList(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? selectedTeacherID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            HelperClass.GetTotalPagesAndRows("Teachers", 8, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsTeacher.GetTeachersByPage((int)NUMPageNumber.Value, 8);
            dgvList.DataSource = _dtList;

            lblRecordsNum.Text = (_dtList.Rows.Count - 1).ToString();
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

            lblRecordsNum.Text = (_dtList.Rows.Count - 1).ToString();
        }

        #region Fill comboBoxies
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilter.Text == "TeacherID" || cbFilter.Text == "TeacherName" || cbFilter.Text == "Age");
            cbGender.Visible = (cbFilter.Text == "Gender");

            if (cbGender.Visible)
                cbGender.SelectedIndex = 0;

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("Gender", cbGender);
        }
        #endregion

        private void frmTeacherList_Load(object sender, EventArgs e) => _RefreshList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddTeacher( this._mainMenuForm, this));
            _RefreshList();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterBy.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsNum.Text = _dtList.Rows.Count.ToString();

                return;
            }

            if (cbFilter.Text != "TeacherName")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", $"{cbFilter.Text.Trim()}", txtFilterBy.Text.Trim());
            }
            else
            {
                _dtList.DefaultView.RowFilter =
                    string.Format("[{0}] like '{1}%'", "TeacherName", txtFilterBy.Text.Trim());
            }

            lblRecordsNum.Text = (_dtList.Rows.Count - 1).ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "TeacherName")
            {
                //this will allow only digits if person id is selected
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void NUMPageNumber_ValueChanged(object sender, EventArgs e) => _RefreshList();

        private void miShowTeacherDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmTeacherInfo(selectedTeacherID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddTeacher(selectedTeacherID, this._mainMenuForm, this));
            _RefreshList();
        }

        private void miDelete_Click(object sender, EventArgs e)
        {

        }

        private void miAssignToSubject_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAppointingTeacherForTheSubject(selectedTeacherID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miSubjectsHeTeaches_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmSubjectsTaughtByTeacher(selectedTeacherID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miClassesheTeaches_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmClassesAreTaughtByTeacher(selectedTeacherID, this, this._mainMenuForm));
            _RefreshList();
        }
    }
}
