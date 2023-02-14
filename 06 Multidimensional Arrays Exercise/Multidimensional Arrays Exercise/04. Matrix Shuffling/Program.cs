using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix= new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
               
            }

            bool isValid = true;

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                
                if (command[0]=="END")
                {
                    return;
                }
                //swap row1 col1 row2 col2
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;
                
                if (command.Length == 5)
                {
                   row1 = int.Parse(command[1]);
                   col1 = int.Parse(command[2]);
                   row2 = int.Parse(command[3]);
                   col2 = int.Parse(command[4]);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (command[0] != "swap")
                {
                    isValid = false;
                }
                else if(command.Length != 5)
                {
                    isValid= false; 
                }
                
                else if (row1>rows||col1>cols||row2>rows||col2>cols)
                {
                    isValid= false;
                }
                else if(row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0)
                {
                    isValid= false;
                }
                else
                {
                    isValid = true;
                }
                
                
                if (isValid)
                {
                    string temp1 = matrix[row1, col1];
                    string temp2 = matrix[row2, col2];

                    matrix[row1, col1] = temp2;
                    matrix[row2, col2] = temp1;

                    for (int row = 0; row < rows; row++)
                    {
                        string[] line= new string[cols];

                        for (int col = 0; col < cols; col++)
                        {
                            line[col] = matrix[row, col];
                        }
                        Console.WriteLine(string.Join(" ",line));

                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

            }
        
        }
    }
}
