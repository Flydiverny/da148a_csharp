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
        /// The currency name.
        /// </summary>
        private string currencyName;

        /// <summary>
        /// The exchange rate.
        /// </summary>
        private decimal exchangeRate;

        private decimal expenses;

        /// <summary>
        /// The start.
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            this.ReadInputAndSumNumbers();
            this.GetExchangeRate();

            ShowResult();
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
        private void ShowResult()
        {
            var converted = this.expenses * this.exchangeRate;

            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Your expenses\t\t{0:C}", this.expenses);
            Console.WriteLine("Exchange rate\t\t{0} {1}", this.exchangeRate, this.currencyName);
            Console.WriteLine("Converted currency\t{0} {1}", converted, this.currencyName);
        }

        /// <summary>
        /// Asks the user for an exchange rate.
        /// </summary>
        private void GetExchangeRate()
        {
            Console.Write("Please enter currency name: ");
            this.currencyName = Console.ReadLine();

            this.exchangeRate = GetDecimalInput("Please enter the exchange rate");
        }

        /// <summary>
        /// The read input and sum numbers.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            decimal input;
            do
            {
                input = GetDecimalInput("Please enter your expense (number)");
                this.expenses += input;
            }
            while (input.Equals(0));
        }
    }
}
