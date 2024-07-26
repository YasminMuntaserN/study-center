using Study_center.Main_Menu;
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
    public partial class frmTeacherInfo : Form
    {
        private frmMainMenu mainMenuForm;
        private int? _TeacherID; 
        public frmTeacherInfo(int? teacherID , frmMainMenu mainMenu = null)
        {
            this.mainMenuForm = mainMenu;
            InitializeComponent();
            _TeacherID = teacherID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeacherInfo_Load(object sender, EventArgs e)
        {
            ctrlTeacherCardWithFilter1.LoadTeacherInfo(_TeacherID);
        }
    }
}
