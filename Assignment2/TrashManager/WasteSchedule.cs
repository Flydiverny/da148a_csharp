// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WasteSchedule.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Defines the WasteSchedule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using System;

    /// <summary>
    /// The waste schedule.
    /// </summary>
    public class WasteSchedule : IStartable
    {
        /// <summary>
        /// The start.
        /// </summary>
        public void Start()
        {
            this.WriteProgramInfo();

            this.HandleMenu();
        }

        /// <summary>
        /// Does what needs to be done for said menu choice.
        /// </summary>
        /// <param name="choice">
        /// Action to perform.
        /// </param>
        private void PerformMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    this.ShowSchedule(2);
                    return;
                case 2:
                    this.ShowSchedule(4);
                    return;
            }
        }

        /// <summary>
        /// Prints a week schedule with specified repetition.
        /// </summary>
        /// <param name="repetition">
        /// Repetition, for example every two weeks would be 2.
        /// </param>
        private void ShowSchedule(int repetition)
        {
            Console.WriteLine("Your bin empties the following weeks:\n\n");

            // Amount of repetitions are known, so it would make sense to use a for loop.
            for (int i = repetition, column = 1; i <= 52; i += repetition, column++)
            {
                Console.Write("{0,15} {1,2}", "Week", i);

                if (column == 4)
                {
                    Console.WriteLine();
                    column = 0;
                }
            }

            Console.WriteLine("\n-----------------------------------");
        }

        /// <summary>
        /// Loops the menu until user asks to exit.
        /// </summary>
        private void HandleMenu()
        {
            do
            {
                this.WriteMenu();

                var choice = this.GetMenuChoice();

                if (choice.Equals(0))
                {
                    return;
                }

                this.PerformMenuChoice(choice);
            }
            while (true);
        }

        /// <summary>
        /// Asks for a menu choice until a valid input is given.
        /// </summary>
        /// <returns>
        /// menu choice
        /// </returns>
        private int GetMenuChoice()
        {
            var output = "Please choose a menu alternative [0-" + 2 + "]: ";
            int choice;

            do
            {
                Console.Write(output);
                var input = Console.ReadLine();
                int.TryParse(input, out choice);
            }
            while (choice < 0 || choice > 2);

            Console.WriteLine("\n");

            return choice;
        }

        /// <summary>
        /// The write menu.
        /// </summary>
        private void WriteMenu()
        {
            const string StrFormat = "{0,2}. Bin No {0,2}. {1} (every {2} week)";
            Console.WriteLine(StrFormat, 1, "household waste", "other");
            Console.WriteLine(StrFormat, 2, "household waste", "4th");
            Console.WriteLine("{0,2}. Exit the program", 0);
        }

        /// <summary>
        /// Writes out some program info.
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("Welcome to the Waste Schedule!!\n\n");
        }
    }
}
