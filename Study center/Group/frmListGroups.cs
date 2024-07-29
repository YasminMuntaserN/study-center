using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Group
{
    public partial class frmListGroups : Form
    {
        private DataTable _dtList;
        private frmMainMenu _mainMenuForm;

        public frmListGroups(frmMainMenu mainMenuForm = null)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
        }

        private int? selectedGroupID => (int)dgvList.CurrentRow.Cells[0].Value;

        private void _RefreshList()
        {
            int totalRows;
            int totalPages;
            clsGroup.GetTotalPagesAndRows(10, out totalRows, out totalPages);

            //DataTable groupsTable = bl.GetGroupsByPage(pageNumber, pageSize);
            NUMPageNumber.Maximum = totalPages;
            _dtList = clsGroup.GetGroupsByPage((int)NUMPageNumber.Value, totalRows);
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
        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbGroups.Visible = (cbFilter.Text == "Group Name");
            txtFilterBy.Visible = (cbFilter.Text == "Group ID");
            cbTeachers.Visible = (cbFilter.Text == "Teacher Name");
            cbSubjects.Visible = (cbFilter.Text == "Subject Name");
            cbClasses.Visible = (cbFilter.Text == "Class Name");
            cbMeetingTimes.Visible = (cbFilter.Text == "Meeting Days");


            if (cbGroups.Visible)
                cbGroups.SelectedIndex = 0;

            if (cbTeachers.Visible)
                cbTeachers.SelectedIndex = 0;

            if (cbSubjects.Visible)
                cbSubjects.SelectedIndex = 0;

            if (cbClasses.Visible)
                cbClasses.SelectedIndex = 0;

            if (cbMeetingTimes.Visible)
                cbMeetingTimes.SelectedIndex = 0;
        }

        private void cbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("TeacherName", cbTeachers);
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("ClassName", cbClasses);
        }

        private void cbGroups_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _Search("GroupName", cbGroups);
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("SubjectName", cbSubjects);
        }

        private void cbMeetingTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Search("MeetingDays", cbMeetingTimes);
        }

        #endregion

        private void _FillComboBoxWithGroupNames()
        {
            cbGroups.Items.Clear();

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                cbGroups.Items.Add(letter);
            }
        }

        private void _FillComboBoxies()
        {
            HelperClass.FillComboBox(cbSubjects, clsSubject.All(), "SubjectName");
            _FillComboBoxWithGroupNames();
            HelperClass.FillComboBox(cbTeachers, clsTeacher.All(), "TeacherName");
            HelperClass.FillComboBox(cbClasses, clsClass.All(), "ClassName");
            HelperClass.FillComboBox(cbMeetingTimes, MeetingPattern.AllPatterns(), "EncodedDays");
        }

        private void frmListGroups_Load(object sender, EventArgs e)
        {
            _FillComboBoxies();
            _RefreshList();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddGroup(this._mainMenuForm));
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
                lblRecordsNum.Text = _dtList.Rows.Count.ToString();

                return;
            }

            if (cbFilter.Text == "Group ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", "GroupID", txtFilterBy.Text.Trim());
            }

            lblRecordsNum.Text = _dtList.Rows.Count.ToString();
        }

        private void miShowGroupsDetails_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmGroupInfo(selectedGroupID, this._mainMenuForm));
            _RefreshList();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddGroup(selectedGroupID, this._mainMenuForm));
            _RefreshList();
        }

        private void miDelete_Click(object sender, EventArgs e)
        {

        }

        private void miAddStudent_Click(object sender, EventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmAddAssignStudentToGroup(selectedGroupID
                ,frmAddAssignStudentToGroup.enLoddingAccordingTo.GroupID ,this._mainMenuForm));
            _RefreshList();
        }
    }
}
