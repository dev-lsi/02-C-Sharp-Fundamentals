using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newPassengers = 0;
            int sum = 0;

            int[] vagon = new int[n];

            for (int i = 0; i < n; i++)
            {
                newPassengers = int.Parse(Console.ReadLine());
                vagon[i] = newPassengers;
                sum += newPassengers;
            }
            Console.WriteLine(string.Join(' ',vagon));
            Console.WriteLine(sum);
        }
    }
}
