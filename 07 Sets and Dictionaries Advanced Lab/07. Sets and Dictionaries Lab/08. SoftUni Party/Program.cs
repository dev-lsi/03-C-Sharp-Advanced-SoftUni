using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> set = new List<string>();

            while (true) 
            {
                string input = Console.ReadLine();
                if (input == "PARTY" || input=="END") 
                {
                    break;
                }
                else
                {
                    set.Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine(); 
                
                if (input=="END")
                {
                    break;
                }
                else
                {
                    set.Remove(input);
                }

            }

            if (set.Count==0)
            {
                Console.WriteLine(set.Count);
                return;
            }

            Console.WriteLine(set.Count);


            for (int i = 0; i < set.Count; i++)
            {
               
                Regex regex = new Regex("[0-9][0-9A-Za-z]");
                Match match = regex.Match(set[i]);
                if (match.Success)
                {
                    Console.WriteLine(set[i]);
                    set.Remove(set[i]);
                    i=0;
                }
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
