using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int curr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                curr = arr[i];

                for (int j = i+1; j < arr.Length; j++)
                {
                    int next = arr[j];
                    if (next >= curr)
                    {
                        break;
                    }
                    else if (curr > next)
                    {
                        if (j == arr.Length-1)
                        {
                            Console.Write($"{curr} ");
                        }
                        continue;
                    }
                    
                }
            }
            Console.Write($"{arr[arr.Length-1]}");
        }
    }
}
