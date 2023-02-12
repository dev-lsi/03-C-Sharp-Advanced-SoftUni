using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] QueDeqX = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(ints);
            if (QueDeqX[1] >= queue.Count ) 
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                for (int i = 0; i < QueDeqX[1]; i++)
                {
                    queue.Dequeue();
                }
            }


            if (queue.Contains(QueDeqX[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }



        }
    }
}
