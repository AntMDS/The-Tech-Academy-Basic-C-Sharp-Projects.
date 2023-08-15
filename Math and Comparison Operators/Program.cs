using System;

namespace Math_and_Comparison_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //prints out "Anonymous Income Comparison Program"
            Console.WriteLine("Person 1"); //prints out person 1 
            int person1HrlyRt = 15; //sets the hourly rate of person 1 as an interger
            int person1HrsWrkd = 10; //sets the hours worked of person 1 as an interger
            int person1salary = Convert.ToInt32(person1HrlyRt) * Convert.ToInt32(person1HrsWrkd) * 52; //multiplies hourly rate by hourly work of person 1 and then by 52 to get ge the annual salary and then set it as an interger
            Console.WriteLine("Hourtly rate?\n" + person1HrlyRt); //prints out the hourly rate of person 1 

            Console.WriteLine("Person 2"); //prints out person 2
            int person2HrlyRt = 20; //sets the hourly rate of person 2 as an interger
            int person2HrsWrkd = 6; //sets the hours worked of person 2 as an interger
            int person2salary = Convert.ToInt32(person2HrlyRt) * Convert.ToInt32(person2HrsWrkd) * 52; //multiplies hourly rate by hourly work of person 2 and then by 52 to get ge the annual salary and then set it as an interger
            Console.WriteLine("Hourtly rate?\n" + person2HrlyRt); //prints out the hourly rate of person 2

            Console.WriteLine("Annual salary of person1");
            Console.WriteLine(person1salary); //prints out the annual salary of person 1
            Console.WriteLine("Annual salary of person2");
            Console.WriteLine(person2salary); //prints out the annual salary of person 2
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool isMore = person1salary > person2salary; //checks if the annual salary of person 1 is greater then the annual salary of person 2 and then sets results in a bool
            Console.WriteLine(isMore); //prints out the results of the bool being true or false
            Console.ReadLine();
        }
    }
}
