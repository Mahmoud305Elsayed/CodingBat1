﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     Given 2 ints, a and b, return true if one if them is 10 or if their sum is 10.

        makes10(9, 10) → true
        makes10(9, 9) → false
        makes10(1, 9) → true
     */
    public class makes10
    {
        public static bool Makes10(int a, int b)
        {
            if(a ==10 || b == 10)
            {
                return true;
            }
            else if((a+b) == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void Main6(string [] ar)
        {
            Console.WriteLine(Makes10(9, 10));
            Console.WriteLine(Makes10(9, 9) );
            Console.WriteLine(Makes10(1, 9) );
        }
    }
}
