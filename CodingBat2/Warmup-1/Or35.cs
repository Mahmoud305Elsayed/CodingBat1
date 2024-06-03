using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Return true if the given non-negative number is a multiple of 3 or a multiple of 5. 
     Use the % "mod" operator -- see Introduction to Mod

        or35(3) → true
        or35(10) → true
        or35(8) → false
 */
namespace CodingBat2.Warmup_1
{
    public class Or35
    {
        public bool or35(int n)
        {
            if (n > 0 &&(n % 3 == 0 || n % 5 == 0))
            {
                    return true;
            }
           
                return false;
        }
        public static void Main14(string[] arg)
        {
            Or35 or35 = new Or35();
            Console.WriteLine(or35.or35(3));  //true
            Console.WriteLine(or35.or35(10)); //true
            Console.WriteLine(or35.or35(8));  //false
            Console.WriteLine(or35.or35(0));  //false
            Console.WriteLine(or35.or35(-5)); //false
        }

    }
}
