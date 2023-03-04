using System;
using System.Threading.Tasks;

namespace MyCalc
{
    public class Calc
    {
        public static int calc(int a, int b, int c)
        {
            return ((a + b) / c);
        }

        public static int calc1(int a, int b)
        {
            return a % b;
        }
    }
}
