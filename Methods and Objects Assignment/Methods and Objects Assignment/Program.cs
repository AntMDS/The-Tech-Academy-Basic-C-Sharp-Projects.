using Methods_and_Objects_Assignment;
using System;

namespace MethodsAndOBjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { FirstName = "Sam", LastName = "Park" };
            sam.SayName();
            Console.ReadLine();
        }
    }
}