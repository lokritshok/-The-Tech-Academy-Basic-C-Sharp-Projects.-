using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class mathOps1
    {
        // Method that accepts an integer and returns an integer result
        public static int Method(int number)
        {
            return number * number;
        }
        // Method that accepts a decimal and returns an integer result
        public static int Method(decimal number)
        {
            return (int)(number * number);
        }
        // Method that accepts a string and converts it to integer
        public static int Method(string text)
        {
            int result;
            // Attempt to parse the string to an integer
            if (int.TryParse(text, out result))
            {
                return result * result;
            }
            else// If parsing fails, throw an exception
            {
                throw new ArgumentException("Input string is not a valid integer.");
            }
        }
    }
}
