using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat.Warmup_1
{
    /*
     * The parameter weekday is true if it is a weekday, 
     * and the parameter vacation is true if we are on vacation. 
     * We sleep in if it is not a weekday or we're on vacation.
     * Return true if we sleep in.

            sleepIn(false, false) → true
            sleepIn(true, false) → false
            sleepIn(false, true) → true
     */
    public class SleepIn
    {
        public static bool sleepIn(bool weekday, bool vacation)
        {
            if (vacation == true || weekday == false)
            {
                return true;
            }
            else
                return false;
        }
        public static void Main1(string[] args)
        {
            Console.WriteLine(sleepIn(false, false));
            Console.WriteLine(sleepIn(true, false));
            Console.WriteLine(sleepIn(false, true));
            Console.WriteLine(sleepIn(true, true));
        }
    }
}
