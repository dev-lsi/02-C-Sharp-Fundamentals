using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int devisionNumber = 0;

            if (input % 10 ==0)
            {
                devisionNumber =10;
            }
            else if (input % 7==0)
            {
                devisionNumber =7;
            }
            else if (input % 6==0)
            {
                devisionNumber =6;
            }
            else if (input % 3==0)
            {
                devisionNumber =3;
            }
            else if (input % 2==0)
            {
                devisionNumber =2;
            }
            

            if (devisionNumber == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {devisionNumber}");
            }
        }
    }
}
