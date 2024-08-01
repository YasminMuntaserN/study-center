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
    public partial class frmGroupInfo : Form
    {
        private int? GroupID;

        private frmMainMenu mainMenuForm;
        private Form previousForm;

        public frmGroupInfo(int? groupID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            GroupID = groupID;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGroupInfo_Load(object sender, EventArgs e)
        {
            ctrlGroupCard1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlGroupCard1.SetPreviousForm(this); // Set the current form as the previous form

            ctrlGroupCard1.LoadData(GroupID);
        }

        private void frmGroupInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }

    }
}
