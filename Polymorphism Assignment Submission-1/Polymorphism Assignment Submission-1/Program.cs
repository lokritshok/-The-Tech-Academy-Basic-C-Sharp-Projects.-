using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03 Creating an instance of the IQuittable class
            IQuittable quittable = new Employee() { FirstName = "Victor", LastName = "Shok" };
            //03 Call the Quit method on the IQuittable instance
            quittable.Quit();

            ////01 Create an instance of the Employee class and call the SayName method
            // Employee employee = new Employee();
            //  employee.FirstName = "Sample";
            //  employee.LastName = "Student";
            ////01 Output the result of SayName method
            ////Console.WriteLine(employee.SayName());
            
            ///02 Call the Quit method
            ///02 employee.Quit();
            Console.ReadLine();
        }
    }
    
}
