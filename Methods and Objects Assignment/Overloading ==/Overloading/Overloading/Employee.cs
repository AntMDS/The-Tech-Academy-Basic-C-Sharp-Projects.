using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Employee
    {
        //employee properties
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //Overloads the "==" operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                return true;
            }
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }
            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
}
