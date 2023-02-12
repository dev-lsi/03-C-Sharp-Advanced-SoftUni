using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Stack<int> OpenBracketIndexes = new Stack<int>();
            int counter = -1;

            foreach (var item in input)
            {    
                counter++;

                if (item=='(')
                {
                    OpenBracketIndexes.Push(counter);
                }
                else if(item==')')
                {
                    int start= OpenBracketIndexes.Pop();
                    int end = counter;
                    
                    for (int i = start; i <= end; i++)
                    {
                        Console.Write(input[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

