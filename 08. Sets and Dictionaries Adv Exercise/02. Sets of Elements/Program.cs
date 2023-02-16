using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts=Console
                .ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int n = counts[0];
            int m = counts[1];
            
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();


            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            
            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            set1.Intersect(set2);
            Console.WriteLine(string.Join(" ",set1));

        }
    }
}
