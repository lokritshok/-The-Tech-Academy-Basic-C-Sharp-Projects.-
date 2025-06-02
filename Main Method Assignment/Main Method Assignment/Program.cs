using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the mathOps1 class
            int intResult = mathOps1.Method(10);
            Console.WriteLine("Integer input result: " + intResult);
            // Call the Method with decimal types of inputs and return an integer result
            decimal decResult = mathOps1.Method(4.5m);
            Console.WriteLine("Decimal input result: " + decResult);
            // Call the Method with string types of inputs and return an integer result
            try
            {
                int strResult = mathOps1.Method("five");
                Console.WriteLine("String input result: " + strResult);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine(); // Keep the console window open until a key is pressed
        }



    }
}
