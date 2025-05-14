using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    internal class Program
    {
        private static int age;

        static void Main(string[] args)

        {  ////A do while loop is a control flow statement that executes a block of code at least once and then repeatedly executes the block as long as a specified condition is true.

            // Prompt the user to enter their age
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool student = age == 18;
            // Check if the user is a student

            do
            {
                switch (age)
                {
                    case 11:
                        Console.WriteLine("you are a minor. Go home!");
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("you are not a student here!");
                        Console.WriteLine("Enter your age: "); ;
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("please you are not a student here.");
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 18:
                        Console.WriteLine("You are a student here, Welcome!");
                        age = Convert.ToInt32(Console.ReadLine());
                        student = age == 18;
                        break;
                    case 19:
                        Console.WriteLine("You are above 18.");
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You are above 19.");
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("You are an adult. Please Go Home!");
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please try again!");
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!student);
            

                Console.WriteLine("Thank you for your time!");
                Console.ReadLine();




            ////A do while loop is a control flow statement that executes a block of code at least once and then repeatedly executes the block as long as a specified condition is true.


            //// Prompt the user to enter their age
            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool student = age <= 18;
            //// Check if the user is a student

            //do
            //{

            //    switch (age)
            //    {
            //        case 11: 
            //            Console.WriteLine("you are a minor. Go home!");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 16:
            //            Console.WriteLine("you are a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            student = age <= 18;
            //            break;
            //        case 17:
            //            Console.WriteLine("you are a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            student = age <= 18;
            //            break;
            //        case 18:
            //            Console.WriteLine("You are a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            student = age <= 18;
            //            break;
            //        case 19:
            //            Console.WriteLine("You are not a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 20:
            //            Console.WriteLine("You are not a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 50:
            //            Console.WriteLine("You are an adult. Please Go Home!");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine("Please try again!");
            //            Console.WriteLine("Enter your age: ");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;


            //    }


            //}
            //while (student);

            //Console.ReadLine();






            //// While statement

            //  while (age <= 18)
            // {    
            //  switch (age)
            //    {
            //        case 11: 
            //            Console.WriteLine("you are a minor. Go home!");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 16:
            //            Console.WriteLine("you are a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            student = age <= 18;
            //            break;
            //        case 17:
            //            Console.WriteLine("you are a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            student = age <= 18;
            //            break;
            //        case 18:
            //            Console.WriteLine("You are a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            student = age <= 18;
            //            break;
            //        case 19:
            //            Console.WriteLine("You are not a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 20:
            //            Console.WriteLine("You are not a student.");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 50:
            //            Console.WriteLine("You are an adult. Please Go Home!");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine("Please try again!");
            //            Console.WriteLine("Enter your age: ");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //     }
            //  }
            //Console.WriteLine("Thank you for your time!");
            //Console.ReadLine();


        }
    }
}