using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class ValidUsernames
    {
        public static void Main()
        {
            var inputData = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

           
            string pattern = @"^[A-Za-z][a-zA-Z0-9_]{2,24}$";
            var regex = new Regex(pattern);
            bool containsValidData = false;
            bool containsValidDataSecond = false;
            int countValidNames = 0;
            int validNamesLength = 0;
            int longestNamesLength = 0;
            var resultList = new List<string>();
            var tempList = new List<string>();

            var copyList = inputData.ToList();
            
            foreach (var item in copyList)
            {
                containsValidData = regex.IsMatch(item);
                if (containsValidData)
                {
                    tempList.Add(item);
                }
                containsValidData = false;
            }


            for (int i = 0; i < tempList.Count; i++)
            {
                containsValidData = regex.IsMatch(tempList[i]);
                if (i + 1 < tempList.Count) containsValidDataSecond = regex.IsMatch(tempList[i + 1]);
                else containsValidDataSecond = false;

                if (containsValidData && containsValidDataSecond)
                {
                    countValidNames += 2;
                    validNamesLength = tempList[i].Count() + tempList[i + 1].Count();

                    if (validNamesLength > longestNamesLength)
                    {
                        longestNamesLength = validNamesLength;
                        resultList.Clear();
                        resultList.Add(tempList[i]);
                        resultList.Add(tempList[i + 1]);
                    }
                 }
                containsValidData = false;
                containsValidDataSecond = false;
            }

            Console.WriteLine(string.Join(Environment.NewLine, resultList));
        }
    }
}
