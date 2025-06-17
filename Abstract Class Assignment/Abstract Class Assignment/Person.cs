using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        // Properties for FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName
        public string SayName()
        {
            // Returns a string that combines FirstName and LastName
            return $"Name: {FirstName} {LastName}";
        }
    }
}
