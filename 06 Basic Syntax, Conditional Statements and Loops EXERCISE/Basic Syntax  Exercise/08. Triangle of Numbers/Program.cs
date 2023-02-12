using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }
        static void PrintLine(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
