using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(.+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<^>]{3})<(\1)");
            
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                bool isMatch = regex.IsMatch(input);
                if (!isMatch)
                {
                    Console.WriteLine("Try another password!");
                }
                else if (isMatch)
                {
                    string encrypted = string.Empty;
                    Match match = regex.Match(input);
                    var groups = match.Groups;
                    StringBuilder sb = new StringBuilder();
                    for (int j = 2; j < 6; j++)
                    {
                        sb.Append(groups[j].ToString());
                    }

                    Console.WriteLine($"Password: {sb.ToString()}");
                    sb.Clear();
                }
            }

        }
    }
}
