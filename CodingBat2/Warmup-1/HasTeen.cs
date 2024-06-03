using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
         We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
         Given 3 int values, return true if 1 or more of them are teen.

         hasTeen(13, 20, 10) → true
         hasTeen(20, 19, 10) → true
         hasTeen(20, 10, 13) → true
 */
namespace CodingBat2.Warmup_1
{
    public class HasTeen
    {
        public bool hasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a <= 20 ) || (b >= 13 && b <= 20) || (c >= 13 && c<=20))
            {
                return true;
            }
            else return false;
        }
        public static void Main19(string[] ar)
        {
            HasTeen hasTeen = new HasTeen();
            Console.WriteLine(hasTeen.hasTeen(10,10,  20));//true
            Console.WriteLine(hasTeen.hasTeen(10,10,  19));//true
            Console.WriteLine(hasTeen.hasTeen(11,10,  19));//true
            Console.WriteLine(hasTeen.hasTeen(9, 10, 190));//false
            Console.WriteLine(hasTeen.hasTeen(9, 10, 21));//false
            Console.WriteLine(hasTeen.hasTeen(9, 10, 0));//false
        }
    }
}
