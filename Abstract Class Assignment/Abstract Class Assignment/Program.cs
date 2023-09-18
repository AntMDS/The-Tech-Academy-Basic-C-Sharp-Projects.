using Abstract_Class_Assignment;
using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of an employee object
            Employee sam = new Employee() { FirstName = "Sam", LastName = " Park" };
            //call sayname method
            sam.SayName();
            Console.ReadLine();
        }
    }
}