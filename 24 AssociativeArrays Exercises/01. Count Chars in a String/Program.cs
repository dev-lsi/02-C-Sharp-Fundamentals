using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar!=' ')
                {
                    if (!charCount.ContainsKey(currChar))
                    {
                        charCount.Add(currChar, 0);
                    }
                    charCount[currChar]++;
                }
               
            }
            foreach (var (key,val) in charCount)
            {
                Console.WriteLine(key+" -> "+val);
            }
        }
    }
}
