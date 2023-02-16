using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            Dictionary<int,int> dic = new Dictionary<int,int>();

            for (int i = 0; i < n; i++)
            {
                int number=int.Parse(Console.ReadLine());
                
                if (!dic.ContainsKey(number))
                {
                     dic.Add(number, 0);
                }

                dic[number]++;
            }

            foreach (var item in dic)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
