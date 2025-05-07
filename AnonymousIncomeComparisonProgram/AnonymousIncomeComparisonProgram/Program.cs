using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opening screen + User1 input 
            Console.WriteLine("Anonymous Income Comparison Program!");
            Console.WriteLine("\n" + "What is your name ?");
            string name1 = Console.ReadLine();
            Console.WriteLine("\n" + "How much do you earn per hour?");
            string ratePerHour1 = Console.ReadLine();
            Console.WriteLine("\n" + "How much hours per week?");
            string weeklyHours1 = Console.ReadLine();

            //User1 Annual Pay calculations
            int rtPerHour1 = Convert.ToInt32(ratePerHour1);
            int wklyHours1 = Convert.ToInt32(weeklyHours1);
            int WkYrly = 54;
            int product1 = rtPerHour1 * wklyHours1 * 54;
            Console.WriteLine("\n" + product1);
          

            //User2 input 
            Console.WriteLine("\n" + "What is your name ?");
            string name2 = Console.ReadLine();
            Console.WriteLine("\n" + "How much do you earn per hour?");
            string ratePerHour2 = Console.ReadLine();
            Console.WriteLine("\n" + "How much hours per week?");
            string weeklyHours2 = Console.ReadLine();

            //User1 Annual Pay calculations
            int rtPerHour2 = Convert.ToInt32(ratePerHour2);
            int wklyHours2 = Convert.ToInt32(weeklyHours2);
            int WkYrly2 = 54;
            int product2 = rtPerHour2 * wklyHours2 * 54;
            Console.WriteLine("\n" + product2);

            //Annual salaries of both persons
            Console.WriteLine("\n" + "Annual Salary of " + name1 + " is:" + "\n" + Convert.ToString(product1));
            Console.WriteLine("\n" + "Annual Salary of " + name2 + " is:" + "\n" + Convert.ToString(product2));

            //Comparison operator use:
            Console.WriteLine("\n" +  name1 + " makes more money than " +  name2);
            int nam1 = product1;
            int nam2 = product2;
            bool trueOrFalse = nam1 > nam2; 
            Console.WriteLine("\n" + trueOrFalse);
        }
    }
}
