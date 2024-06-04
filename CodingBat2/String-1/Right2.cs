using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.The string length will be at least 2.

    // For Example ...

    //right2("Hello") → "loHel"
    //right2("java") → "vaja"
    //right2("Hi") → "Hi"
    public class Right2
    {
        public static string right2(string str)
        {

            if (str.Length > 1)
                return str.Substring(str.Length-2) + str.Substring(0, str.Length-2);
            else

                return str;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(right2("Mahmoud"));
            Console.WriteLine(right2("DotNet"));
            Console.WriteLine(right2("JavaJs"));
            Console.WriteLine(right2("R"));
        }
    }
}
