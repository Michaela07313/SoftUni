using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();

            while(true)
            {
                var inputLine = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                if(inputLine[0] == "quit")
                {
                    break;
                }

                var countryName = inputLine[0];
                var spyName = inputLine[1];
                var daysInService = long.Parse(inputLine[2]);

                if(!dict.ContainsKey(countryName))
                {
                    dict[countryName] = new Dictionary<string, long>();
                    dict[countryName].Add(spyName, daysInService);
                }
                else
                {
                    if (!dict[countryName].ContainsKey(spyName))
                    {
                        dict[countryName].Add(spyName, daysInService);
                    }
                    else
                    {
                        dict[countryName][spyName] = daysInService;
                        
                    }
                }
            }

            var sortedCountries = dict
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var country in sortedCountries)
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key.Trim()} : {spy.Value}");
                }

            }



        }


    }
}
