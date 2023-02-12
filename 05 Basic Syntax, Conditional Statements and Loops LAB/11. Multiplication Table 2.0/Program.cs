using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int theMultipl = int.Parse(Console.ReadLine());
            int result = 0;

            if (theMultipl > 10)
            {
                result = theInteger * theMultipl;
                Console.WriteLine($"{theInteger} X {theMultipl} = {result}");
            }
            else
            {
                for (int i = theMultipl; i <= 10; i++)
                {
                    result = theInteger * theMultipl;
                    Console.WriteLine($"{theInteger} X {theMultipl} = {result}");
                    theMultipl++;
                }
            }

        }
    }
}
