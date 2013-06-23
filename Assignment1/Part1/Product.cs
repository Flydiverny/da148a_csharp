// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Markus Maga">
//   Markus Maga 2013-06-23
// </copyright>
// <summary>
//   Defines the Product type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Part1
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// The product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Constant vat rates for food and other products.
        /// </summary>
        private const double FoodVATRate = 0.12, OtherVATRate = 0.25;

        /// <summary>
        /// Name of product.
        /// </summary>
        private string name;

        /// <summary>
        /// Price per unit.
        /// </summary>
        private double unitPrice;

        /// <summary>
        /// Count of product.
        /// </summary>
        private int count;

        /// <summary>
        /// true = Food item, false = other.
        /// </summary>
        private bool foodItem;

        /// <summary>
        /// Total price for x amount of product.
        /// </summary>
        private double totalPrice;

        /// <summary>
        /// The total vat.
        /// </summary>
        private double totalVat;

        /// <summary>
        /// Program reads input then prints product receipt.
        /// </summary>
        public void Start()
        {
            // Read input
            this.ReadInput();

            // Calculate total tax
            this.CalculateValues();

            // Calculate totalNetPrice, total price
            this.PrintReceipt();
        }

        /// <summary>
        /// Validates user input to see if it can be converted to specified type T.
        /// </summary>
        /// <param name="text">
        /// Text to output before user input.
        /// </param>
        /// <typeparam name="T">
        /// Type to convert input to.
        /// </typeparam>
        /// <returns>
        /// Converted input as type <see cref="T"/>.
        /// </returns>
        private static T ValidateInput<T>(string text) where T : struct
        {
            Console.Write(text);
            var returnValue = default(T);

            do
            {
                var input = Console.ReadLine();
                try
                {
                    var convertFromString = TypeDescriptor.GetConverter(default(T)).ConvertFromString(input);
                    if (convertFromString != null)
                    {
                        returnValue = (T)convertFromString;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write(text);
                }
            }
            while (returnValue.Equals(default(T)));

            return returnValue;
        }

        /// <summary>
        /// Reads user inputs.
        /// </summary>
        private void ReadInput()
        {
            // 1. Read name of the product
            this.ReadName();

            // 2. Read price without VAT
            this.ReadNetUnitPrice();

            // 3. Ask the user if the item is a food item
            this.ReadIfFoodItem();

            // 4. Read number of items (quantity)
            this.ReadCount();
        }

        /// <summary>
        /// Asks user if its a food item or not.
        /// </summary>
        private void ReadIfFoodItem()
        {
            var response = ValidateInput<char>("Food item (y/n): ");

            this.foodItem = (response == 'y') || (response == 'Y');
        }

        /// <summary>
        /// Asks user for product name.
        /// </summary>
        private void ReadName()
        {
            Console.Write("Enter the product name: ");

            this.name = Console.ReadLine();
        }

        /// <summary>
        /// Asks user for the net unit price.
        /// </summary>
        private void ReadNetUnitPrice()
        {
            this.unitPrice = ValidateInput<double>("Net unit price: ");
        }

        /// <summary>
        /// Asks user for the count of product.
        /// </summary>
        private void ReadCount()
        {
            this.count = ValidateInput<int>("Count: ");
        }

        /// <summary>
        /// Calculates the vat and price.
        /// </summary>
        private void CalculateValues()
        {
            var price = this.count * this.unitPrice;
            this.totalVat = price * (this.foodItem ? FoodVATRate : OtherVATRate);
            this.totalPrice = price + this.totalVat;
        }

        /// <summary>
        /// Prints the product receipt.
        /// </summary>
        private void PrintReceipt()
        {
            var vat = this.foodItem ? FoodVATRate * 100 : OtherVATRate * 100;
            Console.WriteLine("\n\n");
            Console.WriteLine("++++++++++++++++ WELCOME TO APU's SUPERMARKET +++++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ Name of the product \t\t" + this.name);
            Console.WriteLine("+++ Quantity \t\t\t\t" + this.count);
            Console.WriteLine("+++ Unit Price \t\t\t\t" + this.unitPrice);
            Console.WriteLine("+++ Food item \t\t\t\t" + this.foodItem);
            Console.WriteLine("+++");
            Console.WriteLine("+++ Total amount to pay:  \t\t" + this.totalPrice);
            Console.WriteLine("+++ Including VAT at " + vat + " %\t\t" + this.totalVat);
            Console.WriteLine("+++");
            Console.WriteLine("+++  This program has been developed by: Markus Maga \t+++");
            Console.WriteLine("++++++++++++++++ PLEASE COME AGAIN! +++++++++++++++++++++++");
            Console.WriteLine("\n");
        }
    }
}

