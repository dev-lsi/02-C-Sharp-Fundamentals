using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string banned = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(banned))
            {
                int startIndex = text.IndexOf(banned);
                text=text.Remove(startIndex, banned.Length);
            }
            Console.WriteLine(text);
        }
    }
}
