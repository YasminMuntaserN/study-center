using Guna.UI2.WinForms;
using Study_center.Class;
using Study_center.Teacher;
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

            ShowFormInPanel(new frmTeacherInfo(2, this));
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

        private void lblPayments_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddClass(this));
        }
    }
}
