using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {// instantiate the class
            int number = new int();
            // Ask the user for input
            
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number if you wish to");

            try
            {
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Arithmatics arithmatics = new Arithmatics();
                arithmatics.Add = firstNumber + secondNumber;
                Console.WriteLine("The sum of {0} and {1} is: {2}", firstNumber, secondNumber, arithmatics.Add);
            }//validating no input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }//any other errors
            catch (Exception)
            {
                Console.WriteLine("Try again!");
                return;
            }//appreciating the user for using the calculator
            finally
            {
                Console.WriteLine("Thank you for using the calculator!");
            }
            // Wait for user input before closing
            Console.ReadLine();




        }
    }
}