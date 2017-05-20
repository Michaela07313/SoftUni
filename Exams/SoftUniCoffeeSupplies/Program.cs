using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        public static void Main()
        {
            var delimiters = Console.ReadLine().Split();
            List<CoffeeDrinker> people = new List<CoffeeDrinker>();
            List<Coffee> coffees = new List<Coffee>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end of info")
                {
                    break;
                }

                if (inputLine.Contains(delimiters[0]))
                {
                    var personalInfo = inputLine.Split(new string[] { delimiters[0] }, StringSplitOptions.RemoveEmptyEntries);
                    var name = personalInfo[0];
                    var coffeeType = personalInfo[1];

                    CoffeeDrinker currentCoffeeDrinker = new CoffeeDrinker()
                    {
                        Name = name,
                        CoffeeType = new Coffee { Name = coffeeType }
                    };

                    if (!coffees.Any(x => x.Name == currentCoffeeDrinker.CoffeeType.Name))
                    {
                        coffees.Add(new Coffee { Name = coffeeType });
                    }

                    people.Add(currentCoffeeDrinker);

                }
                else if (inputLine.Contains(delimiters[1]))
                {
                    var coffeeInfo = inputLine.Split(new string[] { delimiters[1] }, StringSplitOptions.RemoveEmptyEntries);
                    var coffeeType = coffeeInfo[0];
                    var quantity = int.Parse(coffeeInfo[1]);

                    Coffee currentCoffee = new Coffee()
                    {
                        Name = coffeeType,
                        Quantity = quantity
                    };

                    if(coffees.Any(x => x.Name == coffeeType))
                    {
                        int index = coffees.FindIndex(x => x.Name == coffeeType);
                        coffees[index].Quantity += currentCoffee.Quantity;
                    }
                    else
                    {
                        coffees.Add(currentCoffee);
                    }
                }
            }

            foreach (var cofe in coffees.Where(x => x.Quantity <= 0))
            {
                Console.WriteLine($"Out of {cofe.Name}");
            }


            while (true)
            {
                var inputLine2 = Console.ReadLine();

                if (inputLine2 == "end of week")
                {
                    break;
                }

                var personCoffeeInfo = inputLine2.Split();
                var name = personCoffeeInfo[0];
                var coffeeCount = int.Parse(personCoffeeInfo[1]);

                int matchPersonName = people.FindIndex(x => x.Name == name);
                string matchCoffeeName = people[matchPersonName].CoffeeType.Name;
                int matchCoffee = coffees.FindIndex(x => x.Name == matchCoffeeName);
                coffees[matchCoffee].Quantity -= coffeeCount;

                if (coffees[matchCoffee].Quantity <= 0)
                {
                    Console.WriteLine($"Out of {matchCoffeeName}");  
                }  
            }

            var sortedCoffees = coffees.Where(x => x.Quantity > 0)
                .OrderByDescending(x => x.Quantity);

            List<string> coffeeNames = new List<string>();

            Console.WriteLine("Coffee Left:");
            foreach (var cafe in sortedCoffees)
            {
                Console.WriteLine($"{cafe.Name} {cafe.Quantity}");
                coffeeNames.Add(cafe.Name);
            }

            var finalPeople = new List<CoffeeDrinker>();

            foreach (var item in coffeeNames)
            {
                foreach (var person in people)
                {
                    if(person.CoffeeType.Name == item)
                    {
                        finalPeople.Add(person);
                    }
                }
            }

            var sortedPeople = finalPeople
                .OrderBy(x => x.CoffeeType.Name)
                .ThenByDescending(x => x.Name);

            Console.WriteLine("For:");
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.CoffeeType.Name}");
            }
        }
    }
}
