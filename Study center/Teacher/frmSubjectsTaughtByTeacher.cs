using Study_center.Global_Classes;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
using StudyCenter_DAL_;
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
    public partial class frmSubjectsTaughtByTeacher : Form
    {
        private int? _TeacherID;
        public frmSubjectsTaughtByTeacher(int? TeacherID)
        {
            _TeacherID = TeacherID;
            InitializeComponent();
        }
      
        private void _FillData()
        {
            if (_TeacherID == null)
            {
                clsMessages.GeneralErrorMessage($"No Teacher with ID : {_TeacherID}");
                return;
            }
            ctrlTeacherCard1.LoadTeacherInfo(_TeacherID);

            clsTeacher teacherInfo = clsTeacher.Find(_TeacherID, clsTeacher.EnFindTeacherBy.TeacherID);

            if (teacherInfo != null)
            {
                string prefix = teacherInfo.Gender == clsPerson.EnGender.Male ? "Mr." : "Ms.";
                lblTeacherName.Text = string.Concat(prefix, ' ', teacherInfo.FullName);
            }

            dgvGradeLevelSubjects.DataSource = clsTeacherSubject.GetSubjectsByTeacherID(_TeacherID);
        }

        private void frmSubjectsTaughtByTeacher_Load(object sender, EventArgs e)
        {
            _FillData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
