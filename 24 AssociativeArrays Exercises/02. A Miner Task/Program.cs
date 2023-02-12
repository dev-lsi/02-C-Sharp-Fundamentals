using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;
            double quantity = 0;
            Dictionary<string, double> resourseQuantity = new Dictionary<string, double>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                    quantity = double.Parse(Console.ReadLine());
                    if (!resourseQuantity.ContainsKey(input))
                    {
                        resourseQuantity.Add(input,0);
                    }
                    resourseQuantity[input] += quantity;
                }
            }

            foreach (var (k,v) in resourseQuantity)
            {
                Console.WriteLine($"{k} -> {v}");
            }
            
        }
    }
}
