using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside.The strings will not be the same length, but they may be empty (length 0).

    // For Example ...

    //comboString("Hello", "hi") → "hiHellohi"
    //comboString("hi", "Hello") → "hiHellohi"
    //comboString("aaa", "b") → "baaab
    public class ComboString
    {
        public static string comboString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2 + str1 + str2;
            }else
                return str1 + str2 + str1;

        }
        public static void Main9(string[] args)
        {
            Console.WriteLine(comboString("hi","Hello"));
            Console.WriteLine(comboString("hi Mahmoud","Hello"));
            Console.WriteLine(comboString("hi",""));
            Console.WriteLine(comboString("",".Net"));
        }
    }
}
