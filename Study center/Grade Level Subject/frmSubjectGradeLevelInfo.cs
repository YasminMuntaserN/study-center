﻿using Study_center.Group.User_Control;
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

namespace Study_center.Grade_Level_Subject
{
    public partial class frmSubjectGradeLevelInfo : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        private int? _GradeLevelSubjectID;
        public frmSubjectGradeLevelInfo(int? gradeLevelSubjectID, Form previousForm = null, frmMainMenu mainMenuForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _GradeLevelSubjectID = gradeLevelSubjectID;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSubjectGradeLevelInfo_Load(object sender, EventArgs e)
        {
            ctrlGradeLevelSubjectCard1.SetMainMenuForm(mainMenuForm); // Set the main menu form reference
            ctrlGradeLevelSubjectCard1.SetPreviousForm(this); // Set the current form as the previous form
            ctrlGradeLevelSubjectCard1.LoadData(_GradeLevelSubjectID);
        }

        private void frmSubjectGradeLevelInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
        }

    }
}
