using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            while (true)
            {
                string[] command= Console.ReadLine().Split(", ");

                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "IN")
                {
                    set.Add(command[1]);
                }
                else if (command[0]=="OUT")
                {
                    set.Remove(command[1]);
                }

            }

            if (set.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
