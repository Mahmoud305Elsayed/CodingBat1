using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        Given two temperatures, 
        return true if one is less than 0 and the other is greater than 100.

        icyHot(120, -1) → true
        icyHot(-1, 120) → true
        icyHot(2, 120) → false
 */
namespace CodingBat2.Warmup_1
{
    public class IcyHot
    {
        public bool icyHot(int temp1, int temp2)
        {
            if((temp1<0 && temp2>100) || (temp1>100 && temp2 < 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main17(string[] ar)
        {
            IcyHot icyHot = new IcyHot();
            Console.WriteLine(icyHot.icyHot(120,-1));//true
            Console.WriteLine(icyHot.icyHot(-1,120));//true
            Console.WriteLine(icyHot.icyHot(2, 120));//false
            Console.WriteLine(icyHot.icyHot(-5,99));//false
        }
    }
}
