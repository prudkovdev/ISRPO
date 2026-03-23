using System;
using System.Windows.Forms;
using KnapsackSolverApp.Database;

namespace KnapsackSolverApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseTester.TestConnection();
            DatabaseHelper.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
