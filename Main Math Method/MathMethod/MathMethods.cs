using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod
{
    public class MathMethods
    {
        public int MathOp(int number)
        {
            return number + 7;
        }

        public int MathOp(decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }

        public int MathOp(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}
