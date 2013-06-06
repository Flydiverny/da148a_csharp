using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apu's Supermarket";

            // Declare and create an instance of the Product class.
            var cellphone = new Cellphone();

            cellphone.Start();

            Console.Write("Press Enter to exit! "); // Keep the blinky on the same line 
            Console.ReadLine();
        }
    }
}
