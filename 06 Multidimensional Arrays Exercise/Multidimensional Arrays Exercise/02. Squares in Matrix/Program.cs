using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] values = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int counter = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    char c = matrix[row, col];
                    
                    if ( c==matrix[row,col]&& 
                         c== matrix[row,col+1]&&
                         c == matrix[row + 1, col]&&
                         c == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }

            }

            Console.WriteLine(counter);
        }
    }
}
