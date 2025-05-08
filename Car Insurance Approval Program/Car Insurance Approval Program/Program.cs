using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Welcome to the Car Insurance Approval Program!");
            Console.WriteLine("Please answer the following questions to determine your eligibility for car insurance.");
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many accidents have you had in the last 5 years?");
            int accidents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you received in the last 3 years?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
           
            bool qualified = age > 15 && accidents == 0 && speedingTickets <= 3;
            if (qualified)
            {
                Console.WriteLine("Congratulations! You are qualified for car insurance.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not qualified for car insurance.");
            }

        }
    }
}
