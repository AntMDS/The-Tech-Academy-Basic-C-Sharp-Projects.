using System;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++;
            }
            while (count < 5);

            int counting = 0;
            while (counting < 3)
            {
                Console.WriteLine("Counting numbers");
                counting++;
            }
            Console.ReadLine();
        }
    }
}
