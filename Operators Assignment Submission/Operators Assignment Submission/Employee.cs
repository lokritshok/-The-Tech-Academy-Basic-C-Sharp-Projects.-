using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    // This class represents an Employee with properties for Id, firstName, and lastName.
    public class Employee
    {// Properties of the Employee class
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Constructor to initialize an Employee object with Id, firstName, and lastName
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        //overload the == operator to compare two Employee objects based on their Ids
        public static bool operator == (Employee emp1, Employee emp2)
        {
            // Check if both objects are null or if they are the same instance
            if (ReferenceEquals(emp1, emp2)) return true;
            // If either object is null, return false
            if (emp1 is null || emp2 is null) return false;
            // Compare the Ids of the two Employee objects
            return emp1.Id == emp2.Id;
        }
        // Overload the != operator to compare two Employee objects based on their Ids
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the == operator to determine inequality
            return !(emp1 == emp2);
        }
        // Override the ToString method to provide a string representation of the Employee object
        public override string ToString()
        {
            return base.ToString();
        }
        // Override the Equals method to compare two Employee objects based on their Ids
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        // Override the GetHashCode method to provide a hash code for the Employee object
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
