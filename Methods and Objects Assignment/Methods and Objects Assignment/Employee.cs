using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{// This code defines an Employee class that inherits from Person
 // The Employee class has an additional property Id 
 // The Person class contains properties for first name, last name, and age, along with a method to display the full name
 
    public class Employee : Person
    {
        public int Id { get; set; }
        public Employee(string firstName, string lastName, int age, int id)
            : base(firstName, lastName, age)
        {
            Id = id;
        }
        //Calling the SayName method from the Person class to display the employee's name
        public void EmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {Id}");
            SayName();
            Console.WriteLine($"Age: {Age}");
        }
    }
}
