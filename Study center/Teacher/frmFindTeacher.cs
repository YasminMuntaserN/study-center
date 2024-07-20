using Study_center.Person.User_Controls;
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
    public partial class frmFindTeacher : Form
    {
        public frmFindTeacher()
        {
            InitializeComponent();
        }

        private void frmFindTeacher_Load(object sender, EventArgs e)
        {
            ctrlTeacherCard1.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
