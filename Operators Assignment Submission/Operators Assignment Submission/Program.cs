using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with different Ids
            Employee emp1 = new Employee(1902, "Ori", "Shok");
            Employee emp2 = new Employee(1901, "Comfort", "Ejum");
            //001 Compare the two Employee objects using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("Based on their id's, the two employees are equal");
            }
            else
            {
                Console.WriteLine("Based on their id's, the two employees are not equal.");
            }
            //002 Compare the two Employee objects using the overloaded != operator
            //if (emp1 != emp2)
            //{
            //    Console.WriteLine("Based on their id's, the two employees are not equal.");
            // }
            // else
            // {
            //     Console.WriteLine("Based on their id's, the two employees are equal.");
            // }
            Console.ReadLine();
        }
    }
}
