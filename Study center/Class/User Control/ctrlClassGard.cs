using Microsoft.IdentityModel.Tokens;
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

namespace Study_center.Class.User_Control
{
    public partial class ctrlClassGard : UserControl
    {
        private clsClass _Class;
        private int? _ClassID;

        public int? ClassID => _ClassID;    
        public ctrlClassGard()
        {
            InitializeComponent();
        }

        #region Shown In Main Menu
        private frmMainMenu mainMenuForm;
        private Form previousForm;
        public void SetMainMenuForm(frmMainMenu form)
        {
            this.mainMenuForm = form;
        }

        public void SetPreviousForm(Form form)
        {
            this.previousForm = form;
        }
        #endregion

        private void _FillClassDetails()
        {
            lblClassID.Text = _ClassID.ToString();
            lblClassName.Text = _Class.ClassName;
            lblCapacity.Text =_Class.Capacity.ToString();
        }

        public void LoadClassData(int? classID)
        {
            if (!classID.HasValue)
            {
                clsMessages.GeneralErrorMessage($"Cannot find class with ID {classID}");
                return;
            }

            _ClassID = classID;
            _Class = clsClass.Find(_ClassID);

            if (_Class == null)
            {
                clsMessages.GeneralErrorMessage($"Cannot find class with ID {_ClassID}");
                return;
            }

            _FillClassDetails();
        }

        public void LoadClassData(string? className)
        {
            if (className.IsNullOrEmpty())
            {
                clsMessages.GeneralErrorMessage($"Cannot find class with Name {className}");
                return;
            }

           
            _Class = clsClass.Find(className);
            _ClassID = _Class.ClassID;

            if (_Class == null)
            {
                clsMessages.GeneralErrorMessage($"Cannot find class with ID {_ClassID}");
                return;
            }

            _FillClassDetails();
        }

        private void llEditClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddClass frmAddClass = new frmAddClass(_ClassID, mainMenuForm, previousForm);
            mainMenuForm.ShowFormInPanel(frmAddClass);
            LoadClassData(_ClassID);

        }
    }
}
