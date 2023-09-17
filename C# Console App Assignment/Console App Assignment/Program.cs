using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            while (k <= a)
            {
                k++;
                Console.WriteLine("K's current value is " + k);
            }
            Console.ReadLine();



            String[] fruits = { "Apple", "Banana", "Orange", "Apricot", "Peach", "Kiwi", "Mango", "Strawberry", "Blackberry", "Cherries", "Watermelon", "grapes" };
            Console.WriteLine("Please enter a fruit ");
            string selectedFruit = Console.ReadLine();
            bool validFruit = false;

            while (!validFruit)
            {
                try
                {
                    int selectedIndex = Array.IndexOf(fruits, selectedFruit) + 1;
                    Console.WriteLine($"The fruit you selected is {selectedFruit} and is our {selectedIndex}");
                    validFruit = true;
                }
                catch
                {
                    Console.WriteLine("The fruit you have chosen isnt in our array, please choose another: ");
                    selectedFruit = Console.ReadLine();
                }
            }
            Console.ReadLine();

            List<string> nameList = new List<string>()
            {
                "Dave",
                "Steve",
                "john",
                "Gen",
                "Edward",
                "Dave",
                "Fred",
                "Shara",
                "Sasha",
            };

            Console.WriteLine("please check for names in our contacts, E.G: Dave");
            string listSelect = Console.ReadLine();
            bool validSelect = false;

            while (!validSelect)
            {
                try
                {
                    var matchIndex = 0;
                    int nameIndex = nameList.IndexOf(listSelect);
                    for (int b = 0; b < nameList.Count; b++)
                    {
                        if (nameList[b] == listSelect)
                        {
                            matchIndex = b + 1;
                            Console.WriteLine($"The name you have chosen is {listSelect} they are found in your {matchIndex} contact");
                        }
                    }
                    validSelect = true;
                }
                catch
                {
                    Console.WriteLine("That name is not in our contact list, please try again");
                    listSelect = Console.ReadLine();
                }
                Console.ReadLine();
            }

            List<string> letttersList = new List<string>()
            {
                "A",
                "B",
                "C",
                "B",
                "E",
            };

            Console.WriteLine("Lets check a list for duplicates:");
            string letterDuplicate = "";
            foreach (string letter in letttersList)
            {
                if (letttersList.Count != letttersList.Distinct().Count())
                {
                    letterDuplicate = "a duplicate";
                    Console.WriteLine($"{letter} is {letterDuplicate}");
                }
                else
                {
                    letterDuplicate = "unique";

                }
            }
            Console.ReadLine();
        }
    }
}