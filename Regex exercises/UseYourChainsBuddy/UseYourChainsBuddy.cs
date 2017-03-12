using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        public static void Main()
        {
            var inputData = Console.ReadLine();

            string pattern = @"<p>(.[^\/]+)<\/p>";
            string regex = @"[^a-z0-9]+";

            Regex words = new Regex(pattern);
            MatchCollection matches = words.Matches(inputData);
            string encrypted = "";
            for (int i = 0; i < matches.Count; i++)
            {
                string temp = matches[i].Groups[1].Value;
                encrypted += Regex.Replace(temp, regex, word => " ");
            }


            string result = "";
            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] >= 'a' && encrypted[i] <= 'm')
                {
                    result += (char)(encrypted[i] + 13);
                }
                else if (encrypted[i] >= 'n' && encrypted[i] <= 'z')
                {
                    result += (char)(encrypted[i] - 13);
                }
                else if (Char.IsDigit(encrypted[i]) || Char.IsWhiteSpace(encrypted[i]))
                {
                    result += encrypted[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
