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

namespace Study_center.Group
{
    public partial class frmGroupInfo : Form
    {
        private int? GroupID;

        private frmMainMenu _mainMenuForm;

        public frmGroupInfo(int? groupID, frmMainMenu mainMenuForm = null)
        {
            _mainMenuForm = mainMenuForm;
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

        private void frmGroupInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._mainMenuForm.ShowFormInPanel(new frmListGroups(this._mainMenuForm));
        }
    }
}
