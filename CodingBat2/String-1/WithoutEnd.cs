using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given a string, return a version without the first and last char, so "Hello" yields "ell". The string length will be at least 2.

    // For Example ...

    //withoutEnd("Hello") → "ell"
    //withoutEnd("java") → "av"
    //withoutEnd("coding") → "odin"
    public class WithoutEnd
    {
        public static string withoutEnd(string str)
        {
            if (str.Length > 1)
            {
                return str.Substring(1, str.Length - 2);
            }
            else
                return str;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(withoutEnd("Hello"));
            Console.WriteLine(withoutEnd("Mahmoud"));
            Console.WriteLine(withoutEnd("Ma"));
            Console.WriteLine(withoutEnd("M"));
            Console.WriteLine(withoutEnd(""));
        }
    }
}
