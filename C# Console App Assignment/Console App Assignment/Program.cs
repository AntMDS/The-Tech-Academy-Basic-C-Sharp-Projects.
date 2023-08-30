using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] names = { "ben", "jeff", "steve", "harvey", "dave", "bob", "gwen", "rammus", "tristana" };
            Console.WriteLine("please write and adjective for a person you like, eg: handsome.");
            string stringAdjective = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                string[] namesUpdated = { names[i] + " is " + stringAdjective };

                for (int j = 0; j < namesUpdated.Length; j++)
                {
                    Console.WriteLine(namesUpdated[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
