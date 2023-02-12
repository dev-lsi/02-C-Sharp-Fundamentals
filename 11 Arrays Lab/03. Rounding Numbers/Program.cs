using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.WriteLine($"{numbersArr[i]} => {Math.Round(numbersArr[i], MidpointRounding.AwayFromZero)} ");
            }

        }
    }
}
