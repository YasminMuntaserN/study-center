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

namespace Study_center.Class
{
    public partial class frmClassInfo : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _classID;
        public frmClassInfo(int? classID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _classID = classID;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClassInfo_Load(object sender, EventArgs e)
        {
            ctrlClassGard1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlClassGard1.SetPreviousForm(this);
            ctrlClassGard1.LoadClassData(_classID);
        }

        private void frmClassInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }

      
    }
}
