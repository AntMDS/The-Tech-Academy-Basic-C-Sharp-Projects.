using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    //creates an abstract class called Person
    public abstract class Person
    {
        //sets two empty strings that can be fetched and set
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Gives it the method SayName()
        public abstract void SayName();
    }
}
