using System;
using System.Linq;

namespace _05a._Custom_SubMatrix_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensions of the main matrix");
            
            Console.WriteLine("number of rows:");
            int rows=int.Parse(Console.ReadLine());
            
            Console.WriteLine("number of cols:");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine("Dimensions of the sub matrix");
            
            Console.WriteLine("number of rows:");
            int subRows = int.Parse(Console.ReadLine());

            Console.WriteLine("number of cols:");
            int subCols = int.Parse(Console.ReadLine());

            if (subCols > cols||subRows > rows)
            {
                Console.WriteLine("invalid parameters for the sub matrix");
                return;
            }

            int[,] matrix = new int[cols, rows];

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine($"row {row} values ({cols})numbers:");
                int[] rowValues=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int sum = 0;
            int maxSum = 0;
            int[,] maxSubMatrix= new int[subRows, subCols];
            int[,] subMatrix = new int[subRows, subCols];



            for (int row = 0; row < rows-subRows; row++)
            {
                for (int col = 0; col < cols-subCols; col++)
                {
                    for (int srow = row; srow < row+subRows; srow++)
                    {
                        for (int scol = col; scol < col+subCols; scol++)
                        {
                            sum = sum + matrix[srow, scol];
                        }

                    }

                    if (sum>maxSum)
                    {
                        maxSum = sum;
                    }
                }

            }

            Console.WriteLine($"max sum: {maxSum}");
        }
    }
}
