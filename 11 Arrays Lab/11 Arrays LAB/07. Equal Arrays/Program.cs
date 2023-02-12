using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallerLength = 0;
            int elementsSum = 0;

            if (arr1.Length < arr2.Length) { smallerLength = arr1.Length; }
            else if (arr1.Length > arr2.Length) { smallerLength = arr2.Length; }
            else if (arr1.Length == arr2.Length) { smallerLength = arr2.Length; }

            for (int i = 0; i < smallerLength; i++)
            {
                if (arr1[i]!=arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    elementsSum += arr1[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {elementsSum}");
        }
    }
}
