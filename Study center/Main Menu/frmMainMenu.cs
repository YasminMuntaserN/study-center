using Guna.UI2.WinForms;
using Study_center.Teacher;
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
            ShowFormInPanel(new frmTeacherInfo(2, this));
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }
    }
}
