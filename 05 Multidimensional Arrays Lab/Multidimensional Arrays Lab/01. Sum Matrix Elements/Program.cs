using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }

            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;
            foreach (var item in matrix)
            {
                sum=sum+item;
            }

            Console.WriteLine(sum);
        }
    }
}
