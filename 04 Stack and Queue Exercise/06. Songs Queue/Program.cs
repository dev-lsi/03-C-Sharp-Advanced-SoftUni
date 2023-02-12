using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(", ");
            Queue<string> queue=new Queue<string>(input);

            while (queue.Count>0)
            {
                string[] command=Console.ReadLine().Split(" ",2);

                if (command[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
                else if (command[0]=="Add")
                {
                    string adding = command[1];
                    if (queue.Contains(adding))
                    {
                        Console.WriteLine($"{adding} is already contained!");
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(adding);  
                    }

                }

            }

            Console.WriteLine("No more songs!");
        }
    }
}
