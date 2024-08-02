using Guna.UI2.WinForms;
using Study_center.Class;
using Study_center.Global_Classes;
using Study_center.Grade_Level_Subject;
using Study_center.Group;
using Study_center.Log_in;
using Study_center.Meeting_Times;
using Study_center.Payments;
using Study_center.Student;
using Study_center.Subjects;
using Study_center.Teacher;
using Study_center.Teacher_and_Subject;
using Study_center.Users;
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

        private frmLogIn _loginScreen;

        public frmMainMenu(frmLogIn login)
        {
            _loginScreen = login;
            mainPanel = this.guna2CustomGradientPanel1;
            InitializeComponent();
        }

        public void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            // Check if the form size is greater than 895x594
            if (form.Width > 1000 || form.Height > 700)
            {
                // Set the panel location to (50, 70)
                this.guna2CustomGradientPanel1.Location = new Point(90, 46);
            }
            this.guna2CustomGradientPanel1.Size = form.Size;
            this.guna2CustomGradientPanel1.Controls.Clear();
            this.guna2CustomGradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmDashborder());

            _FillCounts();
        }

        private void _FillCounts()
        {
            lblClassesCount.Text = clsClass.Count().ToString();
            lblGradeLevelsCount.Text = clsGradeLevel.Count().ToString();
            lblSubjects.Text = clsSubject.Count().ToString();
            lblStudentCount.Text = clsStudent.Count().ToString();
            lblTeacherCount.Text = clsTeacher.Count().ToString();
            lblPayments.Text = clsPayment.Count().ToString();
            lblMeetingCounts.Text = clsTeacher.Count().ToString();
            lblGroupsCount.Text = clsGroup.Count().ToString();
            lblUsersCount.Text = clsUser.Count().ToString();


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
            ShowFormInPanel(new frmAddGradeLevelSubject(this));
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

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddAssignStudentToGroup(this));
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddUser(this));
        }
        #endregion

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListGroups(this));
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListStudents(this));
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmTeacherList(this));
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListSubjectsGradeLevel(this));
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListClasses(this));
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListPayments(this));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmDashborder());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListUserscs(this));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _loginScreen.Show();
            this.Close();
        }

        private void btnReserveSeat_Click(object sender, EventArgs e) => btnAddStudent.PerformClick();
    }
}
