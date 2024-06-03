using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     * Given an int n, 
     * return the absolute difference between n and 21, 
     * except return double the absolute difference if n is over 21.

        diff21(19) → 2
        diff21(10) → 11
        diff21(21) → 0
     */
    public class diff21
    {
        public static int differ21(int a)
        {
            if(a<= 21)
            {
                return (21 - a);
            }
            else
            {
                return (a - 21) * 2;
            }
        }
        public static void Main4(string[] a)
        {
            Console.WriteLine( differ21(19));//3
            Console.WriteLine( differ21(10));//12
            Console.WriteLine( differ21(21));//0
            Console.WriteLine( differ21(-5));//26
            Console.WriteLine( differ21(0)); //21
            Console.WriteLine( differ21(30));//18
        }
    }
}
