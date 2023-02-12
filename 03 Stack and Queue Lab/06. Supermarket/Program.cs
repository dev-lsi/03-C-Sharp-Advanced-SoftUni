using System;
using System.Collections.Generic;
using System.Drawing;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input=Console.ReadLine();
                

                if (input == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    return;
                }
                else if (input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                }
                else 
                {
                 queue.Enqueue(input);
                }


            }
        }
    }
}
