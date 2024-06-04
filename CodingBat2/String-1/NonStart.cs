using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    //Given 2 strings, return their concatenation, except omit the first char of each.The strings will be at least length 1.

    // For Example ...

    //nonStart("Hello", "There") → "ellohere"
    //nonStart("java", "code") → "avaode"
    //nonStart("shotl", "java") → "hotlava"
    public class NonStart
    {
        public static string nonStart(string a, string b)
        {
            return a.Substring(1) + b.Substring(1);
        }
        public static void Main10(string[] args)
        {
            Console.WriteLine(nonStart("java", "DotNet"));
            Console.WriteLine(nonStart("long", "short"));
            Console.WriteLine(nonStart("java", "DotNet"));
        }
    }
}
