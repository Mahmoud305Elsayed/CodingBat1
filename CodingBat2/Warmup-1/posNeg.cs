using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{

    public class posNeg
    {
        /*
            Given 2 int values, 
            return true if one is negative and one is positive. 
            Except if the parameter "negative" is true, 
            then return true only if both are negative.

            posNeg(1, -1, false) → true
            posNeg(-1, 1, false) → true
            posNeg(-4, -5, true) → true
        */
        public static bool PosNeg(int num1, int num2, bool negative)
        {
            if (num1 < 0 && num2 < 0 && negative == true)
                return true;
            if ((num1 * num2) < 0 && negative == false)
            {
                return true;
            }
            else return false;
          
        }
        public static void Main8(string[] args)
        {
            Console.WriteLine(PosNeg(1, -1, false)); // true
            Console.WriteLine(PosNeg(-1, 1, false)); // true
            Console.WriteLine(PosNeg(-4, -5, true)); // true

        }
    }
}
