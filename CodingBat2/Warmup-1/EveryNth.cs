using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     Given a non-empty string and an int N, 
      return the string made starting with char 0, 
      and then every Nth char of the string. So if N is 3, 
      use char 0, 3, 6, ... and so on. N is 1 or more.

        everyNth("Miracle", 2) → "Mrce"
        everyNth("abcdefg", 2) → "aceg"
        everyNth("abcdefg", 3) → "adg"
     */
    public class EveryNth
    {
        public string everyNth(String str, int n)
        {
        string result = "";
            for(int i=0; i<str.Length; i +=n)
            {
                result += str[i];
            }
            return result;
        }
        public static void Main31(string[] arg)
        {
            EveryNth everyNth = new();
            Console.WriteLine(everyNth.everyNth("Miracle", 2));  //"Mrce"
            Console.WriteLine(everyNth.everyNth("abcdefg", 2));  //"aceg"
            Console.WriteLine(everyNth.everyNth("abcdefg", 3));  //"adg"
            Console.WriteLine(everyNth.everyNth("mahmoud",2));   //mhod
        }

    }
}
