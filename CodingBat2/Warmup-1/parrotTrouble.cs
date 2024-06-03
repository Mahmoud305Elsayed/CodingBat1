using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
        /*
         We have a loud talking parrot. 
        The "hour" parameter is the current hour time in the range 0..23. 
        We are in trouble if the parrot is talking and the hour is before 7 or after 20. 
        Return true if we are in trouble.

        parrotTrouble(true, 6) → true
        parrotTrouble(true, 7) → false
        parrotTrouble(false, 6) → false
         */

    public class parrotTrouble
    {
        public static bool ParrotTrouble(bool talking, int hour)
        {
            if (talking)
            {
                if(hour>=7 && hour <= 20)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }else
                return false;

        }
        public static void Main5(string[] args)
        {
            Console.WriteLine(ParrotTrouble(true, 6)  );//true
            Console.WriteLine(ParrotTrouble(true, 7)  );//false
            Console.WriteLine(ParrotTrouble(false, 6) );//false
            Console.WriteLine(ParrotTrouble(true,20 ));
            Console.WriteLine(ParrotTrouble(true, 20));
        }
    }
}
