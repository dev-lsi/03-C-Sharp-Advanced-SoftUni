using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrix=new int[n,n];
            
            // Reading rows values from the console

            for (int row = 0; row < n; row++)
            {
                int[] values=Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = values[col];
                }

            }

            // Finding primary diagonal
           
            int primarySum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        primarySum = primarySum + matrix[row, col];
                    }
                    
                }
                
            }
            
            // Finding secondary diagonal

            int secondarySum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == n - 1 - row)
                    {
                        secondarySum = secondarySum + matrix[row,col ];
                    }
                }

            }
            
            // Output
            
            int difference = Math.Abs(primarySum-secondarySum);
            
            Console.WriteLine(difference);
        }
    }
}
