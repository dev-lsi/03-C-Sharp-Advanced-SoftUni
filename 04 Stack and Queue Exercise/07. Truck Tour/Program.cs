using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string station = "";
            Queue<string> stations= new Queue<string>();
            Queue<string> stationsCurr = new Queue<string>();

            stationsCurr = stations;
            int balance = 0;
            int index = 0;
            bool succes = false;

            for (int i = 0; i < n; i++)
            {
                station = Console.ReadLine();
                stations.Enqueue(station);
            }

            for (int i = 0; i < n; i++)
            {
                index = i;
                if (succes==true)
                {
                   
                    break;
                }
                for (int j = 0; j < i; j++)
                {
                    stations.Enqueue(stations.Dequeue());
                    
                }
                succes= true;
                balance = 0;
                for (int k = 0; k < n; k++)
                {
                    int[] info=stations.Peek().Split().Select(int.Parse).ToArray();
                    balance = balance + info[0] - info[1];
                    if (balance<0)
                    {
                        succes = false;
                    }
                    stations.Enqueue(stations.Dequeue());
                        
                }

            }
            if (succes)
            {
                Console.WriteLine(index-1);
            }
        }
    }
}
