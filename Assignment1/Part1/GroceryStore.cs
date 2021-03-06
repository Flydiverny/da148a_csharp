﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GroceryStore.cs" company="Markus Maga">
//   Markus Maga 2013-06-23
// </copyright>
// <summary>
//   Defines the Product type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Part1
{
    using System;

    /// <summary>
    /// The grocery store.
    /// </summary>
    public class GroceryStore
    {
        /// <summary>
        /// Starts program.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            Console.Title = "Apu's Supermarket";

            // Declare and create an instance of the Product class.
            var product = new Product();

            product.Start();

            Console.Write("Press Enter to exit! "); // Keep the blinky on the same line 
            Console.ReadLine();
        }
    }
}
