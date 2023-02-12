using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            List<string> list = new List<string>();
            int counter = 0;

            while (true) 
            {
                string input = Console.ReadLine();
                
                if (input == "end")
                {
                    Console.WriteLine($"{counter} cars passed the crossroads.");
                    return;
                }
                else if(input=="green")
                {
                    int passes = 0;
                     
                    if (queue.Count >= n)
                    {
                        passes = n;
                    }
                    else
                    {
                        passes = queue.Count;
                    }
                    for (int i = 0; i < passes; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                    continue;
                }
                else
                {
                   queue.Enqueue(input);
                }
            }

            
        }
    }
}
