using System;

namespace _00_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]==' '&&input[i+1]==' ')
                {
                    input.RemoveAt(i+1);
                }
            }

            Console.WriteLine(input);
        }
    }
}
