using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Product
    {
        private const double foodVATRate = 0.12, otherVATRate = 0.25;

        private String name;
        private double unitPrice;
        private int count;
        private Boolean foodItem; // true = Food item, false = other.

        private double totalPrice;
        private double totalVat;

        public void Start()
        {
            //Read input
            ReadInput();

            //Calculate total tax
            CalculateValues();

            //Calculate totalNetPrice, total price
            PrintReceipt();
        }

        private void ReadInput()
        {
            //1. Read name of the product
            ReadName();

            //2. Read price without VAT
            ReadNetUnitPrice();

            //3. Ask the user if the item is a food item
            ReadIfFoodItem();

            //4. Read number of items (quantity)
            ReadCount();
        }

        private void ReadIfFoodItem()
        {
            Console.Write("Food item (y/n): ");

            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y'))
                foodItem = true;
            else
                foodItem = false;
        }

        private void ReadName()
        {
            Console.Write("Enter the product name: ");

            name = Console.ReadLine();
        }

        private void ReadNetUnitPrice()
        {
            Console.Write("Net unit price: ");

            unitPrice = double.Parse(Console.ReadLine());
        }

        private void ReadCount()
        {
            Console.Write("Count: ");

            count = int.Parse(Console.ReadLine());
        }

        private void CalculateValues()
        {
            var price = count*unitPrice;
            totalVat = price*(foodItem ? foodVATRate : otherVATRate);
            totalPrice = price + totalVat;
        }

        

        private void PrintReceipt()
        {
            var vat = foodItem ? foodVATRate*100 : otherVATRate*100;
            Console.WriteLine("\n\n");
            Console.WriteLine("++++++++++++++++ WELCOME TO APU's SUPERMARKET +++++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ Name of the product \t\t" + name);
            Console.WriteLine("+++ Quantity \t\t\t\t" + count);
            Console.WriteLine("+++ Unit Price \t\t\t\t" + unitPrice);
            Console.WriteLine("+++ Food item \t\t\t\t" + foodItem);
            Console.WriteLine("+++");
            Console.WriteLine("+++ Total amount to pay:  \t\t" + totalPrice);
            Console.WriteLine("+++ Including VAT at " + vat + " %\t\t" + totalVat);
            Console.WriteLine("+++");
            Console.WriteLine("+++  This program has been developed by: Markus Maga \t+++");
            Console.WriteLine("++++++++++++++++ PLEASE COME AGAIN! +++++++++++++++++++++++");
            Console.WriteLine("\n");
        }
    }
}
