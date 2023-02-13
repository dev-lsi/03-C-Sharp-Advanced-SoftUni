using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            int[,] matrix=new int[size,size];

            for (int row = 0; row < size; row++)
            {
                int[] rowValues=Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = rowValues[col];
                }
            }

            int diagonalSum = 0;
            int column = 0;
            
            for (int row = 0; row < size; row++)
            {
                diagonalSum=diagonalSum + matrix[row,column];
                column++;
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
