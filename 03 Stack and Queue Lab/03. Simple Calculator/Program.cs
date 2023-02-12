using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Stack<string> stack = new Stack<string>();
            int sum = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                int curr = int.Parse(stack.Pop());
                string oper = stack.Pop();
                int next = int.Parse(stack.Pop());
                if (oper == "+")
                {
                    curr += next;
                }
                if (oper == "-")
                {
                    curr -= next;
                }
                stack.Push(curr.ToString());

            }
            Console.WriteLine(stack.Pop());
        }
    }
}
