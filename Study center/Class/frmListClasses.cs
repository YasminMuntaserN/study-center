using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Grade_Level_Subject;
using Study_center.Group;
using Study_center.Main_Menu;
using Study_center.Teacher;
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

namespace Study_center.Class
{
    public partial class frmListClasses : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmListClasses(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? ClassID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            HelperClass.GetTotalPagesAndRows("Classes", 8, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsClass.GetClassesByPage((int)NUMPageNumber.Value, 8);
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

            lblRecordsNum.Text = (dgvList.Rows.Count -1 ).ToString();
        }

        #region FillComboBoxies
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClasses.Visible = (cbFilter.Text == "Class Name");
            txtFilterBy.Visible = (cbFilter.Text == "Class ID");

            if (cbClasses.Visible)
                cbClasses.SelectedIndex = 0;

        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("className", cbClasses);
        }

        private void _FillComboBoxies()
        {
            HelperClass.FillComboBox(cbClasses, clsClass.All(), "ClassName");
        }

        #endregion

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddClass(this, this._mainMenuForm));
            _RefreshList();
        }

        private void NUMPageNumber_ValueChanged(object sender, EventArgs e) => _RefreshList();

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
                lblRecordsNum.Text = _dtList.Rows.Count.ToString();

                return;
            }

            if (cbFilter.Text == "Class ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", "ClassID", txtFilterBy.Text.Trim());
            }

        }

        private void miShowClassDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmClassInfo(ClassID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddClass(ClassID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miAddGroup_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddGroup(ClassID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miWhoTeachesIt_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmClassesAreTaughtByTeacher(ClassID, this, this._mainMenuForm));
            _RefreshList();

        }

        private void frmListClasses_Load(object sender, EventArgs e)
        {
            _FillComboBoxies();
            _RefreshList();
        }
    }
}
