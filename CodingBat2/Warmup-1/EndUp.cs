using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /* Question -- 30
     Given a string, 
      return a new string where the last 3 chars are now in upper case. 
      If the string has less than 3 chars, uppercase whatever is there. 
      Note that str.toUpperCase() returns the uppercase version of a string.

        endUp("Hello") → "HeLLO"
        endUp("hi there") → "hi thERE"
        endUp("hi there") → "HI"
     */
    public class EndUp
    {
        public string endUp(String str)
        {
            if (str.Length > 3)
            {
                return str.Substring(0,str.Length-3)+str.Substring(str.Length - 3).ToUpper();
            }
            else return str.ToUpper();
        }
        public static void Main30(string[] args)
        {
            EndUp endUp = new();
            Console.WriteLine(endUp.endUp("Hello")); //heLLO
            Console.WriteLine(endUp.endUp("hi there"));//hi thERE
            Console.WriteLine(endUp.endUp("hi"));//HI
            Console.WriteLine(endUp.endUp("Ali"));//ALI
        }
    }
}
