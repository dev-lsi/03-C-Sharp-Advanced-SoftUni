using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split();
            int moves=int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(players);
            int counter = 1;

            while (queue.Count > 1) 
            {
                if (counter < moves)
                {
                    counter++;
                    queue.Enqueue(queue.Dequeue());
                }
                else
                {
                    
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    counter= 1;
                    
                }
              
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");


        }
    }
}
