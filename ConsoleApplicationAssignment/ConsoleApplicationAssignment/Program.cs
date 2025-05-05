using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math Operations
            Console.WriteLine("Welcome to SHOK's MathLab");
            Console.WriteLine("\n" + "This is my Console Application Assignment!");
            //Multiplication: user input multiply by 50
            Console.WriteLine("\n" + "Please enter a number.");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            int product = num * 50;
            Console.WriteLine("\n" + product);

            //Addition: user input plus 25
            Console.WriteLine("\n" + "Please enter another number.");
            string Anumber = Console.ReadLine();
            int numb = Convert.ToInt32(Anumber);
            int total = numb + 25;
            Console.WriteLine("\n" + total);

            //Division: user input divide by 12.5
            Console.WriteLine("\n" + "Please enter a decimal number.");
            string Dnumber = Console.ReadLine();
            int Dnum = Convert.ToInt32(Dnumber);
            float Dnum2 = 12.5f;
            float quotient = Dnum / Dnum2;
            Console.WriteLine("\n" + quotient);

            //Greater than comparison: Is user input greater than 50?
            Console.WriteLine("\n" + "Please enter any number.");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int num6 = 50;
            bool trueOrFalse = num5 > num6;
            Console.WriteLine(trueOrFalse);

            //Modulus Operator: Remainder- user input divided by 7
            Console.WriteLine("\n" + "Please enter any number.");
            string number10 = Console.ReadLine();
            int num1 = Convert.ToInt32(number10);
            int num4 = 7;
            int remainder = num1 % num4;
            Console.WriteLine(remainder);


            //Console.ReadLine();



        }
    }
}
