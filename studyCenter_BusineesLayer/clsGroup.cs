using studyCenter_BL_;
using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BusineesLayer
{
    public class clsGroup
    {
        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode { get; set; } = enMode.AddNew;

        public int? GroupID { get; set; }
        public string GroupName { get; set; }
        public int? GradeLevelSubjectID { get; set; }
        public decimal GroupStudentCount { get; set; }
        public int? TeacherSubjectID { get; set; }
        public int? ClassID { get; set; }
        public int? MeetingTimeID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public clsTeacherSubject TeacherSubjectInfo => clsTeacherSubject.Find(TeacherSubjectID);
        public clsClass ClassInfo => clsClass.Find(ClassID);
        public clsMeetingTimes MeetingTimeInfo => clsMeetingTimes.Find(MeetingTimeID);



        public clsGroup()
        {
            GroupID = null;
            GroupName = string.Empty;
            GradeLevelSubjectID = 0;
            GroupStudentCount = 0;
            TeacherSubjectID = 0;
            ClassID = 0;
            MeetingTimeID = 0;
            IsActive = true;
            CreationDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsGroup(int groupID, string groupName, int gradeLevelSubjectID, decimal groupStudentCount, int teacherSubjectID, int classID, int meetingTimeID, bool isActive, DateTime creationDate)
        {
            GroupID = groupID;
            GroupName = groupName;
            GradeLevelSubjectID = gradeLevelSubjectID;
            GroupStudentCount = groupStudentCount;
            TeacherSubjectID = teacherSubjectID;
            ClassID = classID;
            MeetingTimeID = meetingTimeID;
            IsActive = isActive;
            CreationDate = creationDate;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            GroupID = clsGroupData.Add(GradeLevelSubjectID, GroupStudentCount, TeacherSubjectID, ClassID, MeetingTimeID, IsActive);
            if (GroupID.HasValue)
            {
                GroupName = GetGroupName(GroupID);
                return true;
            }
            return false;
        }

        private bool _Update()
        {
            return clsGroupData.Update(GroupID, GroupName, GradeLevelSubjectID, GroupStudentCount, TeacherSubjectID, ClassID, MeetingTimeID, IsActive);
        }

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

        public static clsGroup Find(int? groupID)
        {
            string groupName = string.Empty;
            int gradeLevelSubjectID = 0;
            decimal groupStudentCount = 0;
            int teacherSubjectID = 0;
            int classID = 0;
            int meetingTimeID = 0;
            bool isActive = false;
            DateTime creationDate = DateTime.MinValue;

            bool isFound = clsGroupData.GetInfoByID(groupID, ref groupName, ref gradeLevelSubjectID, ref groupStudentCount, ref teacherSubjectID, ref classID, ref meetingTimeID, ref isActive, ref creationDate);

            return (isFound) ? new clsGroup(groupID.Value, groupName, gradeLevelSubjectID, groupStudentCount, teacherSubjectID, classID, meetingTimeID, isActive, creationDate) : null;
        }

        public static bool Delete(int? groupID)
            => clsGroupData.Delete(groupID);

        public static bool Exists(int? groupID)
            => clsGroupData.Exists(groupID);

        public static DataTable All() => clsGroupData.All();

        public static string GetGroupName(int? groupID)
            => clsGroupData.GetGroupName(groupID.Value);

        public static DataTable GetAvailableMeetingTimes(int? classId , int? TeacherId)
           => clsGroupData.GetAvailableMeetingTimes(classId, TeacherId);

        public static int Count() => clsGroupData.Count();

    }
}


