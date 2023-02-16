using System;
using System.Security.Cryptography;

namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            char[,] m = new char[n,n];

            for (int r = 0; r < n; r++)
            {
                char[] rowValues= Console.ReadLine().ToCharArray();
                
                for (int c = 0; c < n; c++)
                {
                    m[r,c] = rowValues[c];
                }
            }

            bool HasThatCanTake = true;

            while (HasThatCanTake)
            {
                int[] result = FindMaxCanTake( m , n);

            }

            
            


        }

        public int[] FindMaxCanTake(char[,] m, int n) 
        {
            int currCanTake = 0;
            int maxCanTake = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (m[row, col] == 'O')
                    {
                        continue;
                    }
                    else
                    {
                        if (row - 2 >= 0)
                        {
                            if (col - 1 >= 0)
                            {
                                if (m[row - 2, col - 1] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row - 2 >= 0)
                        {
                            if (col + 1 <= n - 1)
                            {
                                if (m[row - 2, col + 1] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row - 1 >= 0)
                        {
                            if (col - 2 > 0)
                            {
                                if (m[row - 1, col - 2] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row - 1 >= 0)
                        {
                            if (col + 2 <= n)
                            {
                                if (m[row - 1, col + 2] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row + 2 <= n)
                        {
                            if (col - 1 >= 0)
                            {
                                if (m[row + 2, col - 1] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row + 2 <= n)
                        {
                            if (col + 1 <= n)
                            {
                                if (m[row + 2, col + 1] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row + 1 <= n)
                        {
                            if (col - 2 >= 0)
                            {
                                if (m[row + 1, col - 2] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }
                        if (row + 1 <= n)
                        {
                            if (col + 2 <= n)
                            {
                                if (m[row + 1, col - 2] == 'K')
                                {
                                    currCanTake++;
                                }
                            }
                        }

                        if (currCanTake > maxCanTake)
                        {
                            maxCanTake = currCanTake;
                            maxCol = col;
                            maxRow = row;
                        }

                    }
                }

            }
            int canTake = 0;
            
            if (maxCanTake>0)
            {
                canTake = 1;
            }
            return new int[] { maxCol, maxRow, canTake };
        }







    }
}
