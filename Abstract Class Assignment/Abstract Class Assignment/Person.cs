using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        //abstract class called person with two string properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //give it the method sayname().
        public abstract void SayName();
    }
}
