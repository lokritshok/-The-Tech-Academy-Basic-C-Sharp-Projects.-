using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public class MathsOps2
    {
        //creating a void method to output an integer

        public void OutputInteger()
        {

            int numberOne = new int();
            //prompting user for input
            Console.WriteLine("Enter a number to divide by 2:");
            //reading user input
            numberOne = Convert.ToInt32(Console.ReadLine());
            //outputting the integer divided by 2
            //maths operation: dividing by 2
            int result = numberOne / 2;
            Console.WriteLine("The result of dividing the number by 2 is: " + result);

            //overloading the method 
            Console.WriteLine("\nEnter a number to divide by 3:");
            //reading user input
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            //outputting the integer divided by 3
            //maths operation: dividing by 3
            int result2 = numberTwo / 3;
            Console.WriteLine("The result of dividing the number by 3 is: " + result2);

            //overloading the method
            Console.WriteLine("\nEnter a number to multiply by 4:");
            //reading user input
            int numberThree = Convert.ToInt32(Console.ReadLine());
            //outputting the integer multiplied by 4
            //maths operation: multiplying by 4
            int result3 = numberThree * 4;
            Console.WriteLine("The result of multiplying the number by 4 is: " + result3);




        }



    }
}
