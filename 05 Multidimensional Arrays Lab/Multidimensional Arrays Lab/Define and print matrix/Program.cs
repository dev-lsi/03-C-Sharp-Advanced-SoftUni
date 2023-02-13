using System;

namespace Define_and_print_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4]
            {
                {1,2,3,4 },
                {5, 6, 7, 8 },
                {9,10,11,12 }
            };

            for (int r = 0; r < matrix.GetLength(0); r++) //rows length
            {
                for (int c = 0; c < matrix.GetLength(1); c++)//cols length
                {
                    Console.Write($" {matrix[r,c]}");
                }
                
                Console.WriteLine();
            }

        }
    }
}
