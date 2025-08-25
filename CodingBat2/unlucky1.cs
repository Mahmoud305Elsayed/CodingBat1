namespace CodingBat2
{
    public class unlucky1
    {
        public static bool unlucky1Fun(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return false;

            // Check first two or first three positions
            if ((nums[0] == 1 && nums[1] == 3) ||
                (nums.Length > 2 && nums[1] == 1 && nums[2] == 3))
            {
                return true;
            }

            // Check last two positions
            int last = nums.Length - 1;
            if (nums[last - 1] == 1 && nums[last] == 3)
            {
                return true;
            }

            return false;

        }

        public static void Main3(string[] args)
        {
            Console.WriteLine(unlucky1Fun(new int[] { 2, 1, 3, 4, 5 })); // true
            Console.WriteLine(unlucky1Fun(new int[] { 1, 2, 3 }));       // false
            Console.WriteLine(unlucky1Fun(new int[] { 1, 3, 4, 5 }));    // true
            Console.WriteLine(unlucky1Fun(new int[] { 2, 3, 1 }));       // false
            Console.WriteLine(unlucky1Fun(new int[] { }));
        }

    }
}
