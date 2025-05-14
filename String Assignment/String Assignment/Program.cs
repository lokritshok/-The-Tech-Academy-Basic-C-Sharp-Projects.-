using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Concatenating 3 strings
            //string str1 = "I love to";
            //string str2 = "cook and ";
            //string str3 = "eat homemade pastries!";
            //string result = str1 + " " + str2 + str3;
            //Console.WriteLine("Concatenated String: " + result);
            //Console.ReadLine();

            ////converting string to uppercase
            //string str4 = "i am victorious in christ";
            //string upperStr = str4.ToUpper();
            //Console.WriteLine("Uppercase String: " + upperStr);
            //Console.ReadLine();

            //Creating a stringbuilder and building a paragragh of text, one sentence at a time
            StringBuilder sb = new StringBuilder();
            sb.Append("I love to cook and eat homemade pastries! ");
            sb.Append("I am victorious in Christ. ");
            sb.Append("I am a software developer. ");
            sb.Append("I am married with children. ");
            sb.Append("I am a child of God. ");
            sb.Append("I am blessed. ");
            sb.Append("I am a hard worker. ");
            sb.Append("I am a good friend. ");
            sb.Append("I am a good listener. ");
            sb.Append("I am a good communicator.");
            sb.Append("I am a good problem solver.");
            sb.Append("I am a good team player.");
            sb.Append("I am a leader.");
            sb.Append("I love my family.");
            sb.Append("I love my friends.");
            sb.Append("I love my job.");
            sb.Append("I love my life.");
            sb.Append("I love my God.");
            Console.WriteLine("Paragraph: " + sb.ToString());
            Console.WriteLine("Length of paragraph: " + sb.Length);
            Console.ReadLine();

        }
    }
}
