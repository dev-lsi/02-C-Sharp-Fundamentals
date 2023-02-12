using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbersArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbersArr[n-i-1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(' ',numbersArr));
        }
    }
}
