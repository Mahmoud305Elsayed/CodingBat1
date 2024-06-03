using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
        We have two monkeys, a and b, 
        and the parameters aSmile and bSmile indicate if each is smiling. 
        We are in trouble if they are both smiling or if neither of them is smiling. 
        Return true if we are in trouble.

        monkeyTrouble(true, true) → true
        monkeyTrouble(false, false) → true
        monkeyTrouble(true, false) → false
     */
    public class monkeyTrouble
    {
        public static bool MonkeyTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile != bSmile)
            {
                return false;
            }
            else
                return true;
        }
        public static void Main2(string[] args)
        {
            Console.WriteLine( MonkeyTrouble(true, true)   );//trus
            Console.WriteLine( MonkeyTrouble(false, false)  );//true
            Console.WriteLine( MonkeyTrouble(true, false) );//false
            Console.WriteLine( MonkeyTrouble(false, true));//false
        }

    }
}
