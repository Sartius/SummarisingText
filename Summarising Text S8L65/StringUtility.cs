using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text_S8L65
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxlength = 20)
        {
            if (text.Length < maxlength)
                return text;
            else
            {
                // sentence.Substring(0, maxlength) bad implement
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summarywords = new List<string>();

                foreach (var word in words)
                {
                    summarywords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxlength)
                        break;
                }

                return String.Join(" ", summarywords) + "...";

            }
        }
    }
}
