using Study_center.Class;
using Study_center.Grade_Level_Subject;
using Study_center.Group;
using Study_center.Meeting_Times;
using Study_center.Student;
using Study_center.Subjects;
using Study_center.Teacher;
using Study_center.Teacher_and_Subject;
using studyCenter_BusineesLayer;
using System.Security.Cryptography;
namespace Study_center
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmClassInfo(2));
        }
    }
}