using Guna.UI2.WinForms;
using Study_center.Global_Classes;
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

        public bool LoadPersonData(int? personID)
        {
            Person = clsPerson.Find(personID);

            if (Person == null)
            {
                Reset();
                clsMessages.NotFound("person", personID);
                return false;
            }

            _FillPersonData();
            return true;
        }
     
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson(PersonID);
            frmAddPerson.ShowDialog();  
        }
    }
}
