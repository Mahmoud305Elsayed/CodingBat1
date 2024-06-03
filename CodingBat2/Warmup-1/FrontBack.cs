using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Given a string, return a new string where the first and last chars have been exchanged.
 
    frontBack("code") → "eodc"
    frontBack("a") → "a"
    frontBack("ab") → "ba"
 */
namespace CodingBat2.Warmup_1
{
    public class FrontBack
    {
        public String frontBack(String str)
        {
            if (str.Length > 1)
            {
                str = str[str.Length - 1] +
                    str.Substring(1, str.Length - 2) +
                    str[0];
                return str;
            }
            else
            {
                return str;
            }

        }
        public static void Main11(string[] arg)
        {
            FrontBack frontBack = new FrontBack();
            Console.WriteLine(   frontBack.frontBack("code"));
            Console.WriteLine(  frontBack.frontBack("a"));
            Console.WriteLine(   frontBack.frontBack("ab"));
       }
    }
}
