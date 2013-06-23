// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatteryCalculator.cs" company="Markus Maga">
//   Markus Maga 2013-06-23
// </copyright>
// <summary>
//   The battery calculator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Part2
{
    using System;

    /// <summary>
    /// Class containing main function for a cellphone battery calculator.
    /// </summary>
    public class BatteryCalculator
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            Console.Title = "Battery Calculator";

            // Declare and create an instance of the Cellphone
            var cellphone = new Cellphone();
            cellphone.Start();

            Console.Write("Press Enter to exit! ");
            Console.ReadLine();
        }
    }
}
