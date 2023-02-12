using System;

namespace _00_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "stosho sonev Simov sonev";
            string[] result = text.Split(" ", 2);
            
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
