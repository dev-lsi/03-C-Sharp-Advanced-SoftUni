using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] PushPopX=Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int[] ints=Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Stack<int> stack = new Stack<int>(ints);
            
            for (int i = 0; i < PushPopX[1]; i++)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
                stack.Pop();
            }
            
            if(stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            
            if (stack.Contains(PushPopX[2])) 
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
            }
        }
    }
}
