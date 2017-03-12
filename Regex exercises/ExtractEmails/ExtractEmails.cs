using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        public static void Main()
        {
            string inputData = Console.ReadLine();

            string pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            var regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(inputData, pattern);

            foreach (Match match in matches)
            {
                string checker = match.ToString();
                if (!(checker.StartsWith(".")
                    || checker.StartsWith("-")
                    || checker.StartsWith("_")
                    || checker.EndsWith(".")
                    || checker.EndsWith("-")
                    || checker.EndsWith("_")))
                {
                    Console.WriteLine(checker);
                }

            }
        }
    }
}
