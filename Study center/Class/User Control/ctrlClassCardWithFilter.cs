using Study_center.Global_Classes;
using Study_center.Person.User_Controls;
using studyCenter_BL_;
using StudyCenter_DAL_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Class.User_Control
{
    public partial class ctrlClassCardWithFilter : UserControl
    {
        public ctrlClassCardWithFilter()
        {
            InitializeComponent();
            ctrlFilter1.SetFilterOptions(new List<string> { "ClassID", "ClassName" });
        }

        private void ctrlFilter1_AddClicked(object sender, EventArgs e)
        {
            frmAddClass frmAddClass = new frmAddClass();
            frmAddClass.ClassIDBack += ctrlClassGard1.LoadClassData;
            ctrlFilter1.FilterEnabled = false;
            frmAddClass.ShowDialog();
        }

        private void ctrlFilter1_SearchClicked(object sender, EventArgs e)
        {
            string selectedFilter = ctrlFilter1.SelectedFilter;
            string filterValue = ctrlFilter1.FilterValue;
            if (selectedFilter == "ClassID")
            {
                int classId;
                if (!int.TryParse(filterValue, out classId))
                {
                    clsMessages.GeneralErrorMessage("Connt convert string value into numeric value");
                    return;
                }
                ctrlClassGard1.LoadClassData(classId);
            }
            else if (selectedFilter == "ClassName")
                ctrlClassGard1.LoadClassData(filterValue);
        }

    }
}
