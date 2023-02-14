using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string input = Console.ReadLine();
                          
            char[] word=input.ToCharArray();
            
            //Console.WriteLine(string.Join(",",word));

            int currWordIndex = 0;
            
            char[,] matrix = new char[rows,cols];
            
            // input values into the matrix
            
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }
                        matrix[row, col] = word[currWordIndex];
                        currWordIndex++;
                    }
                }
                else if(row % 2 != 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }
                        matrix[row, col] = word[currWordIndex];
                        currWordIndex++;
                    }


                }
            }

            //Output
            
            for (int i = 0; i < rows; i++)
            {
                char[] line = new char[cols];
                
                for (int j = 0; j < cols; j++)
                {
                    line[j] = matrix[i,j];
                }
                Console.WriteLine(string.Join("",line));

            }
        }
    }
}
