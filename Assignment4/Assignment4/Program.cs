// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Markus Maga">
//   AC7525 Markus Maga 21-07-13
// </copyright>
// <summary>
//   The program startes the WinForm application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assignment3
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
