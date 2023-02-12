using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "end")
                {
                    break;
                }
                else
                {
                    char[] reversedArr = new char[input.Length];
                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        reversedArr[i] = input[input.Length-1-i];
                    }
                    string reversed = string.Join("", reversedArr);
                    Console.WriteLine($"{input} = {reversed}");
                }
            }
            //{word} = {reversed word}
        }
    }
}
