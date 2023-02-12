using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            
            while (input!="end")
            {
                string[] command = input.Split();
                
                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int newPassengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        sum = (wagons[i] + newPassengers);
                        
                        if (capacity - sum >= 0)
                        {
                            wagons[i] += newPassengers;
                            sum = 0;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
