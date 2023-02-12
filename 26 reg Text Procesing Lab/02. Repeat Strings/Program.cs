using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split();
            
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                int wordLength = word.Length;
                for (int j = 0; j < wordLength; j++)
                {
                    result += word;
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
