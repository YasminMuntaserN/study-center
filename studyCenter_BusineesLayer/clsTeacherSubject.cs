using studyCenter_Bl_;
using studyCenter_BusineesLayer;
using StudyCenter_DAL_;
using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BL_
{
    public class clsTeacherSubject
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? TeacherSubjectID { get; set; }
        public int? TeacherID { get; set; }
        public int? GradeLevelSubjectID { get; set; }
        public clsTeacher TeacherInfo => clsTeacher.Find(TeacherID ,clsTeacher.EnFindTeacherBy.TeacherID);
        public clsGradeLevelSubject GradeLevelSubjectInfo => clsGradeLevelSubject.Find(GradeLevelSubjectID);

        public clsTeacherSubject()
        {
            TeacherSubjectID = null;
            TeacherID = 0;
            GradeLevelSubjectID = 0;

            Mode = enMode.AddNew;
        }

        private clsTeacherSubject(int? teacherSubjectID, int teacherID, int gradeLevelSubjectID)
        {
            TeacherSubjectID = teacherSubjectID;
            TeacherID = teacherID;
            GradeLevelSubjectID = gradeLevelSubjectID;

            Mode = enMode.Update;
        }

        public static clsTeacherSubject Find(int? teacherSubjectID)
        {
            int teacherID = 0;
            int gradeLevelSubjectID = 0;

            bool isFound = clsTeacherSubjectData.GetInfoByID(teacherSubjectID, ref teacherID, ref gradeLevelSubjectID);

            return (isFound) ? new clsTeacherSubject(teacherSubjectID, teacherID, gradeLevelSubjectID) : null;
        }

        private bool _Add()
        {
            TeacherSubjectID = clsTeacherSubjectData.Add(TeacherID.Value, GradeLevelSubjectID.Value);

            return (TeacherSubjectID.HasValue);
        }

        private bool _Update()
        {
            return clsTeacherSubjectData.Update(TeacherSubjectID.Value, TeacherID.Value, GradeLevelSubjectID.Value);
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

        public static bool Delete(int? teacherSubjectID)
            => clsTeacherSubjectData.Delete(teacherSubjectID ?? 0);

        public static DataTable All() => clsTeacherSubjectData.GetAll();

        public static bool IsTeachingSubject(int? teacherID, int? gradeLevelSubjectID)
            => clsTeacherSubjectData.IsTeachingSubject(teacherID.Value, gradeLevelSubjectID.Value);

        public static DataTable GetSubjectsByTeacherID(int? teacherID)
            => clsTeacherSubjectData.GetSubjectsByTeacherID(teacherID.Value);

        public static DataTable GetTeachersBySubject(int? SubjectID)
            => clsTeacherSubjectData.GetTeachersBySubject(SubjectID.Value);
    }

}
