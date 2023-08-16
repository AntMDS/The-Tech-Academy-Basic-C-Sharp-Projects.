using System;

namespace Boolean_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application"); //prints Car Insurance Application
            Console.WriteLine("What age are you?"); //prints What age are you?
            int userAge = Convert.ToInt32(Console.ReadLine()); //sets an interger from the users input age 
            Console.WriteLine("Have you ever had a DUI? please answer with Yes or No"); //prints Have you ever had a DUI? please answer with Yes or No
            String duiAnswer = Console.ReadLine().ToLower(); //sets the users input to the question above as a string and makes it all lower text
            bool dui = duiAnswer == "yes"; //sets the bool to true if the users answer from the set string is 'yes'
            Console.WriteLine("how many speeding tickets do you have?"); //prints how many speeding tickets do you have?
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); //sets an interger from the user input
            Console.WriteLine("Do you qualify for insurance?"); //prints Do you qualify for insurance?
            bool qualified = (userAge > 15) && !dui && (speedingTickets <= 3); //calculates if a user can get insurance if, their age is greater then 15, they dont have any DUI's, have less than or equal to 3 speeding tickets. sets a bool depending on results
            Console.WriteLine(qualified); //tells the user if they can get insurance with a True or False
            Console.ReadLine();// gives the user enough time to read the results
        }
    }
}
