using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method_Assignment
{
    public class Numbers
    {
        public string Add(int a, int b)
        {
            return $"{a} + {b} = {a + b}";
        }
        public string Subtract(int a, int b)
        {
            return $"{a} - {b} = {a - b}";
        }
        public string Multiply(int a, int b)
        {
            return $"{a} * {b} = {a * b}";
        }
        
    }
}
