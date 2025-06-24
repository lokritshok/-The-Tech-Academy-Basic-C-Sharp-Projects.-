using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
   class Program

    {
        Employee<string> employee = new Employee<string>();
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee<string> employee = new Employee<string>

            {
                firstName = "Victor",
                lastName = "Shok",
                age = 55,
                employeeId = 130058,
                things = new List<string> { "Laptop", "Phone", "Notebook" }
            };

            // Creating an instance of employee with type int as the generic type parameter
            Employee<int> employeeWithInt = new Employee<int>

            {   firstName = "Ori",
                lastName = "Shok",
                age = 45,
                employeeId = 123456,
                things = new List<int> { 100, 250, 500 }
            };
            // Display employee details
            Console.WriteLine($"Employee Name: {employee.firstName} {employee.lastName}");
            Console.WriteLine($"Age: {employee.age}");
            Console.WriteLine($"Employee ID: {employee.employeeId}");
            Console.WriteLine("Things:");
            foreach (var thing in employee.things)
            {
                Console.WriteLine($"- {thing}");
            }
            // Display employee with int details
            Console.WriteLine($"\nEmployee Name: {employeeWithInt.firstName} {employeeWithInt.lastName}");
            Console.WriteLine($"Age: {employeeWithInt.age}");
            Console.WriteLine($"Employee ID: {employeeWithInt.employeeId}");
            Console.WriteLine("Things:");
            foreach (var thing in employeeWithInt.things)
            {
                Console.WriteLine($"- {thing}");
            }
            Console.ReadLine();
        }

    }
}
