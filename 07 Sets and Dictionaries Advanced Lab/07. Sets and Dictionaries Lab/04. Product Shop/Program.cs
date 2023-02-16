using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopProducts =
                new SortedDictionary<string, Dictionary<string, double>>();

            
            while (true) 
            {
                string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

                if (input[0] == "Revision")
                {
                    break;
                }

                string shop= input[0];
                string product = input[1];
                double price = double.Parse(input[2]);
                
                if (!shopProducts.ContainsKey(shop))
                {
                 shopProducts.Add(shop,new Dictionary<string, double>()); 
                }

                if (shopProducts[shop].ContainsKey(product))
                {
                    shopProducts[shop][product] = price;
                }
                else
                {
                    shopProducts[shop].Add(product, price);
                }
            }

            foreach (var shop in shopProducts)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");

                }

            }


        }
    }
}
