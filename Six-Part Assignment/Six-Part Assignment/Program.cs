using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Assignment Part 1.
            ////One-dimensional array of strings.

            //string[] names = { "Victor", "Ori", "Bryan", "Jed", "Natasha", "Michelle" };
            ////User input
            //Console.WriteLine("Enter a name:");
            //string input = Console.ReadLine();

            ////Creating a loop that iterates through the array and adds the user's input to the array.
            //for (int s = 0; s < names.Length; s++)
            //{
            //    if (names[s] == input)
            //    {
            //        Console.WriteLine("The name is: "  + input);
            //    }

            //}
            //Console.ReadLine();
            ////Second loop that prints the names in the array.
            //for (int s = 0; s < names.Length; s++)
            //{
            //    Console.WriteLine(names[s]);
            //}
            //Console.ReadLine();


            ////Assignment Part 2.
            ////Creating an infinite loop. 
            //while (true)
            //{
            //    Console.WriteLine("Enter a name :");
            //    string input = Console.ReadLine();

            //}

            //// infinite loop executing to normal. 
            //while (true)
            //{
            //    Console.WriteLine("Enter a name :");
            //    string input = Console.ReadLine();
            //    // infinite loop terminates if the user inputs "exit"
            //    if (input == "exit")
            //    {
            //        break;
            //    }

            //}


            ////Assignment Part 3.
            ////A loop where < is used. 
            //for (int s = 0; s < names.Length ; s++)
            //{ //if the name is equal to the user's input, it will print the name.
            //    if (names[s] == input)
            //   {
            //       Console.WriteLine("The name is: " + input);
            //   }
            // }

            ////A loop where <= is used.
            //for (int s = 0; s <= names.Length - 1; s++)
            //{ //if the name is equal to the user's input, it will print the name.
            //    if (names[s] == input)
            //    {
            //        Console.WriteLine("The name is: " + input);
            //    }
            //}


            ////Assignment Part 4.
            ////Creating a list of strings where each item is unique.

            //List<string> uniqueNames = new List<string> { "Lokrit", "Comfort", "Nenmena", "Rotshak", "Osiondu", "Oyaondu" };


            ////Enter user input text to search for a name in the list.
            //Console.WriteLine("Enter a name to search for in the list:");
            //string input = Console.ReadLine();
            //foreach (string name in uniqueNames)
            //{
            //    //if the name is equal to the user's input, it will print the name.
            //    if (name == input)
            //    {
            //        Console.WriteLine("The name is: " + input);
            //    }
            //}
            //Console.ReadLine();

            ////A loop that iterates through the list and then displays the index of user's input.
            //{
            //    if (name == input)
            //    {
            //        int index = uniqueNames.IndexOf(name);
            //        Console.WriteLine($"The name : " + input + " is found at index: " + index);
            //    }
            //}
            //Console.ReadLine();

            ////Adding code to display all names in the list.
            //Console.WriteLine("All names in the list:");
            //foreach (string name in uniqueNames)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //adding code to check if a name isn't on the list and display a message.
            //Console.WriteLine("enter a name to check if it is in the list:");
            //string input = Console.ReadLine();
            //if (!uniqueNames.Contains(input))
            //{
            //    Console.WriteLine("the name " + input + " is not in the list.");
            //}
            ////Adding a code that stops the loop from executing when a mathcing name is found

            //else
            //{
            //    bool nameExists = (uniqueNames.Contains(input));

            //}
            //Console.WriteLine("The name " + input + " is on the list.");

            ////Assignment Part 5.
            ////Adding a list of strings that has a least two identical strings.

            //List<string> namesWithDuplicates = new List<string> { "Alice", "Bob", "Charlie", "Alice", "Eve", "Frank", "Bob", "Eve"};
            ////User input to search for a name in the list.
            //Console.WriteLine("Enter a name to search for in the list:");
            //string input = Console.ReadLine();
            ////Loop that iterates through the list and checks for duplicates.
            //bool found = false;
            //for (int i = 0; i < namesWithDuplicates.Count; i++)
            //{
            //    if (namesWithDuplicates[i].Equals(input, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"The name '{input}' is found at index: {i}");
            //        found = true;
            //    }
            //}
            ////If the name is not found, it will display a message.
            //if (!found)
            //{
            //    Console.WriteLine($"The name '{input}' is not found in the list.");
            //}
            ////Adding code to display all names in the list.
            //Console.WriteLine("All names in the list:");
            //foreach (string name in namesWithDuplicates)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();


            ////Assignment Part 6.
            ////Creating a list of strings that contains at least two identical strings.
            List<string> namesWithDuplicates2= new List<string> { "Alice", "Bob", "Charlie", "Alice", "Eve", "Frank", "Bob", "Eve", "Victor", "Ori", "Bryan", "Jed", "Natasha", "Michelle", "Jed" };
            ////Creating another list to store duplicates.
            List<string> namesAlreadyListed = new List<string>();
           //or (int i = 0; i < namesWithDuplicates2.Count; i++)
            //{
            //    Console.WriteLine(namesWithDuplicates2[i]);
            //}
            //Console.ReadLine();

            foreach (string name in namesWithDuplicates2)
            {                 //Checking if the name is already in the namesAlreadyListed list.
                if (namesAlreadyListed.Contains(name))
                {
                    Console.WriteLine($"The name '{name}' is a duplicate.");
                }
                else
                {
                    //If not, add it to the namesAlreadyListed list.
                    namesAlreadyListed.Add(name);
                    Console.WriteLine($"The name '{name}' is unique.");
                }
                
            }
            Console.ReadLine();













        }

    }
} // End of Program class





