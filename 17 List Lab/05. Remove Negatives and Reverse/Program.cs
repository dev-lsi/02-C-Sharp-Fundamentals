using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
                continue;
            }
            //reverse list
            for (int i = 0; i < list.Count/2; i++)
            {
                int temp = list[i];
                list[i] = list[list.Count-1-i];
                list[list.Count - 1 - i] = temp;
            }
            
            //
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
