using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     Given a string, return a string made of the first 2 chars (if present), 
    however include first char only if it is 'o' and include the second only if it is 'z', 
    so "ozymandias" yields "oz".

        startOz("ozymandias") → "oz"
        startOz("bzoo") → "z"
        startOz("oxx") → "o"
     */
    public class startOz
    {
        public string StartOz(string str)
        {
            if (str.Length > 2)
            {
                if (str.Substring(0, 2) == "oz")
                {
                    return "oz";
                }
                else if (str.Substring(0, 1) == "o")
                {
                    return "o";
                }
                else if (str.Substring(1, 1) == "z")
                {
                    return "z";
                }
            }
            return str;
        }
        public static void Main23(string[] ars)
        {
            startOz startOz = new();
            Console.WriteLine(startOz.StartOz("ozymandias"));// → "oz"
            Console.WriteLine(startOz.StartOz("bzoo")); // → "z"
            Console.WriteLine(startOz.StartOz("oxx")); //→ "o"
        }
    }
}
