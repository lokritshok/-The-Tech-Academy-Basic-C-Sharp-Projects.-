using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternary
            Console.WriteLine("What is your favourite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 7 ? "You are lucky!" : "You are not lucky.";
            Console.WriteLine(result);
            Console.ReadLine();


            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh....something went wrong.");
            //}
            //Console.ReadLine();





            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //Ternary operator

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("The room is at a comfortable temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("The room is too hot.");
            //}
            //else
            //{
            //    Console.WriteLine("The room is too cold.");
            //}
            //// adding another else if

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("The room is at a comfortable temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("The room is cold.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("The room is too hot.");
            //}
            //else
            //{
            //    Console.WriteLine("The room is too cold.");
            //}





        }
    }
}
