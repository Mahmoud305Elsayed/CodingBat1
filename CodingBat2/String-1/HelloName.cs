using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    /*
     
     Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!".

    helloName("Bob") → "Hello Bob!"
    helloName("Alice") → "Hello Alice!"
    helloName("X") → "Hello X!"
     */
    public class HelloName
    {
        public string helloName(string name)
        {
            return $"Hello {name}!";
        }
        public static void Main32(string[] args)
        {
            HelloName helloName = new HelloName();
            Console.WriteLine(helloName.helloName("Bob"));
            Console.WriteLine(helloName.helloName("Alice"));
            Console.WriteLine(helloName.helloName("X"));
        }

    }
}
