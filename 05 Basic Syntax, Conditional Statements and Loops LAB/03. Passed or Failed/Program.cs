using System;

namespace _03._Passed_or_Failed
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
            else
            {
                Console.WriteLine("Failed!");

            }
        }
    }
}
