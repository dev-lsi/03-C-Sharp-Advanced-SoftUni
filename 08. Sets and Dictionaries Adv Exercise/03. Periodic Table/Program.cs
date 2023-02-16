using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in input)
                {
                   set.Add(item);
                }
            }

                set = set.OrderBy(x => x).ToHashSet();
                
            Console.WriteLine(string.Join(" ",set));
        }
    }
}
