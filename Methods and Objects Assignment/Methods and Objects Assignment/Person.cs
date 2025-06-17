using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Person
    {// This code defines a Person class with properties for first name, last name, and age
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        // Method to display the full name of the person
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
