using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2
{
    /*
     Return true if the given string begins with "mix", 
     except the 'm' can be anything, so "pix", "9ix" .. all count.

        mixStart("mix snacks") → true
        mixStart("pix snacks") → true
        mixStart("piz snacks") → false
     */
    public class mixStart
    {
        public bool MixStart(string str)
        {
            if (str.Length > 3)
            {
                if ((str.Substring(1, 2) == "ix"))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        public static void Main22(string[] args)
        {
            mixStart mixStart = new mixStart();
            Console.WriteLine();
           Console.WriteLine( mixStart.MixStart("mix snacks"));// → true
           Console.WriteLine( mixStart.MixStart("pix snacks"));// → true
           Console.WriteLine( mixStart.MixStart("piz snacks"));// → false
           Console.WriteLine( mixStart.MixStart("pi"));// → false
           Console.WriteLine( mixStart.MixStart("p"));// → false
           Console.WriteLine( mixStart.MixStart("mi"));// → false
        }
    }
}
