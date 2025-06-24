using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    // Prompt user to enter the current day of the week
                    Console.WriteLine("Please enter the current day of the week (e.g., Monday, Tuesday, etc.): ");

                    string input = Console.ReadLine();
                    // Attempt to parse the input into the DaysOfTheWeek enum
                    if (Enum.TryParse(input, true, out DaysOfTheWeek day))
                    {
                        // If parsing is successful, display the corresponding enum value
                        Console.WriteLine($"You entered: {day}");
                    }
                    else
                    {
                        // If parsing fails, inform the user
                        Console.WriteLine("Invalid day of the week entered. Please try again.");
                    }
                    //Assign the value of the enum to a variable
                    DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input, true);
                    // Display the value of the enum variable
                    Console.WriteLine($"Today is: {today}");
                    Console.ReadLine();



                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during parsing
                    Console.WriteLine($"Please enter an actual day of the week: {ex.Message}");
                    return;
                }
                finally
                {
                    // Set isValid to true to exit the loop after a successful input
                    isValid = true;
                   

                }
                Console.ReadLine();
                
            }
        }
    }
}

