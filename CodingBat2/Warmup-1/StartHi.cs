using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Given a string, return true if the string starts with "hi" and false otherwise.

    startHi("hi there") → true
    startHi("hi") → true
    startHi("hello hi") → false
 */
namespace CodingBat2.Warmup_1
{
    public class StartHi
    {
        public bool startHi(String str)
        {
            if(str.Length > 1)
            {
                if(str.Substring(0,2) == "hi")
                    return true;
            }
                return false;
        }
        public static void Main16(string[] rg)
        {
            StartHi startHi = new StartHi();
            Console.WriteLine(startHi.startHi("hi there"));// true
            Console.WriteLine(startHi.startHi("hi"));// true
            Console.WriteLine(startHi.startHi("Hello hi"));// false
            Console.WriteLine(startHi.startHi("Hello "));// false
            Console.WriteLine(startHi.startHi(""));// false
        }
    }
}
