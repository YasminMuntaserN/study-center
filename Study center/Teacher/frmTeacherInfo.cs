using Study_center.Class.User_Control;
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

namespace Study_center.Teacher
{
    public partial class frmTeacherInfo : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _TeacherID;
        public frmTeacherInfo(int? teacherID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _TeacherID = teacherID;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeacherInfo_Load(object sender, EventArgs e)
        {
            ctrlTeacherCardWithFilter1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlTeacherCardWithFilter1.SetPreviousForm(this); // Set the current form as the previous form
            ctrlTeacherCardWithFilter1.LoadTeacherInfo(_TeacherID);
        }

        private void frmTeacherInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }

    }
}
