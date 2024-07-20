using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BusineesLayer
{
    public class clsTeacher : clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum EnFindTeacherBy { PersonID = 0, TeacherID = 1 }

        public int? TeacherID { get; set; }
        public int? PersonID { get; set; }
        public DateTime HireDate { get; set; }
        public string Qualification { get; set; }
        public decimal Salary { get; set; }
        public int? UserID { get; set; }

        public clsTeacher() : base()
        {
            TeacherID = null;
            PersonID = null;
            HireDate = DateTime.Now;
            Qualification = string.Empty;
            Salary = 0.0M;
            UserID = null;

            _Mode = enMode.AddNew;
        }

        public clsTeacher(int? teacherID, int? personID, DateTime hireDate, string qualification, decimal salary, int? userID, string firstName, string lastName, EnGender gender, DateTime dateOfBirth, string phoneNumber, string email, string address)
            : base(personID, firstName, lastName, gender, dateOfBirth, address, phoneNumber, email)
        {
            TeacherID = teacherID;
            PersonID = personID;
            HireDate = hireDate;
            Qualification = qualification;
            Salary = salary;
            UserID = userID;

            _Mode = enMode.Update;
        }

        private static clsTeacher _FindByTeacherID(int? teacherID)
        {
            int? personID = null;
            DateTime hireDate = DateTime.Now;
            string qualification = string.Empty;
            decimal salary = 0.0M;
            int? userID = null;

            bool isFound = clsTeacherData.GetInfoByTeacherID(teacherID, ref personID, ref salary, ref userID, ref qualification, ref hireDate);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;

                return new clsTeacher(teacherID, personID, hireDate, qualification, salary, userID, person.FirstName, person.LastName, person.Gender, person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        private static clsTeacher _FindByPersonID(int? personID)
        {
            int? teacherID = null;
            DateTime hireDate = DateTime.Now;
            string qualification = string.Empty;
            decimal salary = 0.0M;
            int? userID = null;

            bool isFound = clsTeacherData.GetInfoByPersonID(personID, ref teacherID, ref salary, ref userID, ref qualification, ref hireDate);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;

                return new clsTeacher(teacherID, personID, hireDate, qualification, salary, userID, person.FirstName, person.LastName, person.Gender, person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        public static clsTeacher Find<T>(T searchValue, EnFindTeacherBy findTeacherBy)
        {
            switch (findTeacherBy)
            {
                case EnFindTeacherBy.PersonID:
                    return _FindByPersonID(Convert.ToInt16(searchValue));
                case EnFindTeacherBy.TeacherID:
                    return _FindByTeacherID(Convert.ToInt16(searchValue));
                default:
                    return null;
            }
        }

        private bool _Add()
        {
            this.TeacherID = clsTeacherData.AddNewTeacher(PersonID.Value, Salary, Qualification, UserID.Value);
            return (TeacherID.HasValue);
        }

        private bool _Update()
        {
            return clsTeacherData.Update(TeacherID.Value, PersonID.Value, Salary, Qualification, HireDate, UserID.Value);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool Delete(int? TeacherID)
        {
            int? personID = clsTeacher.Find(TeacherID, EnFindTeacherBy.TeacherID).PersonID;

            if (!personID.HasValue)
                return false;

            return clsPerson.DeletePerson(personID) ? clsTeacherData.Delete(TeacherID) : false;
        }

        public static bool Exists(int? teacherID) => clsTeacherData.Exists(teacherID);

        public static DataTable All() => clsTeacherData.All();

        public static bool IsPersonTeacher(int? personID) => clsTeacherData.IsPersonTeacher(personID);
    }

}
