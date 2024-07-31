using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyCenter_DAL_;

namespace studyCenter_BL_
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;

        public int? UserID { get; set; }
        public int? PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            UserID = null;
            PersonID = null;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int? userID, int? personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            UserID = clsUserData.Add(PersonID, UserName, Password, IsActive);
            return UserID.HasValue;
        }

        private bool _Update()
            => clsUserData.Update(UserID.Value, PersonID, UserName, Password, IsActive);

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsUser Find(int? userID)
        {
            int? personID = null;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;
            bool isFound = clsUserData.GetInfoByID(userID.Value, ref personID, ref userName, ref password, ref isActive);
            return isFound ? new clsUser(userID, personID, userName, password, isActive) : null;
        }

        public static bool Delete(int? userID)
            => clsUserData.Delete(userID.Value);

        public static bool Exists(int? userID)
            => clsUserData.Exists(userID.Value);

        public static DataTable All()
            => clsUserData.All();
    }
}

