
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodingBat2.Array_1
{
    public class make2
    {

        //Given 2 int arrays, a and b, 
        //return a new array length 2 containing, 
        //as much as will fit, the elements from a followed by the elements from b.
        //The arrays may be any length, including 0, 
        //but there will be 2 or more elements available between the 2 arrays.


        //make2([4, 5], [1, 2, 3]) → [4, 5]
        //make2([4], [1, 2, 3]) → [4, 1]
        //make2([], [1, 2]) → [1, 2]


        public static int[] make2Fun(int[] a, int[] b)
        {
            int[] result = new int[2];
            int index = 0;

            for (int i = 0; i < a.Length && index < 2; i++)
            {
                result[index++] = a[i];
            }

            for (int i = 0; i < b.Length && index < 2; i++)
            {
                result[index++] = b[i];
            }

            return result;

        }

        public static void Main4(string[] args)
        {
            Console.WriteLine(System.String.Join(",", make2Fun(new int[] { 1, 3, 5 }, new int[] { 6, 9, 7 })));
            Console.WriteLine(System.String.Join(",", make2Fun(new int[] { 1 }, new int[] { 6, 9, 7 })));
            Console.WriteLine(System.String.Join(",", make2Fun(new int[] { }, new int[] { 6, 9, 7 })));
            Console.WriteLine(System.String.Join(",", make2Fun(new int[] { }, new int[] { 6 })));
            Console.WriteLine(System.String.Join(",", make2Fun(new int[] { }, new int[] { })));
        }
    }
}
