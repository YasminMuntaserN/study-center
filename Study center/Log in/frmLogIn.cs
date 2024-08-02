using Guna.UI2.WinForms;
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

namespace Study_center.Log_in
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }

            string hashedPassword = clsGlobal.ComputeHash(txtPassword.Text.Trim());

            if (!clsUser.Exists(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                txtUserName.Focus();
                clsMessages.GeneralErrorMessage("Cant be Found this User ! ");

                return;
            }

            clsUser User = clsUser.Find(txtUserName.Text.Trim(), clsUser.EnFindUserBy.UserNameAndPassword, txtPassword.Text.Trim());

            if (User == null)
            {
                txtUserName.Focus();
                clsMessages.GeneralErrorMessage("Cant be Found this User ! ");

                return;
            }

            if (cbRemeberMe.Checked)
            {
                //store username and password
                clsGlobal.RememberUsernameAndPassword
                    (txtUserName.Text.Trim(), clsGlobal.Encrypt(txtPassword.Text.Trim()));
            }
            else
            {
                //remove username and password
                clsGlobal.RemoveStoredCredential();
            }

            if (!User.IsActive)
            {
                txtUserName.Focus();

                MessageBox.Show("Your account is not Active, Contact Admin.",
                    "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentUser = User;
            this.Hide();
            frmMainMenu OpenMainMenu = new frmMainMenu(this);
            OpenMainMenu.ShowDialog();
        }

        private void ValidatingOfTextBoxes(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(((Guna2TextBox)sender), "This field is required!");
            }
            else
            {
                errorProvider1.SetError(((Guna2TextBox)sender), null);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = clsGlobal.Decrypt(Password);
                cbRemeberMe.Checked = true;
            }
            else
                cbRemeberMe.Checked = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
