using Guna.UI2.WinForms;
using Study_center.Global_Classes;
using Study_center.Main_Menu;
using Study_center.Teacher;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Person.User_Controls
{
    public partial class ctrlPersonCard : UserControl
    {
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
      
        public int? PersonID { get; private set; } = null;
        public clsPerson Person { get; private set; } = null;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            PersonID = null;
            Person = null;

            foreach (Guna2TextBox textBox in this.guna2GroupBox1.Controls.OfType<Guna2TextBox>())
            {
                textBox.ResetText();
            }
        }

        private void _FillPersonData()
        {
            lblPersonID.Text = Person.PersonID.ToString();
            lblFullName.Text = Person.FullName;
            lblGender.Text = Person.GenderText;
            lblEmail.Text = Person.Email ?? "N/A";
            lblPhone.Text = Person.Phone;
            lblDateOfBirth.Text = clsFormat.DateToShort(Person.BirthDate);
            lblAddress.Text = Person.Address;
            lblAge.Text = (DateTime.Now.Year - Person.BirthDate.Year).ToString();

            llEditPersonInfo.Enabled = true;
        }

        public void LoadPersonData(int? personID)
        {
            Person = clsPerson.Find(personID);

            if (Person == null)
            {
                Reset();
                clsMessages.NotFound("person", personID);
                return;
            }
            PersonID = personID;    
            _FillPersonData();
            return;
        }
     
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!PersonID.HasValue)
            {
                MessageBox.Show("Select person First !");
                return ;
            }
            frmAddPerson frmAddPerson = new frmAddPerson(PersonID,previousForm ,mainMenuForm);
            frmAddPerson.PersonIDBack += LoadPersonData;
            mainMenuForm.ShowFormInPanel(frmAddPerson);
        }
    }
}
