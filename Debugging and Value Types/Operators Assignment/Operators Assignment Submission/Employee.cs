using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee Employee1, Employee Employee2)
        {
            string IDmatch = "The Id's of the two Employee's match";
            return true;
        }

        public static bool operator !=(Employee Employee1, Employee Employee2)
        {
            string IDmatch = "The Id's of the two Employee's do not match";
            return false;
        }
    }
}
