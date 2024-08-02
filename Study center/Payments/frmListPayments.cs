using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Grade_Level_Subject;
using Study_center.Group;
using Study_center.Main_Menu;
using Study_center.Student;
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

namespace Study_center.Payments
{
    public partial class frmListPayments : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmListPayments(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? selectedPaymentID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            HelperClass.GetTotalPagesAndRows("Payments", 10, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsPayment.GetPaymentsByPage((int)NUMPageNumber.Value, totalRows);
            dgvList.DataSource = _dtList;

            lblRecordsNum.Text = (dgvList.Rows.Count).ToString();
        }

        private void NUMPageNumber_ValueChanged(object sender, EventArgs e) => _RefreshList();

        private void frmListPayments_Load(object sender, EventArgs e) => _RefreshList();

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

            // search with numbers
            _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", $"{cbFilter.Text.Trim()}", txtFilterBy.Text.Trim());

            lblRecordsNum.Text = (dgvList.Rows.Count).ToString();
        }

        private void miShowGroupsDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmGroupInfo((int)dgvList.CurrentRow.Cells[1].Value, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miShowStudentDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmShowStudentInfo((int)dgvList.CurrentRow.Cells[3].Value, this, this._mainMenuForm));
            _RefreshList();
        }

        private void miShowSubjectGradeLevelDetails_Click(object sender, EventArgs e)
        {
            int? GradeLevelSubjectID = clsGroup.Find((int)dgvList.CurrentRow.Cells[1].Value).GradeLevelSubjectID;
            this._mainMenuForm.ShowFormInPanel(new frmSubjectGradeLevelInfo(GradeLevelSubjectID, this, this._mainMenuForm));
            _RefreshList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilter.Text != "None");
        }
    }
}
