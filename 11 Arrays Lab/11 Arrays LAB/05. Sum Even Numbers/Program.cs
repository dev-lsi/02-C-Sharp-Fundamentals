using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 == 0)
                {
                    sum += intArr[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
