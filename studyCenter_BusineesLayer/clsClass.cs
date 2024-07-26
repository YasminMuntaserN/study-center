using StudyCenter_DAL_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BL_
{
    public class clsClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;

        public int? ClassID { get; set; }
        public string ClassName { get; set; }
        public byte? Capacity { get; set; }

        public clsClass()
        {
            ClassID = null;
            ClassName = string.Empty;
            Capacity = null;
            Mode = enMode.AddNew;
        }

        private clsClass(int? classID, string className, byte? capacity)
        {
            ClassID = classID;
            ClassName = className;
            Capacity = capacity;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            ClassID = clsClassesDAL.Add(ClassName, Capacity);
            return ClassID.HasValue;
        }

        private bool _Update()
             => clsClassesDAL.Update(ClassID.Value, ClassName, Capacity);

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

        public static clsClass Find(int? classID)
        {
            string className = string.Empty;
            byte? capacity = null;
            bool isFound = clsClassesDAL.GetInfoByID(classID, ref className, ref capacity);
            return isFound ? new clsClass(classID, className, capacity) : null;
        }
     
        public static clsClass Find(string? className)
        {
            int? classID = null;
            byte? capacity = null;
            bool isFound = clsClassesDAL.GetInfoByName(className, ref classID, ref capacity);
            return isFound ? new clsClass(classID, className, capacity) : null;
        }

        public static bool Delete(int? classID)
            => clsClassesDAL.Delete(classID);

        public static bool Exists(int? classID)
            => clsClassesDAL.Exists(classID);

        public static bool Exists(string ClassName)
          => clsClassesDAL.Exists(ClassName);

        public static int Count()
           =>  clsClassesDAL.Count();   
    }

}