using System;
using System.Collections.Generic;

namespace Console_App_Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77 };
            bool numValid = false;
            while (!numValid)
            {
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    float numDivide = float.Parse(Console.ReadLine());
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number than 0.");
                    }
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + '/' + numDivide + '=' + Divide);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            Console.WriteLine("The program has excited the try/catch block.");
        }
    }
}
