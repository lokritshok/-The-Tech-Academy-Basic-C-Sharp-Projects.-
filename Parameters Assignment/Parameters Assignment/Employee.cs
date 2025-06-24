using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    public class Employee<T> : Person
    {
        // Properties
        //instantiate a person object
        Person person { get; set; }
         
        public List<T> things { get; set; }
        public int employeeId { get; set; }

    }
}
