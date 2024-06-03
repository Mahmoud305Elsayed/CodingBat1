using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
        Given a non-empty string and an int n, 
        return a new string where the char at index n has been removed. 
        The value of n will be a valid index of a char in the original string 
        (i.e. n will be in the range 0..str.length()-1 inclusive).

        missingChar("kitten", 1) → "ktten"
        missingChar("kitten", 0) → "itten"
        missingChar("kitten", 4) → "kittn"
     */
    public class missingChar
    {
        public static string MissingChar(string str, int n)
        {
            string front = str.Substring(0, n);
            string back = str.Substring(n+1, str.Length);
            return front + back;   
        }

        public static void Main10(string[] args)
        {
        
        }
    }
}
