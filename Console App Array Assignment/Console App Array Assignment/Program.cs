using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Declare an array of strings
            //string[] names = new string[6];
            //names[0] = ("Ori");
            //names[1] = ("Bryan"); 
            //names[2] = ("Jed");
            //names[3] = ("Natasha");
            //names[4] = ("Michelle");
            //names[5] = ("Victor");
            //// Prompt the user to enter any number between 1 and 6
            //Console.WriteLine("Please enter any number between 1 and 6:");
            //// Loop to read number from the user to reveal the name
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write($"Enter number {i}: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    // Check if the number is within the valid range
            //    if (number >= 1 && number <= 6)
            //    {
            //        // Display the corresponding name
            //        Console.WriteLine($"The name at position {number} is: {names[number - 1]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid number. Please enter a number between 1 and 6.");
            //    }
            //}



            //// Declare an array of integers
            //int[] numbers = new int[6];
            //numbers[0] = 100;
            //numbers[1] = 2000;
            //numbers[2] = 30000;
            //numbers[3] = 400000;
            //numbers[4] = 5000000;
            //numbers[5] = 60000000;

            //// Prompt the user to enter an integer
            //Console.WriteLine("Please enter a number from 1 to 6:");
            //// Loop to read number from the user to reveal the numbers
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    // Check if the number is within the valid range

            //    if (number >= 1 && number <= 6)
            //    {
            //        // Display the corresponding number
            //        Console.WriteLine($"The number at position {number} is: {numbers[number - 1]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid number. Please enter a number between 1 and 6.");
            //    }



            // creating a list of strings
            List<string> names = new List<string>();
            names.Add("Ori");
            names.Add("Bryan");
            names.Add("Jed");
            names.Add("Natasha");
            names.Add("Michelle");
            names.Add("Victor");

            // Prompt the user to enter any number between 1 and 6
            Console.WriteLine("Please enter any number between 1 and 6:");
            // Loop to read number from the user to reveal the name
            for (int i = 0; i < names.Count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                // Check if the number is within the valid range
                if (number >= 1 && number <= 6)
                {
                    // Display the corresponding name
                    Console.WriteLine($"The name at position {number} is: {names[number - 1]}");
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a number between 1 and 6.");
                }





            }
    }
    }
}
