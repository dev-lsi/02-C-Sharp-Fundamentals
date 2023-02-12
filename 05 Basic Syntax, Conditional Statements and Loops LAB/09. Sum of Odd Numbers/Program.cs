using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNumber = -1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                oddNumber += 2;
                sum += oddNumber;
                Console.WriteLine(oddNumber);
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
