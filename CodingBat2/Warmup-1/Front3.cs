using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  
    Given a string, we'll say that the front is the first 3 chars of the string. 
    If the string length is less than 3, 
    the front is whatever is there. 
    Return a new string which is 3 copies of the front.

    front3("Java") → "JavJavJav"
    front3("Chocolate") → "ChoChoCho"
    front3("abc") → "abcabcabc" 
 */
namespace CodingBat2.Warmup_1
{
    public class Front3
    {
        public String front3(String str)
        {
            if (str.Length > 2)
            {
                str = str.Substring(0, 3);
                return str + str + str;
            }
            else
            {
                return str + str + str;
            }
        }
        public static void Main12(string[] arg)
        {
            Front3 front3 = new Front3();
            Console.WriteLine(front3.front3("Java"));
            Console.WriteLine(front3.front3("Mahmoud"));
            Console.WriteLine(front3.front3("JavaScript"));
            Console.WriteLine(front3.front3("Jav"));
            Console.WriteLine(front3.front3("A"));
            Console.WriteLine(front3.front3("Hi"));
        }

    }
}
