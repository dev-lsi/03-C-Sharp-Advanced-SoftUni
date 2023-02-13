using System;
using System.Linq;

namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows=int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                
                jaggedArr[row] = new int[rowValues.Length];
                
                for (int col = 0; col < rowValues.Length; col++)
                {
                    jaggedArr[row][col] = rowValues[col];
                }


                //jaggedArr[row] = rowValues;

            }

            for (int row = 0; row < rows; row++)
            {
                Console.Write(string.Join(",", jaggedArr[row]));
                Console.WriteLine();
            }
        }
    }
}
