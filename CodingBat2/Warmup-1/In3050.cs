using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
   /* 
        Given 2 int values, 
       return true if they are both in the range 30..40 inclusive, 
       or they are both in the range 40..50 inclusive.

        in3050(30, 31) → true
        in3050(30, 41) → false
        in3050(40, 50) → true*/
    public class In3050
    {
        public bool in3050(int a, int b)
        {
            
            if ((   (40>=a) && (a>=30) && (b<=40) && (b>=30)  ) || ( (a>=40)&&(a<=50) && (b<= 50)&&(b>=40) ))
            {
                return true;
            }
            else { return false; }
        }
        public static void Main26(string[] arg)
        {
            In3050 in3050 = new();
            Console.WriteLine( in3050.in3050(30,31)); //true
            Console.WriteLine( in3050.in3050(30,41)); //false
            Console.WriteLine( in3050.in3050(40,50)); //true
            Console.WriteLine( in3050.in3050(31,44)); //false
            Console.WriteLine( in3050.in3050(31,41)); //false
        }
    }
}
