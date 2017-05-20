using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SpyGram
{
    class Program
    {
        public static void Main()
        {

            var regexMessage = new Regex(@"^TO:\s([A-Z]+);\sMESSAGE:\s(.+);$");
            var key = Console.ReadLine();
            char[] numArray = key.ToCharArray();
            Dictionary<string, List<string>> allMessages = new Dictionary<string, List<string>>();

            while (true)
            {
                var inputMessage = Console.ReadLine();

                if (inputMessage == "END")
                {
                    break;
                }

                var matchMessage = regexMessage.Match(inputMessage);
                if (matchMessage.Success)
                {
                    var name = matchMessage.Groups[1].Value;

                    if (!allMessages.ContainsKey(name))
                    {
                        allMessages.Add(name, new List<string>());
                    }

                    StringBuilder resultString = new StringBuilder();

                    int numIndex = 0;

                    for (int j = 0; j < inputMessage.Length; j++)
                    {
                        int newChar = (int)inputMessage[j] + (int)Char.GetNumericValue(numArray[numIndex]);
                        char ch = Convert.ToChar(newChar);
                        resultString.Append(ch);
                        numIndex++;

                        if (numIndex == numArray.Length)
                        {
                            numIndex = 0;
                        }  
                    }

                    String encryptedMessage = resultString.ToString();
                    allMessages[name].Add(encryptedMessage);
                    
                }
            }

            foreach (var item in allMessages.OrderBy(x => x.Key))
            {
                foreach (var msg in item.Value)
                {
                    Console.WriteLine(msg);
                }

                
            }
        }
    }
}
