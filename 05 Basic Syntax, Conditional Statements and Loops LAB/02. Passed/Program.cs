using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputGrade = double.Parse(Console.ReadLine());

            if (inputGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
