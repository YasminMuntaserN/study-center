using studyCenter_BusineesLayer;
using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_Bl_
{
    public class clsGradeLevelSubject
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? GradeLevelSubjectID { get; set; }
        public int? GradeLevelID { get; set; }
        public int? SubjectID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public clsGradeLevel GradeLevelInfo => clsGradeLevel.Find(GradeLevelID.Value);
        public clsSubject SubjectInfo => clsSubject.Find(SubjectID.Value);
       
        public clsGradeLevelSubject()
        {
            GradeLevelSubjectID = null;
            GradeLevelID = 0;
            SubjectID = 0;
            Title = string.Empty;
            Fees = 0;

            Mode = enMode.AddNew;
        }

        private clsGradeLevelSubject(int? gradeLevelSubjectID, int gradeLevelID, int subjectID, string title, decimal fees)
        {
            GradeLevelSubjectID = gradeLevelSubjectID;
            GradeLevelID = gradeLevelID;
            SubjectID = subjectID;
            Title = title;
            Fees = fees;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            GradeLevelSubjectID = clsGradeLevelSubjectData.Add(GradeLevelID.Value, SubjectID.Value, Title, Fees);

            return (GradeLevelSubjectID.HasValue);
        }

        private bool _Update()
        {
            return clsGradeLevelSubjectData.Update(GradeLevelSubjectID.Value, GradeLevelID.Value, SubjectID.Value, Title, Fees);
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

        public static clsGradeLevelSubject Find(int? gradeLevelSubjectID)
        {
            int gradeLevelID = 0;
            int subjectID = 0;
            string title = string.Empty;
            decimal fees = 0;

            bool isFound = clsGradeLevelSubjectData.GetInfoByID(gradeLevelSubjectID, ref gradeLevelID, ref subjectID, ref title, ref fees);

            return (isFound) ? (new clsGradeLevelSubject(gradeLevelSubjectID, gradeLevelID, subjectID, title, fees)) : null;
        }

        public static bool Delete(int? gradeLevelSubjectID)
            => clsGradeLevelSubjectData.Delete(gradeLevelSubjectID);

        public static bool Exists(int? gradeLevelSubjectID)
            => clsGradeLevelSubjectData.Exists(gradeLevelSubjectID);

        public static DataTable All() => clsGradeLevelSubjectData.All();

        public bool GenerateTitle()
        {
            return clsGradeLevelSubjectData.GenerateTitle(GradeLevelID, SubjectID, out string title) && !string.IsNullOrEmpty(title)
                ? (Title = title) != null
                : false;
        }

        public static bool CheckIfTitleExists(string title)=>clsGradeLevelSubjectData.CheckIfTitleExists(title);

        public static DataTable GetAllGradeLevelSubjectsWithNames()
            =>clsGradeLevelSubjectData.GetAllGradeLevelSubjectsWithNames(); 
    }

}
