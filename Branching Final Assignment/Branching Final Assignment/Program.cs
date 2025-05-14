using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Final_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program is designed to calculate the shipping cost of a package based on its weight and dimensions.
            Console.WriteLine("Welcome to Package Express!" + "\n" + "\n" + "Please follow the instructions below:");
            // The program will start by welcoming the user and asking for the package weight.
            Console.WriteLine("\n" + "Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                // If the weight is greater than 50, it will display a message that the package is too heavy.
                Console.WriteLine("Package is too heavy to be shipped via Package Express.");
            }
            else
            {
                // If the weight is less than or equal to 50, it will ask for the dimensions of the package.
                // The program will ask for the width of the package.
                Console.WriteLine("\n" +"Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());
                // The program will ask for the height of the package.
                Console.WriteLine("\n" + "Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());
                // The program will ask for the length of the package.
                Console.WriteLine("\n" + "Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
               // if the total of the dimensions is greater than 50, it will display a message that the package is too big.
                if (width + height + length > 50)
                {
                    Console.WriteLine("\n" + "Package is too big to be shipped via Package Express.");
                }
                else
                {
                    // If the weight and dimensions are acceptable, it will calculate the shipping cost by multiplying the dimensions and weight, then dividing by 100.
                    double totalCost = (width * height * length * weight) / 100;
                    Console.WriteLine("\n" + "Your quote for shipping this package is: £" + totalCost);
                    Console.WriteLine("\n" + "Thank you for your patronage!");
                }
            }

            // The program will end.
            Console.ReadLine();
           
            


        }
    }
}
