using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = rowValues[col];
                }
            }

            int sum = 0;
            int maxSum = 0;
            int mrow=0;
            int mcol=0;
            int[,] maxMatrix = new int[3, 3];
            int[,] currMatrix= new int[3, 3];

            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    int[,] subMatrix= new int[3, 3];
                    int srow = 0;
                    int scol = 0;
                    for (int i = row; i <= row+2; i++)
                    {
                        scol= 0;
                        for (int j = col; j <= col+2; j++)
                        {
                            sum = sum + matrix[i, j];
                            subMatrix[srow,scol] = matrix[i,j];
                            scol++;
                        }
                        srow++;

                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxMatrix = subMatrix;
                    }
                    sum = 0;

                }

            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < 3; row++)
            {
                int[] line= new int[3];
                for (int col = 0; col < 3; col++)
                {
                    line[col] = maxMatrix[row,col];
                }
                Console.WriteLine(string.Join(" ",line));
                
            }
            
        }

    }
}
