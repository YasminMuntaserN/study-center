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
    public partial class frmFindClass : Form
    {
        public frmFindClass()
        {
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindClass_Load(object sender, EventArgs e)
        {
            ctrlClassCardWithFilter1.Focus();
        }

       
    }
}
