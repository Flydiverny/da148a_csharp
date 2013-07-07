// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WholeNumbersFor.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   The whole numbers for.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The whole numbers for.
    /// </summary>
    public class WholeNumbersFor : IStartable
    {
        /// <summary>
        /// Runs le program.
        /// </summary>
        public void Start()
        {
            // I know all my methods are static, but there is no need for them not to be.
            // I might as well handle all the value's with local variables as there is no need to define them as member fields.
            // Also this promotes reusability, as the functions are not deeply tied to member fields, which is unnessecary in this case.
            WriteProgramInfo();

            var amount = GetAmountOfNumbersToSum();
            var numbers = GetNumbers(amount);
            var sum = SumNumbers(numbers);

            ShowResult(sum);
        }

        /// <summary>
        /// Asks user for integer input using specified text.
        /// </summary>
        /// <param name="text">
        /// Text leading up to input query.
        /// </param>
        /// <returns>
        /// user input <see cref="int"/>.
        /// </returns>
        private static int GetIntInput(string text)
        {
            int userint;
            bool success;

            do
            {
                Console.Write(text + ": ");
                var input = Console.ReadLine();
                success = int.TryParse(input, out userint);
            }
            while (!success);

            return userint;
        }

        /// <summary>
        /// Sums a list of numbers.
        /// </summary>
        /// <param name="numbers">
        /// Numbers to sum.
        /// </param>
        /// <returns>
        /// result of summary <see cref="int"/>.
        /// </returns>
        private static int SumNumbers(IEnumerable<int> numbers)
        {
            var sum = numbers.Sum();

            return sum;
        }

        /// <summary>
        /// Asks the user for X amount of numbers.
        /// </summary>
        /// <param name="amount">
        /// Amount of numbers to ask for.
        /// </param>
        /// <returns>
        /// List of numbers entered <see><cref>IEnumerable</cref></see>
        /// </returns>
        private static IEnumerable<int> GetNumbers(int amount)
        {
            var numbers = new int[amount];
            for (var i = 0; i < amount; i++)
            {
                numbers[i] += GetIntInput("Please enter a number (" + (i + 1) + "/" + amount + ")");
            }

            return numbers;
        }

        /// <summary>
        /// Asks the user for the amount of numbers to sum.
        /// </summary>
        /// <returns>
        /// Amount given by user <see cref="int"/>.
        /// </returns>
        private static int GetAmountOfNumbersToSum()
        {
            return GetIntInput("Number of values to sum");
        }

        /// <summary>
        /// Writes out some program info.
        /// </summary>
        private static void WriteProgramInfo()
        {
            Console.WriteLine("Welcome to the Whole Numbers For!!\n\n");
        }

        /// <summary>
        /// Prints the sum to the console.
        /// </summary>
        /// <param name="sum">
        /// Sum to print.
        /// </param>
        private static void ShowResult(int sum)
        {
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("The sum is \t" + sum);
        }
    }
}
