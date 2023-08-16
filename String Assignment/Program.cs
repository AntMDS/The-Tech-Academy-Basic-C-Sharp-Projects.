using System;
using System.Text;


namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatenates three strings");
            string one = "one";
            string two = " two";
            string three = " three";
            Console.WriteLine(one + two + three);

            StringBuilder sb = new StringBuilder("This string hasnt been edited");
            Console.WriteLine(sb.ToString());
            sb.Replace("This string hasnt been edited", "until now, this has replaced the string.");
            sb.AppendLine(" This is an appended line, adding further to the string.");
            sb.AppendLine("This is a second appended line");
            sb.AppendLine("This is the last line of string.");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
