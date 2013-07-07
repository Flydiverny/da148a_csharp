// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   The menu.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using System;

    /// <summary>
    /// The menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// A menu manager.
        /// </summary>
        private MenuManager.Menu menu;

        /// <summary>
        /// Starts the program
        /// </summary>
        public void Start()
        {
            SetupWindow();

            this.SetupMenu();

            this.menu.Run(); // Run the menu.
        }

        /// <summary>
        /// Sets the console title and eventually writes text to console.
        /// </summary>
        private static void SetupWindow()
        {
            Console.Title = "Selection and iteration algorithms";
        }

        /// <summary>
        /// Creates an instance of my menu manager and populates it with menu items.
        /// </summary>
        private void SetupMenu()
        {
            this.menu = new MenuManager.Menu();
            this.menu.Add(new MenuItem<WholeNumbersFor>("Whole Numbers with For"));
            this.menu.Add(new MenuItem<FloatNumbersWhile>("Floating Point Numbers with While"));
            this.menu.Add(new MenuItem<ExchangeDoWhile>("Currency Converter with Do While"));
            this.menu.Add(new MenuItem<WasteSchedule>("Waste Schedule"));
        }
    }
}
