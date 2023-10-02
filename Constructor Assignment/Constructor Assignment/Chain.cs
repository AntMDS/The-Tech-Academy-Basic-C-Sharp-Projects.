﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Chain
    {
        public Chain(float num1) : this(num1, "Fred")
        {
            Console.WriteLine(num1 + " and your default name is " + Name);
        }

        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and your default favourite number is " + Num);
        }

        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }

        string Name { get; set; }
        float Num { get; set; }

    }
}
