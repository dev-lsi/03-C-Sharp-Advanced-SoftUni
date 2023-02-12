using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            Stack<char> stack = new Stack<char>();
            
            foreach (var item in chars)
            {
                stack.Push(item);
            }
            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
