using System;
using System.Collections.Generic;

namespace Test_Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2==0)
                {
                    stack.Push(i);
                }

            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
