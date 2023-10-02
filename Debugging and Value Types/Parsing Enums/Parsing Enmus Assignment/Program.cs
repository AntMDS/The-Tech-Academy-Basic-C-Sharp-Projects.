using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday, 
            Friday,
            Saturday,
            sunday
        }

        static void Main(string[] args)
        {
            bool isvalid = false;
            while(!isvalid)
            {
                try
                {
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have a niec " + day);
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an acutal day of the week");
                }
            }
        }
    }
}