using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime();
            Console.WriteLine("Current Date and Time: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));//Print current date and time in the specified format
            Console.WriteLine("Please enter a number:");//user input prompt
            string input = Console.ReadLine();//Read user input
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));//Print exact time of user input
            Console.ReadLine();//Wait for user input before closing the console window
        }
    }
}
