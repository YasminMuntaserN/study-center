using Guna.UI2.WinForms;
using Study_center.Class;
using Study_center.Grade_Level_Subject;
using Study_center.Group;
using Study_center.Meeting_Times;
using Study_center.Student;
using Study_center.Subjects;
using Study_center.Teacher;
using Study_center.Teacher_and_Subject;
using studyCenter_BL_;
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

namespace Study_center.Main_Menu
{
    public partial class frmMainMenu : Form
    {
        private Guna2CustomGradientPanel mainPanel;

        private Button btnShowPeopleList;

        public frmMainMenu()
        {
            mainPanel = this.guna2CustomGradientPanel1;
            InitializeComponent();
        }
        public void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.guna2CustomGradientPanel1.Controls.Clear();
            this.guna2CustomGradientPanel1.Controls.Add(form);
            form.Show();
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            _FillCounts();

          
        }

        private void _FillCounts()
        {
            lblClassesCount.Text = clsClass.Count().ToString();
            lblGradeLevelsCount.Text = clsGradeLevel.Count().ToString();
            lblSubjects.Text = clsSubject.Count().ToString();
            lblStudentCount.Text = clsStudent.Count().ToString();
            lblTeacherCount.Text = clsTeacher.Count().ToString();
            //  lblPayments.Text = clsPa.Count().ToString();
            lblMeetingCounts.Text = clsTeacher.Count().ToString();
            lblGroupsCount.Text = clsGroup.Count().ToString();

        }

        #region added Buttons
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddClass(this));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddStudent(this));
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddSubject(this));
        }

        private void btnGradeLevel_Click(object sender, EventArgs e)
        {
            //  ShowFormInPanel(new frmAddGradeLevelSubject(this));
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddGroup(this));
        }

        private void btnAddMeetingTime_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddMeetingTime(this));
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddTeacher(this));
        }
        #endregion


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListGroups(this));
        }
    }
}
