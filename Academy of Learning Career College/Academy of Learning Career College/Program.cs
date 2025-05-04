using System;


namespace Academy_of_Learning_Career_College
{
    internal class Program
    {
        static void Main()
        {
            // Opening console name/type
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("\n" + "Student Daily Report.");
            // checklists for students to respond to
            Console.WriteLine("\n" + "What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\n" + "What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("\n" + "What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("\n" + "Do you need help with anything? Please answer \"true\" or \"false\".");
            String anyHelp = Console.ReadLine();
            Console.WriteLine("\n" + "Where there any positive experiences you'd like to share? Please be specific.");
            String positiveExperience = Console.ReadLine();
            Console.WriteLine("\n" + "Is there any other feedback you'd like to provide? Please be specific.");
            String feedback = Console.ReadLine();
            Console.WriteLine("\n" + "How many hours did you study today?");
            String hoursOfStudy = Console.ReadLine();
            // Ending program with feedback
            Console.WriteLine("\n" + "Thank you for your answers. An instructor will respond shortly. Have a great day!");
        }
    }
}
