using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, firstName = "Victor", lastName = "Shok" },
                new Employee { Id = 2, firstName = "Jane", lastName = "Smith" },
                new Employee { Id = 3, firstName = "Sam", lastName = "Brown" },
                new Employee { Id = 4, firstName = "Lisa", lastName = "Johnson" },
                new Employee { Id = 5, firstName = "Tom", lastName = "Williams" },
                new Employee { Id = 6, firstName = "Joe", lastName = "Davis" },
                new Employee { Id = 7, firstName = "Michael", lastName = "Johnson" },
                new Employee { Id = 8, firstName = "Sarah", lastName = "Jacob" },
                new Employee { Id = 9, firstName = "David", lastName = "Bowe" },
                new Employee { Id = 10, firstName = "Joe", lastName = "Lopez" }

            };
           
            //using a foreach loop to create a new list of employees with first name "Joe"
            var joeEmployees = new List<Employee>();
            foreach (Employee employee in employees)
            {
                  if (employee.firstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }
            // Display the employees with first name "Joe"
            if (joeEmployees.Count > 0)
            {
                Console.WriteLine("Employees with first name 'Joe':");
                foreach (var joe in joeEmployees)
                {
                    Console.WriteLine($"{joe.firstName} {joe.lastName}");
                }
            }
            else
            {
               Console.WriteLine("No employees found with first name 'Joe'.");
            }


            // Using a lambda expression to create a new list of employees with first name "Joe"
            var joeEmployeesLambda = employees.Where(v => v.firstName == "Joe").ToList();
            // Display the employees with first name "Joe" using lambda expression
            if (joeEmployeesLambda.Count > 0)
            {
                Console.WriteLine("Employees with first name 'Joe' using lambda expression:");
                foreach (var joe in joeEmployeesLambda)
                {
                    Console.WriteLine($"{joe.firstName} {joe.lastName}");
                }
            }
            else
            {
                Console.WriteLine("No employees found with first name 'Joe' using lambda expression.");
            }

            //using a lambda expression to create a list of employees with id greater than 5
            var employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();
            // Display the employees with id greater than 5
            if (employeesWithIdGreaterThan5.Count > 0)
            {
                Console.WriteLine("Employees with ID greater than 5:");
                foreach (var employee in employeesWithIdGreaterThan5)
                {
                    Console.WriteLine($"{employee.firstName} {employee.lastName}");
                }
            }
            else
            {
                Console.WriteLine("No employees found with ID greater than 5.");
            }
            Console.ReadLine();

           



        }
    }
}
