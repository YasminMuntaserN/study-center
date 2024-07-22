using Study_center.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Teacher_and_Subject
{
    public partial class frmAllTeachersWhoTeachSubject : Form
    {
        private int? _TeacherSubject;

        public frmAllTeachersWhoTeachSubject(int? TeacherSubject)
        {
            InitializeComponent();
            _TeacherSubject = TeacherSubject;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAllTeachersWhoTeachSubject_Load(object sender, EventArgs e)
        {
            if (!_TeacherSubject.HasValue)
            {
                clsMessages.GeneralErrorMessage($"There is no Teacher Subject for this ID:{_TeacherSubject} ");
                return;
            }
            ctrlListInfo1.FillTeachersWhoTeachSubject(_TeacherSubject);
        }
    }
}
