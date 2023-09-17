using Method_Class_Assignment;
using System;

namespace Method_Class_Assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods mathOp = new MathMethods(); //initates the class
            Console.WriteLine("please enter in two numbers to add together: "); //asks the user to input two numbers to add together
            Console.WriteLine("please enter in number one:"); //asks the user to input the first number
            int firstNumber = Convert.ToInt32(Console.ReadLine()); //sets the first number as an INT variable
            Console.WriteLine("please enter in the second number:"); //asks the user to input the second number
            int secondNumber = Convert.ToInt32(Console.ReadLine()); //sets the second number as an INT variable
            int results; //sets an emoty int as results
            mathOp.Addition(firstNumber, secondNumber, out results); //executes the class equation with our two paramaters and outputs the value as results
            Console.WriteLine(firstNumber + secondNumber + " added together give" + results); //prints out what the two numbers will add up too
            Console.ReadLine(); //gives the user enough time to read everything 
        }
    }
}