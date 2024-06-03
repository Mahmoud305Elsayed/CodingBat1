using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     Given two non-negative int values, 
     return true if they have the same last digit, 
     such as with 27 and 57. Note that the % "mod" operator computes remainders, 
     so 17 % 10 is 7.

        lastDigit(7, 17) → true
        lastDigit(6, 17) → false
        lastDigit(3, 113) → true
     */
    public class LastDigit
    {
        public bool lastDigit(int a, int b)
        {
            if((a%10) == (b % 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main29(string[] arg)
        {
            LastDigit lastDigit = new();
            Console.WriteLine(lastDigit.lastDigit(27,57));//true
            Console.WriteLine(lastDigit.lastDigit(7,117));//true
            Console.WriteLine(lastDigit.lastDigit(275,5));//true
            Console.WriteLine(lastDigit.lastDigit(2,21));//false
        }
    }
}
