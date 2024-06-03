using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     Given 2 int values, 
    return whichever value is nearest to the value 10, 
    or return 0 in the event of a tie. 
    Note that Math.abs(n) returns the absolute value of a number.

        close10(8, 13) → 8
        close10(13, 8) → 8
        close10(13, 7) → 0
     */
    public class Close10
    {
        public int close10(int a, int b)
        {
            int rA = Math.Abs(10 - a);
            int rB = Math.Abs(10 - b);
             if(rA >rB) return b;
            else if (rA< rB) return a;
             else return 0;
        }
        public static void Main25(string[] argd)
        {
            Close10 close10 = new();
            
            Console.WriteLine(close10.close10(5,15) );
            Console.WriteLine(close10.close10(8, 13) ) ;
            Console.WriteLine(close10.close10(13, 8) );
            Console.WriteLine(close10.close10(13, 7) );
        }
    }
}
