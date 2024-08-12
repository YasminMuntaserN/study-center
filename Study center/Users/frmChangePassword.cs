using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using studyCenter_BL_;
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
    public partial class frmChangePassword : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _UserID = null;
        private clsUser _User;

        public frmChangePassword(int? UserID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.SetPreviousForm(this);
            ctrlUserCard1.SetMainMenuForm(mainMenuForm);


            _User = clsUser.Find(_UserID, clsUser.EnFindUserBy.UserID);

            if (_User == null)
            {
                clsMessages.NotFound("User", _UserID);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfoByUserID(_UserID);
        }

        private void _ChangePassword()
        {
            _User.Password = clsGlobal.ComputeHash(txtPassword.Text.Trim());

            if (_User.Save())
            {
                clsMessages.GeneralSuccessMessage("Password Changed Successfully.");
            }
            else
            {
                clsMessages.GeneralErrorMessage("An Error Occurred, Password did not change.");
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();

            // Check if the current password field is empty
            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "The current password cannot be blank. Please enter your current password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            //Validate the current password against the stored hash
            if (_User.Password !=clsGlobal.ComputeHash(currentPassword).Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "The entered password is incorrect. Please try again.");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void _TextBox_TextChanged(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).UseSystemPasswordChar = true;
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "The password field cannot be empty. Please enter a new password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }

            if (clsGlobal.ComputeHash(newPassword) == _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "This password is the same as your current one. Please choose a different password.");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string confirmPassword = txtConfirmPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The Confirm Password field cannot be empty. Please enter a new password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            string newPassword = txtPassword.Text.Trim();

            if (confirmPassword != newPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match. Please confirm your new password again.");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void frmChangePassword_Activated(object sender, EventArgs e)
        {
            txtCurrentPassword.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }
            _ChangePassword();


        }

        private void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
            else
            {
                mainMenuForm.ShowFormInPanel(mainMenuForm);
            }
        }
    }
}
