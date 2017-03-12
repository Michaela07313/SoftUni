using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var matchWord = Console.ReadLine();
            var inputText = Console.ReadLine().Trim().Split(new[] { '!', '?', '.' }).ToArray();

            string pattern = "\\b" + matchWord + "\\b";

            var regex = new Regex(pattern);
            bool containsValidDate = false;

            foreach (var item in inputText)
            {
                containsValidDate = regex.IsMatch(item);
                if(containsValidDate)
                {
                    Console.WriteLine(item.Trim());
                }
            }

        }
    }
}
