using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //creating an instance of Number struct
            Number number = new Number(1999.9m);
            
          //displaying the value of Amount property
            Console.WriteLine("The amount is: " + number.Amount);
            Console.ReadLine();
        }
    }
}
