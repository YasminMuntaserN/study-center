using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Global_User_Controls
{
    public partial class ctrlFilter : UserControl
    {
        #region Filter Enabled
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get => _FilterEnabled;

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        #endregion
        public event EventHandler SearchClicked;
        public event EventHandler AddClicked;

        public ctrlFilter()
        {
            InitializeComponent();
        }

        public void SetFilterOptions(List<string> options)
        {
            cbFilter.Items.Clear();
            cbFilter.Items.AddRange(options.ToArray());
            if (cbFilter.Items.Count > 0)
            {
                cbFilter.SelectedIndex = 0;
            }
        }

        public string SelectedFilter => cbFilter.SelectedItem?.ToString();

        public string FilterValue => txtFilterValue.Text;

        private bool IsNumericFilter()
        {
            // Define which filters require numeric input
            var numericFilters = new List<string> { "TeacherID", "StudentID", "SubjectID", "ClassID" };
            return numericFilters.Contains(SelectedFilter);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                errorProvider1.SetError(txtFilterValue, "Filter value cannot be empty.");
                return;
            }
            SearchClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();

            if (IsNumericFilter())
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                errorProvider1.SetError(txtFilterValue, "Filter value cannot be empty.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }
    }
}
