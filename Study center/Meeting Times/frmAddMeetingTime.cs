using Microsoft.Extensions.Configuration;
using studyCenter_BL_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Study_center.Main_Menu;

namespace Study_center.Meeting_Times
{
    public partial class frmAddMeetingTime : Form
    {
        private frmMainMenu mainMenuForm;
        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        private int? _meetingTimeID = null;
        private clsMeetingTimes _meetingTime = null;

        public frmAddMeetingTime(frmMainMenu mainMenu = null)
        {
            this.mainMenuForm = mainMenu;
            InitializeComponent();
        }

        public frmAddMeetingTime(int? meetingTimeID, frmMainMenu mainMenu = null)
        {
            this.mainMenuForm = mainMenu;
            InitializeComponent();
            _meetingTimeID = meetingTimeID;
            _Mode = enMode.Update;
        }

        private void frmAddMeetingTime_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            _LoadPatterns();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Meeting Time";
                _meetingTime = new clsMeetingTimes();
            }
            else
            {
                lblTitle.Text = "Update Meeting Time";
            }
        }

        private void _LoadPatterns()
        {
            var patterns = new List<MeetingPattern>
            {
        new MeetingPattern { PatternID = 1, PatternName = "Daily" },
        new MeetingPattern { PatternID = 2, PatternName = "STT" },
        new MeetingPattern { PatternID = 3, PatternName = "MW" }
            };

            cbMeetingDays.DataSource = patterns;
            cbMeetingDays.DisplayMember = "PatternName";
            cbMeetingDays.ValueMember = "PatternID";
        }

        private void _LoadData()
        {
            _meetingTime = clsMeetingTimes.Find(_meetingTimeID);

            if (_meetingTime == null)
            {
                MessageBox.Show($"Meeting Time with ID {_meetingTimeID} not found.");
                this.Close();
                return;
            }

            _FillFieldsWithMeetingTimeInfo();
        }

        private void _FillFieldsWithMeetingTimeInfo()
        {
            dtpStartDate.Value = DateTime.Today.Add(_meetingTime.StartTime);
            cbMeetingDays.SelectedValue = _meetingTime.PatternID;
          
            // Update EndTime based on the pattern
            _UpdateEndTime();
        }

        private bool _checkCorrectData()
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please correct the validation errors.");
                return false;
            }

            return true;
        }

        private void _FillMeetingTimeObjectWithFieldsData()
        {
            _meetingTime.StartTime = dtpStartDate.Value.TimeOfDay;
            if (cbMeetingDays.SelectedItem is MeetingPattern selectedPattern)
            {
                _meetingTime.PatternID = selectedPattern.PatternID;
            }
            _UpdateEndTime();
            _meetingTime.EndTime = dtpEndDate.Value.TimeOfDay;
        }

        private void _Save()
        {
            if (_meetingTime.Save())
            {
                lblTitle.Text = "Update Meeting Time";
                lblMeetingTimeID.Text = _meetingTime.MeetingTimeID.ToString();
                _Mode = enMode.Update;
                MessageBox.Show("Meeting Time saved successfully.");
            }
            else
            {
                MessageBox.Show("Failed to save Meeting Time.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillMeetingTimeObjectWithFieldsData();

            if (!_checkCorrectData()) return;

            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMeetingDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpdateEndTime();
        }

        private void _UpdateEndTime()
        {
            if (cbMeetingDays.SelectedItem == null) return;

            var pattern = cbMeetingDays.SelectedItem.ToString();
            double duration = GetPatternDuration(pattern);

            dtpEndDate.Value = dtpStartDate.Value.AddHours(duration);
        }

        private double GetPatternDuration(string pattern)
        {
            var settings = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory()) // Ensure the base path is set correctly
                 .AddJsonFile("appsettings.json")
                 .Build();

            return pattern switch
            {
                "Daily" => settings.GetSection("MeetingPatterns:Daily").Get<double>(),
                "STT" => settings.GetSection("MeetingPatterns:STT").Get<double>(),
                "MW" => settings.GetSection("MeetingPatterns:MW").Get<double>(),
                _ => 0
            };
        }

    }
}
