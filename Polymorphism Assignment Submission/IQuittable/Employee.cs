using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    //creates a Employee class that inherits the Person class and the Iquitable interfac.
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //empliments the SayName method in the employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        //Empliments the Quit method in the employee class
        public void Quit()
        {
            Console.WriteLine("this employee quit");
        }

    }
}
