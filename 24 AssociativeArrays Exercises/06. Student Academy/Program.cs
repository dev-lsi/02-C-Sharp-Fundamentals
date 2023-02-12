using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = 
                      new Dictionary<string, List<double>>();
            
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>{ grade }) ;
                }
                else
                {
                    dict[name].Add(grade);
                }
            }

            foreach (var (name,list) in dict)
            {
                if (list.Average()>=4.50)
                {
                    Console.WriteLine($"{name} -> {list.Average():f2}");
                }
            }

        }

    }
}
