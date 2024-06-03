using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    /*The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. 
     * In this example, the "i" tag makes <i> and </i> which surround the word "Yay". 
     * Given tag and word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>".

    makeTags("i", "Yay") → "<i>Yay</i>"
    makeTags("i", "Hello") → "<i>Hello</i>"
    makeTags("cite", "Yay") → "<cite>Yay</cite>"*/
    public class MakeTags
    {
        public string makeTags(string tag, string word)
        {
            return $"<{tag}>{word}</{tag}>";
        }
        public static void Main34(string[] arg)
        {
            MakeTags makeTags = new MakeTags();
            Console.WriteLine(makeTags.makeTags("i","Work"));
            Console.WriteLine(makeTags.makeTags("br","Work"));
            Console.WriteLine(makeTags.makeTags("p","Pincile"));
        }
    }
}
