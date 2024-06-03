using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given a string, return the string made of its first two chars,
    //so the String "Hello" yields "He". If the string is shorter than length 2, return whatever there is, so "X" yields "X", and the empty string "" yields the empty string "".
    //Note that str.length() returns the length of a string.

    // For Example -> 

    //firstTwo("Hello") → "He"
    //firstTwo("abcdefg") → "ab"
    //firstTwo("ab") → "ab"
    public class FirstTwo
    {
        public static string firstTwo(string str)
        {
            if (str.Length > 2)
            {
                return str.Substring(0, 2);
            }
            else
                return str;
        }
        public static void Main6(string []args)
        {
            Console.WriteLine(firstTwo("Hello"));
            Console.WriteLine(firstTwo("assdfg"));
            Console.WriteLine(firstTwo("as"));
            Console.WriteLine(firstTwo("a"));
            Console.WriteLine(firstTwo(""));
        }
    }
}
