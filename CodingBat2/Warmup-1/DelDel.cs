using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
          Given a string, 
          if the string "del" appears starting at index 1, 
          return a string where that "del" has been deleted. Otherwise, 
          return the string unchanged.

        delDel("adelbc") → "abc"
        delDel("adelHello") → "aHello"
        delDel("adedbc") → "adedbc"
 */
namespace CodingBat2.Warmup_1
{
    public class DelDel
    {
        public String delDel(String str)
        {
            if (str.Length > 3 && str.Substring(1, 3).Equals("del")  )
            {
                return str.Remove(1, 3);
            }
            else return str;
        }
        public static void Main21(string[] ar)
        {
            DelDel delDel = new DelDel();
            Console.WriteLine(delDel.delDel("adelbc")); //abc
            Console.WriteLine(delDel.delDel("adlbc")); //adlbc
            Console.WriteLine(delDel.delDel("adeelbc")); // aadeelbc
            Console.WriteLine(delDel.delDel("ade")); // ade
        }
    }
}
