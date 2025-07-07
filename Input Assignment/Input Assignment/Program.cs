using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Prompt the user for their name and write it to a file
            Console.WriteLine("Please enter your phone number:");// Prompt for phone number
            string phoneNumber = Console.ReadLine();// Read user input for phone number
            File.WriteAllText(@"C:\Users\shokv\Documents\myRepository\mycodefiles\text.txt", phoneNumber);//Location of the file

            Console.WriteLine(phoneNumber);// Display the phone number entered by the user
            using (StreamWriter sw = new StreamWriter(@"C:\Users\shokv\Documents\myRepository\mycodefiles\text.txt", true))
            {
                sw.WriteLine(phoneNumber); // Write the phone number to the file
            }
            Console.ReadLine(); // Wait for user input before closing the console
        }
    }
}
