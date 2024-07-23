using Microsoft.VisualBasic.ApplicationServices;
using Study_center.Global_Classes;
using studyCenter_BL_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Study_center.Teacher_and_Subject.frmAllTeachersWhoTeachSubject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Study_center.Teacher_and_Subject
{
    public partial class frmAllTeachersWhoTeachSubject : Form
    {
        private int? _GradeLevelSubjectID;

        public frmAllTeachersWhoTeachSubject(int? gradeLevelSubjectID)
        {
            InitializeComponent();
            _GradeLevelSubjectID = gradeLevelSubjectID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmAllTeachersWhoTeachSubject_Load(object sender, EventArgs e)
        {
            if (!_GradeLevelSubjectID.HasValue)
            {
                clsMessages.GeneralErrorMessage($"Grade Level Subject ID is not provided.");
                return;
            }

            ctrlListInfo1.FillTeachersWhoTeachSubject(_GradeLevelSubjectID);
        }
    }
}
