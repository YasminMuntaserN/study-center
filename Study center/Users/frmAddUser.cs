using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Person.User_Controls;
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
    public partial class frmAddUser : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        public Action<int?> UserIDBack;
        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        private int? _UserID ;
        private clsUser _User ;

        public frmAddUser( frmMainMenu mainMenuForm = null, Form previousForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddUser(int? UserID, frmMainMenu mainMenuForm = null, Form previousForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            _UserID = UserID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
            }
            else
            {
                this.Text = "Update User";
                lblTitle.Text = "Update User";
                gbPassword.Visible = false; 
            }
        }

        private void _FillUserInfoInField()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(ctrlPersonCardWithFilter.EnSearchCriteria.PersonID, _User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtConfirmPassword.Text = _User.Password;
            txtPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID, clsUser.EnFindUserBy.UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                clsMessages.NotFound("User", _UserID);

                this.Close();
                return;
            }

            _FillUserInfoInField();
        }

        private void _FillUserObjectWithFieldsData()
        {
            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            if (_Mode == enMode.Add)
            {
                _User.Password = clsGlobal.ComputeHash(txtPassword.Text.Trim());
            }
            _User.IsActive = cbIsActive.Checked;
        }

        private bool _CheckForCorrectData()
        {
            if (ctrlPersonCardWithFilter1.PersonInfo == null)
            {
                btnSave.Enabled = false;
                clsMessages.GeneralErrorMessage("You have to select a person first!");
                return false;
            }

            if (_Mode == enMode.Add && clsUser.Exists(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Username has already been used!");
                return false;
            }

            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "The password confirmation field does not match the password");
                return false;
            }


            if (!this.ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return false;
            }

            return true;
        }

        private void _Save()
        {
            _FillUserObjectWithFieldsData();

            if (_User.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;
                lblUserID.Text = _User.UserID.ToString();

                // change form mode to update
                _Mode = enMode.Update;

                clsMessages.OperationDoneSuccessfully("Saved");

                // Trigger the event to send data back to the caller form
                UserIDBack?.Invoke(_User?.UserID);
            }
            else
            {
                clsMessages.OperationFelid("Saved");
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserIDBack?.Invoke(_User.UserID);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_CheckForCorrectData())
            {
                return;
            }

            _Save();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.SetMainMenuForm(mainMenuForm);
            ctrlPersonCardWithFilter1.SetPreviousForm(this);

            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, Study_center.Person.User_Controls.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            if (!e.PersonID.HasValue)
            {
                btnSave.Enabled = false;
                return;
            }

            if (_Mode == enMode.Add && clsPerson.IsPerson(e.PersonID.Value, clsPerson.EnType.User))
            {
                MessageBox.Show("This person is already registered as a User. Please select another person.",
                                "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            _UserID = e.PersonID;
            btnSave.Enabled = true;
        }

        private void frmAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
            else
            {
                mainMenuForm.ShowFormInPanel(new frmDashborder() );
            }
        }

        private void _TextBox_TextChanged(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).UseSystemPasswordChar = true;
        }
    }
}
