using System;
using System.Numerics;

namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows=int.Parse(Console.ReadLine());
            
            BigInteger[][] arr = new BigInteger[rows][];

            for (int row = 0; row < rows; row++)
            {
                BigInteger[] line = new BigInteger[row+1];
                arr[row] = line;
                
                for (int col = 0; col < line.Length; col++)
                {
                    if (row == 0)
                    {
                        arr[0][0] = 1;
                    }
                    else if(col == 0)
                    {
                        arr[row][col]= 1;
                    }
                    else if (col == arr[row].Length - 1)
                    {
                        arr[row][col] = 1;
                    }
                    else
                    {
                        arr[row][col] = arr[row - 1][col] + arr[row - 1][col-1];
                    }

                }
               
                
            }

            foreach (var item in arr)
            {
                Console.WriteLine(string.Join(" ",item));
            }

        }
    }
}
