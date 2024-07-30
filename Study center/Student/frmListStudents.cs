using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Group;
using Study_center.Main_Menu;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static studyCenter_BusineesLayer.clsPerson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Study_center.Student
{
    public partial class frmListStudents : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmListStudents(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? selectedStudentID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            HelperClass.GetTotalPagesAndRows("Students", 8, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsStudent.GetStudentsByPage((int)NUMPageNumber.Value, 8);
            dgvList.DataSource = _dtList;

            lblRecordsNum.Text = _dtList.Rows.Count.ToString();
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

            lblRecordsNum.Text = _dtList.Rows.Count.ToString();
        }

        #region Fill comboBoxies
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilter.Text == "Student ID" || cbFilter.Text == "StudentName" || cbFilter.Text == "Age");
            cbGender.Visible = (cbFilter.Text == "Gender");
            cbGrades.Visible = (cbFilter.Text == "Grade");

            if (cbGender.Visible)
                cbGender.SelectedIndex = 0;

            if (cbGrades.Visible)
                cbGrades.SelectedIndex = 0;

        }

        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("GradeName", cbGrades);
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("Gender", cbGender);
        }

        private void _FillComboBoxies()
        {
            HelperClass.FillComboBox(cbGrades, clsGradeLevel.All(), "GradeLevelName");
        }

        #endregion

        private void btnGroups_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddStudent( this._mainMenuForm , this));
            _RefreshList();
        }

        private void frmListStudents_Load(object sender, EventArgs e)
        {
            _FillComboBoxies();
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

            if (cbFilter.Text != "StudentName")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", $"{cbFilter.Text.Trim()}", txtFilterBy.Text.Trim());
            }
            else
            {
                _dtList.DefaultView.RowFilter =
                    string.Format("[{0}] like '{1}%'", "StudentName", txtFilterBy.Text.Trim());
            }

            lblRecordsNum.Text = _dtList.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "StudentName")
            {
                //this will allow only digits if person id is selected
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void miShowStudentDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmShowStudentInfo(selectedStudentID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddStudent(selectedStudentID,this, this._mainMenuForm));
            _RefreshList();
        }

        private void miDelete_Click(object sender, EventArgs e)
        {

        }

        private void miAssignToGroup_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddAssignStudentToGroup(selectedStudentID,frmAddAssignStudentToGroup.enLoddingAccordingTo.StudentID ,this, this._mainMenuForm));
            _RefreshList();
        }
    }
}
