using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Youve encountered Grozni the Brigand and the launches a surprise attack.");
            Console.WriteLine("Input your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
            Console.WriteLine("Your healer, Serra is near by. SHe heals you with her staff.");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.Heal(magic);
            Console.WriteLine("you have been healed for " + hitpoints + " HP.");
            Console.WriteLine("Now its your turn to attack, inpur your strength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strength);
            Console.WriteLine("You have landed a critical attakc and dealt " + damage + " HP worth of damage.");
            Console.ReadLine();
        }
    }
}