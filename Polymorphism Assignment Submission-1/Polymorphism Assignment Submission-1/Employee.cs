using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission_1
{
   
    
        public class Employee : Person, IQuittable
        {
            // Employee class inherits from Person class
            // Additional properties or methods specific to Employee can be added here
            public Employee()
            {

            }

            // Override the SayName method from the Person class
            public void Quit()
            {
                // Implementation of the Quit method
                Console.WriteLine($"{FirstName} {LastName} has quit the job.");
            }

        }
    
}
