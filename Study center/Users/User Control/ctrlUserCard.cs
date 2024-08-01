using Study_center.Global_Classes;
using Study_center.Properties;
using studyCenter_BL_;
using studyCenter_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_center.Users.User_Control
{
    public partial class ctrlUserCard : UserControl
    {
        private int? _userID = null;
        private clsUser _user = null;

        public int? UserID => _userID;
        public clsUser UserInfo => _user;

        public int? PersonID => ctrlPersonCard1.PersonID;
       // public clsPerson PersonInfo => ctrlPersonCard1.PersonInfo;
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        private void _FillUserData()
        {
            ctrlPersonCard1.LoadPersonData(_user.PersonID);

            lblUserID.Text = _user.UserID.ToString();
            lblUsername.Text = _user.UserName;
            lblIsActive.Text = _user.IsActive ? "Yes" : "No";

            llEditUserInfo.Enabled = true;
        }

        public void LoadUserInfoByUserID(int? userID)
        {
            _userID = userID;

            if (!_userID.HasValue)
            {
                clsMessages.NotFound("user", userID);
                return;
            }

            _user = clsUser.Find(userID, clsUser.EnFindUserBy.UserID);

            if (_user == null)
            {
                clsMessages.NotFound("user", userID);
                return;
            }

            _FillUserData();
        }

        public void LoadUserInfoByPersonID(int? personID)
        {
            if (!personID.HasValue)
            {
                clsMessages.GeneralErrorMessage("There is no a user!");
                return;
            }

            _user = clsUser.Find(personID, clsUser.EnFindUserBy.PersonID);

            if (_user == null)
            {
                MessageBox.Show($"There is no a user with Person ID = {personID} !",
                    "Missing user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserData();
        }
     
        private void llEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
