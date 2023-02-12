using System;

namespace OOP_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();
            Random rnd = new Random();


            for (int i = 0; i < arr.Length; i++)
            {
                int index = rnd.Next(0, arr.Length);
                string temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
