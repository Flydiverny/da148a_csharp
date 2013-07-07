// ----------------------------public ----------------------------------------------------------------------------------------
// <copyright file="ExchangeDoWhile.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Defines the ExchangeDoWhile type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The exchange do while.
    /// </summary>
    public class ExchangeDoWhile : IStartable
    {
        /// <summary>
        /// The start.
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            var sum = this.ReadInputAndSumNumbers();
            var exchangeRate = this.GetExchangeRate();

            ShowResult(sum, exchangeRate);
        }

        /// <summary>
        /// Asks user for decimal input using specified text.
        /// </summary>
        /// <param name="text">
        /// Text leading up to input query.
        /// </param>
        /// <returns>
        /// user input <see cref="decimal"/>.
        /// </returns>
        private static decimal GetDecimalInput(string text)
        {
            decimal userint;
            bool success;

            do
            {
                Console.Write(text + ": ");
                var input = Console.ReadLine();
                success = decimal.TryParse(input, out userint);
            }
            while (!success);

            return userint;
        }

        /// <summary>
        /// Writes out some program info.
        /// </summary>
        private static void WriteProgramInfo()
        {
            Console.WriteLine("Welcome to the Currency Converter!!");
            Console.WriteLine("Please enter your expenses and once\nyou are finished enter 0 to continue.\n");
        }

        /// <summary>
        /// Prints the sum to the console.
        /// </summary>
        /// <param name="sum">
        /// Sum to print.
        /// </param>
        /// <param name="exchangeRate">
        /// The exchange Rate.
        /// </param>
        private static void ShowResult(decimal sum, decimal exchangeRate)
        {
            var converted = sum * exchangeRate;

            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Your expenses\t\t" + sum);
            Console.WriteLine("Exchange rate\t\t" + exchangeRate);
            Console.WriteLine("Converted currency\t" + converted);
        }

        /// <summary>
        /// Asks the user for an exchange rate.
        /// </summary>
        /// <returns>
        /// User specified exchange rate <see cref="decimal"/>.
        /// </returns>
        private decimal GetExchangeRate()
        {
            return GetDecimalInput("Please enter the exchange rate");
        }

        /// <summary>
        /// The read input and sum numbers.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private decimal ReadInputAndSumNumbers()
        {
            decimal sum = 0;
            do
            {
                var input = GetDecimalInput("Please enter your expense (number)");
                sum += input;

                if (input.Equals(0))
                {
                    break;
                }
            }
            while (true);

            return sum;
        }
    }
}
