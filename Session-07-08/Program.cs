using System;
using System.Windows.Forms;

namespace EpsilonNet.CodingSchool2022.Session_07_08
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UniversityForm());
        }
    }
}
