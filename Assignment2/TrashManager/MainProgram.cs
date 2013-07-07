// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainProgram.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Creates and runs a Menu instance.
//   Also waits for input before exiting.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class MainProgram
    {
        /// <summary>
        /// Main method run upon program execution.
        /// </summary>
        /// <param name="args">
        /// Optional args
        /// </param>
        public static void Main(string[] args)
        {
            new Menu().Start();

            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}
