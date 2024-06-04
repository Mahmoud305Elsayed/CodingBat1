﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end.The string length will be at least 2.

    // For Example ...

    //left2("Hello") → "lloHe"
    //left2("java") → "vaja"
    //left2("Hi") → "Hi"
    public class Left2
    {
        public static string left2(string str)
        {
            if (str.Length > 1)
                return str.Substring(2) + str.Substring(0, 2);
            else
                return str;
        }
        public static void Main11(string[] args)
        {
            Console.WriteLine(left2("Mahmoud"));
            Console.WriteLine(left2("DotNet"));
            Console.WriteLine(left2("JavaJs"));
            Console.WriteLine(left2("R"));
        }
    }
}
