using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Class
{
    public partial class frmClassInfo : Form
    {
        private int? _classID;
        public frmClassInfo(int? classID)
        {
            InitializeComponent();
            _classID = classID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClassInfo_Load(object sender, EventArgs e)
        {
            ctrlClassGard1.LoadClassData(_classID);
        }
    }
}
