using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyCenter_BusineesLayer;
using StudyCenter_DAL_;
using static studyCenter_BusineesLayer.clsStudent;
using StudyCenter_DataAccessLayer;
using System.Net;

namespace studyCenter_BL_
{
    public class clsUser : clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public enum EnFindUserBy { PersonID = 0, UserID = 1 , UserNameAndPassword=2}
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

        private clsUser(int? userID, int? personID, string userName, string password, bool isActive, string firstName, string lastName, EnGender gender,
                          DateTime dateOfBirth, string phoneNumber, string email, string address)
            :
            base(personID, firstName, lastName, gender, dateOfBirth, address, phoneNumber, email)
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
            UserID = clsUserData.Add(PersonID.Value, UserName, Password, IsActive);
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

        public static bool IsPersonUser(int? personID) => clsUserData.IsPersonUser(personID);

        private static clsUser _FindByUserID(int? userID)
        {
            int? personID = null;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            bool isFound = clsUserData.GetInfoByID(userID, ref personID, ref userName, ref password, ref isActive);
            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;
               
                return new clsUser(userID, personID, userName, password, isActive, person.FirstName, person.LastName, person.Gender,
                                    person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        private static clsUser _FindByPersonID(int? personID)
        {
            int? userID = null;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            bool isFound = clsUserData.GetInfoByPersonID(personID, ref userID, ref userName, ref password, ref isActive);
            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;

                return new clsUser(userID, personID, userName, password, isActive, person.FirstName, person.LastName, person.Gender,
                                    person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        private static clsUser _FindByUserNameAndPassword(string userName , string password)
        {
            int? personID = null;
            int? userID = null;
            bool isActive = false;

            bool isFound = clsUserData.GetInfoByUserNameAndPassword(userName,password, ref userID, ref personID,ref isActive);
            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;

                return new clsUser(userID, personID, userName, password, isActive, person.FirstName, person.LastName, person.Gender,
                                    person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        public static clsUser Find<T>(T searchValue, EnFindUserBy findUserBy, T SecoundsearchValue = default(T))
        {
            switch (findUserBy)
            {
                case EnFindUserBy.PersonID:
                    return _FindByPersonID(Convert.ToInt32(searchValue));

                case EnFindUserBy.UserID:
                    return _FindByUserID(Convert.ToInt32(searchValue));

                case EnFindUserBy.UserNameAndPassword:
                    return _FindByUserNameAndPassword(Convert.ToString(searchValue), Convert.ToString(SecoundsearchValue));
                default:
                    return null;
            }
        }

        public static bool Delete(int? userID)
            => clsUserData.Delete(userID.Value);

        public static bool Exists(int? userID)
            => clsUserData.Exists(userID.Value);

        public static bool Exists(string Username)
           => clsUserData.DoesUserExist(Username);

        public static bool Exists(string Username, string Password)
          => clsUserData.DoesUserExist(Username, Password);

        public static DataTable All()
            => clsUserData.All();

        public static int Count() =>clsUserData.Count();

        public static DataTable GetUsersByPage(int pageNumber, int pageSize)
           => clsUserData.GetUsersByPage(pageNumber, pageSize);
    }
}

