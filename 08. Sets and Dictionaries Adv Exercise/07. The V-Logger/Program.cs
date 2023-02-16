using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Dictionary<string, HashSet<string>>> vlog = 
                new HashSet<Dictionary<string, HashSet<string>>>(); 

            while (true)
            {
                string[] command=Console.ReadLine().Split(" ");
                if (command[0] == "Statistics")
                {
                    break;
                }
                else if(command.Length== 4) //JennaMarbles joined The V-Logger
                {
                    string name = command[0];
                    Dictionary<string, HashSet<string>> newVlogger =
                        new Dictionary<string, HashSet<string>>();
                    newVlogger.Add(name, new HashSet<string>());    
                    
                    vlog.Add(newVlogger);
                    
                }
                else if(command.Length== 3) //JennaMarbles followed Zoella
                {
                    string follower = command[0];
                    string followed= command[2];
                    if (!vlog.Any(x => x.ContainsKey(follower)))
                    {
                        continue;
                    }
                    if (!vlog.Any(x => x.ContainsKey(followed)))
                    {
                        continue;
                    }
                    if (follower==followed)
                    {
                        continue;
                    }
                    
                       Dictionary<string,HashSet<string>> curr = 
                            vlog.First(x=>x.ContainsKey(follower));
                    
                    if (curr[follower].Contains(follower))
                    {
                        break;
                    }
                    else
                    {
                        vlog.Select(x => x[followed].Add(follower));
                        //curr[follower].Add(follower);
                    }

                    

                    

                }

            }

            foreach (var vlogger in vlog)
            {
                
                
                foreach (var zapis in vlogger)
                {
                    Console.WriteLine(zapis.Key);

                    foreach (var follower in zapis.Value) 
                    {

                        foreach (var item in follower)
                        {
                            Console.WriteLine(string.Join(",",item));
                        }
                    }
                    
                    
                }
            }
        }
    }
}
