using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
         Given 2 positive int values, 
         return the larger value that is in the range 10..20 inclusive, 
         or return 0 if neither is in that range.

         max1020(11, 19) → 19
         max1020(19, 11) → 19
         max1020(11, 9) → 11
     */
    public class Max1020
    {
        public int max1020(int a, int b)
        {
            if(a > b && a>=10 && a<=20)
            {
                return a;
            }
            else if(b > a && b>=10 && b <= 20 && a >= 10 && a <= 20)
            {
                return b;
            }
            else return 0;
        }
        public static void Main27(string[] args)
        {
            Max1020 max1020 = new();
            Console.WriteLine(max1020.max1020(11, 19));//19
            Console.WriteLine(max1020.max1020(19, 11));//19
            Console.WriteLine(max1020.max1020(11, 9));//11
            Console.WriteLine(max1020.max1020(10, 9));//10
            Console.WriteLine(max1020.max1020(1, 9));//0
            Console.WriteLine(max1020.max1020(1, 20));//20
        }
    }
}
