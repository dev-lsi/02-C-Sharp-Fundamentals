using System;
using System.Collections.Generic;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            int unlikedCounter = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split("-");
                if (command[0] == "Stop")
                {
                    break;
                }
                else
                {
                    if (command[0] == "Like") //Like-{guest}-{meal}
                    {
                        string guest = command[1];
                        string meal = command[2];
                        if (!dict.ContainsKey(guest))
                        {
                            dict.Add(guest, new List<string>());
                            dict[guest].Add(meal);
                            
                        }
                        else
                        {

                            if (dict[guest].Contains(meal))
                            {
                                continue;
                            }
                            else
                            dict[guest].Add(meal);
                        }
                    }
                    else if (command[0] == "Dislike")//Dislike-{guest}-{meal}
                    {
                        string guest = command[1];
                        string meal = command[2];
                        if (!dict.ContainsKey(guest))
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        else
                        {
                            if (!dict[guest].Contains(meal))
                            {
                                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            }
                            else
                            {
                                dict[guest].Remove(meal);
                                unlikedCounter++;
                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                            }
                        }
                    }
                }
            }

           
            foreach (var (guest,meals) in dict)
            {
                Console.Write($"{guest}: ");
                Console.WriteLine(string.Join(", ",meals));
            }
            Console.WriteLine($"Unliked meals: {unlikedCounter}");
            
   
        }
    }
}
