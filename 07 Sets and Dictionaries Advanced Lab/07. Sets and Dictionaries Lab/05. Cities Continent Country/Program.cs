using System;
using System.Collections.Generic;

namespace _05._Cities_Continent_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Europe Bulgaria Sofia

            int n=int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();
            // Calculations
            for (int i = 0; i < n; i++)
            {
                string[] input= Console.ReadLine().Split(" ");
                string continent= input[0];
                string country= input[1];
                string city= input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country,new List<string>());
                }

                continents[continent][country].Add(city);

                //if (!continents[continent][country].Contains(city))
                //{
                //    continents[continent][country].Add(city);
                //}

            }

            // Output

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> ");
                    
                    Console.Write($"{string.Join(", ",country.Value)}");

                    Console.WriteLine();
                    
                }
                
            }
        }
    }
}
