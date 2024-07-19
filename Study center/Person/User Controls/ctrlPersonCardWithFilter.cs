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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public class SelectPersonEventArgs : EventArgs
        {
            public int? PersonID { get; }

            public SelectPersonEventArgs(int? PersonID)
            {
                this.PersonID = PersonID;
            }
        }

        public event EventHandler<SelectPersonEventArgs> OnPersonSelectedEvent;

        public void OnPersonSelected(int? PersonID)
        {
            if (OnPersonSelectedEvent != null)
            {
                OnPersonSelectedEvent(this, new SelectPersonEventArgs(PersonID));
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get => _FilterEnabled;

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private clsPerson _Person;
        private int? _PersonID;
        public clsPerson PersonInfo => _Person;
        public int? PersonID => _PersonID;

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int? PersonID)
        {
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonData(PersonID);

            if (OnPersonSelectedEvent != null)
                OnPersonSelected(ctrlPersonCard1?.PersonID);
            _Person = ctrlPersonCard1.Person;
            _PersonID = PersonID;

        }

        private void DataBackEvent(int? PersonID)
        {
            cbFilter.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonData(PersonID);
            _Person = ctrlPersonCard1.Person;
            _PersonID = _Person.PersonID;
        }

        private void FindNow()
        {
            if (!(cbFilter.SelectedIndex > -1))
            {
                errorProvider1.SetError(cbFilter, "You must choose how you want to search");
                return;
            }
            var personId = int.Parse(txtFilterValue.Text.Trim());

            if (cbFilter.Text.Trim() == "Person ID" && !clsPerson.DoesPersonExist(personId))
            {
                clsMessages.AddToSystem("Person");
                return;
            }

            LoadPersonInfo(personId);

            _PersonID = _Person.PersonID;

        }

        public void FilterFocus() => txtFilterValue.Focus();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.PersonIDBack += DataBackEvent;
            frmAddPerson.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e) => FindNow();

    }
}
