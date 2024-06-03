using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
        Given an int n, 
        return true if it is within 10 of 100 or 200. 
        Note: Math.abs(num) computes the absolute value of a number.

        nearHundred(93) → true
        nearHundred(90) → true
        nearHundred(89) → false
     */
    public class nearHundred
    {
        public static bool NearHundred(int n)
        {
            if ((n >= 90 && n <= 110) || (n >= 190 && n <= 210))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
        public static void Main7(string[] arg)
        {
            Console.WriteLine(NearHundred(89)); //false
            Console.WriteLine(NearHundred(90)); //true
            Console.WriteLine(NearHundred(100));//true
            Console.WriteLine(NearHundred(110));//true
            Console.WriteLine(NearHundred(111));//false
            Console.WriteLine(NearHundred(189));//false
            Console.WriteLine(NearHundred(190));//true
            Console.WriteLine(NearHundred(200));//true
            Console.WriteLine(NearHundred(210));//true
            Console.WriteLine(NearHundred(211));//false
        }
    }
}
