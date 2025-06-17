using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class and call the SayName method
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // Output the result of SayName method
            Console.WriteLine(employee.SayName());
            Console.ReadLine();
        }
    }
}
