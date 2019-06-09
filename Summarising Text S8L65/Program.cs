using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text_S8L65
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a realy realy realy realy reay wajdawj woidjoaw oiajwd long text";
            var summary = StringUtility.SummerizeText(sentence,25);
            Console.WriteLine(summary);
                    
        }

    }
}
