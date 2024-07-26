using Study_center.Class;
using Study_center.Global_Classes;
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

namespace Study_center.Group.User_Control
{
    public partial class ctrlGroupCard : UserControl
    {
        private clsGroup _Group;
        private int? _GroupID;

        public ctrlGroupCard()
        {
            InitializeComponent();
        }

        private void _FillObjectInFailed()
        {
            lblGroupID.Text = _GroupID.ToString();
            lblGradeLevelSubjectID.Text = _Group.GradeLevelSubjectID.ToString();
            lblStudentCount.Text = _Group.GroupStudentCount.ToString();
            lblGroupName.Text = _Group.GroupName;
            lblTeacherSubjectID.Text = _Group.TeacherSubjectID.ToString();
            lblClasssID.Text = _Group.ClassID.ToString();
            lblMeetingTimesID.Text = _Group.MeetingTimeID.ToString();
            lblIsActive.Text = _Group.IsActive ? "Active" : "Inactive";
            lblCreationDate.Text = _Group.CreationDate.ToString("g");
        }

        public void LoadData(int? groupID)
        {
            if (!groupID.HasValue)
            {
                clsMessages.GeneralErrorMessage($"Cannot Find Group with ID {_GroupID}");
                return;
            }

            _GroupID = groupID;

            _Group = clsGroup.Find(_GroupID);
            if (_Group == null)
            {
                clsMessages.GeneralErrorMessage($"Cannot Find Group with ID {_GroupID}");
                return;
            }

            _FillObjectInFailed();
        }

        private void llWhoTeachesIt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTeacherInfo frm = new frmTeacherInfo(_Group.TeacherSubjectInfo.TeacherID);
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmClassInfo frm =new frmClassInfo(_Group.ClassID);
            frm.ShowDialog();
        }
    }
}
