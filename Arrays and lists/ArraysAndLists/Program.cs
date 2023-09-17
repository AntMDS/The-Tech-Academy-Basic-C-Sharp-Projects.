using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colorArray = { "Green", "Yellow", "Red", "Orange", "Purple", "Blue", "Pink", "Black" };
            Console.WriteLine("Pick a number between 0 and 7");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favourite color is " + colorArray[stringSelect]);
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. please choose a number between 0 and 7. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            List<string> occupationList = new List<string>()
            {
                "UX Designer",
                "Data Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcast Host",
                "Software developer",
                "QA Tester"
            };

            Console.WriteLine("\nSelect another number between 0 and 9: ");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. please choose a number between 0 and 9. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] intArray = { 34, 65, 22, 12, 5, 32, 72, 27, 10, 2 };
            Console.WriteLine("\nSelect a third number between 0 and 9: ");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. please choose a number between 0 and 9. ");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
