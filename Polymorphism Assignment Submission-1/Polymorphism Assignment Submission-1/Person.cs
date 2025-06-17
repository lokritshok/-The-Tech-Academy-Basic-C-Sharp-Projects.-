using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission_1
{
    public class Person
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
