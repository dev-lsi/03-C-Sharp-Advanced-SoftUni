using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity=int.Parse(Console.ReadLine());

            int[] input=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders= new Queue<int>(input);

            Console.WriteLine($"{orders.Max()}");

            while( quantity > 0 && orders.Count>0) 
            {
                
                int currentOrder = orders.Peek();
                
                if (quantity >= currentOrder)
                {
                   orders.Dequeue();
                    quantity -= currentOrder;
                }
                else
                {
                    break;
                }
            }

            if (orders.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            Console.WriteLine($"Orders left: {string.Join(" ", orders)}");


        }
    }
}
