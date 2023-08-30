using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] names = { "ben", "jeff", "steve", "harvey", "dave", "bob", "gwen", "rammus", "tristana" }; //a list of peoples names in an array
            Console.WriteLine("please write and adjective for a person you like, eg: handsome."); //asks the user to input a string 
            string stringAdjective = Console.ReadLine(); //stores the inputed string of the user

            for (int i = 0; i < names.Length; i++) //loops through each string in the array
            {
                string[] namesUpdated = { names[i] + " is " + stringAdjective };//adds the user input string at the end of each string i nthe array

                for (int j = 0; j < namesUpdated.Length; j++) //loops through the updated array
                {
                    Console.WriteLine(namesUpdated[j]); //prints out all strings inthe array 
                }
            }
            Console.ReadLine(); //gives the user time to read the outcome/ they have to input a button to move the code along 

            int a = 10; //defines a as an int value of 10
            int k = 0; //defines k as an int value of 0

            while (k < a && a < 20) //this loop is infinite as k will always be smaller then a, and a will always be getting increased. to fix this we can add an AND operator so that it can only repeat aslong as a is smaller than 20 
            {
                a++; //will increase the value of a
                Console.WriteLine("This will no longer go on forever"); //will print "This will no longer go on forever" everytime the loop executes
            }
            Console.ReadLine(); //gives the user time to read the outcome/ they have to input a button to move the code along 
        }
    }
}
