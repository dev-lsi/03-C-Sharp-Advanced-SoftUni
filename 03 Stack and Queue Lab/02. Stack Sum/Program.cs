using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split();

                if (command[0]=="end")
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    return;
                }
                else 
                {
                    if (command[0]=="add")
                    {
                        stack.Push(int.Parse(command[1]));
                        stack.Push(int.Parse(command[2]));

                    }
                    else //command=="remove
                    {
                        int count=stack.Count();
                        if (count < int.Parse(command[1]))
                        {
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                    }
                }

            }
        }
    }
}

