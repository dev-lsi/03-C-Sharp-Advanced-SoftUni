

namespace _06._Jagged_Array_Modification
{

    using System;
    using System.Linq;
     internal class Program
     {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] arr = new int[rows][];

            for (int row = 0; row < arr.Length; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

                arr[row] = rowValues;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0]=="END")
                {
                   break;
                }
                else // Add {row} {col} {value} Subtract {row} {col} {value}
                {
                    string operation = command[0];
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row > rows|| row < 0 || col<0 || col > arr[row].Length-1)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else if (operation == "Add")
                    {
                        arr[row][col] = arr[row][col]+value;
                    }
                    else if (operation == "Subtract")
                    {
                        arr[row][col] = arr[row][col] - value;
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
