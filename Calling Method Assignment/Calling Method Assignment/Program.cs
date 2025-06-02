using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {//creating an instance of the Numbers class
            Numbers numbers = new Numbers();
            // Prompting the user for input
            Console.WriteLine("Welcome to the Numbers Operations Program!, \n Please enter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            // Calling the Add method and displaying the result
            int sum = number1 + number2;
            Console.WriteLine(  number1 + " add " + number2  +  " equals "  +  sum);

            // Calling the Subtract method and displaying the result
            int difference = number1 - number2;
            Console.WriteLine(number1 + " subtract " + number2 + " equals " + difference);
            // Calling the Multiply method and displaying the result
            int product = number1 * number2;
            Console.WriteLine(number1 + " multiply " + number2 + " equals " + product);
            Console.ReadLine();

        }
        

        
    }
}
