using Study_center.Student;
using Study_center.Teacher;
using studyCenter_BusineesLayer;
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
            Application.Run(new frmAddStudent());
        }
    }
}