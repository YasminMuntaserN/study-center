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
    public partial class frmFindClass : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        public frmFindClass(frmMainMenu mainMenu = null, Form previousForm = null)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenu;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindClass_Load(object sender, EventArgs e)
        {
            ctrlClassCardWithFilter1.SetMainMenuForm(mainMenuForm);
            ctrlClassCardWithFilter1.SetPreviousForm(previousForm);

            ctrlClassCardWithFilter1.Focus();
        }

       
    }
}
