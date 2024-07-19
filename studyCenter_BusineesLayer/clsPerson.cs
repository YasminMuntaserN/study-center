using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BusineesLayer
{
    public class clsPerson
    {
        public enum EnMode : byte { AddNew = 0, Update = 1 };
        public EnMode Mode;
        public enum EnGender : byte { Male = 0, Female = 1 };

        public int? PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Join(" ", FirstName, LastName);
        public DateTime BirthDate { get; set; }
        public EnGender Gender { get; set; }
        public string GenderText => Gender.ToString();
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public clsPerson()
        {
            Mode = EnMode.AddNew;

            PersonID = null;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDate = DateTime.Now;
            Gender = EnGender.Male;
            Address = null;
            Phone = string.Empty;
            Email = null;
        }

        public clsPerson(int? personID, string firstName, string lastName, EnGender gender,
            DateTime dateOfBirth, string phoneNumber, string email, string address)
        {
            Mode = EnMode.Update;

            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phoneNumber;
            Email = email;
        }

        public static clsPerson Find(int? personID)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            byte gender = 0;
            DateTime dateOfBirth = DateTime.Now;
            string phoneNumber = string.Empty;
            string email = null;
            string address = null;

            bool isFound = clsPersonData.GetPersonInfoByID(personID, ref firstName,
                 ref lastName, ref gender, ref dateOfBirth, ref phoneNumber,
                ref email, ref address);

            return (isFound) ? (new clsPerson(personID, firstName, lastName,
                               (EnGender)gender, dateOfBirth, phoneNumber, email, address))
                             : null;
        }

        public static bool DoesPersonExist(int? personID) => clsPersonData.Exists(personID);

        private bool AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(FirstName,
                LastName, (byte)Gender, BirthDate, Phone, Email, Address);
            return PersonID.HasValue;
        }

        private bool UpdatePerson() =>
             clsPersonData.Update(PersonID, FirstName, LastName, (byte)Gender, BirthDate, Phone, Email, Address);

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (AddNewPerson())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdatePerson();

            }
            return false;
        }

        public static bool DeletePerson(int? personID) => clsPersonData.Delete(personID);
    }
}
