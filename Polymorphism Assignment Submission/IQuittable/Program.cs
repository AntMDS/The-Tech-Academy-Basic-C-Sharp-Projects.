using System;

namespace IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymopgh the Iquittable instanec into an employee object and instantiate it
            IQuittable Employed = new Employee();
            //instantiate an employe object
            Employee Sam = new Employee()
            {
                FirstName = "Sam",
                LastName = "Peter"
            };
            //call the Sayname method
            Sam.SayName();
            //call the quit method
            Employed.Quit();
            Console.ReadLine();
        }
    }
}