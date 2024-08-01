using Study_center.Main_Menu;
using Study_center.Teacher;
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
    public partial class frmUserInfo : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _UserID;

        public frmUserInfo(int? UserID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            _UserID = UserID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlUserCard1.SetPreviousForm(this); // Set the current form as the previous form
            ctrlUserCard1.LoadUserInfoByUserID(_UserID);
        }

        private void frmUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }
    }
}
