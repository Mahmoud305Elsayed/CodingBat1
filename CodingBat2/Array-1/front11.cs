
namespace CodingBat2.Array_1
{
    public class front11
    {
        public static int[] front11Fun(int[] a, int[] b)
        {
            var result = new List<int>();

            if (a.Length > 0)
                result.Add(a[0]);

            if (b.Length > 0)
                result.Add(b[0]);

            return result.ToArray();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", front11Fun(new int[] { 1, 2, 3 }, new int[] { 7, 9, 8 }))); // [1,7]
            Console.WriteLine(string.Join(",", front11Fun(new int[] { 1 }, new int[] { 2 })));             // [1,2]
            Console.WriteLine(string.Join(",", front11Fun(new int[] { 1, 7 }, new int[] { })));            // [1]
            Console.WriteLine(string.Join(",", front11Fun(new int[] {  }, new int[] { })));            // [1]

        }
    }
}
