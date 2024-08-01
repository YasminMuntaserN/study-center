using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Teacher;
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

namespace Study_center.Users
{
    public partial class frmListUserscs : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmListUserscs(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? selectedUserID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            HelperClass.GetTotalPagesAndRows("Users", 8, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsUser.GetUsersByPage((int)NUMPageNumber.Value, 8);
            dgvList.DataSource = _dtList;

            lblRecordsNum.Text = (dgvList.Rows.Count - 1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddUser(this , _mainMenuForm));
            _RefreshList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilter.Text == "UserID" || cbFilter.Text == "UserName");
        }

        private void frmListUserscs_Load(object sender, EventArgs e) => _RefreshList();

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterBy.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsNum.Text = (dgvList.Rows.Count-1).ToString();

                return;
            }

            if (cbFilter.Text != "UserName")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", $"{cbFilter.Text.Trim()}", txtFilterBy.Text.Trim());
            }
            else
            {
                _dtList.DefaultView.RowFilter =
                    string.Format("[{0}] like '{1}%'", "UserName", txtFilterBy.Text.Trim());
            }

            lblRecordsNum.Text = (dgvList.Rows.Count - 1).ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "UserName")
            {
                //this will allow only digits if person id is selected
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void NUMPageNumber_ValueChanged(object sender, EventArgs e) => _RefreshList();

        private void miEdit_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddUser(selectedUserID, this, _mainMenuForm));
            _RefreshList();

        }

        private void miDelete_Click(object sender, EventArgs e)
        {

        }

        private void miChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void miShowUserDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmUserInfo(selectedUserID, this,_mainMenuForm));
            _RefreshList();
        }
    }
}
