using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 == 0)
                {
                    evenSum += intArr[i];
                }
                else
                {
                    oddSum += intArr[i];
                }
            }

            int result = 0;

            result=evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
