using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
        Given a string, 
        return a new string where "not " has been added to the front. 
        However, if the string already begins with "not", 
        return the string unchanged. 
        Note: use .equals() to compare 2 strings.

        notString("candy") → "not candy"
        notString("x") → "not x"
        notString("not bad") → "not bad"
     */
    public class notString
    {
        public static string NotString(string str)
        {
            if(str.Length >=3 && str.Substring(0,3) == "not")
            {
                return str;
            }
            else
            {
                return $"not {str}";
            }
        }
        public static void Main9(string[] args)
        {
            Console.WriteLine(NotString("candy")); // "not candy"
            Console.WriteLine(NotString("x")); //"not x"
            Console.WriteLine(NotString("not bad")); // "not bad"

        }
    }
}
