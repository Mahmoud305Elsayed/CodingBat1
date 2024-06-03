using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.Warmup_1
{
    /*
     Return true if the given string contains between 1 and 3 'e' chars.

        stringE("Hello") → true
        stringE("Heelle") → true
        stringE("Heelele") → false
     */
    public class StringE
    {
        public bool stringE(String str)
        {
        int count = 0;
           
            if (str.Contains('e'))
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if(str[i] == 'e')
                    {
                        count++;
                        if(count > 3)
                        {
                            return false;
                        }
                    }

                }
                return true;
            }return false;
        }
        public static void Main28(string[] args)
        {
            StringE stringE = new();
            Console.WriteLine(stringE.stringE("Hello"));  //true
            Console.WriteLine(stringE.stringE("Heelle")); //true
            Console.WriteLine(stringE.stringE("Heelele"));//false
            Console.WriteLine(stringE.stringE("Mahmoud"));//false
        }
        
    }
}
