using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Given a string, take the last char and return a new string with the last char added at the front and back, 
     so "cat" yields "tcatt". 
     The original string will be length 1 or more.

        backAround("cat") → "tcatt"
        backAround("Hello") → "oHelloo"
        backAround("a") → "aaa"
 */
namespace CodingBat2.Warmup_1
{
    public class BackAround
    {
        public String backAround(String str)
        {
            if (str.Length >= 1)
            {
                char ch = str[str.Length - 1];
                return ch + str + ch ;
            }
            else
            {
                return str;
            }
        }
        public static void Main13(string[] arg)
        {
            BackAround backAround = new BackAround();
            Console.WriteLine(backAround.backAround("cat"));
            Console.WriteLine(backAround.backAround("Hello"));
            Console.WriteLine(backAround.backAround("a"));
            Console.WriteLine(backAround.backAround(""));
        }
    }
}
