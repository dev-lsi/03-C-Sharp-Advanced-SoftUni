using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(arr);
            List<int> list = new List<int>();

            while (queue.Count > 0)
            {
                int curr = queue.Dequeue();

                if (curr % 2 == 0)
                {
                    list.Add(curr);
                }
            }

            Console.WriteLine(string.Join(", ",list));
        }
    }
}

