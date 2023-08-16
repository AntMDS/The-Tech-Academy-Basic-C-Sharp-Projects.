using System;
using System.IO;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //prints Welcome to Package Express. Please follow the instructions below.
            Console.WriteLine("Please enter your packages weight"); //prints Please enter your packages weight
            int weight = Convert.ToInt32(Console.ReadLine()); //stores the users weight input as an int

            if (weight > 50) //if the weight is greater then 50 execure this 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //prints Package too heavy to be shipped via Package Express. Have a good day.
                Console.ReadLine(); //gives the user enough time to read the console
            }
            else //if the weight is less then 50 then execute this
            {
                Console.WriteLine("please enter package Width"); //prints please enter package Width
                int width = Convert.ToInt32(Console.ReadLine()); //stores the users width input as an int
                Console.WriteLine("please enter package height"); //prints please enter package height
                int height = Convert.ToInt32(Console.ReadLine()); //stores the users height input as an int
                Console.WriteLine("Please enter pachage length"); //prints Please enter pachage length
                int length = Convert.ToInt32(Console.ReadLine()); //stores the users length input as an int

                if (width + height + length > 50) //if the width, height and legnth all added together are greater than 50 execute this code
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); //prints Package too big to be shipped via Package Express.
                    Console.ReadLine(); //gives the user enough time to read the console
                }
                else //if the width, height and legnth all added together are less than 50 execute this code
                {
                    int quote = Convert.ToInt32(((width * height * length) * weight) / 100); //creates an int that is the width, height, lenth all multiplied by each other. then multiplied by the weight, then divided by 100 to calculate the quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote); //prints Your estimated total for shipping this package is: $ + the calculated quote
                    Console.ReadLine(); //gives the user enough time to read the console
                }
            }
        }
    }
}
