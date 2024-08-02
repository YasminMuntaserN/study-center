using studyCenter_BL_;
using StudyCenter_DataAccessLayer;
using System.Data;
using static studyCenter_BL_.clsUser;

namespace studyCenter_BusineesLayer
{
    public class clsStudent : clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum EnFindStudentBy { PersonID = 0, StudentID = 1 }
        public int? StudentID { get; set; }
        public int? personID { get; set; }
        public int? GradeLevelID { get; set; }
        public string EmergencyContactPhone { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string GetUserName => clsUser.Find(CreatedByUserID, EnFindUserBy.UserID).UserName;

        public clsStudent() : base()
        {
            StudentID = null;
            PersonID = null;
            GradeLevelID = null;
            CreatedByUserID = null;
            EmergencyContactPhone = string.Empty;
            EnrollmentDate = DateTime.Now;

            _Mode = enMode.AddNew;
        }

        public clsStudent(int? studentID, int? personID, int? gradeLevelID,
                          int? createdByUserID, string emergencyContactPhone, DateTime enrollmentDate, string firstName, string lastName, EnGender gender,
                          DateTime dateOfBirth, string phoneNumber, string email, string address)
            :
            base(personID, firstName, lastName, gender, dateOfBirth, address, phoneNumber, email)
        {
            StudentID = studentID;
            PersonID = personID;
            GradeLevelID = gradeLevelID;
            CreatedByUserID = createdByUserID;
            EmergencyContactPhone = emergencyContactPhone;
            EnrollmentDate = enrollmentDate;

            _Mode = enMode.Update;
        }

        public clsPerson ToPerson()
        {
            return new clsPerson(PersonID, FirstName, LastName, Gender, BirthDate, Address, Phone, Email);
        }

        private static clsStudent _FindByStudentID(int? studentID)
        {
            int? personID = null;
            byte? gradeLevelID = null;
            int? createdByUserID = null;
            string EmergencyContactPhone = string.Empty;
            DateTime enrollmentDate = DateTime.Now;

            bool isFound = clsStudentData.GetInfoByStudentID(studentID, ref personID,
                ref gradeLevelID, ref createdByUserID, ref EmergencyContactPhone, ref enrollmentDate);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;
                return new clsStudent(studentID, personID, gradeLevelID,
                                    createdByUserID, EmergencyContactPhone, enrollmentDate, person.FirstName, person.LastName, person.Gender,
                                    person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        private static clsStudent _FindByPersonID(int? personID)
        {
            int? studentID = null;
            byte? gradeLevelID = null;
            int? createdByUserID = null;
            string EmergencyContactPhone = string.Empty;
            DateTime enrollmentDate = DateTime.Now;

            bool isFound = clsStudentData.GetInfoByPersonID(personID, ref studentID,
                ref gradeLevelID, ref createdByUserID, ref EmergencyContactPhone, ref enrollmentDate);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(personID);

                if (person == null)
                    return null;
                return new clsStudent(studentID, personID, gradeLevelID,
                                    createdByUserID, EmergencyContactPhone, enrollmentDate, person.FirstName, person.LastName, person.Gender,
                                    person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }

        public static clsStudent Find<T>(T searchValue, EnFindStudentBy findStudentBy)
        {
            switch (findStudentBy)
            {
                case EnFindStudentBy.PersonID:
                    return _FindByPersonID(Convert.ToInt16(searchValue));

                case EnFindStudentBy.StudentID:
                    return _FindByStudentID(Convert.ToInt16(searchValue));

                default:
                    return null;
            }
        }

        private bool _Add()
        {
             this.StudentID = clsStudentData.AddNewStudent(personID.Value, GradeLevelID.Value, EmergencyContactPhone, CreatedByUserID.Value);

            return (StudentID.HasValue);
        }

        private bool _Update()
        {
            return clsStudentData.Update(StudentID.Value, PersonID.Value, GradeLevelID.Value, EmergencyContactPhone, CreatedByUserID.Value,EnrollmentDate);
        }

        public new bool Save()
        {
            personID = base.PersonID;
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

        public static bool Delete(int? StudentID)
        {
            int? personID = clsStudent.Find(StudentID, EnFindStudentBy.StudentID).personID;

            if (!personID.HasValue)
                return false;

            return clsPerson.DeletePerson(personID) ? clsStudentData.Delete(StudentID) : false;
        }

        public static bool Exists(int? studentID) => clsStudentData.Exists(studentID);

        public static DataTable All() => clsStudentData.All();

        public static bool IsPersonStudent(int? PersonID) => clsStudentData.IsPersonStudent(PersonID);

        public static int Count() => clsStudentData.Count();

        public static DataTable GetStudentsByPage(int pageNumber, int pageSize)
               => clsStudentData.GetStudentsByPage(pageNumber, pageSize);
    }
}
