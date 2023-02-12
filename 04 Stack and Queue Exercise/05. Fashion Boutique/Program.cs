using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cloths = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int currCapacity = capacity;
            Stack<int> stack = new Stack<int>();
            int counter = 0;

            foreach (var cloth in cloths)
            {
                stack.Push(cloth);
            }

            
            while (stack.Count>0)
            {
                counter++;
                currCapacity = capacity;

                while (currCapacity>0 && stack.Count>0)
                {
                    int next=stack.Peek();
                    
                    if(currCapacity>=next)
                    {
                       stack.Pop();
                       currCapacity -=next;

                    }
                    else
                    {
                        
                        break;
                    }
                }

            }
            
            
            Console.WriteLine(counter);
        }
    }
}
