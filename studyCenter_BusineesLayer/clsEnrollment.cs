using StudyCenter_DAL_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BL_
{
    public class clsEnrollment
    {
        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode { get; set; } = enMode.AddNew;

        public int? EnrollmentID { get; set; }
        public bool IsActive { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? DeletionDate { get; set; }
        public int? StudentID { get; set; }
        public int? GroupID { get; set; }

        public clsEnrollment()
        {
            EnrollmentID = null;
            IsActive = true;
            EnrollmentDate = DateTime.Now;
            DeletionDate = null;
            StudentID = null;
            GroupID = null;

            Mode = enMode.AddNew;
        }

        private clsEnrollment(int enrollmentID, bool isActive, DateTime enrollmentDate, DateTime? deletionDate, int? studentID, int? groupID)
        {
            EnrollmentID = enrollmentID;
            IsActive = isActive;
            EnrollmentDate = enrollmentDate;
            DeletionDate = deletionDate;
            StudentID = studentID;
            GroupID = groupID;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            EnrollmentID = clsEnrollmentData.Add(IsActive, EnrollmentDate, DeletionDate, StudentID, GroupID);
            return EnrollmentID.HasValue;
        }

        private bool _Update()
             => clsEnrollmentData.Update(EnrollmentID, IsActive, EnrollmentDate, DeletionDate, StudentID, GroupID);

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
                    return false;

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsEnrollment Find(int? enrollmentID)
        {
            bool isActive = false;
            DateTime enrollmentDate = DateTime.MinValue;
            DateTime? deletionDate = null;
            int? studentID = null;
            int? groupID = null;

            bool isFound = clsEnrollmentData.GetInfoByID(enrollmentID, ref isActive, ref enrollmentDate, ref deletionDate, ref studentID, ref groupID);

            return isFound ? new clsEnrollment(enrollmentID.Value, isActive, enrollmentDate, deletionDate, studentID, groupID) : null;
        }

        public static bool Delete(int? enrollmentID)
            => clsEnrollmentData.Delete(enrollmentID);

        public static bool Exists(int? enrollmentID)
            => clsEnrollmentData.Exists(enrollmentID);

        public static DataTable All() => clsEnrollmentData.All();

        public static DataTable GetEnrollmentsByStudentID(int? studentID)
            => clsEnrollmentData.GetEnrollmentsByStudentID(studentID);

        public static DataTable GetEnrollmentsByGroupID(int? groupID)
            => clsEnrollmentData.GetEnrollmentsByGroupID(groupID);

    }
}
