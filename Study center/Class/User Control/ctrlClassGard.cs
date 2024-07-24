using Study_center.Global_Classes;
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

        public ctrlClassGard()
        {
            InitializeComponent();
        }

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

        private void llEditClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddClass frmAddClass = new frmAddClass(_ClassID);
            frmAddClass.ShowDialog();   
        }
    }
}
