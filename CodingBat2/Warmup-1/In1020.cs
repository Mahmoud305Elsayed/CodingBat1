using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        Given 2 int values, 
        return true if either of them is in the range 10..20 inclusive.

        in1020(12, 99) → true
        in1020(21, 12) → true
        in1020(8, 99) → false
 */
namespace CodingBat2.Warmup_1
{
    public class In1020
    {
        public bool in1020(int a, int b)
        {
            if((a>=10 && a <= 20) || ( b>=10 && b <= 20))
            {
                return true;
            }else return false;
        }
        public static void Main18(string[] ar)
        {
            In1020  in1020 = new In1020();
            Console.WriteLine(in1020.in1020(10,20));//true
            Console.WriteLine(in1020.in1020(10,19));//true
            Console.WriteLine(in1020.in1020(11,19));//true
            Console.WriteLine(in1020.in1020(9, 190));//false
            Console.WriteLine(in1020.in1020(9, 21));//false
            Console.WriteLine(in1020.in1020(9, 0));//false
        }
    }
}
