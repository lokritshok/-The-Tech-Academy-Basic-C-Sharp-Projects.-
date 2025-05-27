using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Strings_and_integers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating a list of integers
                List<int> myList = new List<int>();
                myList.Add(10);
                myList.Add(20);
                myList.Add(30);
                myList.Add(40);
                //User input to divide each number in the list
                Console.WriteLine("Enter a number to divide by");
                int yourNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myList.Count; i++)

                    myList[i] = myList[i] / yourNumber;

                //Output the results
                Console.WriteLine("The results of dividing each number in the list by " + yourNumber + " are:");
                foreach (int number in myList)
                {
                    Console.WriteLine(number);

                }

            }//End of try block
            //catching non-formatted input

            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");

            }
            //catching division by zero error
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero. Please enter a valid number.");

            }
            //catching any other unexpected errors
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);

            }
            //finally block to ensure the program ends gracefully
            finally
            {
                Console.WriteLine();

            }
            //Exiting try/catch block
            Console.WriteLine("Thank you for using the program. Press any key to exit.");


        }
    }
}