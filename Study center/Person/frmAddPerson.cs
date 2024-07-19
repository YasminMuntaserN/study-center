using Guna.UI2.WinForms;
using studyCenter_BusineesLayer;
using static studyCenter_BusineesLayer.clsPerson;
using System.ComponentModel;
using System.Windows.Forms;
using Study_center.Global_Classes;

namespace Study_center
{
    public partial class frmAddPerson : Form
    {
        public Action<int?> PersonIDBack;

        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        private int? _PersonID = null;
        private clsPerson _Person = null;

        public frmAddPerson()
        {
            _Mode = enMode.Add;
            InitializeComponent();
        }

        public frmAddPerson(int? PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                this.Text = "Update Person";
                lblTitle.Text = "Update Person";
            }
        }

        private void _FillPersonInfoInField()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.BirthDate;
            rbMale.Checked = (_Person.Gender == 0) ? true : rbFemale.Checked = true;
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                clsMessages.NotFound("person", _PersonID);

                this.Close();
                return;
            }

            _FillPersonInfoInField();
        }

        private void _FillPersonObjectWithFieldsData()
        {
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) ? null : txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Gender = (rbMale.Checked) ? clsPerson.EnGender.Male : clsPerson.EnGender.Female;
            _Person.BirthDate = dtpDateOfBirth.Value;
        }

        private void _Save()
        {
            _FillPersonObjectWithFieldsData();

            if (_Person.Save())
            {
                lblTitle.Text = "Update Person";
                this.Text = lblTitle.Text;
                lblPersonID.Text = _Person.PersonID.ToString();

                _Mode = enMode.Update;

                clsMessages.OperationDoneSuccessfully("Saved");

                PersonIDBack?.Invoke(_Person?.PersonID);
            }
            else
            {
                clsMessages.OperationFelid("Saved");
            }
        }

        private bool _CheckCorrectData()
        {
            if (!rbFemale.Checked && !rbMale.Checked)
            {
                errorProvider1.SetError(rbFemale, "You must select Gender");
                return false;
            }

            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

            return true;
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

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckCorrectData()) return;

            if (!ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }

            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPerson_Activated(object sender, EventArgs e) => txtFirstName.Focus();

    }
}
