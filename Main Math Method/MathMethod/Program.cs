using MathMethod;
using System;
using System.Net.NetworkInformation;

namespace MainMethodsAssignment
{
    class program
    {
        static void main(string[] args)
        {
            MathMethods math1 = new MathMethods2();
            Console.WriteLine(math1.MathOp(7));
            Console.WriteLine(math1.MathOp(7.3m));
            Console.WriteLine(math1.MathOp("7"));
        }
    }
}
