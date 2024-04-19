using StudentManagament.HandleLogin;
using System;
using System.Windows.Forms;

namespace StudentManagament
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CourseManagamentForm());
            //Application.Run(new TeacherManagementForm());
            //Application.Run(new ClassManagementForm());
            Application.Run(new LoginForm());
        }
    }
}
