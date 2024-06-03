using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
         Given 2 int values, return true if one or the other is teen, 
         but not both.

        loneTeen(13, 99) → true
        loneTeen(21, 19) → true
        loneTeen(13, 13) → false
 */
namespace CodingBat2.Warmup_1
{
    public class LoneTeen
    {
        public bool loneTeen(int a, int b)
        {
            if ((a >= 13 && a <= 19) && (b >= 13 && b <= 19))
            {
                return false;
            }
            else if ((a >= 13 && a <= 19) || (b >= 13 && b <= 19))
            {
                return true;
            }
            else return false;
        }
        public static void Main20(string[] ar)
        {
            LoneTeen loneTeen = new LoneTeen();
            Console.WriteLine(loneTeen.loneTeen(13, 99));//true
            Console.WriteLine(loneTeen.loneTeen(21, 19));//true
            Console.WriteLine(loneTeen.loneTeen(13, 13));//false
            Console.WriteLine(loneTeen.loneTeen(9, 190));//false
            Console.WriteLine(loneTeen.loneTeen(9, 21));//false
            Console.WriteLine(loneTeen.loneTeen(9, 0));//false
        }
    }
}
