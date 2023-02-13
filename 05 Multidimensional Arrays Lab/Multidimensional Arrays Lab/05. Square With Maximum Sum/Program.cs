using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reading dimensions data from the console
            int[] dimensions=Console
                .ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();
            
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix= new int[rows,cols];

            // reading the matrix values from the console
            for (int row = 0; row < rows; row++)
            {
                int[] colValues = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = colValues[col];
                }
            
            }

            // finding the top left max sum of 2x2 square
            int sum = 0;
            int maxSum = 0;
            int[,] m = new int[2,2];
            
            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    sum =     matrix[row - 1, col - 1] +  matrix[row - 1, col]+
                              matrix[row, col - 1]     +  matrix[row, col];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        m[0, 0] = matrix[row - 1, col - 1];
                        m[0, 1] = matrix[row - 1, col];
                        m[1, 0] = matrix[row, col - 1];
                        m[1,1] = matrix[row, col];
                    }
                    sum = 0;
                }

            }

            //printing the matrix and the sum result
            
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{m[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        
        }

    }
}
