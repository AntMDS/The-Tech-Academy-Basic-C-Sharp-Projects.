using Constructor_Assignment;
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a const variable
            const string nameQuestion = "Your name is: ";
            const string favNumberQuestion = "Your favourite number is: ";
            Console.WriteLine("Enter your name of favourite number: ");
            //creates a variable using the var keyword
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(favNumberQuestion);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(nameQuestion);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}