using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int result = 0;
            
            for (int i = 0; i < 10; i++)
            {
                result = theInteger * (i + 1);
                Console.WriteLine($"{theInteger} X {i + 1} = {result}");
            }
        }
    }
}
