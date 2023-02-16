using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{color} -> {item1},{item2},{item3}…
            int n=int.Parse(Console.ReadLine());
            
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();
            
            

            for (int i = 0; i < n; i++)
            {
            
                string[] input = Console.ReadLine().Split(" -> ");
                
                    string color = input[0];
                    string[] clothes = input[1]
                        .Split("," , StringSplitOptions.RemoveEmptyEntries);

                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }

                    foreach (var cloth in clothes)
                    {
                        if (!wardrobe[color].ContainsKey(cloth))
                        {
                            wardrobe[color].Add(cloth, 1);
                        }
                        else
                        {
                            wardrobe[color][cloth]++;
                        }
                    }
                   
                
            }

            string[] search=Console.ReadLine().Split(" ");

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    //* dress - 1 (found!)
                    if (item.Key == search[1] && color.Key == search[0])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {

                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }

                }

            }
        }
    }
}
