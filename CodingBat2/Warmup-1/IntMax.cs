﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*Given three int values, a b c, return the largest.

       intMax(1, 2, 3) → 3
       intMax(1, 3, 2) → 3
       intMax(3, 2, 1) → 3
       */
    public class IntMax
    {
        public int intMax(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            // Now check between max and c
            if (c > max)
            {
                max = c;
            }

            return max;
        }
        public static void Main24(string[] ard)
        {
            IntMax intMax = new();
            intMax.intMax(3, 2, 1);
        }
    }
}
