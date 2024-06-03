using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*Given two int values, 
     * return their sum. 
     * Unless the two values are the same, 
     * then return double their sum.

        sumDouble(1, 2) → 3
        sumDouble(3, 2) → 5
        sumDouble(2, 2) → 8*/
    public class sumDouble
    {
        public static int sumDoublee(int a, int b)
        {
            if(a != b)
            {
                return a+b;
            }
            else
            {
                return (a+b)*2;
            }
        }
        public static void Main3(string[] args)
        {
            Console.WriteLine(sumDoublee(1, 2) );//3
            Console.WriteLine(sumDoublee(3, 2) );//5
            Console.WriteLine(sumDoublee(2, 2)); //8
            Console.WriteLine(sumDoublee(0, 0)); //0
            Console.WriteLine(sumDoublee(-1, -1));//-4
        }
    }
}
