using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "England" || input == "USA")
            {
                Console.WriteLine("English");
            }
            else if (input == "Mexico" || input == "Argentina" || input == "Spain")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");

            }
        }
    }
}
