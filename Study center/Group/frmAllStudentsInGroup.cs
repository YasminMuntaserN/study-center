using Study_center.Global_Classes;
using Study_center.Group.User_Control;
using Study_center.Main_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Group
{
    public partial class frmAllStudentsInGroup : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _GroupID;
       
        public frmAllStudentsInGroup(int? GroupID,Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            _GroupID = GroupID; 
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAllStudentsInGroup_Load(object sender, EventArgs e)
        {
            if (!_GroupID.HasValue)
            {
                clsMessages.GeneralErrorMessage($"Grade Level Subject ID is not provided.");
                return;
            }

            ctrlListInfo1.FillStudentsInGroup(_GroupID);
            ctrlListInfo1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlListInfo1.SetPreviousForm(previousForm);
        }

        private void frmAllStudentsInGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }
    }
}
