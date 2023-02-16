using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text=Console.ReadLine().ToCharArray();

            Dictionary<char,int> dict=new Dictionary<char,int>();

            foreach (var ch in text)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }
                dict[ch]++; 
            }
            
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key,y => y.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
