using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee employee = new Employee("Sample", "Student", 55, 1704);
            // Display employee information
            employee.EmployeeInfo();
            // Wait for user input before closing the console
            Console.WriteLine("Please ensure to press any key to exit!");
            Console.ReadKey();
        }
    }
}
