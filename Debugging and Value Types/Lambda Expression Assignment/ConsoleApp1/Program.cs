using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a list of 10 employee's
            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee() {Id  = 1, FirstName = "Peter", LastName = "Fred" },
                new Employee() {Id  = 2, FirstName = "Sam", LastName = "Steven" },
                new Employee() {Id  = 3, FirstName = "David", LastName = "Pitcher" },
                new Employee() {Id  = 4, FirstName = "Peter", LastName = "Barkley" },
                new Employee() {Id  = 5, FirstName = "Evan", LastName = "Schmo" },
                new Employee() {Id  = 6, FirstName = "Peter", LastName = "Thomas" },
                new Employee() {Id  = 7, FirstName = "Paul", LastName = "Title" },
                new Employee() {Id  = 8, FirstName = "Andrew", LastName = "Schmo" },
                new Employee() {Id  = 9, FirstName = "Tate", LastName = "Title" },
                new Employee() {Id  = 10, FirstName = "Nat", LastName = "Fred" },
            };
            //Uses a foreach loop to create a new list with all the employees that share the first name Peter
            List<Employee> Peter = new List<Employee>();
            foreach (Employee employee in EmployeeList)
            {
                if (employee.FirstName == "Peter")
                {
                    Peter.Add(employee);
                }
            }
            //Does the same thing as the for each loop but with a lambda expression
            List<Employee> Peter2 = EmployeeList.Where(x => x.FirstName == "Peter").ToList();
            //using lambda expression makes a list of amm employees with an ID higher then 5
            List<Employee> BigId = EmployeeList.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}