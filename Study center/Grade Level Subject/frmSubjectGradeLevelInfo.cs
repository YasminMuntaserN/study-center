using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Grade_Level_Subject
{
    public partial class frmSubjectGradeLevelInfo : Form
    {
        private int? _GradeLevelSubjectID;
        public frmSubjectGradeLevelInfo(int? gradeLevelSubjectID)
        {
            InitializeComponent();
            _GradeLevelSubjectID = gradeLevelSubjectID; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSubjectGradeLevelInfo_Load(object sender, EventArgs e)
        {
            ctrlGradeLevelSubjectCard1.LoadData(_GradeLevelSubjectID);
        }
    }
}
