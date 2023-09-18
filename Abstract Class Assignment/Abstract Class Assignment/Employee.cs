using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    internal class Employee : Person
    {
        //create a class called Employee that inherits the person class
        public int Id { get; set; }
        //implement the sayName() method inside of the employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
