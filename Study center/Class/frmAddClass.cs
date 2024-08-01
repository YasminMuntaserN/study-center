using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Group.User_Control;
using Study_center.Main_Menu;
using Study_center.Teacher;
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

namespace Study_center.Class
{
    public partial class frmAddClass : Form
    {
        private Form previousForm;
        private frmMainMenu mainMenuForm;

        public Action<int?> ClassIDBack;
        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _classID = null;
        private clsClass _class = null;

        public frmAddClass( frmMainMenu mainMenuForm = null, Form previousForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
        }

        public frmAddClass(int? classID, frmMainMenu mainMenuForm = null, Form previousForm = null)
        {
            this.previousForm = previousForm;
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
            _classID = classID;
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Class";
                _class = new clsClass();
            }
            else
            {
                lblTitle.Text = "Update Class";
            }
        }

        private void _FillFieldsWithClassInfo()
        {
            txtClassName.Text = _class.ClassName;
            NuMCapacity.Value = _class.Capacity.HasValue ? _class.Capacity.Value : 0;
        }

        private void _LoadData()
        {
            _class = clsClass.Find(_classID);

            if (_class == null)
            {
                clsMessages.GeneralErrorMessage($"Class with ID {_classID} not found.");
                this.Close();
                return;
            }

            _FillFieldsWithClassInfo();
        }

        private bool _checkCorrectData()
        {
            if (!ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return false;
            }

            if (clsClass.Exists(txtClassName.Text.Trim()) && _Mode != enMode.Update)
            {
                clsMessages.GeneralErrorMessage("Failed to save Class., This class Name Exists ");
                return false;
            }
            return true;
        }

        private void _FillClassObjectWithFieldsData()
        {
            _class.ClassName = txtClassName.Text.Trim();
            _class.Capacity = (byte)NuMCapacity.Value;
        }

        private void _Save()
        {
            if (_class.Save())
            {
                lblTitle.Text = "Update Class";
                lblClassID.Text = _class.ClassID.ToString();
                _Mode = enMode.Update;
                clsMessages.GeneralSuccessMessage("Class saved successfully.");
            }
            else
            {
                clsMessages.GeneralErrorMessage("Failed to save Class.");
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _FillClassObjectWithFieldsData();

            if (!_checkCorrectData()) return;

            _Save();

            ClassIDBack?.Invoke(_class?.ClassID);
        }

        private void frmAddClass_Load_1(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void NuMCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (NuMCapacity.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(NuMCapacity, "Capacity must be greater than 0.");
            }
            else
            {
                errorProvider1.SetError(NuMCapacity, null);
            }
        }

        private void frmAddClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previousForm != null)
            {
                mainMenuForm.ShowFormInPanel(previousForm);
            }
            else
            {
                mainMenuForm.ShowFormInPanel(new frmDashborder());
            }
        }

    }

}
