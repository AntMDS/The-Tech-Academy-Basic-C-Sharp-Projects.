using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates two Employee objects
            Employee employee1 = new Employee(1, "steven", "wok");
            Employee employee2 = new Employee(2, "curtis", "dan");

            //Compares the two Employee objects using overloaded operators
            bool areEqual = employee1 == employee2;
            bool areNotEqual = employee1 != employee2;

            //Displays the results
            Console.WriteLine($"is employee1 and employee2 equal? {areEqual}");
            Console.WriteLine($"is employee1 and employee2 not equal? {areNotEqual}");
        }
    }
}