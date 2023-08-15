using System;

namespace Console_Application_Assignment.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Type something to be multiplied by 50"); //prints Type something to be multiplied by 50
            string input50 = Console.ReadLine(); //sets the input of the user as a string
            int math50 = Convert.ToInt32(input50); //converts the string into an interger
            Console.WriteLine(50 * math50); //multiplies the interger by 50 and prints it

            Console.WriteLine("Input a number to add 25 too"); //prints Input a number to add 25 too
            string input25 = Console.ReadLine(); //sets the input of the user as a string
            int math25 = Convert.ToInt32(input25); //converts the string into an interger
            Console.WriteLine(math25 + 25); //adds 25 to the user set interger

            Console.WriteLine("input a number to to divide by 12.5"); //prints input a number to to divide by 12.5
            string input12 = Console.ReadLine(); //sets the input of the user as a string
            int math12 = Convert.ToInt32(input12); //converts the string into an interger
            Console.WriteLine(math12 / 12.5); //divivdes the user set interget by 12.5

            Console.WriteLine("input somethingto see if its greater then 50"); //prints input somethingto see if its greater then 50
            string inputGreater50 = Console.ReadLine(); //sets the input of the user as a string
            int mathGreater50 = Convert.ToInt32(inputGreater50); //converts the string into an interger
            Console.WriteLine(mathGreater50 > 50); //checks if the user set interger is greater than 50

            Console.WriteLine("input something to divide it by 7"); //prints input something to divide it by 7
            string input7 = Console.ReadLine(); //sets the input of the user as a string
            int math7 = Convert.ToInt32(input7); //converts the string into an interger
            Console.WriteLine(math7 / 7); // divides the user interger by 7
            Console.Read(); //gives the user enough time to read results
        }
    }
}
