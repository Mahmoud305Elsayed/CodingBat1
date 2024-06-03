using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    /*
     * Given a string, 
     * return a new string made of 3 copies of the last 2 chars of the original string. 
     * The string length will be at least 2.

    extraEnd("Hello") → "lololo"
    extraEnd("ab") → "ababab"
    extraEnd("Hi") → "HiHiHi"
     */
    public class ExtraEnd
    {
        public string extraEnd(string a)
        {
            if (a.Length > 2)
            {
                string result = a.Substring(a.Length - 2);
                return result + result + result;
            }
            else
            {
                return a + a + a;
            }
        }
        public static void Main5(string[] ar)
        {
            ExtraEnd extraEnd = new();
            Console.WriteLine(extraEnd.extraEnd("Mahmoud"));
            Console.WriteLine(extraEnd.extraEnd("ab"));
            Console.WriteLine(extraEnd.extraEnd("Hi"));
        }
    }
}
