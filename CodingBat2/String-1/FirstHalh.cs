using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given a string of even length, return the first half.So the string "WooHoo" yields "Woo".

    // For Example
    //firstHalf("WooHoo") → "Woo"
    //firstHalf("HelloThere") → "Hello"
    //firstHalf("abcdef") → "abc"
    public class FirstHalh
    {
        public static string firstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
        public static void Main(string[]args)
        {
            Console.WriteLine(firstHalf("WooHoo"));
            Console.WriteLine(firstHalf("hi"));
        }
    }
}
