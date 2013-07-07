// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Shows a list of menu items and asks the user for input, then executes the menu item chosen.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager.MenuManager
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Prints menu and asks for user input.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Format in which the menu items will be printed.
        /// Index will be placed at 0 and text at 1.
        /// </summary>
        private const string MenuFormat = "{0,3}. {1}";

        /// <summary>
        /// List of menu items.
        /// </summary>
        private readonly IList<IMenuItem> menuItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// With an empty menu.
        /// </summary>
        public Menu() : this(new List<IMenuItem>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// </summary>
        /// <param name="menuItems">
        /// Menu items to use.
        /// </param>
        public Menu(IList<IMenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        /// <summary>
        /// Adds a menu item.
        /// </summary>
        /// <param name="menuItem">
        /// Menu item to add.
        /// </param>
        public void Add(IMenuItem menuItem)
        {
            this.menuItems.Add(menuItem);
        }

        /// <summary>
        /// Runs the menu.
        /// </summary>
        public void Run()
        {
            do
            {
                this.ShowMenu();

                var choice = this.GetMenuChoice();

                if (choice.Equals(-1))
                {
                    return; // exit menu
                }

                // Execute specified menu choice.
                this.menuItems[choice].Execute();
            }
            while (true);
        }

        /// <summary>
        /// Asks for a menu choice until a valid input is given.
        /// </summary>
        /// <returns>
        /// Index of menu choice. (input - 1)
        /// </returns>
        private int GetMenuChoice()
        {
            var output = "Please choose a menu alternative [0-" + this.menuItems.Count + "]: ";
            int choice;

            do
            {
                Console.Write(output);
                var input = Console.ReadLine();
                int.TryParse(input, out choice);
            }
            while (choice < 0 || choice > this.menuItems.Count);

            Console.WriteLine("\n");

            return choice - 1; // menu items are listed with 1 nbr higher.
        }

        /// <summary>
        /// Prints the menu to console, and an exit option last.
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine("\n\n---------------------------------------");

            for (var index = 0; index < this.menuItems.Count; index++)
            {
                var menuItem = this.menuItems[index];
                Console.WriteLine(MenuFormat, index + 1, menuItem.Text);
            }

            Console.WriteLine(MenuFormat, 0, "Exit");
            Console.WriteLine("----------------------------------------");
        }
    }
}
