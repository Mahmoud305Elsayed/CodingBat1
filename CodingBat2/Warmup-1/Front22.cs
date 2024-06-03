using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Given a string, take the first 2 chars and return the string with the 2 chars added at both the front and back, 
        so "kitten" yields"kikittenki". 
        If the string length is less than 2, 
        use whatever chars are there.

        front22("kitten") → "kikittenki"
        front22("Ha") → "HaHaHa"
        front22("abc") → "ababcab"
 */
namespace CodingBat2.Warmup_1
{
    public class Front22
    {
        public string front22(string str)
        {
            if (str.Length > 1)
            {
                return str = str.Substring(0, 2) + str + str.Substring(0, 2);
            }
            else if (str.Length == 1)
                return str + str + str;
            else
                return str;
        }
        public static void Main15(string[] ar)
        {
            Front22 front22 = new Front22();
            Console.WriteLine(front22.front22("Mahmoud"));//MaMahmoudMa
            Console.WriteLine(front22.front22("Ali"));    //AlAliAl 
            Console.WriteLine(front22.front22("Hi"));     //HiHiHi
            Console.WriteLine(front22.front22("H"));      //H
            Console.WriteLine(front22.front22(""));       //
        }
    }
}
