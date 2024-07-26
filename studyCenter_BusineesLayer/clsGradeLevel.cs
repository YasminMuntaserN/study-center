using StudyCenter_DAL_;
using StudyCenter_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BusineesLayer
{
    public class clsGradeLevel
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? GradeLevelID { get; set; }
        public string GradeName { get; set; }

        public clsGradeLevel()
        {
            GradeLevelID = null;
            GradeName = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsGradeLevel(int? gradeLevelID, string gradeName)
        {
            GradeLevelID = gradeLevelID;
            GradeName = gradeName;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            GradeLevelID = clsGradeLevelData.Add(GradeName);

            return (GradeLevelID.HasValue);
        }

        private bool _Update()
        {
            return clsGradeLevelData.Update(GradeLevelID.Value, GradeName);
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

        public static clsGradeLevel Find(int gradeLevelID)
        {
            string gradeName = string.Empty;

            bool isFound = clsGradeLevelData.GetInfoByID(gradeLevelID, ref gradeName);

            return (isFound) ? (new clsGradeLevel(gradeLevelID, gradeName)) : null;
        }

        public static bool Delete(int? gradeLevelID)
            => clsGradeLevelData.Delete(gradeLevelID);

        public static bool Exists(int? gradeLevelID)
            => clsGradeLevelData.Exists(gradeLevelID);

        public static bool Exists(string gradeName)
            => clsGradeLevelData.Exists(gradeName);

        public static DataTable All() => clsGradeLevelData.All();
        public static DataTable AllGradeLevelNames()
            => clsGradeLevelData.AllGradeLevelNames();

        public static string GetGradeLevelName(int? gradeLevelID)
            => clsGradeLevelData.GetGradeLevelName(gradeLevelID);

        public static int? GetGradeLevelID(string gradeName)
           => clsGradeLevelData.GetGradeLevelID(gradeName);

        public static int Count() => clsGradeLevelData.Count();
    }
}
