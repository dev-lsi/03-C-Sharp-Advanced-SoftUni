using System;
using System.Linq;
using System.Xml.Linq;

namespace _06._Jagg_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            // Populating the jagged array

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = rowValues;
            }

            // initial calculations over the elements

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] = jagged[row][col] / 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] = jagged[row + 1][col] / 2;
                    }
                }

            }
            
            bool isValid = true;

            // commands
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length != 4)
                {
                    continue;
                }
                string operation = command[0];
                int irow = int.Parse(command[1]);
                int icol = int.Parse(command[2]);
                int val = int.Parse(command[3]);
                if (irow < 0 || icol < 0)
                {
                    continue;
                }

                if (irow > jagged.Length - 1)
                {
                    continue;
                }

                if (icol > jagged[irow].Length - 1)
                {
                    continue;
                }

                if (operation != "Add" && operation != "Subtract")
                {
                    continue;
                }

                if (isValid && operation == "Add")
                {
                    jagged[irow][icol] += val;
                }

                if (isValid && operation == "Subtract")
                {
                    jagged[irow][icol] -= val;

                }
            }
            //Output

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}
