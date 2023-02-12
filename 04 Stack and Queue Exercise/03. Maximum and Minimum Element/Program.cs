using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.

            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int query = input[0];
                if (query == 1)
                {
                    stack.Push(input[1]);
                }
                else if (query == 2)
                {
                    stack.Pop();
                }
                else if (query == 3)
                {

                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    { continue; }
                }
                else if (query == 4)
                {

                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    { continue; }
                }


            }

            Console.WriteLine(string.Join(", ", stack));

        }
    }
}

