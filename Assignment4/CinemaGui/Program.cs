// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Markus Maga">
//   AC7525 Markus Maga 29-07-13
// </copyright>
// <summary>
//   The program startes the WinForm application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CinemaGui
{
    using System;

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
            new CinemaSystem().Run();
        }
    }
}
