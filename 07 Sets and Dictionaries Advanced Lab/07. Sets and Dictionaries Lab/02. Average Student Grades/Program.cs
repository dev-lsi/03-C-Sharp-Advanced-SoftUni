using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine()); //number of inputs
            
            Dictionary<string, List<decimal>> studentGrades =
                new Dictionary<string, List<decimal>>();
            
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(student)) 
                {
                    studentGrades.Add(student, new List<decimal>());
                }

                studentGrades[student].Add(grade);
            }

            foreach (var item in studentGrades)
            {
                //John -> 5.20 3.20 (avg: 4.20)
                Console.Write($"{item.Key} -> ");

                for (int i = 0; i < item.Value.Count; i++)
                {
                    decimal result = item.Value[i];
                    Console.Write($"{result:f2} ");
                }

                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
            
            
           
        }
    }
}
