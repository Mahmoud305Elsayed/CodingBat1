
namespace CodingBat2.Array_1
{

    //Given an array of ints of odd length, 
    //look at the first, last, and middle values in the array and 
    //return the largest.The array length will be a least 1.


    //maxTriple([1, 2, 3]) → 3
    //maxTriple([1, 5, 3]) → 5
    //maxTriple([5, 2, 3]) → 5

    public class maxTriple
    {

        public static int maxTriplefun(int[] nums)
        {
            int first = nums[0];
            int middle = nums[nums.Length / 2];
            int last = nums[nums.Length - 1];

            return Math.Max(first, Math.Max(middle, last));
        }

        public static void Main1(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(maxTriplefun([5, 2, 1, 3, 4, 8, 0]));
            Console.WriteLine(maxTriplefun([5, 2]));
            Console.WriteLine(maxTriplefun([5]));
        }

    }
}
