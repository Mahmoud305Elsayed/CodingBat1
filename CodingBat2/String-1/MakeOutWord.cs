using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    /*Given an "out" string length 4, 
     * such as "<<>>", 
     * and a word, 
     * return a new string where the word is in the middle of the out string, e.g. "<<word>>". Note: use str.substring(i, j) to extract the String starting at index i and going up to but not including index j.

    makeOutWord("<<>>", "Yay") → "<<Yay>>"
    makeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"
    makeOutWord("[[]]", "word") → "[[word]]"*/
    public class MakeOutWord
    {
        public string makeOutWord(string ot, string word)
        {

            return ot.Substring(0, 2) + word + ot.Substring(2);
        }
        public static void Main35(string[] ar)
        {
            MakeOutWord word = new();
            Console.WriteLine(word.makeOutWord("<<>>","Mah"));
            Console.WriteLine(word.makeOutWord("<<>>", "WooHoo"));
        }
    }
}
