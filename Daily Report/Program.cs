﻿using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of learning career college");
            Console.WriteLine("Student Daily report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help? please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you have?");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. an instructor will respond soon!");
            Console.ReadLine();
        }
    }
}