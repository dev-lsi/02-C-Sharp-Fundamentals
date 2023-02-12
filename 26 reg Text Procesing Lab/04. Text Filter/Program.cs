using System;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedArr = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            
            foreach (var bannedWord in bannedArr)
            {
                int bannWordLength = bannedWord.Length;
                
                //while (text.Contains(bannedWord))
                //{
                    int startIndex = text.IndexOf(bannedWord);
                    text = text.Replace(bannedWord, new string('*', bannWordLength));
                //}
                
            }
            Console.WriteLine(text);
        }
    }
}
