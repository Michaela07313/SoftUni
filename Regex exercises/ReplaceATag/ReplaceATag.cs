using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class ReplaceATag
    {
        public static void Main()
        {


           var inputFile = Console.ReadLine().Trim();

            //string pattern = @"(<a)(.*?)(>)(.*?)(<\/a>)";
              string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
              string replace = @"[URL href=$1]$2[/URL]";
              string result = "";

            while(inputFile != "end")
            {
                result += Regex.Replace(inputFile, pattern, replace);
                inputFile = Console.ReadLine();
            }

            Console.Write(result);



        }
    }
}
