// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FloatNumbersWhile.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Defines the FloatNumbersWhile type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using System;

    /// <summary>
    /// The float numbers while.
    /// </summary>
    public class FloatNumbersWhile : IStartable
    {
        /// <summary>
        /// The start.
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            var sum = this.ReadInputAndSumNumbers();

            ShowResult(sum);
        }

        /// <summary>
        /// Asks user for double input using specified text.
        /// </summary>
        /// <param name="text">
        /// Text leading up to input query.
        /// </param>
        /// <returns>
        /// user input <see cref="double"/>.
        /// </returns>
        private static double GetDoubleInput(string text)
        {
            double userint;
            bool success;

            do
            {
                Console.Write(text + ": ");
                var input = Console.ReadLine();
                success = double.TryParse(input, out userint);
            }
            while (!success);

            return userint;
        }

        /// <summary>
        /// Writes out some program info.
        /// </summary>
        private static void WriteProgramInfo()
        {
            Console.WriteLine("Welcome to the Float Numbers While!!");
            Console.WriteLine("Program will exit if you enter a value of zero.\n\n");
        }

        /// <summary>
        /// Prints the sum to the console.
        /// </summary>
        /// <param name="sum">
        /// Sum to print.
        /// </param>
        private static void ShowResult(double sum)
        {
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("The sum is \t" + sum);
        }

        /// <summary>
        /// The read input and sum numbers.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double ReadInputAndSumNumbers()
        {
            double sum = 0;
            while (true)
            {
                var input = GetDoubleInput("Please enter a number");
                sum += input;

                if (input.Equals(0.0d))
                {
                    return sum;
                }
            }
        }
    }
}
