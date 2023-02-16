﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _01.Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input=Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            Dictionary<double,int> dict = new Dictionary<double,int>();

            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
            
        }
    }
}
