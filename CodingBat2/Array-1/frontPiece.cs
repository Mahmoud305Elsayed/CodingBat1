

using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace CodingBat2.Array_1
{

    //Given an int array of any length, 
    //return a new array of its first 2 elements.If the array is smaller than length 2, 
    //use whatever elements are present.


    //frontPiece([1, 2, 3]) → [1, 2]
    //frontPiece([1, 2]) → [1, 2]
    //frontPiece([1]) → [1]

    public class frontPiece
    {
        public static int[] frontPieceFun(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return Array.Empty<int>();  // ✅ clean, no unnecessary allocations

            if (nums.Length == 1)
                return new[] { nums[0] };

            return new[] { nums[0], nums[1] };
        }

        public static void Main2(string[] args)
        {
            Console.WriteLine(string.Join(",", frontPieceFun([5, 2, 6, 1])));
            Console.WriteLine(string.Join(",", frontPieceFun([5, 0])));
            Console.WriteLine(string.Join(",", frontPieceFun([1])));
            Console.WriteLine(string.Join(",", frontPieceFun([])));
        }
    }
}
