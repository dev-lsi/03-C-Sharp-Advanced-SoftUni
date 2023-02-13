using System;

namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            char[,] matrix=new char[n,n];

            for (int row = 0; row < n; row++)
            {
                string rowChars=Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowChars[col];
                }
            }

            string input = Console.ReadLine();
            char symbol = input[0];
            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col] == symbol && isFound == false)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
