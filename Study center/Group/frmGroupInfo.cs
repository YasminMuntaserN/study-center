using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Group
{
    public partial class frmGroupInfo : Form
    {
        private int? GroupID;

        public frmGroupInfo(int? groupID)
        {
            InitializeComponent();
            GroupID = groupID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGroupInfo_Load(object sender, EventArgs e)
        {
            ctrlGroupCard1.LoadData(GroupID);
        }

    }
}
