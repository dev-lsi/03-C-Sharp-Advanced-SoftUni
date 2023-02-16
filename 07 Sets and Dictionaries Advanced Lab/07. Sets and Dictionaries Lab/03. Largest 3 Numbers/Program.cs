using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers=Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            numbers=numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine($"{string.Join(" ", numbers.Take(3))}");
        }
    }
}
