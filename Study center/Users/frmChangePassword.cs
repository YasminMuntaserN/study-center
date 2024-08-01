using Guna.UI2.WinForms;
using Study_center.Global_Classes;
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
        private int? _UserID = null;
        private clsUser _User;

        public frmChangePassword(int? UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID, clsUser.EnFindUserBy.UserID);

            if (_User == null)
            {
                clsMessages.NotFound("Person", _UserID);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfoByUserID(_UserID);
        }

        private void _ChangePassword()
        {
            _User.Password = txtCurrentPassword.Text;
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
            if (string.IsNullOrEmpty(currentPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
            if (_User.Password != clsGlobal.ComputeHash(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong!");
                return;
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

            if (clsGlobal.Encrypt(newPassword) == _User.Password)
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

    }
}
