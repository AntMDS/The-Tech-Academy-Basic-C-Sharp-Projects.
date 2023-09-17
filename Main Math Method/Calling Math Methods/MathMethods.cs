using System;

public class MathMethods
{
    public class MathMethod
    {
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }

        public static int Defense(int defense)
        {
            int enemy_str = 7;
            int weapong_mt = 11;
            int triangle_bonuse = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapong_mt + triangle_bonuse) - defense) * crit_coeff;
        }

        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }


    }
}
